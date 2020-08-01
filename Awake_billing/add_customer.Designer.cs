namespace Awake_billing
{
    partial class add_customer
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.tb_cus_name = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_cus_mobno = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ta_cus_address = new System.Windows.Forms.RichTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add_cus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(46)))), ((int)(((byte)(97)))));
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(309, 40);
            this.pnl_top.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Customer";
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::Awake_billing.Properties.Resources.close_s;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(272, 9);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // tb_cus_name
            // 
            this.tb_cus_name.BackColor = System.Drawing.Color.White;
            this.tb_cus_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cus_name.Location = new System.Drawing.Point(59, 92);
            this.tb_cus_name.Name = "tb_cus_name";
            this.tb_cus_name.Size = new System.Drawing.Size(195, 27);
            this.tb_cus_name.TabIndex = 1;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(55, 70);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(127, 19);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Customer Name :";
            // 
            // tb_cus_mobno
            // 
            this.tb_cus_mobno.BackColor = System.Drawing.Color.White;
            this.tb_cus_mobno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cus_mobno.Location = new System.Drawing.Point(59, 144);
            this.tb_cus_mobno.Name = "tb_cus_mobno";
            this.tb_cus_mobno.Size = new System.Drawing.Size(195, 27);
            this.tb_cus_mobno.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(55, 122);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(87, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mobile No :";
            // 
            // ta_cus_address
            // 
            this.ta_cus_address.BackColor = System.Drawing.Color.White;
            this.ta_cus_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ta_cus_address.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta_cus_address.Location = new System.Drawing.Point(59, 196);
            this.ta_cus_address.Name = "ta_cus_address";
            this.ta_cus_address.Size = new System.Drawing.Size(195, 84);
            this.ta_cus_address.TabIndex = 3;
            this.ta_cus_address.Text = "";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(55, 174);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Address :";
            // 
            // btn_add_cus
            // 
            this.btn_add_cus.BackColor = System.Drawing.Color.Navy;
            this.btn_add_cus.FlatAppearance.BorderSize = 0;
            this.btn_add_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_cus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_cus.ForeColor = System.Drawing.Color.White;
            this.btn_add_cus.Location = new System.Drawing.Point(59, 293);
            this.btn_add_cus.Name = "btn_add_cus";
            this.btn_add_cus.Size = new System.Drawing.Size(195, 32);
            this.btn_add_cus.TabIndex = 4;
            this.btn_add_cus.Text = "ADD";
            this.btn_add_cus.UseVisualStyleBackColor = false;
            this.btn_add_cus.Click += new System.EventHandler(this.btn_add_cus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(59, 331);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(195, 32);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_top;
            this.bunifuDragControl1.Vertical = true;
            // 
            // add_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(309, 394);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_cus);
            this.Controls.Add(this.ta_cus_address);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tb_cus_mobno);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.tb_cus_name);
            this.Controls.Add(this.pnl_top);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_customer";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "add_customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_customer_FormClosed);
            this.Load += new System.EventHandler(this.add_customer_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cus_name;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox tb_cus_mobno;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.RichTextBox ta_cus_address;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Button btn_add_cus;
        private System.Windows.Forms.Button btn_clear;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}