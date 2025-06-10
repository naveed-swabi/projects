using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class units : Form
    {
       SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        public units()
        {
            InitializeComponent();
        }

        private void button_addunit_Click(object sender, EventArgs e)
        {

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from units where unit = '" +textBox_addunit.Text+ "' ";
            cmd1.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count =0;
            count = Convert.ToInt32 (dt.Rows.Count.ToString());
            if (count == 0)
            {


                string unit = textBox_addunit.Text;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into units values(@unit )";

                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.ExecuteNonQuery();
                displayuints();
            }
            else
            {
                MessageBox.Show("this unit is already added");
            }
        }

        private void units_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            displayuints();
        }
        public void displayuints()
        {
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewunits.DataSource = dt;
          
            

        }

        private void button_deletunit_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that a valid cell is selected
                if (dataGridViewunits.SelectedCells.Count > 0 && dataGridViewunits.SelectedCells[0].Value != null)
                {
                    // Try to convert the selected cell's value to an integer
                    if (int.TryParse(dataGridViewunits.SelectedCells[0].Value.ToString(), out int unitid))
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "delete from units where id = @unitid";
                        cmd.Parameters.AddWithValue("@unitid", unitid);
                        cmd.ExecuteNonQuery();

                        displayuints(); // Assuming you have a method to refresh the DataGridView
                        MessageBox.Show("Deleted successfully");
                    }
                    else
                    {
                        MessageBox.Show("The selected cell does not contain a valid ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid cell.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

       

        private void dataGridViewunits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row
                if (e.RowIndex >= 0)
                {
                    var cellValue = dataGridViewunits.Rows[e.RowIndex].Cells[0].Value; // Assuming you are interested in the first cell of the row

                    // Check if the cell is empty or contains only whitespace
                    if (cellValue == null || string.IsNullOrWhiteSpace(cellValue.ToString()))
                    {
                        MessageBox.Show("The selected row must not be empty.");
                    }
                    else
                    {
                        // Your code to handle a valid row selection
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid row.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
