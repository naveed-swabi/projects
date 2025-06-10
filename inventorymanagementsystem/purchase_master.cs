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
    public partial class purchase_master : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
       
        public purchase_master()
        {
            InitializeComponent();
        }

        private void purchase_master_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            fill_prouct();
            fill_dealer();
        }
        public void LoadUnits()
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM product WHERE product_name = @productName";
                cmd.Parameters.AddWithValue("@productName", txt_product.Text);

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                //comboBox_units.Items.Clear(); // Clear existing items

                foreach (DataRow dr in dt.Rows)
                {
                    // comboBox_units.Items.Add(dr["Unit"].ToString());
                    // comboBox_units.Items.Add(dr["toUnit"].ToString());
                    label_unit.Text = dr["unit"].ToString();
                }
            }
        }
        public void fill_prouct()
        { 
         SqlCommand cmd = conn.CreateCommand();
         cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from product";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product_name"].ToString());
            }
        }
        public void fill_dealer()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dealer_info";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_dealername.Items.Add(dr["dealer_name"].ToString());
            }
        }

        private void comboBox_productname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select unit from product where product_name = '"+list_product.Text+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                label_unit.Text = dr["unit"].ToString();
            }
         
        }

        private void textBox2_pice_Leave(object sender, EventArgs e)
        {

            if (txt_product.Text != "" && textBox_quantity.Text != "")
            {
                textBox_totalprice.Text = Convert.ToString(Convert.ToInt32(textBox2_pice.Text) * Convert.ToInt32(textBox_quantity.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_product.Text != "" && textBox_quantity.Text != "" && label_unit.Text != "" &&
                textBox2_pice.Text != "" &&
                date_purchase.Text != "" && comboBox_dealername.Text != "" &&
                comboBox_purchasetype.Text != "" && date_expiry.Text != "" && textBox_profit.Text != "")


            {
                DateTime selectedDate = date_purchase.Value;
                DateTime expirayDate = date_expiry.Value;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"
    INSERT INTO purchase_master 
     
    VALUES 
    (@productName, @quantity, @unit, @piecePrice, @totalPrice, @purchaseDate, @dealerName, @purchaseType, @expiryDate, @profit)";

                cmd.Parameters.AddWithValue("@productName", txt_product.Text);
                cmd.Parameters.AddWithValue("@quantity", textBox_quantity.Text);
                cmd.Parameters.AddWithValue("@unit", label_unit.Text);
                cmd.Parameters.AddWithValue("@piecePrice", textBox2_pice.Text);
                cmd.Parameters.AddWithValue("@totalPrice", textBox_totalprice.Text);
                cmd.Parameters.AddWithValue("@purchaseDate", date_purchase.Value.Date);
                cmd.Parameters.AddWithValue("@dealerName", comboBox_dealername.Text);
                cmd.Parameters.AddWithValue("@purchaseType", comboBox_purchasetype.Text);
                cmd.Parameters.AddWithValue("@expiryDate", date_expiry.Value.Date);
                cmd.Parameters.AddWithValue("@profit", textBox_profit.Text);

               int rowseffect = cmd.ExecuteNonQuery();
                if(rowseffect > 0)
                {
                    MessageBox.Show("record successfully added");
                }

                int i;
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "SELECT * FROM stock WHERE product_name = @productName AND product_unit = @productUnit";
                cmd1.Parameters.AddWithValue("@productName", txt_product.Text);
                cmd1.Parameters.AddWithValue("@productUnit", label_unit.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "insert into stock values( '" + txt_product.Text + "','" + textBox_quantity.Text + "','" + label_unit.Text + "'  )";
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("successfully added");
                   /* SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO purchase_master VALUES( '" + txt_product.Text + "','" + textBox_quantity.Text + "','" + comboBox_units.Text + "','" + textBox2_pice.Text + "','" + textBox_totalprice.Text + "', '"+date_purchase.Value.Date.ToString() +"','" + comboBox_dealername.Text + "','" + comboBox_purchasetype.Text + "','"+date_expiry.Value.Date.ToString() +"' ,'" + textBox_profit.Text + "' )";
                   // cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    //cmd.Parameters.AddWithValue("@expirayDate", selectedDate);

                    cmd.ExecuteNonQuery();*/

                    
                    label_unit.Text = "";
                    textBox_quantity.Text = "";
                    label_unit.Text = "";
                    textBox2_pice.Text = "";

                    comboBox_dealername.Text = "";
                    comboBox_purchasetype.Text = "";
                    date_expiry.Text = "";
                    textBox_profit.Text = "";
                    textBox_totalprice.Text = "";
                }
                else
                {

                    cmd1.CommandText = "UPDATE stock SET product_qty = product_qty + @quantity WHERE product_name = @productname AND product_unit = @productUnit";
                    cmd1.Parameters.AddWithValue("@quantity", Convert.ToInt32(textBox_quantity.Text));
                    cmd1.Parameters.AddWithValue("@productname1", label_unit.Text);
                    cmd1.Parameters.AddWithValue("@productUnit1", label_unit.Text);
                    cmd1.ExecuteNonQuery();

                  /*  SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO purchase_master VALUES( '" + txt_product.Text + "','" + textBox_quantity.Text + "','" + comboBox_units.Text + "','" + textBox2_pice.Text + "','" + textBox_totalprice.Text + "', '" + date_purchase.Value.Date + "','" + comboBox_dealername.Text + "','" + comboBox_purchasetype.Text + "','" + date_expiry.Value.Date + "' ,'" + textBox_profit.Text + "' )";
                    // cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                    //cmd.Parameters.AddWithValue("@expirayDate", selectedDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("record successfully added");*/
                    //  comboBox_productname.Text = "";
                    txt_product.Text ="";
                    textBox_quantity.Text = "";
                   // label_unit.Text = "";
                    textBox2_pice.Text = "";
                    label_unit.Text = "";
                    comboBox_dealername.Text = "";
                    comboBox_purchasetype.Text = "";
                    date_expiry.Text = "";
                    textBox_profit.Text = "";
                    textBox_totalprice.Text = "";
                }
            }
          
            else
            {
                MessageBox.Show("Fill all the required fields");
            
            }
            label_unit.Text = "";
            textBox_quantity.Text = "";
            label_unit.Text = "";
            textBox2_pice.Text = "";

            comboBox_dealername.Text = "";
            comboBox_purchasetype.Text = "";
            date_expiry.Text = "";
            textBox_profit.Text = "";
            textBox_totalprice.Text = "";
        }

        private void textBox_quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_pice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox2_pice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void textBox_totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_quantity_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox_quantity_Leave(object sender, EventArgs e)
        {
            if (textBox2_pice.Text != "")
            {
                textBox_totalprice.Text = Convert.ToString(Convert.ToInt32(textBox2_pice.Text) * Convert.ToInt32(textBox_quantity.Text));
            }
            
        }

        private void textBox_profit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_profit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void txt_product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                list_product.Focus();
                list_product.SelectedIndex = 0;
            }
        }

        private void txt_product_KeyUp(object sender, KeyEventArgs e)
        {
            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_product.Text;
            cmd.CommandText = "SELECT * FROM product WHERE product_name LIKE @productName";
            cmd.Parameters.AddWithValue("@productName", "%" + txt_product.Text.Trim() + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product_name"].ToString());
            }
        }

        private void txt_product_Leave(object sender, EventArgs e)
        {
            LoadUnits();
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
                        txt_product.Text = this.list_product.SelectedItem.ToString().Trim();
                        list_product.Visible = false;
                        //txt_price.Focus();
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
                    txt_product.Text = this.list_product.SelectedItem.ToString().Trim();
                    list_product.Visible = false;
                    // txt_price.Focus();
                    label_unit.Text = null;
                    LoadUnits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label_purchasedate_Click(object sender, EventArgs e)
        {

        }
    }
}

