﻿namespace PCBreakTimer
{
    partial class MainProgramForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgramForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HomeTimeLabel = new System.Windows.Forms.Label();
            this.AwayTimeLabel = new System.Windows.Forms.Label();
            this.timeUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LastBreakLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.testLockBtn = new System.Windows.Forms.Button();
            this.testUnlockBtn = new System.Windows.Forms.Button();
            this.BreakWarningLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.homeAtLabel = new System.Windows.Forms.Label();
            this.keepUnlockedTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(275, 227);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time At Desk - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Away - ";
            // 
            // HomeTimeLabel
            // 
            this.HomeTimeLabel.AutoSize = true;
            this.HomeTimeLabel.Location = new System.Drawing.Point(393, 33);
            this.HomeTimeLabel.Name = "HomeTimeLabel";
            this.HomeTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.HomeTimeLabel.TabIndex = 3;
            this.HomeTimeLabel.Text = "00:00:00";
            // 
            // AwayTimeLabel
            // 
            this.AwayTimeLabel.AutoSize = true;
            this.AwayTimeLabel.Location = new System.Drawing.Point(393, 63);
            this.AwayTimeLabel.Name = "AwayTimeLabel";
            this.AwayTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.AwayTimeLabel.TabIndex = 4;
            this.AwayTimeLabel.Text = "00:00:00";
            // 
            // timeUpdateTimer
            // 
            this.timeUpdateTimer.Enabled = true;
            this.timeUpdateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Break - ";
            // 
            // LastBreakLabel
            // 
            this.LastBreakLabel.AutoSize = true;
            this.LastBreakLabel.Location = new System.Drawing.Point(393, 94);
            this.LastBreakLabel.Name = "LastBreakLabel";
            this.LastBreakLabel.Size = new System.Drawing.Size(49, 13);
            this.LastBreakLabel.TabIndex = 7;
            this.LastBreakLabel.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Time - ";
            // 
            // TotalTimeLabel
            // 
            this.TotalTimeLabel.AutoSize = true;
            this.TotalTimeLabel.Location = new System.Drawing.Point(393, 126);
            this.TotalTimeLabel.Name = "TotalTimeLabel";
            this.TotalTimeLabel.Size = new System.Drawing.Size(49, 13);
            this.TotalTimeLabel.TabIndex = 9;
            this.TotalTimeLabel.Text = "00:00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.minimizeToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem,
            this.versionHistoryToolStripMenuItem,
            this.licenceToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.readMeToolStripMenuItem.Text = "Read Me";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // versionHistoryToolStripMenuItem
            // 
            this.versionHistoryToolStripMenuItem.Name = "versionHistoryToolStripMenuItem";
            this.versionHistoryToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.versionHistoryToolStripMenuItem.Text = "Version History";
            this.versionHistoryToolStripMenuItem.Click += new System.EventHandler(this.versionHistoryToolStripMenuItem_Click);
            // 
            // licenceToolStripMenuItem
            // 
            this.licenceToolStripMenuItem.Name = "licenceToolStripMenuItem";
            this.licenceToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.licenceToolStripMenuItem.Text = "Licence";
            this.licenceToolStripMenuItem.Click += new System.EventHandler(this.licenceToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ratio (At Desk)";
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Location = new System.Drawing.Point(393, 192);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(15, 13);
            this.PercentageLabel.TabIndex = 13;
            this.PercentageLabel.Text = "%";
            // 
            // testLockBtn
            // 
            this.testLockBtn.Enabled = false;
            this.testLockBtn.Location = new System.Drawing.Point(290, 257);
            this.testLockBtn.Name = "testLockBtn";
            this.testLockBtn.Size = new System.Drawing.Size(75, 23);
            this.testLockBtn.TabIndex = 14;
            this.testLockBtn.Text = "lock";
            this.testLockBtn.UseVisualStyleBackColor = true;
            this.testLockBtn.Visible = false;
            this.testLockBtn.Click += new System.EventHandler(this.testLockBtn_Click);
            // 
            // testUnlockBtn
            // 
            this.testUnlockBtn.Enabled = false;
            this.testUnlockBtn.Location = new System.Drawing.Point(371, 257);
            this.testUnlockBtn.Name = "testUnlockBtn";
            this.testUnlockBtn.Size = new System.Drawing.Size(75, 23);
            this.testUnlockBtn.TabIndex = 15;
            this.testUnlockBtn.Text = "unlock";
            this.testUnlockBtn.UseVisualStyleBackColor = true;
            this.testUnlockBtn.Visible = false;
            this.testUnlockBtn.Click += new System.EventHandler(this.testUnlockBtn_Click);
            // 
            // BreakWarningLabel
            // 
            this.BreakWarningLabel.AutoSize = true;
            this.BreakWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.BreakWarningLabel.Location = new System.Drawing.Point(298, 241);
            this.BreakWarningLabel.Name = "BreakWarningLabel";
            this.BreakWarningLabel.Size = new System.Drawing.Size(72, 13);
            this.BreakWarningLabel.TabIndex = 16;
            this.BreakWarningLabel.Text = "Take a Break";
            this.BreakWarningLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Time Left - ";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Location = new System.Drawing.Point(393, 158);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(49, 13);
            this.TimeLeftLabel.TabIndex = 18;
            this.TimeLeftLabel.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Home At";
            // 
            // homeAtLabel
            // 
            this.homeAtLabel.AutoSize = true;
            this.homeAtLabel.Location = new System.Drawing.Point(393, 216);
            this.homeAtLabel.Name = "homeAtLabel";
            this.homeAtLabel.Size = new System.Drawing.Size(49, 13);
            this.homeAtLabel.TabIndex = 20;
            this.homeAtLabel.Text = "00:00:00";
            // 
            // keepUnlockedTimer
            // 
            this.keepUnlockedTimer.Interval = 55000;
            this.keepUnlockedTimer.Tick += new System.EventHandler(this.keepUnlockedTimer_Tick);
            // 
            // MainProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 286);
            this.ControlBox = false;
            this.Controls.Add(this.homeAtLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BreakWarningLabel);
            this.Controls.Add(this.testUnlockBtn);
            this.Controls.Add(this.testLockBtn);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalTimeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastBreakLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AwayTimeLabel);
            this.Controls.Add(this.HomeTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainProgramForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Break Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HomeTimeLabel;
        private System.Windows.Forms.Label AwayTimeLabel;
        private System.Windows.Forms.Timer timeUpdateTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LastBreakLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalTimeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button testLockBtn;
        private System.Windows.Forms.Button testUnlockBtn;
        private System.Windows.Forms.Label BreakWarningLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TimeLeftLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label homeAtLabel;
        private System.Windows.Forms.ToolStripMenuItem licenceToolStripMenuItem;
        private System.Windows.Forms.Timer keepUnlockedTimer;
    }
}

