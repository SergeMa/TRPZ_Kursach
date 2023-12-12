using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Drawing;
using Microsoft.VisualBasic;

namespace TRPZ_Cursach_WinForm
{
    public partial class AddMediaReview : Form
    {
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
        Form MainForm;

        public AddMediaReview(Form MainForm, int ProjectId)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);
            FillValues(db, ProjectId);
        }

        public AddMediaReview(Form MainForm, int ProjectId, int ReviewId)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);
            FillValues(db, ProjectId);
            var media = db.GetTable<Media_Reviews>().SingleOrDefault(p => p.Review_ID == ReviewId);
            label6.Text = ReviewId.ToString();
            Add_Review.Text = "Edit review";
            textBox1.Text = media.Review_Link;
            textBox2.Text = media.Review_Date.ToString();
        }

        void FillValues(DataContext db, int ProjectId)
        {
            var mediaCount = db.GetTable<Media_Reviews>().Count();
            label6.Text = (mediaCount + 1).ToString();
            label7.Text = ProjectId.ToString();
            var projectInfo = db.GetTable<Project>().SingleOrDefault(p => p.Project_ID == ProjectId).Project_Name;
            label8.Text = projectInfo;
        }

        private void Add_Review_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Something was not added for the review", "Some fields are left null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (DataContext db = new DataContext(connectionString))
                {
                    string formattedSqlDate;
                    if (DateTime.TryParseExact(textBox2.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        formattedSqlDate = parsedDate.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("Wrong date format! please write in the following format 'yyyy-MM-dd'", "Wrong input format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (this.Text == "Adding media review")
                    {
                        string insertQuery = "INSERT INTO Media_Reviews " +
                                 $"VALUES ({label6.Text}, {label7.Text}, '{textBox1.Text}', '{formattedSqlDate}')";

                        using (SqlCommand Insert = new SqlCommand(insertQuery, _con))
                        {
                            try
                            {
                                _con.Open();
                                Insert.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show("Something went wrong: " + a.Message, "Wrong input data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        string UpdateQuery = $"update Media_Reviews set Review_Link = '{textBox1.Text}', Review_Date = '{formattedSqlDate}' where Review_ID = {label6.Text}";
                        using (SqlCommand Update = new SqlCommand(UpdateQuery, _con))
                        {
                            try
                            {
                                _con.Open();
                                Update.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (Exception a)
                            {
                                MessageBox.Show("Something went wrong: " + a.Message, "Wrong input data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                }
                this.Close();

            }
        }
    }


}
