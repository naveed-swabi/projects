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
using Google.Protobuf.WellKnownTypes;
using System.Globalization;
using Google.Protobuf;
//using System.Web.UI.WebControls;
using System.Diagnostics.Eventing.Reader;

using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using inventorymanagementsystem.Properties;



namespace inventorymanagementsystem
{
    public partial class sales : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");

        DataTable printtd = new DataTable();
        DataTable dt1 = new DataTable();
        int stock;
        int totalpay = 0;

        
        // string orderid = "";
        int qty;
        double largeUnitQuantity;
        double remainingSmallUnits;
        string productname;
        float factor1;
        String fromunit1;
        string tounit1;
        string productcmp;
        float convertFactor = 0;
        string unit = "";

        string orderid = "";
        string orderid1 = "";
        public sales()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sales_Load(object sender, EventArgs e)
        {
            //DateTime noSelectionDate = new DateTime(1900, , );
            
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            dt1.Clear();
           // dt1.Columns.Add("order_id");
            dt1.Columns.Add("product");
          
            dt1.Columns.Add("price");
            dt1.Columns.Add("qty");
            dt1.Columns.Add("unit");
            dt1.Columns.Add("total");
          

           // LoadUnits();
        }
        public void LoadUnits()
        {
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM UnitConversions WHERE product_name = @productName";
                cmd.Parameters.AddWithValue("@productName", txt_product.Text);

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                comboBox_units.Items.Clear(); // Clear existing items
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox_units.Items.Add(dr["fromUnit"].ToString());
                        comboBox_units.Items.Add(dr["toUnit"].ToString());
                    }
                }
                else {
                     SqlCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "SELECT * FROM purchase_master  WHERE product_name = @productName";
                    cmd1.Parameters.AddWithValue("@productName", txt_product.Text);

                    DataTable dt1 = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd1))
                    {
                        adapter.Fill(dt1);
                        foreach (DataRow dr in dt1.Rows)
                        {
                            comboBox_units.Items.Add(dr["product_unit"].ToString());
                           
                        }
                    }

                }
            }
        }

        public void Empty()
        {
            txt_customername.Text = "";
            txt_contact.Text = "";
            cmb_bill.Text = "";
            selectdate.Text = "";
            txt_product.Text = "";
            txt_price.Text = "";
            txt_quantity.Text = "";
            txt_total.Text = "";
            lbl_totalpayement.Text = "";
            txt_total.Text = "";
        }
        private void bttn_add_Click(object sender, EventArgs e)
        {
           productcmp = txt_product.Text;
            string product;
          

            SqlCommand cmd8 = conn.CreateCommand();
            cmd8.CommandType = CommandType.Text;
            cmd8.CommandText = " delete from stock where product_qty = 0";
            cmd8.ExecuteNonQuery();
            if (txt_customername.Text !=""  && cmb_bill.Text !=""
                && selectdate.Text !="" && txt_price.Text != "" && txt_quantity.Text != "") 
            {
                qty = Convert.ToInt32(txt_quantity.Text);
                string unit2 = comboBox_units.Text;
               
                SqlCommand cmd3 = conn.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "SELECT * FROM UnitConversions WHERE product_name = @productcmp ";
                cmd3.Parameters.AddWithValue("@productcmp", productcmp);
               // cmd3.Parameters.AddWithValue("@unit", unit2);

                SqlDataAdapter adapter1 = new SqlDataAdapter(cmd3);
                DataTable dt2 = new DataTable();
                adapter1.Fill(dt2);
               
                if (dt2.Rows.Count > 0)
                {

                    // Get conversion factor
                   factor1  = float.Parse(dt2.Rows[0]["conversionfactor"].ToString());
                    fromunit1 = dt2.Rows[0]["fromUnit"].ToString();
                    tounit1 = dt2.Rows[0]["tounit"].ToString();
                    // smallUnit = convertFactor * qty;




                }
                else
                {
                    DataRow dr1 = dt1.NewRow();
                   // dr1["order_id"] = orderid;
                    dr1["product"] = txt_product.Text;
                    dr1["unit"] = comboBox_units.Text;
                    dr1["price"] = txt_price.Text;
                    dr1["qty"] = txt_quantity.Text;
                    dr1["total"] = txt_total.Text;

                    dt1.Rows.Add(dr1);
                    dataGridView1.DataSource = dt1;

                    totalpay = totalpay + Convert.ToInt32(dr1["total"].ToString());

                    lbl_totalpayement.Text = totalpay.ToString();
                }

                if (fromunit1 == unit2)
                {

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    product = txt_product.Text;
                    cmd.CommandText = "SELECT * FROM stock WHERE product_name = @product AND product_unit = @fromunit1 ";

                    cmd.Parameters.AddWithValue("@product", product);
                    cmd.Parameters.AddWithValue("@fromunit1", fromunit1);
                    //cmd.Parameters.AddWithValue("@tounit1", tounit1);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {


                        stock = Convert.ToInt32(dr["product_qty"].ToString());


                    }
                    if (Convert.ToInt32(txt_quantity.Text) > stock)
                    {
                        MessageBox.Show("so much quantity is not available");
                    }
                    else
                    {
                        DataRow dr1 = dt1.NewRow();
                       // dr1["order_id"] = orderid;
                        dr1["product"] = txt_product.Text;
                        dr1["unit"] = comboBox_units.Text;
                        dr1["price"] = txt_price.Text;
                        dr1["qty"] = txt_quantity.Text;
                        dr1["total"] = txt_total.Text;
                      
                        dt1.Rows.Add(dr1);
                        dataGridView1.DataSource = dt1;

                        totalpay = totalpay + Convert.ToInt32(dr1["total"].ToString());

                        lbl_totalpayement.Text = totalpay.ToString();
                        txt_product.Text = "";
                        txt_price.Text = "";
                        txt_quantity.Text = "";
                        txt_total.Text = "";


                    }
                } 
                // }
                    if (tounit1 == unit2)
                    {
                        SqlCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                         product = txt_product.Text;
                        cmd1.CommandText = "SELECT * FROM stock WHERE product_name = @product AND product_unit = @tounit1 ";

                        cmd1.Parameters.AddWithValue("@product", product);
                        // cmd.Parameters.AddWithValue("@fromunit1", fromunit1);
                        cmd1.Parameters.AddWithValue("@tounit1", tounit1);
                        SqlDataAdapter adapter2 = new SqlDataAdapter(cmd1);
                        DataTable dt3 = new DataTable();
                        adapter2.Fill(dt3);
                        foreach (DataRow dr in dt3.Rows)
                        {


                            stock = Convert.ToInt32(dr["product_qty"].ToString());


                        }
                    if (stock >= (Convert.ToInt32(txt_quantity.Text)))
                    {
                        DataRow dr1 = dt1.NewRow();
                       // dr1["order_id"] = orderid;
                        dr1["product"] = txt_product.Text;
                        dr1["unit"] = comboBox_units.Text;
                        dr1["price"] = txt_price.Text;
                        dr1["qty"] = txt_quantity.Text;
                        dr1["total"] = txt_total.Text;
                        dt1.Rows.Add(dr1);
                        dataGridView1.DataSource = dt1;

                        totalpay = totalpay + Convert.ToInt32(dr1["total"].ToString());

                        lbl_totalpayement.Text = totalpay.ToString();
                        txt_product.Text = "";
                        txt_price.Text = "";
                        txt_quantity.Text = "";
                        txt_total.Text = "";

                    }

                      else
                      {  SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        product = txt_product.Text;
                        cmd.CommandText = "SELECT * FROM stock WHERE product_name = @product AND product_unit = @fromunit1 ";

                        cmd.Parameters.AddWithValue("@product", product);
                        cmd.Parameters.AddWithValue("@fromunit1", fromunit1);
                        //cmd.Parameters.AddWithValue("@tounit1", tounit1);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                           foreach (DataRow dr in dt.Rows)
                           {


                            stock = Convert.ToInt32(dr["product_qty"].ToString());


                            }
                        largeUnitQuantity = Math.Floor(qty / factor1);

                               if (largeUnitQuantity > stock)
                               {
                                MessageBox.Show("so much quantity is not available");
                                }
                                 else
                                 {
                                   DataRow dr1 = dt1.NewRow();
                                  // dr1["order_id"] = orderid;
                                   dr1["product"] = txt_product.Text;
                                   dr1["price"] = txt_price.Text;
                                   dr1["qty"] = txt_quantity.Text;
                                    dr1["unit"] = comboBox_units.Text;
                                   dr1["total"] = txt_total.Text;
                                   dt1.Rows.Add(dr1);
                                   dataGridView1.DataSource = dt1;

                                   totalpay = totalpay + Convert.ToInt32(dr1["total"].ToString());

                                    lbl_totalpayement.Text = totalpay.ToString();
                                    txt_product.Text = "";
                                    txt_price.Text = "";
                                    txt_quantity.Text = "";
                                    txt_total.Text = "";


                                  }
                         
                   
                    }    
                    }
                
               
            }
           
        }

        private void txt_product_KeyUp(object sender, KeyEventArgs e)
        {
            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd =conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_product.Text;
            cmd.CommandText = "SELECT * FROM stock WHERE product_name LIKE @productName";
            cmd.Parameters.AddWithValue("@productName", "%" + txt_product.Text.Trim() + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product_name"].ToString());
            }
        }

        private void txt_product_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down) 
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

        private void sales_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.list_product.SelectedItem != null)
            {
                txt_product.Text = this.list_product.SelectedItem.ToString().Trim();
                list_product.Visible = false;
                //txt_price.Focus();
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
                    comboBox_units.Text = null;
                    LoadUnits();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_price_Leave(object sender, EventArgs e)
        {
            if (txt_price.Text != "" && txt_quantity.Text != "")
            {
                txt_total.Text = Convert.ToString(Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_quantity.Text));
            }
        }

        private void txt_quantity_Leave(object sender, EventArgs e)
        {
            if (txt_price.Text != "" && txt_quantity.Text != "")
            {
                txt_total.Text = Convert.ToString((Convert.ToInt32(txt_price.Text) * Convert.ToInt32(txt_quantity.Text)));
            }
        }

        private void bttn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow) // Ensure the row is not the new row placeholder
                    {
                        dataGridView1.Rows.Remove(row);
                        totalpay = 0;
                        foreach (DataRow dr1 in dt1.Rows)
                        {
                            totalpay = totalpay + Convert.ToInt32(dr1["total"].ToString());

                            lbl_totalpayement.Text = totalpay.ToString();
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            
            DateTime seleDate2 = selectdate.Value.Date;

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string product = txt_product.Text;
            cmd.CommandText = "insert into order_customer values('" + txt_customername.Text + "','" + txt_contact.Text + "','" + selectdate.Value.ToString("dd-MM-yyyy") + "','" + cmb_bill.Text + "')";
            cmd.ExecuteNonQuery();

            /* cmd.CommandText = "INSERT INTO order_customer (customer_name, contact, order_date, bill) VALUES ('"
     + txt_customername.Text + "', '"
     + txt_contact.Text + "', '"
     + date.Value.ToString("yyyy-MM-dd") + "', '"
     + cmb_bill.Text + "')";*/
            DateTime saledate = DateTime.Parse(selectdate.Value.ToString());
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = " select top 1 * from order_customer order by id desc ";
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            Adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                orderid = dr["id"].ToString();
            }

                // DateTime saledate = date.Value.Date;


                foreach (DataRow dr1 in dt1.Rows)
                {


                    qty = 0;
                    string pname = " ";
                    SqlCommand cmdinsert = conn.CreateCommand();
                    cmdinsert.CommandType = CommandType.Text;
                    // SqlCommand cmdinsert = conn.CreateCommand();
                    largeUnitQuantity = 0;
                    remainingSmallUnits = 0;

                    cmdinsert.CommandText = "insert into order_item values('" + orderid.ToString() + "','" + dr1["product"].ToString() + "','" + dr1["price"].ToString() + "','" + dr1["qty"].ToString() + "','" + dr1["total"] + "' , @seleDate2, '" + dr1["unit"] + "' )";
                    cmdinsert.Parameters.AddWithValue("@seleDate2", seleDate2);
                    cmdinsert.ExecuteNonQuery();
                    


                    qty = Convert.ToInt32(dr1["qty"].ToString());
                    pname = dr1["product"].ToString();
                    unit = dr1["unit"].ToString();

                    SqlCommand cmddelete = conn.CreateCommand();
                    cmddelete.CommandType = CommandType.Text;
                    cmddelete.CommandText = " delete from stock where product_qty = 0";
                    cmddelete.ExecuteNonQuery();


                    SqlCommand cmdupdatunit = conn.CreateCommand();

                    cmdupdatunit.CommandType = CommandType.Text;
                    cmdupdatunit.CommandText = "UPDATE stock SET product_qty = product_qty - @qty WHERE product_name = @pname AND product_unit = @unit AND product_qty >= @qty";

                    cmdupdatunit.Parameters.AddWithValue("@qty", qty);
                    cmdupdatunit.Parameters.AddWithValue("@pname", pname.ToString());
                    cmdupdatunit.Parameters.AddWithValue("@unit", unit);

                    int rowsAffect = cmdupdatunit.ExecuteNonQuery();

                    if (rowsAffect > 0)
                    {
                        MessageBox.Show("inserted and updated successfully");
                    }

                    else
                    {
                        // double smallUnit = 0;


                        //string unit = comboBox_units.Text;
                        string fromunit;
                        string tounit;
                        productname = pname.ToString();

                        // Create SQL command to get conversion factor
                        SqlCommand cmdselecunit = conn.CreateCommand();
                        cmdselecunit.CommandType = CommandType.Text;
                        cmdselecunit.CommandText = "SELECT * FROM UnitConversions WHERE product_name = @productname AND tounit = @unit";
                        cmdselecunit.Parameters.AddWithValue("@productname", productname);
                        cmdselecunit.Parameters.AddWithValue("@unit", unit);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmdselecunit);
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);

                        if (dt1.Rows.Count > 0)
                        {

                            // Get conversion factor
                            convertFactor = float.Parse(dt1.Rows[0]["conversionfactor"].ToString());
                            fromunit = dt1.Rows[0]["fromUnit"].ToString();
                            tounit = dt1.Rows[0]["tounit"].ToString();
                            // smallUnit = convertFactor * qty;

                            // Convert small unit to large unit
                            if (convertFactor <= qty)
                            {
                                largeUnitQuantity = Math.Floor(qty / convertFactor);
                                remainingSmallUnits = qty % convertFactor;

                                string productname1 = pname.ToString();
                                // Create SQL command to update stock
                                SqlCommand updatstock5 = conn.CreateCommand();
                                updatstock5.CommandType = CommandType.Text;

                                // Update large unit stock
                                updatstock5.CommandText = "UPDATE stock SET product_qty = product_qty - @largeQty WHERE product_name = @productName AND product_unit = @fromunit";
                                updatstock5.Parameters.AddWithValue("@productName", productname1);
                                updatstock5.Parameters.AddWithValue("@fromunit", fromunit);
                                updatstock5.Parameters.AddWithValue("@largeQty", largeUnitQuantity);




                                int rowsAffected = updatstock5.ExecuteNonQuery();

                                // If no large unit stock exists or not enough large unit stock, insert remaining quantity as small unit
                                if (rowsAffected == 0 || remainingSmallUnits > 0)
                                {
                                    string productname2 = pname.ToString();
                                    SqlCommand cmdselectprod = conn.CreateCommand();
                                    // tounit = dt1.Rows[0]["tounit"].ToString();
                                    cmdselectprod.CommandType = CommandType.Text;

                                    // Check if small unit stock exists
                                    cmdselectprod.CommandText = "SELECT COUNT(*) FROM stock WHERE product_name = @productName2 AND product_unit = @tounit2";
                                    cmdselectprod.Parameters.AddWithValue("@productName2", productname2);
                                    cmdselectprod.Parameters.AddWithValue("@tounit2", tounit);

                                    int count = (int)cmdselectprod.ExecuteScalar();

                                    if (count > 0)
                                    {
                                        SqlCommand cmdupdatesock1 = conn.CreateCommand();
                                        cmdupdatesock1.CommandType = CommandType.Text;
                                        //Update existing small unit stock
                                        cmdupdatesock1.CommandText = "UPDATE stock SET product_qty = product_qty + @smallQty WHERE product_name = @productName AND product_unit = @tounit";
                                        cmdupdatesock1.Parameters.AddWithValue("@smallQty", remainingSmallUnits);
                                        cmdupdatesock1.Parameters.AddWithValue("@tounit", tounit);
                                        cmdupdatesock1.Parameters.AddWithValue("@productName", productname2);
                                        int rowsAffected1 = cmdupdatesock1.ExecuteNonQuery();

                                        if (rowsAffected1 > 0)
                                        {
                                            MessageBox.Show("insertd and  updated successfully.");
                                        }
                                    }
                                    else
                                    {
                                        SqlCommand cmdinsertstock = conn.CreateCommand();
                                        // Insert new small unit stock
                                        string productname3 = pname.ToString();
                                        cmdinsertstock.CommandText = "INSERT INTO stock (product_name,  product_qty ,product_unit ) VALUES (@productName,@smallQty   ,@tounit )";
                                        cmdinsertstock.Parameters.AddWithValue("@smallQty", remainingSmallUnits);
                                        cmdinsertstock.Parameters.AddWithValue("@tounit", tounit);
                                        cmdinsertstock.Parameters.AddWithValue("@productName", productname3);
                                        MessageBox.Show("inserted and update successfully");
                                    }


                                    // rowsAffected = updatstock.ExecuteNonQuery();
                                }
                            }

                            else
                            {

                                string productname4 = pname.ToString();
                                remainingSmallUnits = qty;
                                SqlCommand selectstock = conn.CreateCommand();
                                selectstock.CommandType = CommandType.Text;
                                // tounit1 = dt1.Rows[0]["tounit"].ToString();
                                // Check if small unit stock exists
                                selectstock.CommandText = "SELECT COUNT(*) FROM stock WHERE product_name = @productName4 AND product_unit = @tounit1";
                                selectstock.Parameters.AddWithValue("@productName4", productname4);
                                selectstock.Parameters.AddWithValue("@tounit1", tounit);

                                int count = (int)selectstock.ExecuteScalar();

                                if (count > 0)


                                {

                                    string productname5 = pname.ToString();
                                    // Update existing small unit stock
                                    SqlCommand cmdupdatstock2 = conn.CreateCommand();
                                    cmdupdatstock2.CommandText = "UPDATE stock SET product_qty = product_qty + (@convertFactor - @smallQty) WHERE product_name = @productName AND product_unit = @tounit";
                                    cmdupdatstock2.Parameters.AddWithValue("@smallQty", qty);
                                    cmdupdatstock2.Parameters.AddWithValue("@tounit", tounit);
                                    cmdupdatstock2.Parameters.AddWithValue("@convertFactor", convertFactor);
                                    cmdupdatstock2.Parameters.AddWithValue("@productName", productname5);

                                    cmdupdatstock2.ExecuteNonQuery();

                                    SqlCommand cmdupdatstock3 = conn.CreateCommand();

                                    cmdupdatstock3.CommandText = "UPDATE stock SET product_qty = product_qty - 1 WHERE product_name = @productName AND product_unit = @fromunit";
                                    // cmd6.Parameters.AddWithValue("@smallQty", 1);
                                    cmdupdatstock3.Parameters.AddWithValue("@productName", productname5);
                                    cmdupdatstock3.Parameters.AddWithValue("@fromunit", fromunit);
                                    cmdupdatstock3.ExecuteNonQuery();
                                    MessageBox.Show("inserted and update successfully");
                                }
                                else
                                {
                                    float qty1 = convertFactor - qty;
                                    string productname5 = pname.ToString();
                                    // Insert new small unit stock
                                    SqlCommand cmdinsertstok1 = conn.CreateCommand();
                                    cmdinsertstok1.CommandText = "INSERT INTO stock (product_name,  product_qty  ,product_unit ) VALUES (@productName, @smallQty, @tounit)";
                                    cmdinsertstok1.Parameters.AddWithValue("@smallQty", qty1);
                                    cmdinsertstok1.Parameters.AddWithValue("@tounit", tounit);
                                    cmdinsertstok1.Parameters.AddWithValue("@productName", productname5);
                                    cmdinsertstok1.ExecuteNonQuery();

                                    SqlCommand cmdupdatstock4 = conn.CreateCommand();
                                    cmdupdatstock4.CommandType = CommandType.Text;

                                    cmdupdatstock4.CommandText = "UPDATE stock SET product_qty = product_qty - 1 WHERE product_name = @productName AND product_unit = @fromunit";
                                    // cmd6.Parameters.AddWithValue("@smallQty", 1);
                                    cmdupdatstock4.Parameters.AddWithValue("@productName", productname5);
                                    cmdupdatstock4.Parameters.AddWithValue("@fromunit", fromunit);
                                    cmdupdatstock4.ExecuteNonQuery();
                                    MessageBox.Show("inserted and update successfully");


                                }
                            }

                        }
                        else
                        {
                            // Handle case where no conversion factor is found
                            MessageBox.Show("Conversion factor not found for the selected unit.");
                        }





                    }




                }
            
            Empty();
           // MessageBox.Show("record inserted successfully");
            dt1.Clear();
            dataGridView1.DataSource = dt1;
          
        }

        private void button_saveandprint_Click(object sender, EventArgs e)
        {
            
                DateTime seleDate2 = selectdate.Value.Date;

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string product = txt_product.Text;
                cmd.CommandText = "insert into order_customer values('" + txt_customername.Text + "','" + txt_contact.Text + "','" + selectdate.Value.ToString("dd-MM-yyyy") + "','" + cmb_bill.Text + "')";
                cmd.ExecuteNonQuery();

                /* cmd.CommandText = "INSERT INTO order_customer (customer_name, contact, order_date, bill) VALUES ('"
         + txt_customername.Text + "', '"
         + txt_contact.Text + "', '"
         + date.Value.ToString("yyyy-MM-dd") + "', '"
         + cmb_bill.Text + "')";*/
                DateTime saledate = DateTime.Parse(selectdate.Value.ToString());
                SqlCommand cmd1 = conn.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = " select top 1 * from order_customer order by id desc ";
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                Adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    orderid = dr["id"].ToString();
                }

                // DateTime saledate = date.Value.Date;


                foreach (DataRow dr1 in dt1.Rows)
                {


                    qty = 0;
                    string pname = " ";
                    SqlCommand cmdinsert = conn.CreateCommand();
                    cmdinsert.CommandType = CommandType.Text;
                    // SqlCommand cmdinsert = conn.CreateCommand();
                    largeUnitQuantity = 0;
                    remainingSmallUnits = 0;

                    cmdinsert.CommandText = "insert into order_item values('" + orderid.ToString() + "','" + dr1["product"].ToString() + "','" + dr1["price"].ToString() + "','" + dr1["qty"].ToString() + "','" + dr1["total"] + "' , @seleDate2, '" + dr1["unit"] + "' )";
                    cmdinsert.Parameters.AddWithValue("@seleDate2", seleDate2);
                    cmdinsert.ExecuteNonQuery();
                    //cmdprint

                    SqlCommand cmdprint = conn.CreateCommand();
                    cmdprint.CommandText = " select top 1 * from order_item order by id desc ";
                    // cmdprint.Parameters.AddWithValue("@orderid", orderid);
                    /* cmdprint.ExecuteNonQuery();

                     DataTable printtd = new DataTable();
                     printtd.Columns.Add("order_id");
                     printtd.Columns.Add("product");

                     printtd.Columns.Add("price");
                     printtd.Columns.Add("qty");
                     printtd.Columns.Add("unit");
                     printtd.Columns.Add("total");*/
                    SqlDataAdapter printadp = new SqlDataAdapter(cmdprint);
                    DataTable printtd = new DataTable();
                    printadp.Fill(printtd);
                    foreach (DataRow print in printtd.Rows)
                    {
                        orderid1 = print["order_id"].ToString();
                    }
                    //DataRow prt = printtd.NewRow();




                    /*   foreach (DataRow dr in printtd.Rows)
                       {

                           // prt["order_id"] = row["order_id"];
                           // DataRow dr1 = dt1.NewRow();
                           prt["order_id"] = dr["order_id"];
                           prt["product"] = dr["product"];
                           prt["unit"] = dr["unit"];
                           prt["price"] = dr["price"];
                           prt["qty"] = dr["qty"];
                           prt["total"] = dr["total"];
                       }*/
                    // dt1.Rows.Add(dr1);
                    dataGridView1.DataSource = dt1;

                    // printtd.Rows.Add(prt);
                    //dataGridView1.DataSource = printtd;


                    //print

                    qty = Convert.ToInt32(dr1["qty"].ToString());
                    pname = dr1["product"].ToString();
                    unit = dr1["unit"].ToString();

                    SqlCommand cmddelete = conn.CreateCommand();
                    cmddelete.CommandType = CommandType.Text;
                    cmddelete.CommandText = " delete from stock where product_qty = 0";
                    cmddelete.ExecuteNonQuery();


                    SqlCommand cmdupdatunit = conn.CreateCommand();

                    cmdupdatunit.CommandType = CommandType.Text;
                    cmdupdatunit.CommandText = "UPDATE stock SET product_qty = product_qty - @qty WHERE product_name = @pname AND product_unit = @unit AND product_qty >= @qty";

                    cmdupdatunit.Parameters.AddWithValue("@qty", qty);
                    cmdupdatunit.Parameters.AddWithValue("@pname", pname.ToString());
                    cmdupdatunit.Parameters.AddWithValue("@unit", unit);

                    int rowsAffect = cmdupdatunit.ExecuteNonQuery();

                    if (rowsAffect > 0)
                    {
                        
                    }

                    else
                    {
                        // double smallUnit = 0;


                        //string unit = comboBox_units.Text;
                        string fromunit;
                        string tounit;
                        productname = pname.ToString();

                        // Create SQL command to get conversion factor
                        SqlCommand cmdselecunit = conn.CreateCommand();
                        cmdselecunit.CommandType = CommandType.Text;
                        cmdselecunit.CommandText = "SELECT * FROM UnitConversions WHERE product_name = @productname AND tounit = @unit";
                        cmdselecunit.Parameters.AddWithValue("@productname", productname);
                        cmdselecunit.Parameters.AddWithValue("@unit", unit);

                        SqlDataAdapter adapter1 = new SqlDataAdapter(cmdselecunit);
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);

                        if (dt1.Rows.Count > 0)
                        {

                            // Get conversion factor
                            convertFactor = float.Parse(dt1.Rows[0]["conversionfactor"].ToString());
                            fromunit = dt1.Rows[0]["fromUnit"].ToString();
                            tounit = dt1.Rows[0]["tounit"].ToString();
                            // smallUnit = convertFactor * qty;

                            // Convert small unit to large unit
                            if (convertFactor <= qty)
                            {
                                largeUnitQuantity = Math.Floor(qty / convertFactor);
                                remainingSmallUnits = qty % convertFactor;

                                string productname1 = pname.ToString();
                                // Create SQL command to update stock
                                SqlCommand updatstock5 = conn.CreateCommand();
                                updatstock5.CommandType = CommandType.Text;

                                // Update large unit stock
                                updatstock5.CommandText = "UPDATE stock SET product_qty = product_qty - @largeQty WHERE product_name = @productName AND product_unit = @fromunit";
                                updatstock5.Parameters.AddWithValue("@productName", productname1);
                                updatstock5.Parameters.AddWithValue("@fromunit", fromunit);
                                updatstock5.Parameters.AddWithValue("@largeQty", largeUnitQuantity);




                                int rowsAffected = updatstock5.ExecuteNonQuery();

                                // If no large unit stock exists or not enough large unit stock, insert remaining quantity as small unit
                                if (rowsAffected == 0 || remainingSmallUnits > 0)
                                {
                                    string productname2 = pname.ToString();
                                    SqlCommand cmdselectprod = conn.CreateCommand();
                                    // tounit = dt1.Rows[0]["tounit"].ToString();
                                    cmdselectprod.CommandType = CommandType.Text;

                                    // Check if small unit stock exists
                                    cmdselectprod.CommandText = "SELECT COUNT(*) FROM stock WHERE product_name = @productName2 AND product_unit = @tounit2";
                                    cmdselectprod.Parameters.AddWithValue("@productName2", productname2);
                                    cmdselectprod.Parameters.AddWithValue("@tounit2", tounit);

                                    int count = (int)cmdselectprod.ExecuteScalar();

                                    if (count > 0)
                                    {
                                        SqlCommand cmdupdatesock1 = conn.CreateCommand();
                                        cmdupdatesock1.CommandType = CommandType.Text;
                                        //Update existing small unit stock
                                        cmdupdatesock1.CommandText = "UPDATE stock SET product_qty = product_qty + @smallQty WHERE product_name = @productName AND product_unit = @tounit";
                                        cmdupdatesock1.Parameters.AddWithValue("@smallQty", remainingSmallUnits);
                                        cmdupdatesock1.Parameters.AddWithValue("@tounit", tounit);
                                        cmdupdatesock1.Parameters.AddWithValue("@productName", productname2);
                                        int rowsAffected1 = cmdupdatesock1.ExecuteNonQuery();

                                        if (rowsAffected1 > 0)
                                        {
                                            MessageBox.Show(" updated and inserted successfully.");
                                        }
                                    }
                                    else
                                    {
                                        SqlCommand cmdinsertstock = conn.CreateCommand();
                                        // Insert new small unit stock
                                        string productname3 = pname.ToString();
                                        cmdinsertstock.CommandText = "INSERT INTO stock (product_name,  product_qty ,product_unit ) VALUES (@productName,@smallQty   ,@tounit )";
                                        cmdinsertstock.Parameters.AddWithValue("@smallQty", remainingSmallUnits);
                                        cmdinsertstock.Parameters.AddWithValue("@tounit", tounit);
                                        cmdinsertstock.Parameters.AddWithValue("@productName", productname3);
                                        MessageBox.Show("updated and inserted successfully");
                                    }


                                    // rowsAffected = updatstock.ExecuteNonQuery();
                                }
                            }

                            else
                            {

                                string productname4 = pname.ToString();
                                remainingSmallUnits = qty;
                                SqlCommand selectstock = conn.CreateCommand();
                                selectstock.CommandType = CommandType.Text;
                                // tounit1 = dt1.Rows[0]["tounit"].ToString();
                                // Check if small unit stock exists
                                selectstock.CommandText = "SELECT COUNT(*) FROM stock WHERE product_name = @productName4 AND product_unit = @tounit1";
                                selectstock.Parameters.AddWithValue("@productName4", productname4);
                                selectstock.Parameters.AddWithValue("@tounit1", tounit);

                                int count = (int)selectstock.ExecuteScalar();

                                if (count > 0)


                                {

                                    string productname5 = pname.ToString();
                                    // Update existing small unit stock
                                    SqlCommand cmdupdatstock2 = conn.CreateCommand();
                                    cmdupdatstock2.CommandText = "UPDATE stock SET product_qty = product_qty + (@convertFactor - @smallQty) WHERE product_name = @productName AND product_unit = @tounit";
                                    cmdupdatstock2.Parameters.AddWithValue("@smallQty", qty);
                                    cmdupdatstock2.Parameters.AddWithValue("@tounit", tounit);
                                    cmdupdatstock2.Parameters.AddWithValue("@convertFactor", convertFactor);
                                    cmdupdatstock2.Parameters.AddWithValue("@productName", productname5);

                                    cmdupdatstock2.ExecuteNonQuery();

                                    SqlCommand cmdupdatstock3 = conn.CreateCommand();

                                    cmdupdatstock3.CommandText = "UPDATE stock SET product_qty = product_qty - 1 WHERE product_name = @productName AND product_unit = @fromunit";
                                    // cmd6.Parameters.AddWithValue("@smallQty", 1);
                                    cmdupdatstock3.Parameters.AddWithValue("@productName", productname5);
                                    cmdupdatstock3.Parameters.AddWithValue("@fromunit", fromunit);
                                    cmdupdatstock3.ExecuteNonQuery();
                                    MessageBox.Show("updated and inserted successfully");
                                }
                                else
                                {
                                    float qty1 = convertFactor - qty;
                                    string productname5 = pname.ToString();
                                    // Insert new small unit stock
                                    SqlCommand cmdinsertstok1 = conn.CreateCommand();
                                    cmdinsertstok1.CommandText = "INSERT INTO stock (product_name,  product_qty  ,product_unit ) VALUES (@productName, @smallQty, @tounit)";
                                    cmdinsertstok1.Parameters.AddWithValue("@smallQty", qty1);
                                    cmdinsertstok1.Parameters.AddWithValue("@tounit", tounit);
                                    cmdinsertstok1.Parameters.AddWithValue("@productName", productname5);
                                    cmdinsertstok1.ExecuteNonQuery();

                                    SqlCommand cmdupdatstock4 = conn.CreateCommand();
                                    cmdupdatstock4.CommandType = CommandType.Text;

                                    cmdupdatstock4.CommandText = "UPDATE stock SET product_qty = product_qty - 1 WHERE product_name = @productName AND product_unit = @fromunit";
                                    // cmd6.Parameters.AddWithValue("@smallQty", 1);
                                    cmdupdatstock4.Parameters.AddWithValue("@productName", productname5);
                                    cmdupdatstock4.Parameters.AddWithValue("@fromunit", fromunit);
                                    cmdupdatstock4.ExecuteNonQuery();
                                    MessageBox.Show("update and inserted successfully");

                                }
                            }

                        }
                        else
                        {
                            // Handle case where no conversion factor is found
                            MessageBox.Show("Conversion factor not found for the selected unit.");
                        }





                    }





                }
                printDocument1.Print();
                Empty();
               // MessageBox.Show("record inserted successfully");
                dt1.Clear();
                dataGridView1.DataSource = dt1;

           

          /* generate_bill gbill = new generate_bill();
            gbill.getvalue(Convert.ToInt32((orderid.ToString())));
            gbill.Show();*/
        }

        private void list_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_customername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                // If it's not a valid character, prevent the character from being entered into the textbox
                e.Handled = true;
            }
        }

        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void txt_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If not, suppress the key press event
                e.Handled = true;
            }
        }

        private void txt_product_Leave(object sender, EventArgs e)
        {
            LoadUnits();
        }

        private void comboBox_units_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void comboBox_units_MouseMove(object sender, MouseEventArgs e)
        {

           // LoadUnits();
        }

        private void comboBox_units_Move(object sender, EventArgs e)
        {
           // LoadUnits();

        }

        private void btn_preiv_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmdprint = conn.CreateCommand();
            cmdprint.CommandText = "select * from order_item  where order_id = @orderid";
            cmdprint.Parameters.AddWithValue("@orderid", orderid);
            cmdprint.ExecuteNonQuery();
            
            DataTable printtd = new DataTable();
            printtd.Columns.Add("order_id");
            printtd.Columns.Add("product");

            printtd.Columns.Add("price");
            printtd.Columns.Add("qty");
            printtd.Columns.Add("unit");
            printtd.Columns.Add("total");
            SqlDataAdapter printadp = new SqlDataAdapter(cmdprint);
            // DataTable dt = new DataTable();
            printadp.Fill(printtd);

            DataRow prt = printtd.NewRow();




            foreach (DataRow row in printtd.Rows)
            {

                prt["order_id"] = row["order_id"];
                prt["product"] = row["product"];
                prt["unit"] = row["unit"];
                prt["price"] = row["price"];
                prt["qty"] = row["qty"];
                prt["total"] = row["total"];
            }
            printtd.Rows.Add(prt);
            dataGridView1.DataSource = printtd;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            SqlCommand cmdprint = conn.CreateCommand();
            cmdprint.CommandText = " select top 1 * from order_item order by id desc ";
            // cmdprint.Parameters.AddWithValue("@orderid", orderid);
            /* cmdprint.ExecuteNonQuery();

             DataTable printtd = new DataTable();
             printtd.Columns.Add("order_id");
             printtd.Columns.Add("product");

             printtd.Columns.Add("price");
             printtd.Columns.Add("qty");
             printtd.Columns.Add("unit");
             printtd.Columns.Add("total");*/
            SqlDataAdapter printadp = new SqlDataAdapter(cmdprint);
            DataTable printtd = new DataTable();
            printadp.Fill(printtd);
            foreach (DataRow print in printtd.Rows)
            {
                orderid1 = print["order_id"].ToString();
            }

            string dashline = "---------------------------------------------------------------------------------------------------------------------------------------";
            Bitmap bitmap = Properties.Resources.inventory_icon;
            
            Image image1 = bitmap;
           //Image image = new Image(bitmap);
            e.Graphics.DrawImage(image1, 0, 0, 880, 100);
            e.Graphics.DrawString("Smart shopping mall main bazar Topi, contact: 03152373174",
            new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(255, 100));

            e.Graphics.DrawString("customer name:   " + txt_customername.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Date:   " + DateTime.Now, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(420, 200));

            e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 250));

            e.Graphics.DrawString("Order_id    ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 320));
            e.Graphics.DrawString("Product    ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, 320));
            e.Graphics.DrawString("Price     ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(260, 320));
            e.Graphics.DrawString("Quantity    ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(370, 320));

            e.Graphics.DrawString("Unit   ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(490, 320));
            e.Graphics.DrawString("Total Price    ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 320));

            // e.Graphics.DrawString(comboBox_PRODUCT.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(70, 350));
            // e.Graphics.DrawString(textBoxPRICE.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(250, 350));
            //e.Graphics.DrawString(comboBox_QUANTITY.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(400, 350));
            //e.Graphics.DrawString(textBox_TORALPRICE.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 350));

            // e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 600));

            //e.Graphics.DrawString("Total Payment   ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(400, 700));

            // e.Graphics.DrawString("Total   ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 700));
            // using(Pen dashedPen = new Pen(Color.Black))
            //{
            // dashedPen.DashStyle = DashStyle.Dash;
            // e.Graphics.DrawLine(dashedPen, 50, 250, 750, 250); // Adjust coordinates as needed
            // }
            /* dr1["order_id"] = orderid;
             dr1["product"] = txt_product.Text;
             dr1["unit"] = comboBox_units.Text;
             dr1["price"] = txt_price.Text;
             dr1["qty"] = txt_quantity.Text;
             dr1["total"] = txt_total.Text;*/

            e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 300));
            int startY = 420;
           
            foreach (DataRow dr1 in dt1.Rows)
            {
                e.Graphics.DrawString(orderid1, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, startY));

                e.Graphics.DrawString(dr1["product"].ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, startY));

                e.Graphics.DrawString(dr1["Price"].ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(260, startY));

  
                e.Graphics.DrawString(dr1["qty"].ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(370, startY));
                e.Graphics.DrawString(dr1["unit"].ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(490, startY));
                e.Graphics.DrawString(dr1["total"].ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, startY));
               // e.Graphics.DrawString((Convert.ToDecimal(dr1["Price"]) * Convert.ToInt32(dr1["qty"])).ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, startY));
                startY += 30;
            }

            e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, startY));

            // Calculate total payment
           /* decimal totalPayment = 0;
            foreach (var dr1 in dt1.Rows)
            {
                totalPayment +=lbl_totalpayement.Text;
            }*/
            e.Graphics.DrawString("Total Amount  = ", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(350, startY + 50));
            e.Graphics.DrawString(lbl_totalpayement.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, startY + 50));


        }
    }
}
