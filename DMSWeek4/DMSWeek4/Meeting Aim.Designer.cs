namespace DMSWeek4
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.RB_Meeting = new System.Windows.Forms.RadioButton();
            this.RB_StudentInterview = new System.Windows.Forms.RadioButton();
            this.RB_SalesAppointment = new System.Windows.Forms.RadioButton();
            this.RB_SiteVisit = new System.Windows.Forms.RadioButton();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify the natyre of the meeting";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RB_Meeting
            // 
            this.RB_Meeting.AutoSize = true;
            this.RB_Meeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RB_Meeting.Location = new System.Drawing.Point(60, 86);
            this.RB_Meeting.Name = "RB_Meeting";
            this.RB_Meeting.Size = new System.Drawing.Size(83, 20);
            this.RB_Meeting.TabIndex = 1;
            this.RB_Meeting.TabStop = true;
            this.RB_Meeting.Text = "Meeting";
            this.RB_Meeting.UseVisualStyleBackColor = true;
            // 
            // RB_StudentInterview
            // 
            this.RB_StudentInterview.AutoSize = true;
            this.RB_StudentInterview.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RB_StudentInterview.Location = new System.Drawing.Point(294, 182);
            this.RB_StudentInterview.Name = "RB_StudentInterview";
            this.RB_StudentInterview.Size = new System.Drawing.Size(145, 20);
            this.RB_StudentInterview.TabIndex = 2;
            this.RB_StudentInterview.TabStop = true;
            this.RB_StudentInterview.Text = "Student Interview";
            this.RB_StudentInterview.UseVisualStyleBackColor = true;
            this.RB_StudentInterview.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB_SalesAppointment
            // 
            this.RB_SalesAppointment.AutoSize = true;
            this.RB_SalesAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RB_SalesAppointment.Location = new System.Drawing.Point(294, 97);
            this.RB_SalesAppointment.Name = "RB_SalesAppointment";
            this.RB_SalesAppointment.Size = new System.Drawing.Size(158, 20);
            this.RB_SalesAppointment.TabIndex = 3;
            this.RB_SalesAppointment.TabStop = true;
            this.RB_SalesAppointment.Text = "Sales Appointment";
            this.RB_SalesAppointment.UseVisualStyleBackColor = true;
            // 
            // RB_SiteVisit
            // 
            this.RB_SiteVisit.AutoSize = true;
            this.RB_SiteVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RB_SiteVisit.Location = new System.Drawing.Point(60, 182);
            this.RB_SiteVisit.Name = "RB_SiteVisit";
            this.RB_SiteVisit.Size = new System.Drawing.Size(89, 20);
            this.RB_SiteVisit.TabIndex = 4;
            this.RB_SiteVisit.TabStop = true;
            this.RB_SiteVisit.Text = "Site Visit";
            this.RB_SiteVisit.UseVisualStyleBackColor = true;
            this.RB_SiteVisit.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BT_Cancel.Location = new System.Drawing.Point(84, 266);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(120, 39);
            this.BT_Cancel.TabIndex = 5;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_OK
            // 
            this.BT_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BT_OK.Location = new System.Drawing.Point(294, 266);
            this.BT_OK.Name = "BT_OK";
            this.BT_OK.Size = new System.Drawing.Size(120, 39);
            this.BT_OK.TabIndex = 6;
            this.BT_OK.Text = "OK";
            this.BT_OK.UseVisualStyleBackColor = true;
            this.BT_OK.Click += new System.EventHandler(this.BT_OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 338);
            this.Controls.Add(this.BT_OK);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.RB_SiteVisit);
            this.Controls.Add(this.RB_SalesAppointment);
            this.Controls.Add(this.RB_StudentInterview);
            this.Controls.Add(this.RB_Meeting);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Aim";
            this.Load += new System.EventHandler(this.Meeting_Aim_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RB_Meeting;
        private System.Windows.Forms.RadioButton RB_StudentInterview;
        private System.Windows.Forms.RadioButton RB_SalesAppointment;
        private System.Windows.Forms.RadioButton RB_SiteVisit;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_OK;
    }
}