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


namespace DMSWeek4
{
    public partial class Form1 : Form
    {
        public static Form1 Self;

        public Form1()
        {
            InitializeComponent();
            Self = this;
        }

        public string connectionString = @"Data Source=LAPTOP-6MSI1143\SQLEXPRESS;Initial Catalog=VisitorInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-6MSI1143\\SQLEXPRESS;Initial Catalog=VisitorInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand command = new SqlCommand();
        SqlDataReader reader;
        String SqlStmt;
        int PK = 0; 
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            staff_load();

            string sql_query = "select Visitor.Visitor_ID, Visitor.VFirstName, Visitor.VLastName, Visitor.VisitorMobileNumber, Visitor.VisitorEmail, Visitor.VisitorDate, Visitor.VisitorTime, Visitor.MeetingAim, Staff.MeetingWith from Visitor, Staff where Staff.Staff_ID = Visitor.Staff_ID";

            SqlCommand cmd = new SqlCommand(sql_query, con);
            cmd.Parameters.Clear();

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LB_Visitoron_site.Items.Add((reader["VFirstName"] + " " + reader["VLastName"] +
                    " " + reader["VisitorMobileNumber"] + " " + reader["VisitorEmail"] + " " + reader["VisitorDate"] +
                    " " + reader["VisitorTime"] + " " + reader["MeetingAim"] + " " + reader["Visitor.MeetingWith"] +
                    " ( " + reader["Staff.MeetingWith"] + " ) "));
            }
            reader.Close();
            con.Close();
        }

        private void staff_load()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            string sql_Query2 = "Select FirstName From Staff";

            SqlCommand cmd2 = new SqlCommand(sql_Query2, conn);

            conn.Open();

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                TB_MeetingWith.Items.Add(reader["FirstName"]);
            }

            reader.Close();

            conn.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void TB_MeetingWith_TextChanged(object sender, EventArgs e)
        {

        }
        private void TB_MeetingAim_Click(object sender, EventArgs e)
        {

        }
        private void Meeting_Aim_Bnt_Click(object sender, EventArgs e)
        {
            Form2 aim = new Form2();
            aim.Show();
        }
        public bool AddVisitor(int ID, string FirstName, String LastName, String Mobile, String Email, DateTime Date, String MeetingAim, String MeetingWith)
        {
            bool res = false;

            String sqlStmt = "Insert into Visitor (Visitor_ID, VFirstName, VLastName, VisitorMobileNumber, VisitorEmail, VisitorDate, MeetingAim) values " +
                "(@Visitor_ID,@VFName, @VLName, @VMobile, @VEmail, @VDate, @VMeetingAim)";

            using (command = new SqlCommand(sqlStmt, con))
            {
                command.Parameters.AddWithValue("@Visitor_ID", ID);
                command.Parameters.AddWithValue("@VFName", FirstName);
                command.Parameters.AddWithValue("@VLName", LastName);
                command.Parameters.AddWithValue("@VMobile", Mobile);
                command.Parameters.AddWithValue("@VEmail", Email);
                command.Parameters.AddWithValue("@VDate", Date);
                command.Parameters.AddWithValue("@VMeetingAim", MeetingAim);


                con.Open();
                int rowsadded = command.ExecuteNonQuery();
                if (rowsadded > 0)
                {
                    res = true;
                    MessageBox.Show("Record Added Successfully !!!!!");
                }
                con.Close();

            }
            return res;
        }
        public void Load_ListBox()
        {
            String sqlStmt = "select * from Visitor";
            con.Open();
            command = new SqlCommand(sqlStmt, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                LB_Visitoron_site.Items.Add(reader["Visitor_ID"] + " " + reader["VFirstName"] + " " + reader["VLastName"] + " " + reader["VisitorMobileNumber"]);
            }
            con.Close();

        }

        public void Load_Data(int ID)
        {
            String SqlStmt = "Select * from Visitor where Visitor_ID = " + ID;
            using (command = new SqlCommand(SqlStmt, con))
            {
                con.Open();
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TB_FName.Text = reader["VFirstName"].ToString();
                        TB_LName.Text = reader["VLastName"].ToString();
                        TB_Mobile.Text = reader["VisitorMobileNumber"].ToString();
                    }

                }
                con.Close();
            }
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            Random rnd_num = new Random();
            int ID = rnd_num.Next(1, 10000);
            string FirstName = TB_FName.Text;
            string LastName = TB_LName.Text;
            string Mobile = TB_Mobile.Text;
            string Email = TB_Email.Text;
            DateTime date = TB_MeetingDate.Value.Date;
            string MeetingAim = Meeting_Aim_Btn.Text;
            string MeetingWith = ((string)TB_MeetingWith.SelectedItem).ToString();



            bool res = AddVisitor(ID, FirstName, LastName, Mobile, Email, date, MeetingAim, MeetingWith);
            Load_ListBox();
            //if(res)
            //{
            // Clear_Fields();
            //Load_ListBox();
            //}

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
            else if (TB_Mobile.Text == "")
            {
                TB_Mobile.Focus();
                MessageBox.Show("Mobile is mandatory");
            }
            else if (!Regex.IsMatch(TB_Mobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show("Please enter valid mobile number");
            }
            else if (TB_Email.Text == "")
            {
                TB_Email.Focus();
                MessageBox.Show("Email is mandatory");
            }
            else if (!Regex.IsMatch(TB_Email.Text, @"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$"))
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
                LB_Visitoron_site.Items.Add("Visitor Name: " + TB_Visitor_Name.Text);
                LB_Visitoron_site.Items.Add("Visitor Surname: " + TB_Visitor_Surname.Text);
                LB_Visitoron_site.Items.Add("Visitor Email: " + TB_Email.Text);
                LB_Visitoron_site.Items.Add("Visitor Mobile: " + TB_Mobile.Text);
                LB_Visitoron_site.Items.Add("Meeting With: " + TB_MeetingWith.Text);
                LB_Visitoron_site.Items.Add("Meeting Hour: " + TB_MeetingHours.Text);
                LB_Visitoron_site.Items.Add("Meeting Minute: " + TB_MeetingMinutes.Text);
                LB_Visitoron_site.Items.Add("Meeting Aim: " + Meeting_Aim_Btn.Text);
                //clearForm();
                LB_Visitoron_site.Items.Add("----------Information Added------------");
                string myString = "Hello World!";
                byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(myString);
                LB_Visitoron_site.Items.Add(asciiBytes);
            }

        }
        private void Clear_Fields()
        {
            TB_Visitor_Name.Text = "";
            TB_Visitor_Surname.Text = "";
            TB_Email.Text = "";
            TB_Mobile.Text = "";
            TB_MeetingWith.Text = "";
            TB_MeetingHours.Text = "";
            TB_MeetingMinutes.Text = "";
            Meeting_Aim_Btn.Text = "";
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

        private void TB_MeetingWith_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlStmt = "SELECT MeetingWith FROM Staff;";
            command = new SqlCommand(SqlStmt, con);

            //Open Connection to DB
            con.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                TB_MeetingWith.Items.Add(reader[0].ToString());
            }
        }

        private void LB_Visitoron_site_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LB_Visitoron_site_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                while (LB_Visitoron_site.SelectedItems.Count > 0)
                {
                    LB_Visitoron_site.Items.Remove(LB_Visitoron_site.SelectedItems[0]);
                }

            }
        }

        private void TB_Update_Btn_Click(object sender, EventArgs e)
        {

        }

        private void TB_Delete_Btn_Click(object sender, EventArgs e)
        {
            {
                string SqlStmt = "Delete From Visitor where Visitor_ID = " + PK;
                using (command = new SqlCommand(SqlStmt, con))
                {
                    DialogResult dialog = MessageBox.Show("Are you Sure !!!!!", "Delete", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                        Clear_Fields();
                        Load_ListBox();
                    }
                }
            }
        }

        private void LB_StudentDetail_MouseClick(object sender, MouseEventArgs e)
        {
            var selectedRecord = LB_Visitoron_site.SelectedItem;
            string fetchedData = LB_Visitoron_site.SelectedItem.ToString();
            string[] words = fetchedData.Split(' ');
            PK = Int16.Parse(words[0]);
            Load_Data(PK);
        }

        private void TB_Insert_Btn_Click(object sender, EventArgs e)
        {

        }

        private void TB_Edit_Btn_Click(object sender, EventArgs e)
        {

        }

        private void LB_Visitoron_site_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TB_Visitor_Surname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

