
namespace Picturebox
{
    partial class FrmMAC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtXiMang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhuGia2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhuGia1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCatKho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTroKhoang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lvMAC = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.txtXiMang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPhuGia2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhuGia1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCatKho);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTroKhoang);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMAC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý đơn hàng";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 35);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(247, 411);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(83, 35);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtXiMang
            // 
            this.txtXiMang.Location = new System.Drawing.Point(59, 362);
            this.txtXiMang.Name = "txtXiMang";
            this.txtXiMang.Size = new System.Drawing.Size(142, 22);
            this.txtXiMang.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Xi măng";
            // 
            // txtPhuGia2
            // 
            this.txtPhuGia2.Location = new System.Drawing.Point(59, 300);
            this.txtPhuGia2.Name = "txtPhuGia2";
            this.txtPhuGia2.Size = new System.Drawing.Size(142, 22);
            this.txtPhuGia2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phụ gia 2";
            // 
            // txtPhuGia1
            // 
            this.txtPhuGia1.Location = new System.Drawing.Point(59, 238);
            this.txtPhuGia1.Name = "txtPhuGia1";
            this.txtPhuGia1.Size = new System.Drawing.Size(142, 22);
            this.txtPhuGia1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phụ gia 1";
            // 
            // txtCatKho
            // 
            this.txtCatKho.Location = new System.Drawing.Point(59, 176);
            this.txtCatKho.Name = "txtCatKho";
            this.txtCatKho.Size = new System.Drawing.Size(142, 22);
            this.txtCatKho.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cát khô";
            // 
            // txtTroKhoang
            // 
            this.txtTroKhoang.Location = new System.Drawing.Point(59, 114);
            this.txtTroKhoang.Name = "txtTroKhoang";
            this.txtTroKhoang.Size = new System.Drawing.Size(142, 22);
            this.txtTroKhoang.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tro khoáng";
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(59, 52);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(142, 22);
            this.txtMAC.TabIndex = 2;
            this.txtMAC.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập MAC";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(141, 423);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(83, 35);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // lvMAC
            // 
            this.lvMAC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMAC.FullRowSelect = true;
            this.lvMAC.GridLines = true;
            this.lvMAC.HideSelection = false;
            this.lvMAC.Location = new System.Drawing.Point(384, 12);
            this.lvMAC.Name = "lvMAC";
            this.lvMAC.Size = new System.Drawing.Size(535, 457);
            this.lvMAC.TabIndex = 2;
            this.lvMAC.UseCompatibleStateImageBehavior = false;
            this.lvMAC.View = System.Windows.Forms.View.Details;
            this.lvMAC.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đơn hàng";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tro khoáng";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cát khô";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phụ gia 1";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phụ gia 2";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Xi măng";
            // 
            // FrmMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 490);
            this.Controls.Add(this.lvMAC);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMAC";
            this.Text = "Quản lý nhập MAC";
            this.Load += new System.EventHandler(this.FrmMAC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtXiMang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhuGia2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhuGia1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCatKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTroKhoang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListView lvMAC;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}