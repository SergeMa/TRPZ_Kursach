using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;



namespace TRPZ_Cursach_WinForm
{
    public partial class CreateProjectsForm : Form
    {
        int ScientistId;
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
        ScientistForm MainForm;

        public CreateProjectsForm(int CurrentScientistId, ScientistForm MainForm)
        {
            InitializeComponent();
            ScientistId = CurrentScientistId;
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);

            GetElementsFromMentors(db);
            GetElementsFromDevStage(db);
            GetElementsFromDevSphere(db);
            SetScientistValues(db);
            SetProjectID(db);
        }

        public CreateProjectsForm(int CurrentScientistId, int ProjectId, ScientistForm MainForm)
        {
            InitializeComponent();
            ScientistId = CurrentScientistId;
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);

            CreateProject_Button.Text = "Update project";
            GetElementsFromMentors(db);
            GetElementsFromDevStage(db);
            GetElementsFromDevSphere(db);
            SetScientistValues(db);
            SetProjectID(db);
            FillElements(ProjectId, db);
        }

        void FillElements(int ProjectId, DataContext db)
        {
            ID_Label.Text = ProjectId.ToString();
            var projectInfo = db.GetTable<Project>().SingleOrDefault(p => p.Project_ID == ProjectId);
            textBox1.Text = projectInfo.Project_Name;
            textBox2.Text = projectInfo.Project_Description;
            Sphere_comboBox.SelectedIndex = projectInfo.Sphere_Id - 1;
            Stage_comboBox.SelectedIndex = projectInfo.Stage_Id - 1;
            Mentor mentor = db.GetTable<Mentor>().SingleOrDefault(m => m.Mentor_ID == db.GetTable<Project>().SingleOrDefault(p => p.Project_ID == ProjectId).Mentor_Id);
            Mentor_comboBox.SelectedItem = mentor.Mentor_Name + " " + mentor.Mentor_Surname;
        }

        public void GetElementsFromMentors(DataContext db)
        {
            var GetElementsFromMentors = from b in db.GetTable<Mentor>()
                                         where db.GetTable<Scientist>().Any(s => s.Scientist_ID == ScientistId && s.Institution_ID == b.Institution_ID)
                                         select b;
            foreach (var b in GetElementsFromMentors)
            {
                Mentor_comboBox.Items.Add(b.Mentor_Name + " " + b.Mentor_Surname);
            }
        }

        public void GetElementsFromDevStage(DataContext db)
        {
            var GetElementsFromDevStage = from b in db.GetTable<Development_Stage>()
                                          select b;
            foreach (var b in GetElementsFromDevStage)
            {
                Stage_comboBox.Items.Add(b.Stage_Name);
            }
        }

        public void GetElementsFromDevSphere(DataContext db)
        {
            var GetElementsFromDevStage = from b in db.GetTable<Project_Sphere>()
                                          select b;
            foreach (var b in GetElementsFromDevStage)
            {
                Sphere_comboBox.Items.Add(b.Sphere_Name);
            }
        }

        public void SetScientistValues(DataContext db)
        {
            var SetScientistValues = from b in db.GetTable<Scientist>()
                                     join i in db.GetTable<Institution>() on b.Institution_ID equals i.Institution_ID
                                     where b.Scientist_ID == ScientistId
                                     select new
                                     {
                                         Scientist = b.Scientist_Name + " " + b.Scientist_Surname,
                                         Institution = i.Institution_Name
                                     };
            foreach (var item in SetScientistValues)
            {
                Scientist.Text = item.Scientist;
                Institution.Text = item.Institution;
            }
        }

        public void SetProjectID(DataContext db)
        {
            var maxProjectId = db.GetTable<Project>().Max(p => p.Project_ID) + 1;
            ID_Label.Text = maxProjectId.ToString();
        }

        private void CreateProject_Button_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionString);
            var InstitutionId = (from b in db.GetTable<Scientist>()
                                 where b.Scientist_ID == ScientistId
                                 select b.Institution_ID).FirstOrDefault();

            if (textBox1.Text == "" || textBox2.Text == "" || Sphere_comboBox.SelectedIndex < 0 || Stage_comboBox.SelectedIndex < 0 || Mentor_comboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Some fields are left null", "Something was not chosen for the project", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                String[] MentorInfo = Mentor_comboBox.SelectedItem.ToString().Split(" ");
                var mentorId = (from mentor in db.GetTable<Mentor>()
                                where mentor.Mentor_Name == MentorInfo[0] && mentor.Mentor_Surname == MentorInfo[1]
                                select mentor.Mentor_ID).FirstOrDefault();
                using (SqlConnection _con = new SqlConnection(connectionString))
                {
                    if (this.Text == "Create project")
                    {
                        string InsertSQL = $"INSERT INTO Project(Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)" +
                            $"VALUES({ID_Label.Text}, '{textBox1.Text}', '{textBox2.Text}', {Sphere_comboBox.SelectedIndex + 1}, {Stage_comboBox.SelectedIndex + 1}," +
                            $" {ScientistId}, {mentorId}, {InstitutionId})";
                        using (SqlCommand Insert = new SqlCommand(InsertSQL, _con))
                        {
                            _con.Open();
                            Insert.ExecuteNonQuery();
                            _con.Close();
                        }
                    }
                    else
                    {

                        string UpdateSQL = $"update Project set Project_Name = '{textBox1.Text}', Project_Description = '{textBox2.Text}', " +
                            $"Sphere_Id = {Sphere_comboBox.SelectedIndex + 1}, Stage_Id = {Stage_comboBox.SelectedIndex + 1}, Mentor_ID = {mentorId} where Project_ID = {ID_Label.Text}";
                        using (SqlCommand Insert = new SqlCommand(UpdateSQL, _con))
                        {
                            _con.Open();
                            Insert.ExecuteNonQuery();
                            _con.Close();
                        }
                        MainForm.Fill_ChangeLog_And_Media_tables();
                    }
                    MainForm.GetProjectTableForScientist();
                }
                this.Close();
            }

        }
    }
}


