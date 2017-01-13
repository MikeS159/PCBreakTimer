using PCBreakTimer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using JR.Utils.GUI.Forms;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Timers;
using System.Diagnostics;
using System.Reflection;

namespace PCBreakTimer
{
    public partial class MainProgramForm : Form
    {

        #region Varibles

        private static SessionSwitchEventHandler sseh;
        SettingsForm userSettingsForm = new SettingsForm();
        Stopwatch homeStopWatch = new Stopwatch();
        Stopwatch awayStopwatch = new Stopwatch();
        Stopwatch lastBreakStopwatch = new Stopwatch();
        Stopwatch initialStopwatch = new Stopwatch();
        TimeSpan lastBreakTimeSpan = new TimeSpan();
        TimeSpan homeTimeSpan = new TimeSpan();
        TimeSpan awayTimeSpan = new TimeSpan();
        TimeSpan homeUpdateTimeSpan = new TimeSpan();
        TimeSpan awayUpdateTimeSpan = new TimeSpan();
        TimeSpan totalTime = new TimeSpan();
        TimeSpan timeUntilHome = new TimeSpan();
        NotifyIcon sysTrayIcon = new NotifyIcon();
        TimeSpan defaultTime = Settings.Default.DefaultBreakTime;
        TimeSpan maxTime = Settings.Default.DefaultBreakTime;
        TimeSpan addTime = Settings.Default.AddTime;
        TimeSpan workingDay = Settings.Default.WorkingDay;
        TimeSpan lunchTime = Settings.Default.LunchTime;
        string workingPattern = Settings.Default.WorkingPattern;
        string lunchPattern = Settings.Default.LunchPattern;
        bool userWorkingPattern = Settings.Default.UseWorkingPattern;
        DateTime startTimeDT;
        TimeSpan homeAt = new TimeSpan();
        CultureInfo sessionCulture = new CultureInfo(Thread.CurrentThread.CurrentCulture.Name);

        bool firstEvent = true;
        bool popUpWarning = Settings.Default.PopUpWarning;
        bool startMinimized = Settings.Default.StartMinimized;
        int currentForm = 1;
        int windowXPos = Settings.Default.WindowXPos;
        int windowYPos = Settings.Default.WindowYPos;
#if DEBUG
        int windowHeight = 320;
        int windowWidth = 500;
#else
        int windowHeight = 300;
        int windowWidth = 500;
#endif
        string timeFormat = "h'h 'm'm 's's'";
        private bool allowVisible = false;

#endregion

#region FormElements

        public MainProgramForm()
        {
            InitializeComponent();
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
                reloadSettings();
            }
            if(userWorkingPattern)
            {
                parsePatterns();
            }
            allowVisible = !startMinimized;
            sseh = new SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            SystemEvents.SessionSwitch += sseh;
            sysTrayIcon.MouseDoubleClick += new MouseEventHandler(sysTrayIcon_MouseDoubleClick);
            sysTrayIcon.BalloonTipText = "Timers Running";
            //Icon ic = new Icon(@"C:\Users\T0177633\Documents\Projects\Git\PCBreakTimer\pc_lock_test\PC_Lock_Test\coffee-maker.ico");
            this.sysTrayIcon.Icon = Resources.Coffee;
            sysTrayIcon.Visible = true;
            sysTrayIcon.ShowBalloonTip(500);
            this.Left = windowXPos;
            this.Top = windowYPos;
            startTimeDT = DateTime.Now;
            richTextBox1.AppendText("Start Time - " + DateTime.Now.ToString(sessionCulture) + "\n");
            Start();

#if DEBUG
                testLockBtn.Enabled = true;
                testLockBtn.Visible = true;
                testUnlockBtn.Enabled = true;
                testUnlockBtn.Visible = true;
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
#endif
        }

