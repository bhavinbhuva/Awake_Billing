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
    public partial class dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bhavin\source\repos\Awake_Billing\Awake_billing\awake_billing.mdf;Integrated Security=True");
        String cname = "";
        //int cid = 0;
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
        public dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            Fillcombo();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            Fillcombo();

            comboBox1.Text = "";
            lbl_disp_name.Text = "";
            dp_date.Value = DateTime.Today;
        }
        public void Fillcombo()
        {
            comboBox1.Text = "";
            try
            {
                con.Open();
                string query1 = "select * from cus_info";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader dr1;
                Dictionary<int,string> userListDictionary = new Dictionary<int,string>();
                comboBox1.DisplayMember = "Value";
                comboBox1.ValueMember = "Key";
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {

                    userListDictionary.Add(dr1.GetInt32(0), dr1.GetString(1));

                }
                comboBox1.DataSource = new BindingSource(userListDictionary, null);
                con.Close();
                comboBox1.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("error "+ex.Message);
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //nav btn start
        private void button1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(0);

            //active tab set
            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(30, 46, 97);
            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice_b);

            //other tab reset
            button2.BackColor = SystemColors.HotTrack;
            button3.BackColor = SystemColors.HotTrack;
            button4.BackColor = SystemColors.HotTrack;
            button5.BackColor = SystemColors.HotTrack;
            button6.BackColor = SystemColors.HotTrack;

            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;

            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.statement);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(1);

            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(30, 46, 97);
            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer_b);

            button1.BackColor = SystemColors.HotTrack;
            button3.BackColor = SystemColors.HotTrack;
            button4.BackColor = SystemColors.HotTrack;
            button5.BackColor = SystemColors.HotTrack;
            button6.BackColor = SystemColors.HotTrack;

            button1.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;

            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.statement);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(2);

            button3.BackColor = Color.White;
            button3.ForeColor = Color.FromArgb(30, 46, 97);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo_b);

            button1.BackColor = SystemColors.HotTrack;
            button2.BackColor = SystemColors.HotTrack;
            button4.BackColor = SystemColors.HotTrack;
            button5.BackColor = SystemColors.HotTrack;
            button6.BackColor = SystemColors.HotTrack;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;

            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice);
            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.statement);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(3);

            button4.BackColor = Color.White;
            button4.ForeColor = Color.FromArgb(30, 46, 97);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote_b);

            button1.BackColor = SystemColors.HotTrack;
            button2.BackColor = SystemColors.HotTrack;
            button3.BackColor = SystemColors.HotTrack;
            button5.BackColor = SystemColors.HotTrack;
            button6.BackColor = SystemColors.HotTrack;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;


            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice);
            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.statement);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(4);

            button5.BackColor = Color.White;
            button5.ForeColor = Color.FromArgb(30, 46, 97);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.statement_b);

            button1.BackColor = SystemColors.HotTrack;
            button2.BackColor = SystemColors.HotTrack;
            button3.BackColor = SystemColors.HotTrack;
            button4.BackColor = SystemColors.HotTrack;
            button6.BackColor = SystemColors.HotTrack;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button6.ForeColor = Color.White;

            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice);
            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectTab(5);

            button6.BackColor = Color.White;
            button6.ForeColor = Color.FromArgb(30, 46, 97);
            button6.Image = new Bitmap(Awake_billing.Properties.Resources.customer_b);

            button1.BackColor = SystemColors.HotTrack;
            button2.BackColor = SystemColors.HotTrack;
            button3.BackColor = SystemColors.HotTrack;
            button4.BackColor = SystemColors.HotTrack;
            button5.BackColor = SystemColors.HotTrack;

            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;

            button1.Image = new Bitmap(Awake_billing.Properties.Resources.invoice);
            button2.Image = new Bitmap(Awake_billing.Properties.Resources.printer);
            button3.Image = new Bitmap(Awake_billing.Properties.Resources.memo);
            button4.Image = new Bitmap(Awake_billing.Properties.Resources.creditnote);
            button5.Image = new Bitmap(Awake_billing.Properties.Resources.customer);
        }
        //nav btn end
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex != -1)
            {
                String cid = comboBox1.SelectedValue.ToString();
                if (comboBox1.SelectedValue.ToString() == "1")
                {
                    tb_cno.Text = "";
                    ta_address.Text = "";
                }
                else
                {
                    con.Close();
                    con.Open();
                    String query = "SELECT * from cus_info WHERE cid =" + cid;
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr;
                    try
                    {
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            tb_cno.Text = dr.GetString(2);
                            ta_address.Text = dr.GetString(3);

                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lbl_disp_name.Text = comboBox1.Text.ToString();
            cname = comboBox1.Text.ToString();
            //cid = comboBox1.SelectedValue.ToString();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            add_customer add_cus = new add_customer();
            add_cus.ShowDialog();
            if(add_cus.DialogResult.Equals(DialogResult.OK))
            {
                Fillcombo();
            }
        }

        private void btn_item_add_Click(object sender, EventArgs e)
        {
            Fillcombo();
        }

        private void btn_item_del_Click(object sender, EventArgs e)
        {

        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {

        }

        private void tb_cno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_invoiceno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
