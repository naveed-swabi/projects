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
using System.Diagnostics;
using System.Data.Common;

namespace inventorymanagementsystem
{
    public partial class products : Form
    {
        SqlConnection conn = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True");
        public products()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void product_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            
            loadcombounit();
            loadgridproduct();
        }
        public void loadgridproduct( )
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           dataGridView_product.DataSource = dt;
        }
        public void loadcombounit()
        {
          SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from units";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_unit.Items.Add(dr["unit"].ToString());
                comboBox_unit2.Items.Add(dr["unit"].ToString());
            }
        }

        private void button_addproduct_Click(object sender, EventArgs e)
        {
            if (comboBox_unit.SelectedIndex != -1&&textBox_addproduct.Text != "")
            {
               SqlCommand cmdselect = conn.CreateCommand();
               cmdselect.CommandType = CommandType.Text;
                cmdselect.CommandText = "select * from product where product_name = '"+textBox_addproduct.Text+"'";
                DataTable dt = new DataTable();
                SqlDataAdapter d = new SqlDataAdapter(cmdselect);
                d.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("product already exixt");
                }
                else
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    string uints = comboBox_unit.Text;
                    string product = textBox_addproduct.Text;
                    cmd.CommandText = "insert into product values(@product,@units)";
                    //cmd.Parameters.AddWithValue("@uints", uints);
                    // cmd.Parameters.AddWithValue("@product", product);

                    cmd.Parameters.AddWithValue("@product", product);
                    cmd.Parameters.AddWithValue("@units", uints);

                    cmd.ExecuteNonQuery();
                    comboBox_unit.SelectedIndex = -1;
                    textBox_addproduct.Text = "";
                    loadgridproduct();
                    MessageBox.Show("record inserted successfully");
                }
            }
        }

        private void dataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
              
                
        }

        private void dataGridView_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is not a header or invalid cell
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    panel_update.Visible = true;
                    comboBox_unit2.Items.Clear();

                    SqlCommand cmd2 = conn.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select * from units";
                    // cmd2.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                    da2.Fill(dt2);
                    foreach (DataRow dr in dt2.Rows)
                    {
                        comboBox_unit2.Items.Add(dr["unit"].ToString());
                    }
                }
                else
                {
                    // Log or debug message to know the cell click event was on an invalid cell
                    Debug.WriteLine("Clicked cell is not a valid data cell.");
                }
            }
            catch (Exception ex)
            {
                // Log the exception to understand what went wrong
                Debug.WriteLine("Error in CellContentClick: " + ex.Message);
            }


            int i = Convert.ToInt32(dataGridView_product.SelectedCells[0].Value.ToString());
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product where id =@i";
            cmd.Parameters.AddWithValue("@i", i);
            // cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {


                // comboBox_unit2.SelectedText = dr["unit"].ToString();
                textBox_product2.Text = dr["product_name"].ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_product2.Text != "" && comboBox_unit2.Text != "")
            {
                int i = Convert.ToInt32(dataGridView_product.SelectedCells[0].Value.ToString());



                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string productunit = comboBox_unit2.Text;
                string productname = textBox_product2.Text;

                cmd.CommandText = "update product set product_name = @productname,unit=@productunit where id =@i";
                cmd.Parameters.AddWithValue("@i", i);
                cmd.Parameters.AddWithValue("@productname", productname);
                cmd.Parameters.AddWithValue("@productunit", productunit);
                cmd.ExecuteNonQuery();
                panel_update.Visible = true;
                loadgridproduct();
                loadcombounit();
                MessageBox.Show("updated successfully");
                textBox_product2.Text = "";
                comboBox_unit2.Text = "";

            }
            

        }

        private void button_searchproduct_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string product = txt_serchproduct.Text;
            cmd.CommandText = "select * from product where product_name like @product";
            cmd.Parameters.AddWithValue("@product", "%"+product+"%");
            // cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView_product.DataSource = dt;
            textBox_product2.Text = "";
            comboBox_unit2.Text = "";
        }

        private void button_deleteproduct_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView_product.SelectedCells[0].Value.ToString());
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from product where id =@i";
            cmd.Parameters.AddWithValue("@i", i);
            cmd.ExecuteNonQuery();
            loadgridproduct();
            textBox_product2.Text = "";
            comboBox_unit2.Text = "";
        }

        private void textBox_addproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_product2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_seachproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
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

        private void txt_serchproduct_KeyUp(object sender, KeyEventArgs e)
        {
            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_serchproduct.Text;
            cmd.CommandText = "SELECT * FROM product WHERE product_name LIKE @productname";
            cmd.Parameters.AddWithValue("@productname", "%" + txt_serchproduct.Text.Trim() + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product_name"].ToString());
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
                        button_searchproduct.Focus();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    button_searchproduct.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_searchall_Click(object sender, EventArgs e)
        {
            loadcombounit();
            loadgridproduct();
            textBox_product2.Text = "";
            comboBox_unit2.Text = "";
        }
    }
}

