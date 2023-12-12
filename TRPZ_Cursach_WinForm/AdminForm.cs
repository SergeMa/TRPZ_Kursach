using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace TRPZ_Cursach_WinForm
{
    public partial class AdminForm : Form
    {
        int InstitutionID;
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(int AdminID)
        {
            InstitutionID = AdminID;
            InitializeComponent();


            DataGridViewButtonColumn ProjectButtonColumn = new DataGridViewButtonColumn();
            ProjectButtonColumn.HeaderText = "Show login and password";
            ProjectButtonColumn.Text = "Show";
            ProjectButtonColumn.UseColumnTextForButtonValue = true;
            Scientist_dataGridView.Columns.Insert(Scientist_dataGridView.ColumnCount, ProjectButtonColumn);
            Scientist_dataGridView.CellContentClick += (sender, e) => Scientist_DataGridView_CellContentClick(sender!, e);
            Scientist_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Scientist_dataGridView.AllowUserToAddRows = false;


            DataGridViewButtonColumn MentorButtonColumn = new DataGridViewButtonColumn();
            MentorButtonColumn.HeaderText = "Show login and password";
            MentorButtonColumn.Text = "Show";
            MentorButtonColumn.UseColumnTextForButtonValue = true;
            Mentor_dataGridView.Columns.Insert(Mentor_dataGridView.ColumnCount, MentorButtonColumn);
            Mentor_dataGridView.CellContentClick += (sender, e) => Mentor_DataGridView_CellContentClick(sender!, e);
            Mentor_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mentor_dataGridView.AllowUserToAddRows = false;
            GetProjectTableForAdmin();
            FillAccountInfo();
        }

        private void Scientist_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataContext db = new DataContext(connectionString);
                string Name = Scientist_dataGridView.Rows[e.RowIndex].Cells["Scientist_Name"].Value.ToString();
                string Surname = Scientist_dataGridView.Rows[e.RowIndex].Cells["Scientist_Surname"].Value.ToString();
                string Login = $"{Name}_{Surname}";

                var LoginInfo = (from b in db.GetTable<Users_Roles>()
                                 where b.UserName == Login
                                 select b).FirstOrDefault();
                MessageBox.Show($"Login: {LoginInfo.UserName};\nPassword: {LoginInfo.UserPassword}", "Login info for user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Mentor_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                DataContext db = new DataContext(connectionString);
                string Name = Mentor_dataGridView.Rows[e.RowIndex].Cells["Mentor_Name"].Value.ToString();
                string Surname = Mentor_dataGridView.Rows[e.RowIndex].Cells["Mentor_Surname"].Value.ToString();
                string Login = $"{Name}_{Surname}";
                var LoginInfo = (from b in db.GetTable<Users_Roles>()
                                 where b.UserName == Login
                                 select b).FirstOrDefault();
                MessageBox.Show($"Login: {LoginInfo.UserName};\nPassword: {LoginInfo.UserPassword}", "Login info for user", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetProjectTableForAdmin()
        {
            string GetScientists = $"SELECT * FROM Scientist where Institution_Id = {InstitutionID}";
            string GetMentors = $"SELECT * FROM Mentor where Institution_Id = {InstitutionID}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(GetScientists, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                Scientist_dataGridView.DataSource = dataSet.Tables[0];
                Scientist_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Scientist_dataGridView.AllowUserToAddRows = false;

                adapter = new SqlDataAdapter(GetMentors, connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                Mentor_dataGridView.DataSource = dataSet.Tables[0];
                Mentor_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Mentor_dataGridView.AllowUserToAddRows = false;
            }
        }

        public void FillAccountInfo()
        {
            DataContext db = new DataContext(connectionString);
            var institutionInfo = (from i in db.GetTable<Institution>()
                                   where i.Institution_ID == InstitutionID
                                   select i.Institution_Name).FirstOrDefault();
            institution_Name_Label.Text = institutionInfo;
            GetActivity();
            Activity_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Activity_dataGridView.AllowUserToAddRows = false;
        }

        private void Sign_Out_Click(object sender, EventArgs e)
        {
            Login_Form lf = new Login_Form();
            lf.Visible = true;
            this.Close();
        }

        private void Change_Password_Button_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionString);
            var LoginInfo = from b in db.GetTable<Institution>()
                            where b.Institution_ID == InstitutionID
                            select b.Institution_Name;
            if (Password_TextBox.Text.ToCharArray().Length >= 12)
            {
                try
                {
                    string UpdateSQL = $"update Users_Roles set UserPassword = '{Password_TextBox.Text}' where UserName = '{LoginInfo}'";
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
                MessageBox.Show("Password should contain more than 12 symbols", "Wrong password input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_Scientist_Click(object sender, EventArgs e)
        {
            AddScientistForm af = new AddScientistForm(InstitutionID);
            af.FormClosed += (sender, e) => Additional_FormClosed(sender, e);
            af.ShowDialog();
        }

        private void Additional_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetProjectTableForAdmin();
        }

        private void Add_Mentor_Click(object sender, EventArgs e)
        {
            AddMentorForm am = new AddMentorForm(InstitutionID);
            am.FormClosed += (sender, e) => Additional_FormClosed(sender, e);
            am.ShowDialog();
        }

        private void GetActivity()
        {
            DataContext db = new DataContext(connectionString);
            var institutionInfo = (from i in db.GetTable<Institution>()
                                   where i.Institution_ID == InstitutionID
                                   select i.Institution_Name).FirstOrDefault();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string GetActivity = $"SELECT * FROM Institution_Activity where Institution = '{institutionInfo}'";
                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(GetActivity, connection);
                adapter.Fill(dataSet);
                Activity_dataGridView.DataSource = dataSet.Tables[0];
            }
        }
    }
}
