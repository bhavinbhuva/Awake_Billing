using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awake_billing
{
    public partial class add_customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhavin\source\repos\Awake_Billing\Awake_billing\awake_billing.mdf;Integrated Security=True");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public add_customer()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btn_add_cus_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO cus_info(cname,cmobno,caddress) VALUES('" + tb_cus_name.Text + "','" + tb_cus_mobno.Text + "','" + ta_cus_address.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Customer Added Successfully");
            
            tb_cus_name.Text = "";
            tb_cus_mobno.Text = "";
            ta_cus_address.Text = "";
        }

        private void add_customer_FormClosed(object sender, FormClosedEventArgs e)
        {
                   
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_cus_name.Text = "";
            tb_cus_mobno.Text = "";
            ta_cus_address.Text = "";
        }

        private void add_customer_Load(object sender, EventArgs e)
        {

        }
    }
}
