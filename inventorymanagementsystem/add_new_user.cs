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
    public partial class add_new_user : Form
    {
        SqlConnection conn = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        public add_new_user()
        {
            InitializeComponent();
        }

        private void add_new_user_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Open();
            }
            display();
        }
        public void display()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button_addnewuser_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text != "" &&
                textBox_lastname.Text != "" &&
                textBox_username.Text != "" &&
                textBox_password.Text != "" &&
                textBox_email.Text != "" &&
                textBox_contact.Text != "")
            {




                int i = 0;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from registration where username ='" + textBox_username.Text + " '";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());



                if (i == 0)



                {

                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into registration values('" + textBox_firstname.Text + "','" + textBox_lastname.Text + "','" + textBox_username.Text + "','" + textBox_password.Text + "','" + textBox_email.Text + "','" + textBox_contact.Text + "' )";
                    cmd1.ExecuteNonQuery();
                    textBox_firstname.Text = "";
                    textBox_lastname.Text = "";
                    textBox_username.Text = "";
                    textBox_password.Text = "";
                    textBox_email.Text = "";
                    textBox_contact.Text = "";

                    MessageBox.Show("user successfully added");
                    display();

                }
                else
                {




                    MessageBox.Show("this username already register try another");

                }
            }
            else { MessageBox.Show("Fill all the field"); }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure there are selected cells
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    // Ensure the selected row index is valid
                    if (rowIndex >= 0)
                    {
                        var cellValue = dataGridView1.Rows[rowIndex].Cells[0].Value;

                        // Ensure the cell contains a valid value
                        if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                        {
                            // Ensure the cell value is a valid integer
                            if (int.TryParse(cellValue.ToString(), out int rowid))
                            {
                               
                                   // conn.Open();
                                    SqlCommand cmd = conn.CreateCommand();
                                    cmd.CommandType = CommandType.Text;
                                    cmd.CommandText = "DELETE FROM registration WHERE id = @rowid";
                                    cmd.Parameters.AddWithValue("@rowid", rowid);

                                    int i = cmd.ExecuteNonQuery();
                                    if (i != 0)
                                    {
                                        MessageBox.Show("Deleted successfully");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Select a row to delete");
                                    }
                                
                                display();
                            }
                            else
                            {
                                MessageBox.Show("Please select a valid row to delete (invalid ID format).");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid row to delete (empty or null value).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid row to delete (invalid row index).");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void textBox_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the selected row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount)
            {
                // Ensure that the selected cell is not empty
                if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells[0].Value != null)
                {
                    // Try to convert the value to an integer
                    if (int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out int i))
                    {
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from registration where id = @i";
                        cmd.Parameters.AddWithValue("@i", i);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                        foreach (DataRow dr in dt.Rows)
                        {
                            textBox_firstname.Text = dr["firstname"].ToString();
                            textBox_lastname.Text = dr["lastname"].ToString();
                            textBox_username.Text = dr["username"].ToString();
                            textBox_password.Text = dr["password"].ToString();
                            textBox_email.Text = dr["email"].ToString();
                            textBox_contact.Text = dr["contact"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid cell with a valid ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid cell.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }
        }


        private void bttn_update_Click(object sender, EventArgs e)
        {



            // Ensure that a valid cell is selected
            if (dataGridView1.SelectedCells.Count > 0 && dataGridView1.SelectedCells[0].Value != null)
            {
                // Try to convert the selected cell's value to an integer
                if (int.TryParse(dataGridView1.SelectedCells[0].Value.ToString(), out int i))
                {
                    // Ensure that all text boxes are filled
                    if (!string.IsNullOrWhiteSpace(textBox_firstname.Text) &&
                        !string.IsNullOrWhiteSpace(textBox_lastname.Text) &&
                        !string.IsNullOrWhiteSpace(textBox_contact.Text) &&
                        !string.IsNullOrWhiteSpace(textBox_email.Text) &&
                        !string.IsNullOrWhiteSpace(textBox_username.Text) &&
                        !string.IsNullOrWhiteSpace(textBox_password.Text))
                    {
                        string firstname = textBox_firstname.Text;
                        string lastname = textBox_lastname.Text;
                        string contact = textBox_contact.Text;
                        string email = textBox_email.Text;
                        string username = textBox_username.Text;
                        string password = textBox_password.Text;

                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE registration SET firstname = @firstname, lastname = @lastname, username = @username, " +
                                          "password = @password, email = @email, contact = @contact WHERE id = @i";
                        cmd.Parameters.AddWithValue("@i", i);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.ExecuteNonQuery();

                        // Clear the text boxes
                        textBox_firstname.Text = "";
                        textBox_lastname.Text = "";
                        textBox_email.Text = "";
                        textBox_contact.Text = "";
                        textBox_username.Text = "";
                        textBox_password.Text = "";

                        MessageBox.Show("Updated successfully");
                    }
                    else
                    {
                        MessageBox.Show("Fill all the fields");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid cell with a valid ID.");
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }

            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
