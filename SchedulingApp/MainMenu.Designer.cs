namespace SchedulingApp
{
    partial class MainMenu
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
            this.appointmentsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.customerLabel = new System.Windows.Forms.Label();
            this.currentMonthButton = new System.Windows.Forms.RadioButton();
            this.currentWeekButton = new System.Windows.Forms.RadioButton();
            this.allAppointmentsButton = new System.Windows.Forms.RadioButton();
            this.deleteAptButton = new System.Windows.Forms.Button();
            this.updateAptButton = new System.Windows.Forms.Button();
            this.addAptButton = new System.Windows.Forms.Button();
            this.deleteCustButton = new System.Windows.Forms.Button();
            this.updateCustButton = new System.Windows.Forms.Button();
            this.addCustButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentsLabel
            // 
            this.appointmentsLabel.AutoSize = true;
            this.appointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLabel.Location = new System.Drawing.Point(12, 9);
            this.appointmentsLabel.Name = "appointmentsLabel";
            this.appointmentsLabel.Size = new System.Drawing.Size(89, 16);
            this.appointmentsLabel.TabIndex = 0;
            this.appointmentsLabel.Text = "Appointments";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 291);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(566, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 291);
            this.dataGridView2.TabIndex = 2;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(563, 9);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(71, 16);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customers";
            // 
            // currentMonthButton
            // 
            this.currentMonthButton.AutoSize = true;
            this.currentMonthButton.Location = new System.Drawing.Point(234, 9);
            this.currentMonthButton.Name = "currentMonthButton";
            this.currentMonthButton.Size = new System.Drawing.Size(92, 17);
            this.currentMonthButton.TabIndex = 4;
            this.currentMonthButton.TabStop = true;
            this.currentMonthButton.Text = "Current Month";
            this.currentMonthButton.UseVisualStyleBackColor = true;
            // 
            // currentWeekButton
            // 
            this.currentWeekButton.AutoSize = true;
            this.currentWeekButton.Location = new System.Drawing.Point(333, 9);
            this.currentWeekButton.Name = "currentWeekButton";
            this.currentWeekButton.Size = new System.Drawing.Size(91, 17);
            this.currentWeekButton.TabIndex = 5;
            this.currentWeekButton.TabStop = true;
            this.currentWeekButton.Text = "Current Week";
            this.currentWeekButton.UseVisualStyleBackColor = true;
            // 
            // allAppointmentsButton
            // 
            this.allAppointmentsButton.AutoSize = true;
            this.allAppointmentsButton.Location = new System.Drawing.Point(431, 9);
            this.allAppointmentsButton.Name = "allAppointmentsButton";
            this.allAppointmentsButton.Size = new System.Drawing.Size(103, 17);
            this.allAppointmentsButton.TabIndex = 6;
            this.allAppointmentsButton.TabStop = true;
            this.allAppointmentsButton.Text = "All Appointments";
            this.allAppointmentsButton.UseVisualStyleBackColor = true;
            // 
            // deleteAptButton
            // 
            this.deleteAptButton.Location = new System.Drawing.Point(458, 326);
            this.deleteAptButton.Name = "deleteAptButton";
            this.deleteAptButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAptButton.TabIndex = 7;
            this.deleteAptButton.Text = "Delete";
            this.deleteAptButton.UseVisualStyleBackColor = true;
            // 
            // updateAptButton
            // 
            this.updateAptButton.Location = new System.Drawing.Point(377, 325);
            this.updateAptButton.Name = "updateAptButton";
            this.updateAptButton.Size = new System.Drawing.Size(75, 23);
            this.updateAptButton.TabIndex = 8;
            this.updateAptButton.Text = "Update";
            this.updateAptButton.UseVisualStyleBackColor = true;
            this.updateAptButton.Click += new System.EventHandler(this.updateAptButton_Click);
            // 
            // addAptButton
            // 
            this.addAptButton.Location = new System.Drawing.Point(296, 325);
            this.addAptButton.Name = "addAptButton";
            this.addAptButton.Size = new System.Drawing.Size(75, 23);
            this.addAptButton.TabIndex = 9;
            this.addAptButton.Text = "Add";
            this.addAptButton.UseVisualStyleBackColor = true;
            this.addAptButton.Click += new System.EventHandler(this.addAptButton_Click);
            // 
            // deleteCustButton
            // 
            this.deleteCustButton.Location = new System.Drawing.Point(1009, 325);
            this.deleteCustButton.Name = "deleteCustButton";
            this.deleteCustButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCustButton.TabIndex = 10;
            this.deleteCustButton.Text = "Delete";
            this.deleteCustButton.UseVisualStyleBackColor = true;
            // 
            // updateCustButton
            // 
            this.updateCustButton.Location = new System.Drawing.Point(928, 326);
            this.updateCustButton.Name = "updateCustButton";
            this.updateCustButton.Size = new System.Drawing.Size(75, 23);
            this.updateCustButton.TabIndex = 11;
            this.updateCustButton.Text = "Update";
            this.updateCustButton.UseVisualStyleBackColor = true;
            this.updateCustButton.Click += new System.EventHandler(this.updateCustButton_Click);
            // 
            // addCustButton
            // 
            this.addCustButton.Location = new System.Drawing.Point(847, 326);
            this.addCustButton.Name = "addCustButton";
            this.addCustButton.Size = new System.Drawing.Size(75, 23);
            this.addCustButton.TabIndex = 12;
            this.addCustButton.Text = "Add";
            this.addCustButton.UseVisualStyleBackColor = true;
            this.addCustButton.Click += new System.EventHandler(this.addCustButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(928, 415);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(156, 23);
            this.logoutButton.TabIndex = 13;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(766, 415);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(156, 23);
            this.reportButton.TabIndex = 14;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.addCustButton);
            this.Controls.Add(this.updateCustButton);
            this.Controls.Add(this.deleteCustButton);
            this.Controls.Add(this.addAptButton);
            this.Controls.Add(this.updateAptButton);
            this.Controls.Add(this.deleteAptButton);
            this.Controls.Add(this.allAppointmentsButton);
            this.Controls.Add(this.currentWeekButton);
            this.Controls.Add(this.currentMonthButton);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.appointmentsLabel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.RadioButton currentMonthButton;
        private System.Windows.Forms.RadioButton currentWeekButton;
        private System.Windows.Forms.RadioButton allAppointmentsButton;
        private System.Windows.Forms.Button deleteAptButton;
        private System.Windows.Forms.Button updateAptButton;
        private System.Windows.Forms.Button addAptButton;
        private System.Windows.Forms.Button deleteCustButton;
        private System.Windows.Forms.Button updateCustButton;
        private System.Windows.Forms.Button addCustButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button reportButton;
    }
}