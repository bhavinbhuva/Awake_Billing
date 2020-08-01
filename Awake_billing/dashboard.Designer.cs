namespace Awake_billing
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Invoice = new System.Windows.Forms.TabPage();
            this.dg_item_list = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.cb_gst = new System.Windows.Forms.ComboBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_item_del = new System.Windows.Forms.Button();
            this.dp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_item_add = new System.Windows.Forms.Button();
            this.pan_add = new System.Windows.Forms.Panel();
            this.ta_address = new System.Windows.Forms.RichTextBox();
            this.btn_manage = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_cno = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_gtotal = new System.Windows.Forms.TextBox();
            this.tb_discount = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.tb_amount = new System.Windows.Forms.TextBox();
            this.lbl_disp_name = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_invoiceno = new System.Windows.Forms.TextBox();
            this.tb_item_name = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.printing = new System.Windows.Forms.TabPage();
            this.cash_memo = new System.Windows.Forms.TabPage();
            this.credit_note = new System.Windows.Forms.TabPage();
            this.cus_statement = new System.Windows.Forms.TabPage();
            this.manage = new System.Windows.Forms.TabPage();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_item_list)).BeginInit();
            this.pan_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_minimize);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "National Electric";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackgroundImage = global::Awake_billing.Properties.Resources.minimize_s;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Location = new System.Drawing.Point(970, 8);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Awake_billing.Properties.Resources.close_s;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(1006, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 536);
            this.panel2.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Awake_billing.Properties.Resources.customer;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 325);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button6.Size = new System.Drawing.Size(178, 50);
            this.button6.TabIndex = 0;
            this.button6.TabStop = false;
            this.button6.Text = "Manage\r\nCustomer \r\n";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Awake_billing.Properties.Resources.statement;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(11, 270);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button5.Size = new System.Drawing.Size(178, 50);
            this.button5.TabIndex = 0;
            this.button5.TabStop = false;
            this.button5.Text = "Customer \r\nStatement";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Awake_billing.Properties.Resources.creditnote;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(11, 214);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(178, 50);
            this.button4.TabIndex = 0;
            this.button4.TabStop = false;
            this.button4.Text = "Credit Note";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Awake_billing.Properties.Resources.printer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(11, 158);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(178, 50);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.Text = "Printing";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Awake_billing.Properties.Resources.memo;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 102);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button3.Size = new System.Drawing.Size(178, 50);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.Text = "Cash Memo";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button1.Size = new System.Drawing.Size(178, 50);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Invoice";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.Invoice);
            this.materialTabControl1.Controls.Add(this.printing);
            this.materialTabControl1.Controls.Add(this.cash_memo);
            this.materialTabControl1.Controls.Add(this.credit_note);
            this.materialTabControl1.Controls.Add(this.cus_statement);
            this.materialTabControl1.Controls.Add(this.manage);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(192, 40);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(848, 536);
            this.materialTabControl1.TabIndex = 0;
            // 
            // Invoice
            // 
            this.Invoice.BackColor = System.Drawing.Color.White;
            this.Invoice.Controls.Add(this.dg_item_list);
            this.Invoice.Controls.Add(this.btn_cancle);
            this.Invoice.Controls.Add(this.cb_gst);
            this.Invoice.Controls.Add(this.btn_print);
            this.Invoice.Controls.Add(this.btn_item_del);
            this.Invoice.Controls.Add(this.dp_date);
            this.Invoice.Controls.Add(this.btn_item_add);
            this.Invoice.Controls.Add(this.pan_add);
            this.Invoice.Controls.Add(this.materialDivider1);
            this.Invoice.Controls.Add(this.bunifuSeparator2);
            this.Invoice.Controls.Add(this.bunifuSeparator1);
            this.Invoice.Controls.Add(this.materialLabel8);
            this.Invoice.Controls.Add(this.materialLabel7);
            this.Invoice.Controls.Add(this.materialLabel13);
            this.Invoice.Controls.Add(this.materialLabel12);
            this.Invoice.Controls.Add(this.materialLabel11);
            this.Invoice.Controls.Add(this.materialLabel10);
            this.Invoice.Controls.Add(this.materialLabel9);
            this.Invoice.Controls.Add(this.tb_gtotal);
            this.Invoice.Controls.Add(this.tb_discount);
            this.Invoice.Controls.Add(this.tb_total);
            this.Invoice.Controls.Add(this.tb_amount);
            this.Invoice.Controls.Add(this.lbl_disp_name);
            this.Invoice.Controls.Add(this.materialLabel14);
            this.Invoice.Controls.Add(this.materialLabel6);
            this.Invoice.Controls.Add(this.tb_price);
            this.Invoice.Controls.Add(this.tb_quantity);
            this.Invoice.Controls.Add(this.tb_invoiceno);
            this.Invoice.Controls.Add(this.tb_item_name);
            this.Invoice.Controls.Add(this.materialLabel5);
            this.Invoice.Controls.Add(this.materialLabel4);
            this.Invoice.Location = new System.Drawing.Point(4, 4);
            this.Invoice.Name = "Invoice";
            this.Invoice.Padding = new System.Windows.Forms.Padding(3);
            this.Invoice.Size = new System.Drawing.Size(840, 510);
            this.Invoice.TabIndex = 0;
            this.Invoice.Text = "invoice";
            // 
            // dg_item_list
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dg_item_list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_item_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_item_list.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dg_item_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_item_list.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_item_list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_item_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_item_list.ColumnHeadersHeight = 30;
            this.dg_item_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.qty,
            this.price,
            this.amount});
            this.dg_item_list.DoubleBuffered = true;
            this.dg_item_list.EnableHeadersVisualStyles = false;
            this.dg_item_list.HeaderBgColor = System.Drawing.SystemColors.HotTrack;
            this.dg_item_list.HeaderForeColor = System.Drawing.Color.White;
            this.dg_item_list.Location = new System.Drawing.Point(20, 177);
            this.dg_item_list.Name = "dg_item_list";
            this.dg_item_list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_item_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_item_list.RowHeadersVisible = false;
            this.dg_item_list.Size = new System.Drawing.Size(557, 246);
            this.dg_item_list.TabIndex = 10;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Item Name";
            this.item_name.Name = "item_name";
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty.";
            this.qty.Name = "qty";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_cancle.Location = new System.Drawing.Point(637, 485);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(145, 32);
            this.btn_cancle.TabIndex = 0;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // cb_gst
            // 
            this.cb_gst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_gst.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gst.FormattingEnabled = true;
            this.cb_gst.Items.AddRange(new object[] {
            "GST 9%",
            "GST 6%"});
            this.cb_gst.Location = new System.Drawing.Point(721, 266);
            this.cb_gst.Name = "cb_gst";
            this.cb_gst.Size = new System.Drawing.Size(87, 27);
            this.cb_gst.TabIndex = 3;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_print.Location = new System.Drawing.Point(452, 485);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(145, 32);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_item_del
            // 
            this.btn_item_del.BackColor = System.Drawing.Color.Red;
            this.btn_item_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_item_del.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_del.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_item_del.Image = global::Awake_billing.Properties.Resources.trash;
            this.btn_item_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_item_del.Location = new System.Drawing.Point(721, 385);
            this.btn_item_del.Name = "btn_item_del";
            this.btn_item_del.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_item_del.Size = new System.Drawing.Size(87, 38);
            this.btn_item_del.TabIndex = 0;
            this.btn_item_del.Text = "DEL";
            this.btn_item_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_item_del.UseVisualStyleBackColor = false;
            this.btn_item_del.Click += new System.EventHandler(this.btn_item_del_Click);
            // 
            // dp_date
            // 
            this.dp_date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_date.Location = new System.Drawing.Point(647, 104);
            this.dp_date.Name = "dp_date";
            this.dp_date.Size = new System.Drawing.Size(176, 27);
            this.dp_date.TabIndex = 2;
            this.dp_date.Value = new System.DateTime(2020, 7, 25, 0, 0, 0, 0);
            // 
            // btn_item_add
            // 
            this.btn_item_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_item_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_item_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_item_add.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_item_add.Image = global::Awake_billing.Properties.Resources.plus_w;
            this.btn_item_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_item_add.Location = new System.Drawing.Point(613, 385);
            this.btn_item_add.Name = "btn_item_add";
            this.btn_item_add.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_item_add.Size = new System.Drawing.Size(87, 38);
            this.btn_item_add.TabIndex = 0;
            this.btn_item_add.Text = "ADD";
            this.btn_item_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_item_add.UseVisualStyleBackColor = false;
            this.btn_item_add.Click += new System.EventHandler(this.btn_item_add_Click);
            // 
            // pan_add
            // 
            this.pan_add.Controls.Add(this.ta_address);
            this.pan_add.Controls.Add(this.btn_manage);
            this.pan_add.Controls.Add(this.btn_add);
            this.pan_add.Controls.Add(this.comboBox1);
            this.pan_add.Controls.Add(this.materialLabel1);
            this.pan_add.Controls.Add(this.tb_cno);
            this.pan_add.Controls.Add(this.materialLabel3);
            this.pan_add.Controls.Add(this.materialLabel2);
            this.pan_add.Location = new System.Drawing.Point(6, 6);
            this.pan_add.Name = "pan_add";
            this.pan_add.Size = new System.Drawing.Size(609, 132);
            this.pan_add.TabIndex = 9;
            // 
            // ta_address
            // 
            this.ta_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ta_address.Enabled = false;
            this.ta_address.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_address.Location = new System.Drawing.Point(242, 35);
            this.ta_address.Name = "ta_address";
            this.ta_address.Size = new System.Drawing.Size(185, 84);
            this.ta_address.TabIndex = 3;
            this.ta_address.Text = "";
            // 
            // btn_manage
            // 
            this.btn_manage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage.ForeColor = System.Drawing.Color.White;
            this.btn_manage.Location = new System.Drawing.Point(446, 87);
            this.btn_manage.Name = "btn_manage";
            this.btn_manage.Size = new System.Drawing.Size(145, 32);
            this.btn_manage.TabIndex = 0;
            this.btn_manage.Text = "Add Customer";
            this.btn_manage.UseVisualStyleBackColor = false;
            this.btn_manage.Click += new System.EventHandler(this.btn_manage_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(446, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(145, 32);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Select";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(14, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 27);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 15);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Name :";
            // 
            // tb_cno
            // 
            this.tb_cno.Enabled = false;
            this.tb_cno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cno.Location = new System.Drawing.Point(14, 92);
            this.tb_cno.Name = "tb_cno";
            this.tb_cno.Size = new System.Drawing.Size(195, 27);
            this.tb_cno.TabIndex = 2;
            this.tb_cno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cno_KeyPress);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(10, 70);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(87, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Mobile No :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(238, 15);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Address :";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(621, 6);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(10, 132);
            this.materialDivider1.TabIndex = 0;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 429);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(844, 35);
            this.bunifuSeparator2.TabIndex = 0;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 124);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(844, 35);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(717, 241);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(37, 19);
            this.materialLabel8.TabIndex = 0;
            this.materialLabel8.Text = "GST";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(609, 243);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(72, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Quantity :";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(275, 467);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(95, 19);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Grand Total :";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(153, 467);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(98, 19);
            this.materialLabel12.TabIndex = 0;
            this.materialLabel12.Text = "Discount(%) :";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(16, 467);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(52, 19);
            this.materialLabel11.TabIndex = 0;
            this.materialLabel11.Text = "Total :";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(717, 299);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(70, 19);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "Amount :";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(609, 299);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(51, 19);
            this.materialLabel9.TabIndex = 0;
            this.materialLabel9.Text = "Price :";
            // 
            // tb_gtotal
            // 
            this.tb_gtotal.Enabled = false;
            this.tb_gtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gtotal.Location = new System.Drawing.Point(279, 489);
            this.tb_gtotal.Name = "tb_gtotal";
            this.tb_gtotal.Size = new System.Drawing.Size(115, 27);
            this.tb_gtotal.TabIndex = 5;
            this.tb_gtotal.Text = "0";
            // 
            // tb_discount
            // 
            this.tb_discount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_discount.Location = new System.Drawing.Point(157, 489);
            this.tb_discount.Name = "tb_discount";
            this.tb_discount.Size = new System.Drawing.Size(94, 27);
            this.tb_discount.TabIndex = 5;
            this.tb_discount.Text = "0";
            // 
            // tb_total
            // 
            this.tb_total.Enabled = false;
            this.tb_total.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(20, 489);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(115, 27);
            this.tb_total.TabIndex = 5;
            this.tb_total.Text = "0";
            // 
            // tb_amount
            // 
            this.tb_amount.Enabled = false;
            this.tb_amount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_amount.Location = new System.Drawing.Point(721, 321);
            this.tb_amount.Name = "tb_amount";
            this.tb_amount.Size = new System.Drawing.Size(87, 27);
            this.tb_amount.TabIndex = 5;
            this.tb_amount.Text = "0";
            // 
            // lbl_disp_name
            // 
            this.lbl_disp_name.AutoSize = true;
            this.lbl_disp_name.Depth = 0;
            this.lbl_disp_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_disp_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_disp_name.Location = new System.Drawing.Point(143, 157);
            this.lbl_disp_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_disp_name.Name = "lbl_disp_name";
            this.lbl_disp_name.Size = new System.Drawing.Size(97, 19);
            this.lbl_disp_name.TabIndex = 0;
            this.lbl_disp_name.Text = "display name";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(16, 158);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(127, 19);
            this.materialLabel14.TabIndex = 0;
            this.materialLabel14.Text = "Customer Name :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(609, 187);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(91, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Item Name :";
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(613, 322);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(87, 27);
            this.tb_price.TabIndex = 4;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(613, 266);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(87, 27);
            this.tb_quantity.TabIndex = 2;
            this.tb_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_quantity_KeyPress);
            // 
            // tb_invoiceno
            // 
            this.tb_invoiceno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_invoiceno.Location = new System.Drawing.Point(647, 46);
            this.tb_invoiceno.Name = "tb_invoiceno";
            this.tb_invoiceno.Size = new System.Drawing.Size(176, 27);
            this.tb_invoiceno.TabIndex = 1;
            this.tb_invoiceno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_invoiceno_KeyPress);
            // 
            // tb_item_name
            // 
            this.tb_item_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item_name.Location = new System.Drawing.Point(613, 210);
            this.tb_item_name.Name = "tb_item_name";
            this.tb_item_name.Size = new System.Drawing.Size(195, 27);
            this.tb_item_name.TabIndex = 1;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(643, 82);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(48, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Date :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(643, 21);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Invoice No :";
            // 
            // printing
            // 
            this.printing.BackColor = System.Drawing.Color.White;
            this.printing.Location = new System.Drawing.Point(4, 4);
            this.printing.Name = "printing";
            this.printing.Padding = new System.Windows.Forms.Padding(3);
            this.printing.Size = new System.Drawing.Size(840, 510);
            this.printing.TabIndex = 1;
            this.printing.Text = "Printing";
            // 
            // cash_memo
            // 
            this.cash_memo.BackColor = System.Drawing.Color.White;
            this.cash_memo.Location = new System.Drawing.Point(4, 4);
            this.cash_memo.Name = "cash_memo";
            this.cash_memo.Padding = new System.Windows.Forms.Padding(3);
            this.cash_memo.Size = new System.Drawing.Size(840, 510);
            this.cash_memo.TabIndex = 2;
            this.cash_memo.Text = "Cash Memo";
            // 
            // credit_note
            // 
            this.credit_note.BackColor = System.Drawing.Color.White;
            this.credit_note.Location = new System.Drawing.Point(4, 4);
            this.credit_note.Name = "credit_note";
            this.credit_note.Size = new System.Drawing.Size(840, 510);
            this.credit_note.TabIndex = 3;
            this.credit_note.Text = "Credit Note";
            // 
            // cus_statement
            // 
            this.cus_statement.BackColor = System.Drawing.Color.White;
            this.cus_statement.Location = new System.Drawing.Point(4, 4);
            this.cus_statement.Name = "cus_statement";
            this.cus_statement.Size = new System.Drawing.Size(840, 510);
            this.cus_statement.TabIndex = 4;
            this.cus_statement.Text = "Customer Statement";
            // 
            // manage
            // 
            this.manage.Location = new System.Drawing.Point(4, 4);
            this.manage.Name = "manage";
            this.manage.Padding = new System.Windows.Forms.Padding(3);
            this.manage.Size = new System.Drawing.Size(840, 510);
            this.manage.TabIndex = 5;
            this.manage.Text = "Manage Customer";
            this.manage.UseVisualStyleBackColor = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dg_item_list;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 576);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.Invoice.ResumeLayout(false);
            this.Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_item_list)).EndInit();
            this.pan_add.ResumeLayout(false);
            this.pan_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage Invoice;
        private System.Windows.Forms.TabPage printing;
        private System.Windows.Forms.TabPage cash_memo;
        private System.Windows.Forms.TabPage credit_note;
        private System.Windows.Forms.TabPage cus_statement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox ta_address;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TextBox tb_cno;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pan_add;
        private System.Windows.Forms.Button btn_manage;
        private System.Windows.Forms.DateTimePicker dp_date;
        private System.Windows.Forms.TextBox tb_item_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox cb_gst;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox tb_quantity;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TextBox tb_price;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TextBox tb_amount;
        private System.Windows.Forms.TextBox tb_invoiceno;
        private System.Windows.Forms.Button btn_item_del;
        private System.Windows.Forms.Button btn_item_add;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dg_item_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox tb_gtotal;
        private System.Windows.Forms.TextBox tb_discount;
        private System.Windows.Forms.TextBox tb_total;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_print;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private MaterialSkin.Controls.MaterialLabel lbl_disp_name;
        private System.Windows.Forms.TabPage manage;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}