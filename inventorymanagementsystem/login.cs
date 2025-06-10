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
    public partial class login : Form      
       
    {
        SqlConnection conn = new SqlConnection(@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\visual studion 2022\inventorymanagementsystem\inventorymanagementsystem\inventory.mdf"";Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from registration where username ='" +textBox_username.Text+ " 'and password ='" +textBox_password.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                MessageBox.Show("this username and password does not match");
            }
            else
            {
                this.Hide();
                MDIParent1 mDIParent1 = new MDIParent1();
                mDIParent1.Show();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
           if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
