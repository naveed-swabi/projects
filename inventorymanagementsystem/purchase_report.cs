using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class purchase_report : Form
    {

        public string query;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        public DateTime firstdate;
        public DateTime lastdate;

        public purchase_report()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void purchase_report_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
              conn.Close();
            }
            conn.Open();
        }

        private void button_searchall_Click(object sender, EventArgs e)
        {
           int i = 0;
            SqlCommand cmd = conn.CreateCommand();
           // DataSet1 ds1 = new DataSet1();
     
            cmd.CommandType = CommandType.Text;
            query = "select * from purchase_master";
            using (SqlCommand cmd1 = new SqlCommand(query, conn))

            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                foreach (DataRow dr in dt.Rows)
                {
                    i = i + Convert.ToInt32(dr["product_total"].ToString());
                }
                label_total.Text = i.ToString();
               
            }
        }

        private void button_searh_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker_startdate.Value.Date;
            DateTime endDate = dateTimePicker_enddate.Value.Date;
            int i = 0;
            if (txt_serchproduct.Text != "")
            {
                query = "SELECT * FROM purchase_master WHERE purchase_date >= @startDate AND purchase_date <= @endDate AND product_name = @productname";
                //query = "SELECT * FROM purchase_master WHERE purchase_date >= '"+dateTimePicker_startdate.Value.Date+"' AND purchase_date <= '"+dateTimePicker_enddate.Value.Date+"' AND product_name = '" +txt_serchproduct.Text+"'";
            }
            else
            {
                query = "SELECT * FROM purchase_master WHERE purchase_date >= @startDate AND purchase_date <= @endDate ";
/* query = "SELECT * FROM purchase_master WHERE purchase_date >= '"
                + dateTimePicker_startdate.Value.Date
                          + "' AND purchase_date <= '"
                          + dateTimePicker_enddate.Value.Date 
                          + "'";*/
               // query = "SELECT * FROM purchase_master WHERE purchase_date >= @firstdate AND purchase_date <= @lastdate";
            }
            using (SqlCommand cmd = new SqlCommand(query, conn))
           // using (SqlCommand cmd = conn.CreateCommand())
            {

                // cmd.CommandType = CommandType.Text;
                // cmd.CommandText = "SELECT * FROM purchase_master WHERE purchase_date >= @firstdate AND purchase_date <= @lastdate";
                cmd.Parameters.AddWithValue("@startDate", startDate);
                cmd.Parameters.AddWithValue("@endDate", endDate);
                if (txt_serchproduct.Text != "")
                {
                    cmd.Parameters.AddWithValue("@productname", txt_serchproduct.Text);
                }

                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                dataGridView1.DataSource = dt;

                foreach (DataRow dr in dt.Rows)
                {
                    i = i+Convert.ToInt32(dr["product_total"]);
                }
            }
            label_total.Text = i.ToString();
            // query = "SELECT * FROM purchase_master WHERE purchase_date >= dateTimePicker_startdate.Value.Date  AND purchase_date <= dateTimePicker_enddate.Value.Date";
           ;
            
           /* query = "SELECT * FROM purchase_master WHERE purchase_date >= '"
                           + dateTimePicker_startdate.Value.Date
                           + "' AND purchase_date <= '"
                           + dateTimePicker_enddate.Value.Date
                           + "'"; */
       
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

        private void list_product_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                // Check if an item is selected
                if (this.list_product.SelectedItem != null)
                {
                    txt_serchproduct.Text = this.list_product.SelectedItem.ToString().Trim();
                    list_product.Visible = false;
                    button_searh.Focus ();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker_startdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_enddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_serchproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void list_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
