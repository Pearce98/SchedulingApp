namespace SchedulingApp
{
    partial class AddAppointment
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
            this.addAppointmentLabel = new System.Windows.Forms.Label();
            this.appointmentID = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.aptIDTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.custIDBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addAppointmentLabel
            // 
            this.addAppointmentLabel.AutoSize = true;
            this.addAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.addAppointmentLabel.Name = "addAppointmentLabel";
            this.addAppointmentLabel.Size = new System.Drawing.Size(157, 24);
            this.addAppointmentLabel.TabIndex = 0;
            this.addAppointmentLabel.Text = "Add Appointment";
            // 
            // appointmentID
            // 
            this.appointmentID.AutoSize = true;
            this.appointmentID.Location = new System.Drawing.Point(89, 51);
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.Size = new System.Drawing.Size(80, 13);
            this.appointmentID.TabIndex = 1;
            this.appointmentID.Text = "Appointment ID";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(138, 77);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Type";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(114, 106);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 6;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(117, 157);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 7;
            this.endDateLabel.Text = "End Date";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(114, 131);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 8;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(117, 185);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 9;
            this.endTimeLabel.Text = "End Time";
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(104, 210);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(65, 13);
            this.custIDLabel.TabIndex = 10;
            this.custIDLabel.Text = "Customer ID";
            // 
            // aptIDTextBox
            // 
            this.aptIDTextBox.Enabled = false;
            this.aptIDTextBox.Location = new System.Drawing.Point(194, 48);
            this.aptIDTextBox.Name = "aptIDTextBox";
            this.aptIDTextBox.Size = new System.Drawing.Size(214, 20);
            this.aptIDTextBox.TabIndex = 0;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(194, 74);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(214, 20);
            this.typeTextBox.TabIndex = 1;
            // 
            // custIDBox
            // 
            this.custIDBox.FormattingEnabled = true;
            this.custIDBox.Location = new System.Drawing.Point(194, 207);
            this.custIDBox.Name = "custIDBox";
            this.custIDBox.Size = new System.Drawing.Size(214, 21);
            this.custIDBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(333, 249);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 249);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(194, 104);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(214, 20);
            this.startDateTextBox.TabIndex = 2;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(194, 130);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(214, 20);
            this.startTimeTextBox.TabIndex = 3;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(194, 156);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(214, 20);
            this.endDateTextBox.TabIndex = 4;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Location = new System.Drawing.Point(194, 181);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(214, 20);
            this.endTimeTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 65);
            this.label1.TabIndex = 11;
            this.label1.Text = "Note:\r\nBusiness Hours are 9:00 am - 5:00 pm EST.\r\nPlease put dates in MM-dd-yyyy " +
    "format.\r\nPlease put times in hh:mm:ss tt format.\r\nYou may put times in your own " +
    "time zone.";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.custIDBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.aptIDTextBox);
            this.Controls.Add(this.custIDLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.appointmentID);
            this.Controls.Add(this.addAppointmentLabel);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAppointmentLabel;
        private System.Windows.Forms.Label appointmentID;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.TextBox aptIDTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.ComboBox custIDBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.Label label1;
    }
}