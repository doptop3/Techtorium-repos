using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie_1._1
{
    public partial class Meeting_Aim : Form
    {
        public Meeting_Aim()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            if (RB_Meeting.Checked)
            {
                Form1.Self.Meeting_Aim_Bnt.Text= RB_Meeting.Text;
            }
           else if (RB_SalesAppointment.Checked)
            {
                Form1.Self.Meeting_Aim_Bnt.Text = RB_SalesAppointment.Text;
            }
            else if (RB_SiteVisit.Checked)
            {
                Form1.Self.Meeting_Aim_Bnt.Text = RB_SiteVisit.Text;
            }
            else if (RB_StudentInterview.Checked)
            {
                Form1.Self.Meeting_Aim_Bnt.Text = RB_StudentInterview.Text;
            }
            this.Close();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Meeting_Aim_Load(object sender, EventArgs e)
        {

        }
    }
}
