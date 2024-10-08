﻿namespace SchedulingApp
{
    partial class ReportMenu
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
            this.reportsTitleLabel = new System.Windows.Forms.Label();
            this.userScheduleGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.titleOneLabel = new System.Windows.Forms.Label();
            this.titleTwoLabel = new System.Windows.Forms.Label();
            this.meetingTypeLabel = new System.Windows.Forms.Label();
            this.meetingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfMeetingsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numbMeetings = new System.Windows.Forms.Label();
            this.updateScheduleButton = new System.Windows.Forms.Button();
            this.aptMonthUpdateButton = new System.Windows.Forms.Button();
            this.countryNameBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numbCusts = new System.Windows.Forms.Label();
            this.numbCustUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsTitleLabel
            // 
            this.reportsTitleLabel.AutoSize = true;
            this.reportsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.reportsTitleLabel.Name = "reportsTitleLabel";
            this.reportsTitleLabel.Size = new System.Drawing.Size(75, 24);
            this.reportsTitleLabel.TabIndex = 0;
            this.reportsTitleLabel.Text = "Reports";
            // 
            // userScheduleGrid
            // 
            this.userScheduleGrid.AllowUserToAddRows = false;
            this.userScheduleGrid.AllowUserToDeleteRows = false;
            this.userScheduleGrid.AllowUserToResizeColumns = false;
            this.userScheduleGrid.AllowUserToResizeRows = false;
            this.userScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleGrid.Location = new System.Drawing.Point(12, 73);
            this.userScheduleGrid.Name = "userScheduleGrid";
            this.userScheduleGrid.RowHeadersVisible = false;
            this.userScheduleGrid.Size = new System.Drawing.Size(333, 330);
            this.userScheduleGrid.TabIndex = 1;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(981, 521);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 414);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(32, 13);
            this.userLabel.TabIndex = 5;
            this.userLabel.Text = "User:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(430, 128);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(40, 13);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "Month:";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(51, 409);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(294, 21);
            this.userComboBox.TabIndex = 7;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(476, 125);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(226, 21);
            this.monthComboBox.TabIndex = 8;
            // 
            // titleOneLabel
            // 
            this.titleOneLabel.AutoSize = true;
            this.titleOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleOneLabel.Location = new System.Drawing.Point(242, 54);
            this.titleOneLabel.Name = "titleOneLabel";
            this.titleOneLabel.Size = new System.Drawing.Size(103, 16);
            this.titleOneLabel.TabIndex = 9;
            this.titleOneLabel.Text = "User Schedules";
            // 
            // titleTwoLabel
            // 
            this.titleTwoLabel.AutoSize = true;
            this.titleTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTwoLabel.Location = new System.Drawing.Point(556, 54);
            this.titleTwoLabel.Name = "titleTwoLabel";
            this.titleTwoLabel.Size = new System.Drawing.Size(146, 16);
            this.titleTwoLabel.TabIndex = 10;
            this.titleTwoLabel.Text = "Appointments by Month";
            // 
            // meetingTypeLabel
            // 
            this.meetingTypeLabel.AutoSize = true;
            this.meetingTypeLabel.Location = new System.Drawing.Point(395, 172);
            this.meetingTypeLabel.Name = "meetingTypeLabel";
            this.meetingTypeLabel.Size = new System.Drawing.Size(75, 13);
            this.meetingTypeLabel.TabIndex = 11;
            this.meetingTypeLabel.Text = "Meeting Type:";
            // 
            // meetingTypeComboBox
            // 
            this.meetingTypeComboBox.FormattingEnabled = true;
            this.meetingTypeComboBox.Location = new System.Drawing.Point(476, 169);
            this.meetingTypeComboBox.Name = "meetingTypeComboBox";
            this.meetingTypeComboBox.Size = new System.Drawing.Size(226, 21);
            this.meetingTypeComboBox.TabIndex = 12;
            // 
            // numberOfMeetingsLabel
            // 
            this.numberOfMeetingsLabel.AutoSize = true;
            this.numberOfMeetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfMeetingsLabel.Location = new System.Drawing.Point(442, 226);
            this.numberOfMeetingsLabel.Name = "numberOfMeetingsLabel";
            this.numberOfMeetingsLabel.Size = new System.Drawing.Size(122, 15);
            this.numberOfMeetingsLabel.TabIndex = 13;
            this.numberOfMeetingsLabel.Text = "Number of Meetings:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(919, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customers by Country";
            // 
            // numbMeetings
            // 
            this.numbMeetings.AutoSize = true;
            this.numbMeetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbMeetings.Location = new System.Drawing.Point(570, 226);
            this.numbMeetings.Name = "numbMeetings";
            this.numbMeetings.Size = new System.Drawing.Size(14, 15);
            this.numbMeetings.TabIndex = 15;
            this.numbMeetings.Text = "0";
            // 
            // updateScheduleButton
            // 
            this.updateScheduleButton.Location = new System.Drawing.Point(270, 436);
            this.updateScheduleButton.Name = "updateScheduleButton";
            this.updateScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.updateScheduleButton.TabIndex = 16;
            this.updateScheduleButton.Text = "Update";
            this.updateScheduleButton.UseVisualStyleBackColor = true;
            this.updateScheduleButton.Click += new System.EventHandler(this.updateScheduleButton_Click);
            // 
            // aptMonthUpdateButton
            // 
            this.aptMonthUpdateButton.Location = new System.Drawing.Point(529, 260);
            this.aptMonthUpdateButton.Name = "aptMonthUpdateButton";
            this.aptMonthUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.aptMonthUpdateButton.TabIndex = 17;
            this.aptMonthUpdateButton.Text = "Update";
            this.aptMonthUpdateButton.UseVisualStyleBackColor = true;
            this.aptMonthUpdateButton.Click += new System.EventHandler(this.aptMonthUpdateButton_Click);
            // 
            // countryNameBox
            // 
            this.countryNameBox.FormattingEnabled = true;
            this.countryNameBox.Location = new System.Drawing.Point(866, 125);
            this.countryNameBox.Name = "countryNameBox";
            this.countryNameBox.Size = new System.Drawing.Size(190, 21);
            this.countryNameBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Country Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(758, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Number of Customers in the Country:";
            // 
            // numbCusts
            // 
            this.numbCusts.AutoSize = true;
            this.numbCusts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbCusts.Location = new System.Drawing.Point(971, 228);
            this.numbCusts.Name = "numbCusts";
            this.numbCusts.Size = new System.Drawing.Size(14, 15);
            this.numbCusts.TabIndex = 21;
            this.numbCusts.Text = "0";
            // 
            // numbCustUpdateButton
            // 
            this.numbCustUpdateButton.Location = new System.Drawing.Point(890, 260);
            this.numbCustUpdateButton.Name = "numbCustUpdateButton";
            this.numbCustUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.numbCustUpdateButton.TabIndex = 22;
            this.numbCustUpdateButton.Text = "Update";
            this.numbCustUpdateButton.UseVisualStyleBackColor = true;
            this.numbCustUpdateButton.Click += new System.EventHandler(this.numbCustUpdateButton_Click);
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 556);
            this.Controls.Add(this.numbCustUpdateButton);
            this.Controls.Add(this.numbCusts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryNameBox);
            this.Controls.Add(this.aptMonthUpdateButton);
            this.Controls.Add(this.updateScheduleButton);
            this.Controls.Add(this.numbMeetings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberOfMeetingsLabel);
            this.Controls.Add(this.meetingTypeComboBox);
            this.Controls.Add(this.meetingTypeLabel);
            this.Controls.Add(this.titleTwoLabel);
            this.Controls.Add(this.titleOneLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.userScheduleGrid);
            this.Controls.Add(this.reportsTitleLabel);
            this.Name = "ReportMenu";
            this.Text = "ReportMenu";
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportsTitleLabel;
        private System.Windows.Forms.DataGridView userScheduleGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label titleOneLabel;
        private System.Windows.Forms.Label titleTwoLabel;
        private System.Windows.Forms.Label meetingTypeLabel;
        private System.Windows.Forms.ComboBox meetingTypeComboBox;
        private System.Windows.Forms.Label numberOfMeetingsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numbMeetings;
        private System.Windows.Forms.Button updateScheduleButton;
        private System.Windows.Forms.Button aptMonthUpdateButton;
        private System.Windows.Forms.ComboBox countryNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numbCusts;
        private System.Windows.Forms.Button numbCustUpdateButton;
    }
}