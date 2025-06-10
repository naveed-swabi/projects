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
    public partial class stock : Form
    {
        public string query;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        
        public stock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stock_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = conn.CreateCommand();
            // DataSet1 ds1 = new DataSet1();

            cmd.CommandType = CommandType.Text;
            query = "select * from stock";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))

            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

               

            }
        }

        private void button_searh_Click(object sender, EventArgs e)
        {
            if (txt_serchproduct.Text != "")
            {
                SqlCommand cmd = conn.CreateCommand();
                // DataSet1 ds1 = new DataSet1();

                cmd.CommandType = CommandType.Text;
                query = "select * from stock where product_name = '" + txt_serchproduct.Text + "'";
                using (SqlCommand cmd1 = new SqlCommand(query, conn))

                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;



                }
            }
            else
            {
                MessageBox.Show(" Enter the product name to seach");
                SqlCommand cmd = conn.CreateCommand();
                // DataSet1 ds1 = new DataSet1();

                cmd.CommandType = CommandType.Text;
                query = "select * from stock";
                using (SqlCommand cmd1 = new SqlCommand(query, conn))

                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;



                }
            }
        }

        private void txt_serchproduct_KeyUp(object sender, KeyEventArgs e)
        {
            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_serchproduct.Text;
            cmd.CommandText = "SELECT * FROM stock WHERE product_name LIKE @productName";
            cmd.Parameters.AddWithValue("@productName", "%" + txt_serchproduct.Text.Trim() + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product_name"].ToString());
            }
        }

        private void txt_serchproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                list_product.Focus();
                list_product.SelectedIndex = 0;
            }
        }

        private void list_product_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Down)
                {
                    if (this.list_product.SelectedIndex < this.list_product.Items.Count - 1)
                    {
                        this.list_product.SelectedIndex = this.list_product.SelectedIndex + 1;
                    }

                }
                if (e.KeyCode == Keys.Up)
                {
                    if (this.list_product.SelectedIndex > 0)
                    {
                        this.list_product.SelectedIndex = this.list_product.SelectedIndex - 1;
                    }
                }

                if (e.KeyCode == Keys.Enter)
                {
                    // Check if an item is selected
                    if (this.list_product.SelectedItem != null)
                    {
                        txt_serchproduct.Text = this.list_product.SelectedItem.ToString().Trim();
                        list_product.Visible = false;
                        button_searh.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_product_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // Check if an item is selected
                if (this.list_product.SelectedItem != null)
                {
                    txt_serchproduct.Text = this.list_product.SelectedItem.ToString().Trim();
                    list_product.Visible = false;
                    button_searh.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_serchproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void button_showallproduct_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = conn.CreateCommand();
            // DataSet1 ds1 = new DataSet1();

            cmd.CommandType = CommandType.Text;
            query = "select * from stock";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))

            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;



            }
        }
    }
}
