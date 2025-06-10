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

namespace inventorymanagementsystem
{
    public partial class dealer_info : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        public dealer_info()
        {
            InitializeComponent();
        }

        private void button_adddealer_Click(object sender, EventArgs e)
        {
            if (textBox_dealername.Text == "")
            {
                MessageBox.Show("insert at least dealer name");
            }
       
           else 
                 {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = " insert into dealer_info values('" + textBox_dealername.Text + "','" + textBox_company.Text + "','" + textBox_contact.Text + "','" + textBox_address.Text + "','" + textBox_city.Text + "')";
                cmd.ExecuteNonQuery();
                textBox_address.Text = "";
                textBox_city.Text = "";
                textBox_company.Text = "";
                textBox_contact.Text = "";
                textBox_dealername.Text = "";
                MessageBox.Show("record successfully inserted ");
                showdealer();

                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        public void showdealer()
        {
            
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from dealer_info";
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView_dealer.DataSource = dt;
                

        }

        private void dealer_info_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            showdealer();
        }

        private void button_updatedealer_Click(object sender, EventArgs e)
        {
            if (textBox_address.Text != ""&&

            textBox_city.Text != ""&&
            textBox_company.Text != ""&&
            textBox_contact.Text != ""&&
            textBox_dealername.Text !="") {

                int i = Convert.ToInt32(dataGridView_dealer.SelectedCells[0].Value.ToString());

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string Dealer_Name = textBox_dealername.Text;
                string DealerCompany_Name = textBox_company.Text;
                string Contact_no = textBox_contact.Text;
                string Address_det = textBox_address.Text;
                string city_name = textBox_city.Text;

                cmd.CommandText = "UPDATE dealer_info SET dealer_name = @Dealer_Name, dealer_company_name = @DealerCompany_Name, contact = @Contact_no, address = @Address_det, city = @City_name WHERE id = @i";

                // Add parameters with their values
                cmd.Parameters.AddWithValue("@Dealer_Name", Dealer_Name);
                cmd.Parameters.AddWithValue("@DealerCompany_Name", DealerCompany_Name);
                cmd.Parameters.AddWithValue("@Contact_no", Contact_no);
                cmd.Parameters.AddWithValue("@Address_det", Address_det);
                cmd.Parameters.AddWithValue("@City_name", city_name);
                cmd.Parameters.AddWithValue("@i", i); // Pass the integer 'i' here

                // Execute the command
                cmd.ExecuteNonQuery();

                textBox_address.Text = "";

                textBox_city.Text = "";
                textBox_company.Text = "";
                textBox_contact.Text = "";
                textBox_dealername.Text = "";
                MessageBox.Show("record successfully update ");
                showdealer();

            }

// Execute the command


        }

        private void dataGridView_dealer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = Convert.ToInt32(dataGridView_dealer.SelectedCells[0].Value.ToString());

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info where id = @i";
            cmd.Parameters.AddWithValue("@i", i);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox_dealername.Text = dr["dealer_name"].ToString();
                textBox_company.Text = dr["dealer_company_name"].ToString();
                textBox_contact.Text = dr["contact"].ToString();
                textBox_address.Text = dr["address"].ToString();
                textBox_city.Text = dr["city"].ToString();
            }

        }

        private void button_searchdealer_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string dealer = textBox_searchdealer.Text;
            cmd.CommandText = "select * from dealer_info where dealer_name like @dealer";
            cmd.Parameters.AddWithValue("@dealer", "%" + dealer + "%");
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView_dealer.DataSource = dt;
            textBox_address.Text = "";
            textBox_city.Text = "";
            textBox_company.Text = "";
            textBox_contact.Text = "";
            textBox_dealername.Text = "";
        }

        private void button_deletedealer_Click(object sender, EventArgs e)
        {
            if (dataGridView_dealer.SelectedRows.Count > 0)
            {

                int i = Convert.ToInt32(dataGridView_dealer.SelectedCells[0].Value.ToString());






                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete  from dealer_info where id = @i";
                cmd.Parameters.AddWithValue("@i", i);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted successfully");
                showdealer();
                textBox_address.Text = "";
                textBox_city.Text = "";
                textBox_company.Text = "";
                textBox_contact.Text = "";
                textBox_dealername.Text = "";

            }
            else
            {
                MessageBox.Show("select a row the press delete");
            }
            

        }

        private void textBox_dealername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_searchdealer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_dealername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_company_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a digit or a control key (e.g., backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void textBox_company_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_searchdealer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
