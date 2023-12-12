using System.Data.SqlClient;
using System.Data.Linq;

namespace TRPZ_Cursach_WinForm
{
    public partial class AddScientistForm : Form
    {
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
        int Institution_ID;
        public AddScientistForm(int Institution_ID)
        {
            this.Institution_ID = Institution_ID;
            InitializeComponent();
            DataContext db = new DataContext(connectionString);
            var ScientistCount = db.GetTable<Scientist>().Count();
            Scientist_Label.Text = (ScientistCount + 1).ToString();
            Institution_Id_Label.Text = Institution_ID.ToString();
        }

        private void Add_Scientist_Button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("No name or surname given", "Some fields are left null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (DataContext db = new DataContext(connectionString))
                {
                    string insertQuery = "INSERT INTO Scientist " +
                             $"VALUES ({Scientist_Label.Text}, '{textBox2.Text}', '{textBox1.Text}', {Institution_ID})";

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
                    this.Close();

                }
            }
        }
    }
}
