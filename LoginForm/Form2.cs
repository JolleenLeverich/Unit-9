using Microsoft.Data.SqlClient;
using WinFormsApp1;

namespace LoginForm
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = UserTextBx.Text;
            string password = PasswordTxtBx.Text;

            string connString = $@"Data Source=DESKTOP-L263P3K\SQLEXPRESS;Initial Catalog=Northwind;User ID={user};Password={password};Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    Console.WriteLine("Successfully connected to the database.");

                    var form1 = new Form1(user);
                    form1.Show();
                    this.Hide();

                    UserTextBx.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        } 
    }
}
