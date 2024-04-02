using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1(string User)
        {
            InitializeComponent();


            if (User.Contains("Sales"))
            {
                OrdersRB.Enabled = true;
                CustomersRB.Enabled = true;
            }
            else if (User.Contains("HR"))
            {
                EmployeeRB.Enabled = true;

            }
            else if (User.Contains("CEO"))
            {
                OrdersRB.Enabled = true;
                CustomersRB.Enabled = true;
                EmployeeRB.Enabled = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!OrdersRB.Checked && !CustomersRB.Checked && !EmployeeRB.Checked)
            {
                MessageBox.Show("Please select a radio button option to proceed.");
                return;
            }

            DataTable dt = new DataTable();
            string connString = @"Data Source=DESKTOP-L263P3K\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    SqlCommand com = null;

                    if (OrdersRB.Checked)
                    {
                        com = new SqlCommand("SELECT * FROM Orders", con);
                    }
                    else if (CustomersRB.Checked)
                    {
                        com = new SqlCommand("SELECT * FROM Customers", con);
                    }
                    else if (EmployeeRB.Checked)
                    {
                        com = new SqlCommand("SELECT * FROM Employees", con);
                    }
                    else if (com != null)
                    {
                        using (var da = new SqlDataAdapter(com))
                        {
                            da.Fill(dt);
                        }
                    }
                    else if (dt == null || dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data available.");
                        return;
                    }
                }

                catch (SqlException sqlEx)
                {
                    MessageBox.Show("A database error occurred. Please try again later.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: Please try again.");
                }
            }

            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!OrdersRB.Checked && !CustomersRB.Checked && !EmployeeRB.Checked)
            {
                MessageBox.Show("Please select a radio button option to proceed.");
                return;
            }

            DataTable dt = new DataTable();
            string connString = @"Data Source=DESKTOP-L263P3K\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

            using (var con = new SqlConnection(connString))
            {
                try
                {
                    con.Open();
                    using (var command = new SqlCommand("", con))
                    {
                        using (var da = new SqlDataAdapter(command))
                        {
                            da.Fill(dt);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: Please try again");
                }
            }

            dataGridView1.DataSource = dt;
        }

        private void EmployeesChBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrdersRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}