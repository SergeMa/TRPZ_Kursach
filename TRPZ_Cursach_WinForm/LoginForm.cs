using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.VisualBasic.Logging;

namespace TRPZ_Cursach_WinForm
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string Login = Login_TextBox.Text;
            string Password = Password_TextBox.Text;
            if (Login == "" || Password == "")
            {
                MessageBox.Show("Empty login or password", "Log in denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
                DataContext db = new DataContext(connectionString);
                var GetUserRole = (from Users_Roles in db.GetTable<Users_Roles>()
                                   where Users_Roles.UserName == Login && Users_Roles.UserPassword == Password
                                   select Users_Roles.UserRole).FirstOrDefault();
                string[] Inputs = Login.Split("_");
                switch (GetUserRole)
                {
                    case "Scientist":

                        var GetScientist = (from Scientist in db.GetTable<Scientist>()
                                            where Scientist.Scientist_Name == Inputs[0] && Scientist.Scientist_Surname == Inputs[1]
                                            select Scientist.Scientist_ID).FirstOrDefault();
                        this.Visible = false;
                        ScientistForm sf = new ScientistForm(GetScientist);
                        sf.Show();
                        break;
                    case "Mentor":
                        var GetMentor = (from m in db.GetTable<Mentor>()
                                         where m.Mentor_Name == Inputs[0] && m.Mentor_Surname == Inputs[1]
                                         select m.Mentor_ID).FirstOrDefault();
                        this.Visible = false;
                        MentorForm mf = new MentorForm(GetMentor);
                        mf.Show();
                        break;
                    case "Admin":
                        var GetAdmin = (from m in db.GetTable<Institution>()
                                        where m.Institution_Name == Login
                                        select m.Institution_ID).FirstOrDefault();
                        this.Visible = false;
                        AdminForm af = new AdminForm(GetAdmin);
                        af.Show();
                        break;
                    default:
                        MessageBox.Show("Wrong login or password", "Log in denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VisitorForm vf = new VisitorForm(this);
            vf.Show();
        }
    }
}