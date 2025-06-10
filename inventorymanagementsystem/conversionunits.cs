using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorymanagementsystem
{
    public partial class conversionunits : Form
    {
       // string connectionString;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True ");
        public conversionunits()
        {
            InitializeComponent();
        }

        private void conversionunits_Load(object sender, EventArgs e)
        {

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            LoadUnits();
        }
        public void LoadUnits()
        {
            // Query to select distinct units from the 'units' table
            string query = "SELECT DISTINCT unit FROM units";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind distinct units to 'toUnitComboBox'
                toUnitComboBox.DataSource = dt;
                toUnitComboBox.DisplayMember = "unit";
                toUnitComboBox.ValueMember = "unit"; // Assuming 'unit' column contains the unique identifier
                toUnitComboBox.Text = "";
            }

            // Query to select distinct units from the 'purchase_master' table
            string query1 = "SELECT DISTINCT product_unit FROM purchase_master";
            using (SqlCommand cmd1 = new SqlCommand(query1, conn))
            {
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                // Bind distinct units to 'fromUnitComboBox'
                fromUnitComboBox.DataSource = dt1;
                fromUnitComboBox.DisplayMember = "product_unit";
                fromUnitComboBox.ValueMember = "product_unit"; // Assuming 'product_unit' column contains the unique identifier
                fromUnitComboBox.Text = "";
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
                       // button_searh.Focus();
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
                    //button_searh.Focus();
                    fromUnitComboBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_serchproduct_KeyUp(object sender, KeyEventArgs e)
        {

            list_product.Visible = true;
            list_product.Items.Clear();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string productname = txt_serchproduct.Text;
            cmd.CommandText = "SELECT * FROM purchase_master WHERE product_name LIKE @productname";
            cmd.Parameters.AddWithValue("@productname", "%" + txt_serchproduct.Text.Trim() + "%");

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

        private void addConversionButton_Click(object sender, EventArgs e)
        {
            try
            {
              if(txt_serchproduct.Text != "" && 
                fromUnitComboBox.Text != "" &&
                toUnitComboBox.Text != "" &&
                conversionFactorTextBox.Text != "" )
                {
                    string product_name = txt_serchproduct.Text;  // Ensure the textbox name is correct
                    string fromUnit = fromUnitComboBox.Text;
                    string toUnit = toUnitComboBox.Text;
                    double conversionFactor = double.Parse(conversionFactorTextBox.Text);

                    // Use the correct schema if necessary
                    string query = "INSERT INTO UnitConversions (product_name, fromUnit, toUnit, conversionFactor) " +
                                   "VALUES (@product_name, @fromUnit, @toUnit, @conversionFactor)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_name", product_name);
                        cmd.Parameters.AddWithValue("@fromUnit", fromUnit);
                        cmd.Parameters.AddWithValue("@toUnit", toUnit);
                        cmd.Parameters.AddWithValue("@conversionFactor", conversionFactor);

                      // conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Conversion factor added successfully.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("select a product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            txt_serchproduct.Text = "";
            fromUnitComboBox.Text = "";
            toUnitComboBox.Text = "";
            conversionFactorTextBox.Text = "";
            

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}