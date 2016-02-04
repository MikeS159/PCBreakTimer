using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            LunchTimeTextBox.Text = Properties.Settings.Default.LunchTime.ToString();
            WorkDayTextBox.Text = Properties.Settings.Default.WorkingDay.ToString();
            AddTimeTextBox.Text = Properties.Settings.Default.AddTime.ToString();
            MaxTimeTextBox.Text = Properties.Settings.Default.DefaultBreakTime.ToString();
            WinXPosTextBox.Text = Properties.Settings.Default.WindowXPos.ToString();
            WinYPosTextBox.Text = Properties.Settings.Default.WindowYPos.ToString();
            PopupMessageCheckBox.Checked = Properties.Settings.Default.PopUpWarning;
            StartMinimizedCheckBox.Checked = Properties.Settings.Default.StartMinimized;
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
                Properties.Settings.Default.LunchTime = tempSpan;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            
            if (TimeSpan.TryParse(WorkDayTextBox.Text, out tempSpan))
            {
                Properties.Settings.Default.WorkingDay = tempSpan;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            if (TimeSpan.TryParse(AddTimeTextBox.Text, out tempSpan))
            {
                Properties.Settings.Default.AddTime = tempSpan;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            if (TimeSpan.TryParse(MaxTimeTextBox.Text, out tempSpan))
            {
                Properties.Settings.Default.DefaultBreakTime = tempSpan;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter time in a valid format");
            }
            int tempXPos = 0;
            int tempYPos = 0;
            if (Int32.TryParse(WinXPosTextBox.Text, out tempXPos))
            {
                Properties.Settings.Default.WindowXPos = tempXPos;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
            }
            if (Int32.TryParse(WinYPosTextBox.Text, out tempYPos))
            {
                Properties.Settings.Default.WindowYPos = tempYPos;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer");
            }
            Properties.Settings.Default.PopUpWarning = PopupMessageCheckBox.Checked;
            Properties.Settings.Default.StartMinimized = StartMinimizedCheckBox.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
