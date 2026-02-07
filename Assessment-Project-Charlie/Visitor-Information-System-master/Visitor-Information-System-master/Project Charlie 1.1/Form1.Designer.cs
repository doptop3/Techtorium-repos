namespace Project_Charlie_1._1
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
            this.components = new System.ComponentModel.Container();
            this.Visitor_Details_GB = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.TB_Visitor_Email = new System.Windows.Forms.TextBox();
            this.Visitor_Email = new System.Windows.Forms.Label();
            this.TB_Visitor_Mobile = new System.Windows.Forms.TextBox();
            this.Visitor_Mobilr = new System.Windows.Forms.Label();
            this.TB_Visitor_Surname = new System.Windows.Forms.TextBox();
            this.Visitor_Surmane = new System.Windows.Forms.Label();
            this.TB_Visitor_Name = new System.Windows.Forms.TextBox();
            this.Visitor_Name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Meeting_Details_GB = new System.Windows.Forms.GroupBox();
            this.Meeting_Aim_Bnt = new System.Windows.Forms.Button();
            this.TB_MeetingMinutes = new System.Windows.Forms.DomainUpDown();
            this.TB_MeetingHours = new System.Windows.Forms.DomainUpDown();
            this.TB_MeetingDate = new System.Windows.Forms.DateTimePicker();
            this.Meeting_Aim = new System.Windows.Forms.Label();
            this.TB_MeetingWith = new System.Windows.Forms.TextBox();
            this.Meeting_With = new System.Windows.Forms.Label();
            this.Meeting_time = new System.Windows.Forms.Label();
            this.Meeting_Date = new System.Windows.Forms.Label();
            this.SignIn_Btn = new System.Windows.Forms.Button();
            this.LB_Visitoron_site = new System.Windows.Forms.ListBox();
            this.GB_Visitoron_site = new System.Windows.Forms.GroupBox();
            this.Visitor_Details_GB.SuspendLayout();
            this.Meeting_Details_GB.SuspendLayout();
            this.GB_Visitoron_site.SuspendLayout();
            this.SuspendLayout();
            // 
            // Visitor_Details_GB
            // 
            this.Visitor_Details_GB.Controls.Add(this.lblError);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Email);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Email);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Mobile);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Mobilr);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Surname);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Surmane);
            this.Visitor_Details_GB.Controls.Add(this.TB_Visitor_Name);
            this.Visitor_Details_GB.Controls.Add(this.Visitor_Name);
            this.Visitor_Details_GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Details_GB.Location = new System.Drawing.Point(27, 17);
            this.Visitor_Details_GB.Name = "Visitor_Details_GB";
            this.Visitor_Details_GB.Size = new System.Drawing.Size(328, 386);
            this.Visitor_Details_GB.TabIndex = 0;
            this.Visitor_Details_GB.TabStop = false;
            this.Visitor_Details_GB.Text = "Visitor Details";
            this.Visitor_Details_GB.Enter += new System.EventHandler(this.Visitor_Details_GB_Enter);
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
            // TB_Visitor_Email
            // 
            this.TB_Visitor_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Visitor_Email.Location = new System.Drawing.Point(18, 304);
            this.TB_Visitor_Email.Name = "TB_Visitor_Email";
            this.TB_Visitor_Email.Size = new System.Drawing.Size(241, 24);
            this.TB_Visitor_Email.TabIndex = 10;
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
            // TB_Visitor_Mobile
            // 
            this.TB_Visitor_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_Visitor_Mobile.Location = new System.Drawing.Point(18, 223);
            this.TB_Visitor_Mobile.MaxLength = 10;
            this.TB_Visitor_Mobile.Name = "TB_Visitor_Mobile";
            this.TB_Visitor_Mobile.Size = new System.Drawing.Size(241, 24);
            this.TB_Visitor_Mobile.TabIndex = 8;
            this.TB_Visitor_Mobile.TextChanged += new System.EventHandler(this.TB_Visitor_Mobile_TextChanged_1);
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
            // 
            // Visitor_Surmane
            // 
            this.Visitor_Surmane.AutoSize = true;
            this.Visitor_Surmane.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Surmane.Location = new System.Drawing.Point(15, 113);
            this.Visitor_Surmane.Name = "Visitor_Surmane";
            this.Visitor_Surmane.Size = new System.Drawing.Size(75, 18);
            this.Visitor_Surmane.TabIndex = 5;
            this.Visitor_Surmane.Text = "Surmane";
            this.Visitor_Surmane.Click += new System.EventHandler(this.label1_Click);
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
            // Visitor_Name
            // 
            this.Visitor_Name.AutoSize = true;
            this.Visitor_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Visitor_Name.Location = new System.Drawing.Point(15, 36);
            this.Visitor_Name.Name = "Visitor_Name";
            this.Visitor_Name.Size = new System.Drawing.Size(52, 18);
            this.Visitor_Name.TabIndex = 1;
            this.Visitor_Name.Text = "Name";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // Meeting_Details_GB
            // 
            this.Meeting_Details_GB.Controls.Add(this.Meeting_Aim_Bnt);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingMinutes);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingHours);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingDate);
            this.Meeting_Details_GB.Controls.Add(this.Meeting_Aim);
            this.Meeting_Details_GB.Controls.Add(this.TB_MeetingWith);
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
            // Meeting_Aim_Bnt
            // 
            this.Meeting_Aim_Bnt.Location = new System.Drawing.Point(18, 304);
            this.Meeting_Aim_Bnt.Name = "Meeting_Aim_Bnt";
            this.Meeting_Aim_Bnt.Size = new System.Drawing.Size(241, 40);
            this.Meeting_Aim_Bnt.TabIndex = 12;
            this.Meeting_Aim_Bnt.Text = "Meeting Aim";
            this.Meeting_Aim_Bnt.UseVisualStyleBackColor = true;
            this.Meeting_Aim_Bnt.Click += new System.EventHandler(this.Meeting_Aim_Bnt_Click);
            // 
            // TB_MeetingMinutes
            // 
            this.TB_MeetingMinutes.Location = new System.Drawing.Point(163, 139);
            this.TB_MeetingMinutes.Name = "TB_MeetingMinutes";
            this.TB_MeetingMinutes.Size = new System.Drawing.Size(120, 24);
            this.TB_MeetingMinutes.TabIndex = 11;
            // 
            // TB_MeetingHours
            // 
            this.TB_MeetingHours.Location = new System.Drawing.Point(13, 139);
            this.TB_MeetingHours.Name = "TB_MeetingHours";
            this.TB_MeetingHours.Size = new System.Drawing.Size(120, 24);
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
            // TB_MeetingWith
            // 
            this.TB_MeetingWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.TB_MeetingWith.Location = new System.Drawing.Point(18, 223);
            this.TB_MeetingWith.Name = "TB_MeetingWith";
            this.TB_MeetingWith.Size = new System.Drawing.Size(241, 24);
            this.TB_MeetingWith.TabIndex = 8;
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
            this.SignIn_Btn.Location = new System.Drawing.Point(27, 447);
            this.SignIn_Btn.Name = "SignIn_Btn";
            this.SignIn_Btn.Size = new System.Drawing.Size(746, 102);
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
            this.LB_Visitoron_site.SelectedIndexChanged += new System.EventHandler(this.LB_Visitoron_site_SelectedIndexChanged);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 584);
            this.Controls.Add(this.GB_Visitoron_site);
            this.Controls.Add(this.SignIn_Btn);
            this.Controls.Add(this.Meeting_Details_GB);
            this.Controls.Add(this.Visitor_Details_GB);
            this.Name = "Form1";
            this.Text = "Visitor Registration";
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
        private System.Windows.Forms.Label Visitor_Name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label Visitor_Email;
        private System.Windows.Forms.TextBox TB_Visitor_Mobile;
        private System.Windows.Forms.Label Visitor_Mobilr;
        private System.Windows.Forms.TextBox TB_Visitor_Surname;
        private System.Windows.Forms.Label Visitor_Surmane;
        private System.Windows.Forms.GroupBox Meeting_Details_GB;
        private System.Windows.Forms.DateTimePicker TB_MeetingDate;
        private System.Windows.Forms.Label Meeting_Aim;
        private System.Windows.Forms.TextBox TB_MeetingWith;
        private System.Windows.Forms.Label Meeting_With;
        private System.Windows.Forms.Label Meeting_time;
        private System.Windows.Forms.Label Meeting_Date;
        private System.Windows.Forms.DomainUpDown TB_MeetingMinutes;
        private System.Windows.Forms.DomainUpDown TB_MeetingHours;
        private System.Windows.Forms.Button SignIn_Btn;
        private System.Windows.Forms.ListBox LB_Visitoron_site;
        private System.Windows.Forms.GroupBox GB_Visitoron_site;
        public System.Windows.Forms.Button Meeting_Aim_Bnt;
        private System.Windows.Forms.TextBox TB_Visitor_Email;
        private System.Windows.Forms.Label lblError;
    }
}