        /// <summary>
        /// Called when the form is loaded, sets up user options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            homeAt = new TimeSpan(startTimeDT.Hour, startTimeDT.Minute, startTimeDT.Second);
            homeAt = homeAt.Add(workingDay.Add(lunchTime));
            homeAtLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", Math.Floor(homeAt.TotalHours), homeAt.Minutes, homeAt.Seconds);
            if (startMinimized)
            {
                minimizeWindow();
            }
            else
            {
                showCurrentForm();
            }
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!this.IsHandleCreated) CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        private void showCurrentForm()
        {
            switch (currentForm)
            {
                case 1:
                    this.Show();
                    this.Activate();
                    this.WindowState = FormWindowState.Normal;
                    this.Left = windowXPos;
                    this.Top = windowYPos;
                    this.Height = windowHeight;
                    this.Width = windowWidth;
                    break;
                case 2:
                    userSettingsForm.Left = windowXPos;
                    userSettingsForm.Top = windowYPos;
                    userSettingsForm.Show();
                    userSettingsForm.Activate();
                    userSettingsForm.WindowState = FormWindowState.Normal;
                    break;
                default:
                    this.Show();
                    this.Activate();
                    this.WindowState = FormWindowState.Normal;
                    this.Left = windowXPos;
                    this.Top = windowYPos;
                    this.Height = windowHeight;
                    this.Width = windowWidth;
                    break;
            }
        }

        private void minimizeWindow()
        {
            windowXPos = this.Left;
            windowYPos = this.Top;
            timer1.Enabled = false;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }

#endregion

#region Events

        /// <summary>
        /// Called when the session switch event is triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemEvents_SessionSwitch(object sender, SessionSwitchEventArgs e)
        {
            string s = DateTime.Now.ToString(sessionCulture);
            s = s + " " + e.Reason.ToString();
            richTextBox1.AppendText(s + "\n");
            if (e.Reason == SessionSwitchReason.SessionLogon)
            {
                Start();
            }
            if (e.Reason == SessionSwitchReason.SessionLogoff)
            {
                Stop();
            }
            if (e.Reason == SessionSwitchReason.SessionUnlock)
            {
                Unlock();
            }
            if (e.Reason == SessionSwitchReason.SessionLock)
            {
                Lock();
            }
            if (e.Reason == SessionSwitchReason.ConsoleConnect)
            {
                Unlock();
            }
            if (e.Reason == SessionSwitchReason.ConsoleDisconnect)
            {
                Lock();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }

#endregion

#region FormButtons

        private void sysTrayIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            allowVisible = true;
            showCurrentForm();
            timer1.Enabled = true;
        }

        private void testLockBtn_Click(object sender, EventArgs e)
        {
            Lock();
            richTextBox1.AppendText(DateTime.Now.ToString(sessionCulture) + " Test Lock\n");
        }

        private void testUnlockBtn_Click(object sender, EventArgs e)
        {
            Unlock();
            richTextBox1.AppendText(DateTime.Now.ToString(sessionCulture) + " Test Unlock\n");
        }

#endregion

