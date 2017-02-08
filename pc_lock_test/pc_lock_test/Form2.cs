using PCBreakTimer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCBreakTimer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            setFormToUserSettings();
        }

        private void setFormToUserSettings()
        {
            LunchTimeTextBox.Text = Settings.Default.LunchTime.ToString();
            WorkDayTextBox.Text = Settings.Default.WorkingDay.ToString();
            AddTimeTextBox.Text = Settings.Default.AddTime.ToString();
            MaxTimeTextBox.Text = Settings.Default.DefaultBreakTime.ToString();
            WinXPosTextBox.Text = Settings.Default.WindowXPos.ToString(CultureInfo.InvariantCulture);
            WinYPosTextBox.Text = Settings.Default.WindowYPos.ToString(CultureInfo.InvariantCulture);
            workingPatternTB.Text = Settings.Default.WorkingPattern;
            lunchPatternTB.Text = Settings.Default.LunchPattern;
            PopupMessageCheckBox.Checked = Settings.Default.PopUpWarning;
            StartMinimizedCheckBox.Checked = Settings.Default.StartMinimized;
            useWorkingPatternCheckBox.Checked = Settings.Default.UseWorkingPattern;
            keepUnlockedCheckBox.Checked = Settings.Default.KeepUnlocked;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            setFormToUserSettings();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            TimeSpan tempSpan = new TimeSpan();
            
            if (TimeSpan.TryParse(LunchTimeTextBox.Text, out tempSpan))
            {
                Settings.Default.LunchTime = tempSpan;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            
            if (TimeSpan.TryParse(WorkDayTextBox.Text, out tempSpan))
            {
                Settings.Default.WorkingDay = tempSpan;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            if (TimeSpan.TryParse(AddTimeTextBox.Text, out tempSpan))
            {
                Settings.Default.AddTime = tempSpan;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            if (TimeSpan.TryParse(MaxTimeTextBox.Text, out tempSpan))
            {
                Settings.Default.DefaultBreakTime = tempSpan;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            int tempXPos = 0;
            int tempYPos = 0;
            if (Int32.TryParse(WinXPosTextBox.Text, out tempXPos))
            {
                Settings.Default.WindowXPos = tempXPos;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
            }
            if (Int32.TryParse(WinYPosTextBox.Text, out tempYPos))
            {
                Settings.Default.WindowYPos = tempYPos;
                Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
            }
            Settings.Default.WorkingPattern = workingPatternTB.Text;
            Settings.Default.LunchPattern = lunchPatternTB.Text;
            Settings.Default.PopUpWarning = PopupMessageCheckBox.Checked;
            Settings.Default.StartMinimized = StartMinimizedCheckBox.Checked;
            Settings.Default.UseWorkingPattern = useWorkingPatternCheckBox.Checked;
            Settings.Default.KeepUnlocked = keepUnlockedCheckBox.Checked;
            Settings.Default.Save();
        }
    }
}
