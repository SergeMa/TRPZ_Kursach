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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRPZ_Cursach_WinForm
{
    public partial class ScientistForm : Form
    {
        public int ScientistID;
        public int CurrentActiveProject = 0;
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";

        public DataSet ds = new DataSet();


        public ScientistForm(int scientistID)
        {
            ScientistID = scientistID;
            InitializeComponent();
            GetProjectTableForScientist();

            DataGridViewButtonColumn ProjectButtonColumn = new DataGridViewButtonColumn();
            ProjectButtonColumn.HeaderText = "Set active project";
            ProjectButtonColumn.Text = "Set active";
            ProjectButtonColumn.UseColumnTextForButtonValue = true;
            Project_DataGridView.Columns.Insert(Project_DataGridView.ColumnCount, ProjectButtonColumn);
            Project_DataGridView.CellContentClick += (sender, e) => Project_DataGridView_CellContentClick(sender!, e);
            Project_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Project_DataGridView.AllowUserToAddRows = false;

            FillAccountInfo();
        }

        public void FillAccountInfo()
        {
            DataContext db = new DataContext(connectionString);
            var ScientistInfo = (from b in db.GetTable<Scientist>()
                                 join i in db.GetTable<Institution>() on b.Institution_ID equals i.Institution_ID
                                 where b.Scientist_ID == ScientistID
                                 select new
                                 {
                                     Name = b.Scientist_Name,
                                     Surname = b.Scientist_Surname,
                                     Institution = i.Institution_Name
                                 }).FirstOrDefault();
            Name_Label.Text = ScientistInfo.Name;
            Surname_Label.Text = ScientistInfo.Surname;
            Institution_Label.Text = ScientistInfo.Institution;
        }

        public void GetProjectTableForScientist()
        {
            string GetProjectTableString = $"SELECT * FROM Visitor_Info where Scientist = (select concat(Scientist_Name, ' ', Scientist_Surname) from Scientist where Scientist_Id = {ScientistID})";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetProjectTableString, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Project_DataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void Project_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int projectId = Convert.ToInt32(Project_DataGridView.Rows[e.RowIndex].Cells["Project ID"].Value);
            CurrentActiveProject = projectId;
            this.Text = "Working with project " + projectId;
            Fill_ChangeLog_And_Media_tables();
        }

        public void Fill_ChangeLog_And_Media_tables()
        {
            if (CurrentActiveProject > 0)
            {
                string GetChangeLogView = $"SELECT * FROM Change_Log_Info where [Project ID] = {CurrentActiveProject}";
                string GetMediaView = $"SELECT * FROM Media_Info where [Project ID] = {CurrentActiveProject}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(GetChangeLogView, connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    Change_Log_DataGridView.DataSource = dataSet.Tables[0];
                    Change_Log_DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    Change_Log_DataGridView.AllowUserToAddRows = false;

                    adapter = new SqlDataAdapter(GetMediaView, connection);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    Media_dataGridView.DataSource = dataSet.Tables[0];
                    Media_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    Media_dataGridView.AllowUserToAddRows = false;
                }
            }
        }

        private void CreateProject_Button_Click(object sender, EventArgs e)
        {
            CreateProjectsForm cp = new CreateProjectsForm(ScientistID, this);
            cp.ShowDialog();
        }

        private void Sign_Out_Button_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Visible = true;
            this.Close();
        }

        private void EditProject_Button_Click(object sender, EventArgs e)
        {
            if (CurrentActiveProject != 0)
            {
                CreateProjectsForm cp = new CreateProjectsForm(ScientistID, CurrentActiveProject, this);
                cp.Text = "Updating project " + CurrentActiveProject;
                cp.ShowDialog();
            }
            else
            {
                MessageBox.Show("No project selected", "Press 'Set active' in the Project tab", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CurrentActiveProject != 0)
            {
                AddMediaReview ad = new AddMediaReview(this, CurrentActiveProject);
                ad.FormClosed += (sender, e) => Ad_FormClosed(sender, e);
                ad.ShowDialog();
            }
            else
            {
                MessageBox.Show("Press 'Set active' in the Project tab", "No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Ad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fill_ChangeLog_And_Media_tables();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (CurrentActiveProject != 0)
            {
                foreach (DataGridViewRow row in Media_dataGridView.SelectedRows)
                {
                    if (int.TryParse(row.Cells["Review ID"].Value.ToString(), out int reviewId))
                    {
                        string deleteQuery = $"DELETE FROM Media_Reviews WHERE Review_ID = {reviewId}";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                        Fill_ChangeLog_And_Media_tables();
                    }
                    else
                    {
                        MessageBox.Show("Select reviews you want to delete", "No reviews selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Press 'Set active' in the Project tab", "No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (CurrentActiveProject != 0)
            {
                if (Media_dataGridView.SelectedRows.Count == 1)
                {
                    AddMediaReview ad = new AddMediaReview(this, CurrentActiveProject, int.Parse(Media_dataGridView.SelectedRows[0].Cells["Review ID"].Value.ToString()));
                    ad.Text = "Editing media review";
                    ad.FormClosed += (sender, e) => Ad_FormClosed(sender, e);
                    ad.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You can edit only one review at a time", "Wrong number of reviews chosen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Press 'Set active' in the Project tab", "No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionString);
            var LoginInfo = (from b in db.GetTable<Scientist>()
                             where b.Scientist_ID == ScientistID
                             select new
                             {
                                 Name = b.Scientist_Name,
                                 Surname = b.Scientist_Surname,
                             }).FirstOrDefault();
            if (Password_TextBox.Text.ToCharArray().Length >= 8)
            {
                try
                {
                    string UpdateSQL = $"update Users_Roles set UserPassword = '{Password_TextBox.Text}' where UserName = '{LoginInfo.Name + "_" + LoginInfo.Surname}'";
                    SqlConnection _con = new SqlConnection(connectionString);
                    using (SqlCommand Insert = new SqlCommand(UpdateSQL, _con))
                    {
                        _con.Open();
                        Insert.ExecuteNonQuery();
                        _con.Close();
                    }
                    MessageBox.Show($"Password to your account was changed successfully", "Password change successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to change password.\n Error: {ex.Message}", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password should contain more than 8 symbols", "Wrong password input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProject_Button_Click(object sender, EventArgs e)
        {
            if (CurrentActiveProject == 0)
            {
                MessageBox.Show("Press 'Set active' in the Project tab", "No project selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataContext db = new DataContext(connectionString);
                var ChangeInfo = from b in db.GetTable<Change_Log>()
                                 where b.Project_ID == CurrentActiveProject
                                 select b;

                foreach (var item in ChangeInfo)
                {
                    string deleteFromInspectionResult = $"DELETE FROM Inspection_Result WHERE Change_Log_Id = {item.Change_Log_ID}";
                    string deleteFromChangeLog = $"DELETE FROM Change_Log WHERE Change_Log_Id = {item.Change_Log_ID}";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(deleteFromInspectionResult, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(deleteFromChangeLog, connection))
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                string deleteQuery = $"DELETE FROM Media_Reviews WHERE Project_ID = {CurrentActiveProject}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                string deleteProj = $"DELETE FROM Project WHERE Project_ID = {CurrentActiveProject}";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(deleteProj, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                CurrentActiveProject = 0;
                this.Text = "Select a project";
                GetProjectTableForScientist();
                Fill_ChangeLog_And_Media_tables();
            }
        }
    }
}