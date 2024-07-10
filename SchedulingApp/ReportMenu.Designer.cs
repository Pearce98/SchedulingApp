namespace SchedulingApp
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
            this.aptsByMonthGrid = new System.Windows.Forms.DataGridView();
            this.thirdReportGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.titleOneLabel = new System.Windows.Forms.Label();
            this.titleTwoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptsByMonthGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdReportGrid)).BeginInit();
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
            this.userScheduleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userScheduleGrid.Location = new System.Drawing.Point(12, 73);
            this.userScheduleGrid.Name = "userScheduleGrid";
            this.userScheduleGrid.Size = new System.Drawing.Size(333, 330);
            this.userScheduleGrid.TabIndex = 1;
            // 
            // aptsByMonthGrid
            // 
            this.aptsByMonthGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aptsByMonthGrid.Location = new System.Drawing.Point(369, 73);
            this.aptsByMonthGrid.Name = "aptsByMonthGrid";
            this.aptsByMonthGrid.Size = new System.Drawing.Size(333, 330);
            this.aptsByMonthGrid.TabIndex = 2;
            // 
            // thirdReportGrid
            // 
            this.thirdReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thirdReportGrid.Location = new System.Drawing.Point(723, 73);
            this.thirdReportGrid.Name = "thirdReportGrid";
            this.thirdReportGrid.Size = new System.Drawing.Size(333, 330);
            this.thirdReportGrid.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(981, 464);
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
            this.monthLabel.Location = new System.Drawing.Point(369, 417);
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
            this.monthComboBox.Location = new System.Drawing.Point(415, 414);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(287, 21);
            this.monthComboBox.TabIndex = 8;
            // 
            // titleOneLabel
            // 
            this.titleOneLabel.AutoSize = true;
            this.titleOneLabel.Location = new System.Drawing.Point(263, 57);
            this.titleOneLabel.Name = "titleOneLabel";
            this.titleOneLabel.Size = new System.Drawing.Size(82, 13);
            this.titleOneLabel.TabIndex = 9;
            this.titleOneLabel.Text = "User Schedules";
            // 
            // titleTwoLabel
            // 
            this.titleTwoLabel.AutoSize = true;
            this.titleTwoLabel.Location = new System.Drawing.Point(584, 57);
            this.titleTwoLabel.Name = "titleTwoLabel";
            this.titleTwoLabel.Size = new System.Drawing.Size(118, 13);
            this.titleTwoLabel.TabIndex = 10;
            this.titleTwoLabel.Text = "Appointments by Month";
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 499);
            this.Controls.Add(this.titleTwoLabel);
            this.Controls.Add(this.titleOneLabel);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.thirdReportGrid);
            this.Controls.Add(this.aptsByMonthGrid);
            this.Controls.Add(this.userScheduleGrid);
            this.Controls.Add(this.reportsTitleLabel);
            this.Name = "ReportMenu";
            this.Text = "ReportMenu";
            ((System.ComponentModel.ISupportInitialize)(this.userScheduleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aptsByMonthGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdReportGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportsTitleLabel;
        private System.Windows.Forms.DataGridView userScheduleGrid;
        private System.Windows.Forms.DataGridView aptsByMonthGrid;
        private System.Windows.Forms.DataGridView thirdReportGrid;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.Label titleOneLabel;
        private System.Windows.Forms.Label titleTwoLabel;
    }
}