#region Timers

        /// <summary>
        /// Used to update forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            homeUpdateTimeSpan = homeTimeSpan + homeStopWatch.Elapsed;
            HomeTimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", (Math.Floor(homeUpdateTimeSpan.TotalHours)), homeUpdateTimeSpan.Minutes, homeUpdateTimeSpan.Seconds);
            awayUpdateTimeSpan = awayTimeSpan + awayStopwatch.Elapsed;
            AwayTimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", (Math.Floor(awayUpdateTimeSpan.TotalHours)), awayUpdateTimeSpan.Minutes, awayUpdateTimeSpan.Seconds);
            lastBreakTimeSpan = lastBreakStopwatch.Elapsed;
            LastBreakLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", (Math.Floor(lastBreakTimeSpan.TotalHours)), lastBreakTimeSpan.Minutes, lastBreakTimeSpan.Seconds);
            totalTime = homeUpdateTimeSpan + awayUpdateTimeSpan;
            TotalTimeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", (Math.Floor(totalTime.TotalHours)), totalTime.Minutes, totalTime.Seconds);
            timeUntilHome = (workingDay.Add(lunchTime)).Subtract(totalTime);
            TimeLeftLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", (Math.Floor(timeUntilHome.TotalHours)), timeUntilHome.Minutes, timeUntilHome.Seconds);
            if (lastBreakTimeSpan > maxTime)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                maxTime = maxTime.Add(addTime);
                BreakWarningLabel.Visible = true;
                if (popUpWarning)
                {
                    MessageBox.Show("Take a Break!", "Coffee Time", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
            if (totalTime > (workingDay + lunchTime))
            {
                label4.ForeColor = Color.Red;
                TotalTimeLabel.ForeColor = Color.Red;
            }
            else
            {
                label4.ForeColor = Color.Black;
                TotalTimeLabel.ForeColor = Color.Black;
            }
            double percentageAtDesk = 0;
            percentageAtDesk = (100 - ((awayTimeSpan.TotalMilliseconds / totalTime.TotalMilliseconds) * 100));
            percentageAtDesk = Math.Round(percentageAtDesk, 2);
            PercentageLabel.Text = percentageAtDesk.ToString(sessionCulture) + " %";
        }

#endregion

#region SessionEventMethods

        private void Start()
        {
            homeStopWatch.Start();
            initialStopwatch.Start();
            lastBreakStopwatch.Start();
        }

        private void Stop()
        {
            homeStopWatch.Stop();
            homeTimeSpan = homeTimeSpan + homeStopWatch.Elapsed;
            homeStopWatch.Reset();
        }

        private void Lock()
        {
            homeStopWatch.Stop();
            awayStopwatch.Start();
            lastBreakStopwatch.Stop();
            lastBreakStopwatch.Reset();
            homeTimeSpan = homeTimeSpan + homeStopWatch.Elapsed;
            homeStopWatch.Reset();
            HomeTimeLabel.Text = homeTimeSpan.ToString(timeFormat, sessionCulture);
            maxTime = defaultTime;
            BreakWarningLabel.Visible = false;
            if (firstEvent) //This corrects timers if the program starts when the computer is locked
            {
                firstEvent = false;
                initialStopwatch.Reset();
            }
        }

        private void Unlock()
        {
            if (!firstEvent)
            {
                awayStopwatch.Stop();
                homeStopWatch.Start();
                awayTimeSpan = awayTimeSpan + awayStopwatch.Elapsed;
                awayStopwatch.Reset();
                AwayTimeLabel.Text = awayTimeSpan.ToString(timeFormat, sessionCulture);
                lastBreakStopwatch.Start();
            }
            else
            {
                awayStopwatch.Stop();
                initialStopwatch.Stop();
                homeStopWatch.Restart();
                awayTimeSpan = awayTimeSpan + initialStopwatch.Elapsed;
                awayStopwatch.Reset();
                initialStopwatch.Reset();
                HomeTimeLabel.Text = homeTimeSpan.ToString(timeFormat, sessionCulture);
                AwayTimeLabel.Text = awayTimeSpan.ToString(timeFormat, sessionCulture);
                lastBreakStopwatch.Restart();
                firstEvent = false;
            }
        }

#endregion

#region MenuItems

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minimizeWindow();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure you want to close?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign);
            if (closeResult == DialogResult.Yes)
            {
                sysTrayIcon.Visible = false;
                sysTrayIcon.Dispose();
                this.Close();
            }
            else if (closeResult == DialogResult.No)
            {

            }
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming in future version... probably");
        }

        private void versionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show(Version_History.returnString());
            //MessageBox.Show(Version_History.returnString());
        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlexibleMessageBox.Show("The MIT License (MIT) Copyright © 2016 Mike Simpson \n\n" + "This program also uses Flexible Message Box (https://www.codeproject.com/articles/601900/flexiblemessagebox-a-flexible-replacement-for-the) \n\n" + "Icon from - http://www.flaticon.com/authors/madebyoliver \nAvalible under the Creative Commons Licence 3.0 http://creativecommons.org/licenses/by/3.0/");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Assembly assem = Assembly.GetEntryAssembly();
            string programName = FileVersionInfo.GetVersionInfo(assem.Location).ProductName;
            string companyName = FileVersionInfo.GetVersionInfo(assem.Location).CompanyName;
            string copyright = FileVersionInfo.GetVersionInfo(assem.Location).LegalCopyright;
            //string comments = FileVersionInfo.GetVersionInfo(assem.Location).Comments;
            string assemVer = FileVersionInfo.GetVersionInfo(assem.Location).FileVersion;
            string infoVer = FileVersionInfo.GetVersionInfo(assem.Location).ProductVersion;
            string s =
            programName + " by " +
            companyName + "\n" +
            copyright + "\n\n" +
            "Version: " + infoVer + " (" + assemVer + ")";
            MessageBox.Show(s);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            currentForm = 2;
            userSettingsForm.ShowDialog();
            updateUserSettings();
            currentForm = 1;
            showCurrentForm();
        }

