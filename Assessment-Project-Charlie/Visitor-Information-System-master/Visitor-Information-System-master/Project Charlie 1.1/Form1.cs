using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Project_Charlie_1._1
{
    public partial class Form1 : Form
    {
        //string connString = @"Data Source=NSK-NOTE06\SQLEXPRESS;
        //                //Integrated Security = True; 
        //                //Connect Timeout = 30; 
        //                //Encrypt=False;
        //                //TrustServerCertificate=False;
        //                //ApplicationIntent=ReadWrite;
                        //MultiSubnetFailover=False";

       
        public static Form1 Self;
        Meeting_Aim aim = new Meeting_Aim();
        public Form1()
    {
        InitializeComponent();
        Self = this;
    }
        //private void Form1_Load(object sender, EventArgs e)

        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    string sql_Query = "select Visitor.Visitor_ID,
        //        Visitor.VisitorName,
        //        Visitor.SurName,
        //        Visitor.Mobile,
        //        Visitor.Email,
        //        Visitor.MeetingDate,
        //        Visitor.MeetingTime,
        //        Visitor.MeetingAim,
        //        Staff.Meeting_With
        //        From Visitor, Staff
        //        Where Staff.Staff_ID = Visitor.Staff_ID";

        //        SqlCommand cmd = new SqlCommand(sql_Query, conn);
        //    cmd.Parameters.Clear();

        //    conn.Open();
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        LB_Visitoron_site.Items.Add((reader["VisitorName"] + " " + reader["SurName"] +
        //            " " + reader["Mobile"] + " " + reader["Email"] + " " + reader["MeetingDate"] +
        //            " " + reader["MeetingTime"] + " " + reader["MeetingAim"] + " " + reader["Meeting_With"] +
        //            " ( " + reader["Staff.Meeting_With"] + ")"));
        //    }
        //    reader.Close();
        //    conn.Close();
        //}
        //}




        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void TB_MeetingWtih_TextChanged(object sender, EventArgs e)
        {

        }
        private void TB_MeetingAim_Click(object sender, EventArgs e)
        {

        }
        private void Meeting_Aim_Bnt_Click(object sender, EventArgs e)
        {
            Meeting_Aim aim = new Meeting_Aim();
            aim.Show();
        }
        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            
            if (TB_Visitor_Name.Text == "")
            {
                TB_Visitor_Name.Focus();
                MessageBox.Show("Name is mandatory");
            }
            else if (TB_Visitor_Surname.Text == "")
            {
                TB_Visitor_Surname.Focus();
                MessageBox.Show("Surname is mandatory");
            }
            else if (TB_Visitor_Mobile.Text == "")
            {
                TB_Visitor_Mobile.Focus();
                MessageBox.Show("Mobile is mandatory");
            }
            else if (!Regex.IsMatch(TB_Visitor_Mobile.Text, @"^[0-9]{10}$"))
               { 
                MessageBox.Show("Please enter valid mobile number");
                }
            else if (TB_Visitor_Email.Text == "")
            {
                TB_Visitor_Email.Focus();
                MessageBox.Show("Email is mandatory");
            }
            else if (!Regex.IsMatch(TB_Visitor_Email.Text, @"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$"))
            {
                lblError.ForeColor = Color.Blue;
                lblError.Text = "Email is Invalid.";
            }
            else if (TB_MeetingWith.Text == "")
            {
                TB_MeetingWith.Focus();
                MessageBox.Show("Meeting With is mandatory");
            }
            else if (TB_MeetingHours.Text == "")
            {
                TB_MeetingHours.Focus();
                MessageBox.Show("Hour is mandatory");
            }
            else if (TB_MeetingMinutes.Text == "")
            {
                TB_MeetingMinutes.Focus();
                MessageBox.Show("Minutes is mandatory");
            }
            else
            {
                //LB_Visitoron_site.Items.Add("Visitor Name: " + TB_Visitor_Name.Text);
                //LB_Visitoron_site.Items.Add("Visitor Surname: " + TB_Visitor_Surname.Text);
                //LB_Visitoron_site.Items.Add("Visitor Email: " + TB_Visitor_Email.Text);
                //LB_Visitoron_site.Items.Add("Visitor Mobile: " + TB_Visitor_Mobile.Text);
                //LB_Visitoron_site.Items.Add("Meeting With: " + TB_MeetingWith.Text);
                //LB_Visitoron_site.Items.Add("Meeting Hour: " + TB_MeetingHours.Text);
                //LB_Visitoron_site.Items.Add("Meeting Minute: " + TB_MeetingMinutes.Text);
                //LB_Visitoron_site.Items.Add("Meeting Aim: " + Meeting_Aim_Bnt.Text);
                //clearForm();
                //LB_Visitoron_site.Items.Add("----------Information Added------------");
                string myString = "Hello World!";
                byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(myString);
                LB_Visitoron_site.Items.Add(asciiBytes);
            }
           
        }
        private void clearForm()
        {
            TB_Visitor_Name.Text = "";
            TB_Visitor_Surname.Text = "";
            TB_Visitor_Email.Text = "";
            TB_Visitor_Mobile.Text = "";
            TB_MeetingWith.Text = "";
            TB_MeetingHours.Text = "";
            TB_MeetingMinutes.Text = "";
            Meeting_Aim_Bnt.Text = "Meeting Aim";
        }
        
        
        private void Visitor_Email_Click(object sender, EventArgs e)
        {

        }

        private void TB_Visitor_Mobile_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TB_Visitor_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void LB_Visitoron_site_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Visitor_Details_GB_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LB_Visitoron_site_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                while (LB_Visitoron_site.SelectedItems.Count > 0)
                {
                    LB_Visitoron_site.Items.Remove(LB_Visitoron_site.SelectedItems[0]);
                }
                
            }
        }
    }
 }
