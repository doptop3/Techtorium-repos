namespace DMSWeek4
{
    partial class Form1
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
            this.Visitor_Details_GB = new System.Windows.Forms.GroupBox();
            this.TB_Insert_Btn = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.Visitor_Email = new System.Windows.Forms.Label();
            this.TB_Mobile = new System.Windows.Forms.TextBox();
            this.Visitor_Mobilr = new System.Windows.Forms.Label();
            this.TB_Visitor_Surname = new System.Windows.Forms.TextBox();
            this.TB_LName = new System.Windows.Forms.Label();
            this.TB_Visitor_Name = new System.Windows.Forms.TextBox();
            this.TB_FName = new System.Windows.Forms.Label();
            this.Meeting_Details_GB = new System.Windows.Forms.GroupBox();
            this.TB_Edit_Btn = new System.Windows.Forms.Button();
            this.TB_MeetingWith = new System.Windows.Forms.ComboBox();
            this.Meeting_Aim_Btn = new System.Windows.Forms.Button();
            this.TB_MeetingMinutes = new System.Windows.Forms.DomainUpDown();
            this.TB_MeetingHours = new System.Windows.Forms.DomainUpDown();
            this.TB_MeetingDate = new System.Windows.Forms.DateTimePicker();
            this.Meeting_Aim = new System.Windows.Forms.Label();
            this.Meeting_With = new System.Windows.Forms.Label();
            this.Meeting_time = new System.Windows.Forms.Label();
            this.Meeting_Date = new System.Windows.Forms.Label();
            this.SignIn_Btn = new System.Windows.Forms.Button();
            this.LB_Visitoron_site = new System.Windows.Forms.ListBox();
            this.GB_Visitoron_site = new System.Windows.Forms.GroupBox();
            this.TB_Update_Btn = new System.Windows.Forms.Button();
            this.TB_Delete_Btn = new System.Windows.Forms.Button();
            this.Visitor_Details_GB.SuspendLayout();
            this.Meeting_Details_GB.SuspendLayout();
            this.GB_Visitoron_site.SuspendLayout();
            this.SuspendLayout();
            // 
            // Visitor_Details_GB
            // 
            this.Visitor_Details_GB.Controls.Add(this.TB_Insert_Btn);
            this.Visitor_Details_GB.Controls.Add(this.lblError);
            this.Visitor_Details_GB.Controls.Add(this.TB_Email);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Email);
            this.Visitor_Details_GB.Controls.Add(this.TB_Mobile);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Mobilr);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Surname);
            this.Visitor_Details_GB.Controls.Add(this.TB_LName);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Name);
            this.Visitor_Details_GB.Controls.Add(this.TB_FName);
            this.Visitor_Details_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Details_GB.Location = new System.Drawing.Point(27, 17);
            this.Visitor_Details_GB.Name = "Visitor_Details_GB";
            this.Visitor_Details_GB.Size = new System.Drawing.Size(351, 386);
            this.Visitor_Details_GB.TabIndex = 0;
            this.Visitor_Details_GB.TabStop = false;
            this.Visitor_Details_GB.Text = "Student Details";
            // 
            // TB_Insert_Btn
            // 
            this.TB_Insert_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Insert_Btn.Location = new System.Drawing.Point(42, 348);
            this.TB_Insert_Btn.Name = "TB_Insert_Btn";
            this.TB_Insert_Btn.Size = new System.Drawing.Size(268, 32);
            this.TB_Insert_Btn.TabIndex = 8;
            this.TB_Insert_Btn.Text = "Insert";
            this.TB_Insert_Btn.UseVisualStyleBackColor = true;
            this.TB_Insert_Btn.Click += new System.EventHandler(this.TB_Insert_Btn_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblError.Location = new System.Drawing.Point(143, 269);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 11;
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Email.Location = new System.Drawing.Point(18, 304);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(241, 24);
            this.TB_Email.TabIndex = 10;
            // 
            // Visitor_Email
            // 
            this.Visitor_Email.AutoSize = true;
            this.Visitor_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Email.Location = new System.Drawing.Point(15, 269);
            this.Visitor_Email.Name = "Visitor_Email";
            this.Visitor_Email.Size = new System.Drawing.Size(50, 18);
            this.Visitor_Email.TabIndex = 9;
            this.Visitor_Email.Text = "Email";
            this.Visitor_Email.Click += new System.EventHandler(this.Visitor_Email_Click);
            // 
            // TB_Mobile
            // 
            this.TB_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Mobile.Location = new System.Drawing.Point(18, 223);
            this.TB_Mobile.MaxLength = 10;
            this.TB_Mobile.Name = "TB_Mobile";
            this.TB_Mobile.Size = new System.Drawing.Size(241, 24);
            this.TB_Mobile.TabIndex = 8;
            this.TB_Mobile.TextChanged += new System.EventHandler(this.TB_Visitor_Mobile_TextChanged_1);
            // 
            // Visitor_Mobilr
            // 
            this.Visitor_Mobilr.AutoSize = true;
            this.Visitor_Mobilr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Mobilr.Location = new System.Drawing.Point(15, 188);
            this.Visitor_Mobilr.Name = "Visitor_Mobilr";
            this.Visitor_Mobilr.Size = new System.Drawing.Size(58, 18);
            this.Visitor_Mobilr.TabIndex = 7;
            this.Visitor_Mobilr.Text = "Mobile";
            // 
            // TB_Visitor_Surname
            // 
            this.TB_Visitor_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Visitor_Surname.Location = new System.Drawing.Point(18, 148);
            this.TB_Visitor_Surname.Name = "TB_Visitor_Surname";
            this.TB_Visitor_Surname.Size = new System.Drawing.Size(241, 24);
            this.TB_Visitor_Surname.TabIndex = 6;
            this.TB_Visitor_Surname.TextChanged += new System.EventHandler(this.TB_Visitor_Surname_TextChanged);
            // 
            // TB_LName
            // 
            this.TB_LName.AutoSize = true;
            this.TB_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_LName.Location = new System.Drawing.Point(15, 113);
            this.TB_LName.Name = "TB_LName";
            this.TB_LName.Size = new System.Drawing.Size(89, 18);
            this.TB_LName.TabIndex = 5;
            this.TB_LName.Text = "Last Name";
            this.TB_LName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Visitor_Name
            // 
            this.TB_Visitor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Visitor_Name.Location = new System.Drawing.Point(18, 71);
            this.TB_Visitor_Name.Name = "TB_Visitor_Name";
            this.TB_Visitor_Name.Size = new System.Drawing.Size(241, 24);
            this.TB_Visitor_Name.TabIndex = 4;
            this.TB_Visitor_Name.TextChanged += new System.EventHandler(this.TB_Visitor_Name_TextChanged);
            // 
            // TB_FName
            // 
            this.TB_FName.AutoSize = true;
            this.TB_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_FName.Location = new System.Drawing.Point(15, 36);
            this.TB_FName.Name = "TB_FName";
            this.TB_FName.Size = new System.Drawing.Size(91, 18);
            this.TB_FName.TabIndex = 1;
            this.TB_FName.Text = "First Name";
            // 
            // Meeting_Details_GB
            // 
            this.Meeting_Details_GB.Controls.Add(this.TB_Edit_Btn);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingWith);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_Aim_Btn);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingMinutes);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingHours);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingDate);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_Aim);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_With);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_time);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_Date);
            this.Meeting_Details_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Meeting_Details_GB.Location = new System.Drawing.Point(423, 17);
            this.Meeting_Details_GB.Name = "Meeting_Details_GB";
            this.Meeting_Details_GB.Size = new System.Drawing.Size(350, 386);
            this.Meeting_Details_GB.TabIndex = 2;
            this.Meeting_Details_GB.TabStop = false;
            this.Meeting_Details_GB.Text = "Meeting Details";
            // 
            // TB_Edit_Btn
            // 
            this.TB_Edit_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Edit_Btn.Location = new System.Drawing.Point(38, 348);
            this.TB_Edit_Btn.Name = "TB_Edit_Btn";
            this.TB_Edit_Btn.Size = new System.Drawing.Size(268, 32);
            this.TB_Edit_Btn.TabIndex = 8;
            this.TB_Edit_Btn.Text = "Edit";
            this.TB_Edit_Btn.UseVisualStyleBackColor = true;
            this.TB_Edit_Btn.Click += new System.EventHandler(this.TB_Edit_Btn_Click);
            // 
            // TB_MeetingWith
            // 
            this.TB_MeetingWith.FormattingEnabled = true;
            this.TB_MeetingWith.Location = new System.Drawing.Point(18, 221);
            this.TB_MeetingWith.Name = "TB_MeetingWith";
            this.TB_MeetingWith.Size = new System.Drawing.Size(305, 26);
            this.TB_MeetingWith.TabIndex = 13;
            this.TB_MeetingWith.SelectedIndexChanged += new System.EventHandler(this.TB_MeetingWith_SelectedIndexChanged);
            // 
            // Meeting_Aim_Btn
            // 
            this.Meeting_Aim_Btn.Location = new System.Drawing.Point(42, 296);
            this.Meeting_Aim_Btn.Name = "Meeting_Aim_Btn";
            this.Meeting_Aim_Btn.Size = new System.Drawing.Size(264, 40);
            this.Meeting_Aim_Btn.TabIndex = 12;
            this.Meeting_Aim_Btn.Text = "Meeting Aim";
            this.Meeting_Aim_Btn.UseVisualStyleBackColor = true;
            this.Meeting_Aim_Btn.Click += new System.EventHandler(this.Meeting_Aim_Bnt_Click);
            // 
            // TB_MeetingMinutes
            // 
            this.TB_MeetingMinutes.Location = new System.Drawing.Point(189, 139);
            this.TB_MeetingMinutes.Name = "TB_MeetingMinutes";
            this.TB_MeetingMinutes.Size = new System.Drawing.Size(134, 24);
            this.TB_MeetingMinutes.TabIndex = 11;
            // 
            // TB_MeetingHours
            // 
            this.TB_MeetingHours.Location = new System.Drawing.Point(18, 139);
            this.TB_MeetingHours.Name = "TB_MeetingHours";
            this.TB_MeetingHours.Size = new System.Drawing.Size(139, 24);
            this.TB_MeetingHours.TabIndex = 3;
            this.TB_MeetingHours.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // TB_MeetingDate
            // 
            this.TB_MeetingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_MeetingDate.Location = new System.Drawing.Point(18, 62);
            this.TB_MeetingDate.Name = "TB_MeetingDate";
            this.TB_MeetingDate.Size = new System.Drawing.Size(305, 22);
            this.TB_MeetingDate.TabIndex = 3;
            // 
            // Meeting_Aim
            // 
            this.Meeting_Aim.AutoSize = true;
            this.Meeting_Aim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Meeting_Aim.Location = new System.Drawing.Point(15, 269);
            this.Meeting_Aim.Name = "Meeting_Aim";
            this.Meeting_Aim.Size = new System.Drawing.Size(100, 18);
            this.Meeting_Aim.TabIndex = 9;
            this.Meeting_Aim.Text = "Meeting Aim";
            // 
            // Meeting_With
            // 
            this.Meeting_With.AutoSize = true;
            this.Meeting_With.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Meeting_With.Location = new System.Drawing.Point(15, 188);
            this.Meeting_With.Name = "Meeting_With";
            this.Meeting_With.Size = new System.Drawing.Size(106, 18);
            this.Meeting_With.TabIndex = 7;
            this.Meeting_With.Text = "Meeting With";
            // 
            // Meeting_time
            // 
            this.Meeting_time.AutoSize = true;
            this.Meeting_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Meeting_time.Location = new System.Drawing.Point(15, 113);
            this.Meeting_time.Name = "Meeting_time";
            this.Meeting_time.Size = new System.Drawing.Size(45, 18);
            this.Meeting_time.TabIndex = 5;
            this.Meeting_time.Text = "Time";
            // 
            // Meeting_Date
            // 
            this.Meeting_Date.AutoSize = true;
            this.Meeting_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Meeting_Date.Location = new System.Drawing.Point(15, 36);
            this.Meeting_Date.Name = "Meeting_Date";
            this.Meeting_Date.Size = new System.Drawing.Size(43, 18);
            this.Meeting_Date.TabIndex = 1;
            this.Meeting_Date.Text = "Date";
            // 
            // SignIn_Btn
            // 
            this.SignIn_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SignIn_Btn.Location = new System.Drawing.Point(27, 456);
            this.SignIn_Btn.Name = "SignIn_Btn";
            this.SignIn_Btn.Size = new System.Drawing.Size(746, 93);
            this.SignIn_Btn.TabIndex = 3;
            this.SignIn_Btn.Text = "Sign In";
            this.SignIn_Btn.UseVisualStyleBackColor = true;
            this.SignIn_Btn.Click += new System.EventHandler(this.SignIn_Btn_Click);
            // 
            // LB_Visitoron_site
            // 
            this.LB_Visitoron_site.FormattingEnabled = true;
            this.LB_Visitoron_site.ItemHeight = 18;
            this.LB_Visitoron_site.Location = new System.Drawing.Point(6, 23);
            this.LB_Visitoron_site.Name = "LB_Visitoron_site";
            this.LB_Visitoron_site.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_Visitoron_site.Size = new System.Drawing.Size(314, 490);
            this.LB_Visitoron_site.TabIndex = 4;
            this.LB_Visitoron_site.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_StudentDetail_MouseClick);
            this.LB_Visitoron_site.SelectedIndexChanged += new System.EventHandler(this.LB_Visitoron_site_SelectedIndexChanged_1);
            this.LB_Visitoron_site.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LB_Visitoron_site_KeyDown);
            // 
            // GB_Visitoron_site
            // 
            this.GB_Visitoron_site.Controls.Add(this.LB_Visitoron_site);
            this.GB_Visitoron_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.GB_Visitoron_site.Location = new System.Drawing.Point(820, 17);
            this.GB_Visitoron_site.Name = "GB_Visitoron_site";
            this.GB_Visitoron_site.Size = new System.Drawing.Size(338, 532);
            this.GB_Visitoron_site.TabIndex = 5;
            this.GB_Visitoron_site.TabStop = false;
            this.GB_Visitoron_site.Text = "Visitor on-site";
            // 
            // TB_Update_Btn
            // 
            this.TB_Update_Btn.Location = new System.Drawing.Point(69, 413);
            this.TB_Update_Btn.Name = "TB_Update_Btn";
            this.TB_Update_Btn.Size = new System.Drawing.Size(268, 32);
            this.TB_Update_Btn.TabIndex = 6;
            this.TB_Update_Btn.Text = "Update";
            this.TB_Update_Btn.UseVisualStyleBackColor = true;
            this.TB_Update_Btn.Click += new System.EventHandler(this.TB_Update_Btn_Click);
            // 
            // TB_Delete_Btn
            // 
            this.TB_Delete_Btn.Location = new System.Drawing.Point(461, 413);
            this.TB_Delete_Btn.Name = "TB_Delete_Btn";
            this.TB_Delete_Btn.Size = new System.Drawing.Size(268, 32);
            this.TB_Delete_Btn.TabIndex = 7;
            this.TB_Delete_Btn.Text = "Delete";
            this.TB_Delete_Btn.UseVisualStyleBackColor = true;
            this.TB_Delete_Btn.Click += new System.EventHandler(this.TB_Delete_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 584);
            this.Controls.Add(this.TB_Delete_Btn);
            this.Controls.Add(this.TB_Update_Btn);
            this.Controls.Add(this.GB_Visitoron_site);
            this.Controls.Add(this.SignIn_Btn);
            this.Controls.Add(this.Meeting_Details_GB);
            this.Controls.Add(this.Visitor_Details_GB);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Visitor_Details_GB.ResumeLayout(false);
            this.Visitor_Details_GB.PerformLayout();
            this.Meeting_Details_GB.ResumeLayout(false);
            this.Meeting_Details_GB.PerformLayout();
            this.GB_Visitoron_site.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Visitor_Details_GB;
        private System.Windows.Forms.TextBox TB_Visitor_Name;
        private System.Windows.Forms.Label TB_FName;
        private System.Windows.Forms.Label Visitor_Email;
        private System.Windows.Forms.TextBox TB_Mobile;
        private System.Windows.Forms.Label Visitor_Mobilr;
        private System.Windows.Forms.TextBox TB_Visitor_Surname;
        private System.Windows.Forms.Label TB_LName;
        private System.Windows.Forms.GroupBox Meeting_Details_GB;
        private System.Windows.Forms.DateTimePicker TB_MeetingDate;
        private System.Windows.Forms.Label Meeting_Aim;
        private System.Windows.Forms.Label Meeting_With;
        private System.Windows.Forms.Label Meeting_time;
        private System.Windows.Forms.Label Meeting_Date;
        private System.Windows.Forms.DomainUpDown TB_MeetingMinutes;
        private System.Windows.Forms.DomainUpDown TB_MeetingHours;
        private System.Windows.Forms.Button SignIn_Btn;
        private System.Windows.Forms.ListBox LB_Visitoron_site;
        private System.Windows.Forms.GroupBox GB_Visitoron_site;
        public System.Windows.Forms.Button Meeting_Aim_Btn;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox TB_MeetingWith;
        private System.Windows.Forms.Button TB_Update_Btn;
        private System.Windows.Forms.Button TB_Delete_Btn;
        private System.Windows.Forms.Button TB_Insert_Btn;
        private System.Windows.Forms.Button TB_Edit_Btn;
    }
}

