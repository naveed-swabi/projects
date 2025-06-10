using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace inventorymanagementsystem
{
    public partial class sales_report : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        string query;
        // int total = 0;
        decimal amount = 0;

        DataTable dtorder = new DataTable();

        public sales_report()
        {
            InitializeComponent();
        }

        private void sales_report_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();

        }

        private void button_searchall_Click(object sender, EventArgs e)
        {
            txtsearchorderno.Text = "";
            int total = 0;
            string query = "SELECT * FROM order_item";

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                using (SqlCommand cmd_allsales = new SqlCommand(query, conn))
                {
                    DataTable dtsales = new DataTable();
                    SqlDataAdapter dasales = new SqlDataAdapter(cmd_allsales);
                    dasales.Fill(dtsales);

                    if (dtsales.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found.");
                    }
                    else
                    {
                        grid_sales.DataSource = dtsales;
                        grid_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        grid_sales.ReadOnly = true;
                        grid_sales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        grid_sales.Refresh();

                        foreach (DataGridViewRow row in grid_sales.Rows)
                        {
                            row.Visible = true;
                        }

                        foreach (DataRow dr in dtsales.Rows)
                        {
                            total += dr["total"] == DBNull.Value ? 0 : Convert.ToInt32(dr["total"]);
                        }

                        label_total.Text = total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void button_searh_Click(object sender, EventArgs e)
        {
            txtsearchorderno.Text = "";
            int total = 0;

            DateTime startDate = dateTimePicker_startdate.Value.Date;
            DateTime endDate = dateTimePicker_enddate.Value.Date;
          
            
            string ProductName =txt_serchproduct.Text;

            if (txt_serchproduct.Text != "")
            {
                query = "SELECT * FROM order_item WHERE sale_date >= @StartDate AND sale_date <= @EndDate AND product = @ProductName";
            }
            else
            {
                query = "SELECT * FROM order_item WHERE sale_date >= @StartDate AND sale_date <= @EndDate";
            }

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                if (ProductName!= "")
                {
                    cmd.Parameters.AddWithValue("@ProductName", ProductName);
                }

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                grid_sales.DataSource = dt;

                foreach (DataRow dr in dt.Rows)
                {
                    total = total + Convert.ToInt32(dr["total"]);
                }
            }

            label_total.Text = total.ToString();

        }

        private void txt_serchproduct_KeyUp(object sender, KeyEventArgs e)
        {

            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_serchproduct.Text;
            cmd.CommandText = "SELECT * FROM order_item WHERE product LIKE @productname";
            cmd.Parameters.AddWithValue("@productname", "%" + txt_serchproduct.Text.Trim() + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                list_product.Items.Add(dr["product"].ToString());
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

        private void button_print_Click(object sender, EventArgs e)
        {


            if (grid_sales.DataSource != null && txtsearchorderno.Text != "" )
            {
                printPreviewDialog2.Document = printDocument2;
                printPreviewDialog2.ShowDialog();
                printDocument2.Print();
            }
            else
            {
                MessageBox.Show("Please  search Order_id first.");
            }

        }

        private void bttn_searchorder_Click(object sender, EventArgs e)
        {






            if (txtsearchorderno.Text != "")
            {
                query = "SELECT * FROM order_item WHERE order_id = '" + txtsearchorderno.Text + "'";


                using (SqlCommand cmdsearchorder = new SqlCommand(query, conn))
                {

                    decimal total = 0;

                    DataTable dtorder = new DataTable();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmdsearchorder))
                    {
                        da.Fill(dtorder);
                    }
                    grid_sales.DataSource = dtorder;
                    foreach (DataGridViewRow row in grid_sales.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            total += Convert.ToDecimal(row.Cells["total"].Value);
                        }
                    }

                    label_total.Text = total.ToString();
                }
            }
            else
            {
                MessageBox.Show("Enter order no");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            amount = 0; 
            string dashline = "---------------------------------------------------------------------------------------------------------------------------------------";
            Bitmap bitmap = Properties.Resources.inventory_icon;

            Image image = bitmap;
            e.Graphics.DrawImage(image, 0, 0, 880, 100);
            e.Graphics.DrawString("Smart shopping mall main bazar Topi, contact: 03152373174",
                new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(255, 100));

            e.Graphics.DrawString("Sale Date:", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("Order_id", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, 320));
            e.Graphics.DrawString("Product", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, 320));
            e.Graphics.DrawString("Price", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 320));
            e.Graphics.DrawString("Quantity", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(450, 320));
            e.Graphics.DrawString("Unit", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, 320));
            e.Graphics.DrawString("Total Price", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, 320));

            e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 300));
            int startY = 420;

            foreach (DataGridViewRow row in grid_sales.Rows)
            {
                if (!row.IsNewRow)
                {
                    e.Graphics.DrawString(row.Cells["sale_date"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(200, 220));
                    e.Graphics.DrawString(row.Cells["order_id"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(10, startY));
                    e.Graphics.DrawString(row.Cells["product"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(150, startY));
                    e.Graphics.DrawString(row.Cells["Price"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, startY));
                    e.Graphics.DrawString(row.Cells["qty"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(450, startY));
                    e.Graphics.DrawString(row.Cells["unit"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(600, startY));
                    e.Graphics.DrawString(row.Cells["total"].Value.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, startY));

                    startY += 30;
                }
            }

            e.Graphics.DrawString(dashline, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, startY));

           
            foreach (DataGridViewRow row in grid_sales.Rows)
            {
                if (!row.IsNewRow)
                {
                    amount += Convert.ToDecimal(row.Cells["total"].Value);
                }
            }

            e.Graphics.DrawString("Total Amount =", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(500, startY + 50));
            e.Graphics.DrawString(amount.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(700, startY + 50));
            // label_total.Text = amount.ToString();
        }

        private void bttn_preview_Click(object sender, EventArgs e)
        {
            if (txtsearchorderno.Text != "" )
            {
                printPreviewDialog2.Document = printDocument2;
                printPreviewDialog2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Search Bill Order_id");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void list_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