#endregion

#region Settings

        private void updateUserSettings()
        {
            lunchTime = Settings.Default.LunchTime;
            workingDay = Settings.Default.WorkingDay;
            addTime = Settings.Default.AddTime;
            defaultTime = Settings.Default.DefaultBreakTime;
            //maxTime = defaultTime;
            windowXPos = Settings.Default.WindowXPos;
            windowYPos = Settings.Default.WindowYPos;
            popUpWarning = Settings.Default.PopUpWarning;
            workingPattern = Settings.Default.WorkingPattern;
            lunchPattern = Settings.Default.LunchPattern;
            userWorkingPattern = Settings.Default.UseWorkingPattern;
        }

        private void reloadSettings()
        {
            defaultTime = Settings.Default.DefaultBreakTime;
            maxTime = Settings.Default.DefaultBreakTime;
            addTime = Settings.Default.AddTime;
            workingDay = Settings.Default.WorkingDay;
            lunchTime = Settings.Default.LunchTime;
            popUpWarning = Settings.Default.PopUpWarning;
            startMinimized = Settings.Default.StartMinimized;
            windowXPos = Settings.Default.WindowXPos;
            windowYPos = Settings.Default.WindowYPos;
            workingPattern = Settings.Default.WorkingPattern;
            lunchPattern = Settings.Default.LunchPattern;
            userWorkingPattern = Settings.Default.UseWorkingPattern;            
        }

        private void parsePatterns()
        {
            int daysInWeek = 7;
            int day = -1;
            string[] dailyWorkingTimes = workingPattern.Split(',');
            string[] dailyLunchTimes = lunchPattern.Split(',');
            if (dailyLunchTimes.Length == daysInWeek && dailyWorkingTimes.Length == daysInWeek)
            {
                DateTime today = DateTime.Now;
                switch (today.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        day = 0;
                        break;
                    case DayOfWeek.Tuesday:
                        day = 1;
                        break;
                    case DayOfWeek.Wednesday:
                        day = 2;
                        break;
                    case DayOfWeek.Thursday:
                        day = 3;
                        break;
                    case DayOfWeek.Friday:
                        day = 4;
                        break;
                    case DayOfWeek.Saturday:
                        day = 5;
                        break;
                    case DayOfWeek.Sunday:
                        day = 6;
                        break;
                    default:
                        richTextBox1.AppendText("Critical date error");
                        break;
                }
                if (0 <= day && day <= 6)
                {
                    TimeSpan tempSpan = new TimeSpan();

                    if (TimeSpan.TryParse(dailyWorkingTimes[day], out tempSpan))
                    {
                        workingDay = tempSpan;
                    }
                    else
                    {
                        richTextBox1.AppendText("Work pattern not formatted correctly, switching to default times");
                    }
                    if (TimeSpan.TryParse(dailyLunchTimes[day], out tempSpan))
                    {
                        lunchTime = tempSpan;
                    }
                    else
                    {
                        richTextBox1.AppendText("Lunch pattern not formatted correctly, switching to default times");
                    }
                }
                else
                {
                    richTextBox1.AppendText("Work and lunch patterns should contain 7 elements seperated by commas");
                }
            }
#endregion

        }
    }
}