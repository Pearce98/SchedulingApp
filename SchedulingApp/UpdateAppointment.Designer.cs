namespace SchedulingApp
{
    partial class UpdateAppointment
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.aptIDTextBox = new System.Windows.Forms.TextBox();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.appointmentID = new System.Windows.Forms.Label();
            this.updateAppointmentLabel = new System.Windows.Forms.Label();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.custIDBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 249);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(333, 250);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(194, 100);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(214, 20);
            this.startDateTextBox.TabIndex = 2;
            // 
            // aptIDTextBox
            // 
            this.aptIDTextBox.Enabled = false;
            this.aptIDTextBox.Location = new System.Drawing.Point(194, 48);
            this.aptIDTextBox.Name = "aptIDTextBox";
            this.aptIDTextBox.Size = new System.Drawing.Size(214, 20);
            this.aptIDTextBox.TabIndex = 40;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(120, 181);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(52, 13);
            this.endTimeLabel.TabIndex = 36;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(117, 129);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.startTimeLabel.TabIndex = 35;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(120, 155);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 34;
            this.endDateLabel.Text = "End Date";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(117, 103);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 33;
            this.startDateLabel.Text = "Start Date";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(141, 77);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 30;
            this.typeLabel.Text = "Type";
            // 
            // appointmentID
            // 
            this.appointmentID.AutoSize = true;
            this.appointmentID.Location = new System.Drawing.Point(92, 51);
            this.appointmentID.Name = "appointmentID";
            this.appointmentID.Size = new System.Drawing.Size(80, 13);
            this.appointmentID.TabIndex = 28;
            this.appointmentID.Text = "Appointment ID";
            // 
            // updateAppointmentLabel
            // 
            this.updateAppointmentLabel.AutoSize = true;
            this.updateAppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentLabel.Location = new System.Drawing.Point(12, 9);
            this.updateAppointmentLabel.Name = "updateAppointmentLabel";
            this.updateAppointmentLabel.Size = new System.Drawing.Size(182, 24);
            this.updateAppointmentLabel.TabIndex = 27;
            this.updateAppointmentLabel.Text = "Update Appointment";
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(107, 207);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(65, 13);
            this.custIDLabel.TabIndex = 37;
            this.custIDLabel.Text = "Customer ID";
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Location = new System.Drawing.Point(194, 178);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(214, 20);
            this.endTimeTextBox.TabIndex = 5;
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(194, 152);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(214, 20);
            this.endDateTextBox.TabIndex = 4;
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(194, 126);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(214, 20);
            this.startTimeTextBox.TabIndex = 3;
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
            this.custIDBox.Location = new System.Drawing.Point(194, 204);
            this.custIDBox.Name = "custIDBox";
            this.custIDBox.Size = new System.Drawing.Size(214, 21);
            this.custIDBox.TabIndex = 6;
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 298);
            this.Controls.Add(this.custIDBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.aptIDTextBox);
            this.Controls.Add(this.custIDLabel);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.appointmentID);
            this.Controls.Add(this.updateAppointmentLabel);
            this.Name = "UpdateAppointment";
            this.Text = "UpdateAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.TextBox aptIDTextBox;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label appointmentID;
        private System.Windows.Forms.Label updateAppointmentLabel;
        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.ComboBox custIDBox;
    }
}