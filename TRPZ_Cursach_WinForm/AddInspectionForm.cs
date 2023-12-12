using System.Data.SqlClient;
using System.Data.Linq;

namespace TRPZ_Cursach_WinForm
{
    public partial class AddInspectionForm : Form
    {
        string connectionString = @"Data Source=DESKTOP\SQLEXPRESS; Initial Catalog=Scientific_Library; Integrated Security=True";
        int Change_Log_ID;
        Form MainForm;


        public AddInspectionForm(Form MainForm, int Change_Log_Id)
        {
            InitializeComponent();
            Change_Log_ID = Change_Log_Id;
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);
            Change_Log_Label.Text = Change_Log_Id.ToString();
            var InspectionCount = db.GetTable<Inspection_Result>().Count();
            Inspection_label.Text = (InspectionCount+1).ToString();
        }

        public AddInspectionForm(Form MainForm, int Change_Log_Id, string Inspection_Comment)
        {
            InitializeComponent();
            Change_Log_ID = Change_Log_Id;
            this.MainForm = MainForm;
            DataContext db = new DataContext(connectionString);
            var GetInspection = (from Inspection in db.GetTable<Inspection_Result>()
                                where Inspection.Change_Log_ID == Change_Log_ID
                                select Inspection.Inspection_ID).FirstOrDefault();
            Inspection_label.Text = GetInspection.ToString();
            Change_Log_Label.Text = Change_Log_Id.ToString();
            Inspection_TextBox.Text = Inspection_Comment;
        }

        private void AddInspection_Button_Click(object sender, EventArgs e)
        {
            if (Inspection_TextBox.Text == "")
            {
                MessageBox.Show("No inspection text given", "Some fields are left null", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (DataContext db = new DataContext(connectionString))
                {
                    if (this.Text == "Add inspection")
                    {
                        string insertQuery = "INSERT INTO Inspection_Result " +
                                 $"VALUES ({Inspection_label.Text}, {Change_Log_ID}, GetDate(), '{Inspection_TextBox.Text}')";

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
                    else
                    {
                        string updateQuery = $"update Inspection_Result set Inspection_Comments = '{Inspection_TextBox.Text}' where Inspection_ID = {Inspection_label.Text}";
                        using (SqlCommand Insert = new SqlCommand(updateQuery, _con))
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
}
