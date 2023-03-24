
namespace Picturebox
{
    partial class FrmNormal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cảnhBáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picWarnOff = new System.Windows.Forms.PictureBox();
            this.picAutoOff = new System.Windows.Forms.PictureBox();
            this.picHdOn = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.picWarnOn = new System.Windows.Forms.PictureBox();
            this.picAutoOn = new System.Windows.Forms.PictureBox();
            this.picHdOff = new System.Windows.Forms.PictureBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMAC = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtXiMang = new System.Windows.Forms.TextBox();
            this.txtPhuGia2 = new System.Windows.Forms.TextBox();
            this.txtCatKho = new System.Windows.Forms.TextBox();
            this.txtPhuGia1 = new System.Windows.Forms.TextBox();
            this.txtSoMe = new System.Windows.Forms.TextBox();
            this.txtTroKhoang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHdOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHdOff)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cảnhBáoToolStripMenuItem,
            this.xuấtBáoCáoToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cảnhBáoToolStripMenuItem
            // 
            this.cảnhBáoToolStripMenuItem.Name = "cảnhBáoToolStripMenuItem";
            this.cảnhBáoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cảnhBáoToolStripMenuItem.Text = "Cảnh báo";
            this.cảnhBáoToolStripMenuItem.Click += new System.EventHandler(this.cảnhBáoToolStripMenuItem_Click);
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.picWarnOff);
            this.groupBox1.Controls.Add(this.picAutoOff);
            this.groupBox1.Controls.Add(this.picHdOn);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.picWarnOn);
            this.groupBox1.Controls.Add(this.picAutoOn);
            this.groupBox1.Controls.Add(this.picHdOff);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 278);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẢNG ĐIỀU KHIỂN";
            // 
            // picWarnOff
            // 
            this.picWarnOff.Image = global::Picturebox.Properties.Resources.zyro_image_1_;
            this.picWarnOff.Location = new System.Drawing.Point(310, 147);
            this.picWarnOff.Name = "picWarnOff";
            this.picWarnOff.Size = new System.Drawing.Size(61, 50);
            this.picWarnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarnOff.TabIndex = 11;
            this.picWarnOff.TabStop = false;
            // 
            // picAutoOff
            // 
            this.picAutoOff.Image = global::Picturebox.Properties.Resources.zyro_image_1_;
            this.picAutoOff.Location = new System.Drawing.Point(176, 147);
            this.picAutoOff.Name = "picAutoOff";
            this.picAutoOff.Size = new System.Drawing.Size(61, 50);
            this.picAutoOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAutoOff.TabIndex = 10;
            this.picAutoOff.TabStop = false;
            // 
            // picHdOn
            // 
            this.picHdOn.Image = global::Picturebox.Properties.Resources.zyro_image_2_;
            this.picHdOn.Location = new System.Drawing.Point(48, 147);
            this.picHdOn.Name = "picHdOn";
            this.picHdOn.Size = new System.Drawing.Size(61, 50);
            this.picHdOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHdOn.TabIndex = 9;
            this.picHdOn.TabStop = false;
            this.picHdOn.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Cảnh báo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(161, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Tự động";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Hoạt động";
            // 
            // picWarnOn
            // 
            this.picWarnOn.Image = global::Picturebox.Properties.Resources.zyro_image;
            this.picWarnOn.Location = new System.Drawing.Point(310, 147);
            this.picWarnOn.Name = "picWarnOn";
            this.picWarnOn.Size = new System.Drawing.Size(61, 50);
            this.picWarnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWarnOn.TabIndex = 5;
            this.picWarnOn.TabStop = false;
            this.picWarnOn.Visible = false;
            // 
            // picAutoOn
            // 
            this.picAutoOn.Image = global::Picturebox.Properties.Resources.zyro_image_2_;
            this.picAutoOn.Location = new System.Drawing.Point(176, 147);
            this.picAutoOn.Name = "picAutoOn";
            this.picAutoOn.Size = new System.Drawing.Size(61, 50);
            this.picAutoOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAutoOn.TabIndex = 4;
            this.picAutoOn.TabStop = false;
            this.picAutoOn.Visible = false;
            // 
            // picHdOff
            // 
            this.picHdOff.Image = global::Picturebox.Properties.Resources.zyro_image_1_;
            this.picHdOff.Location = new System.Drawing.Point(48, 147);
            this.picHdOff.Name = "picHdOff";
            this.picHdOff.Size = new System.Drawing.Size(61, 50);
            this.picHdOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHdOff.TabIndex = 3;
            this.picHdOff.TabStop = false;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(145, 52);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(122, 60);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(283, 52);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 60);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(17, 52);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpTime);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbMAC);
            this.groupBox2.Controls.Add(this.btnXacNhan);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtXiMang);
            this.groupBox2.Controls.Add(this.txtPhuGia2);
            this.groupBox2.Controls.Add(this.txtCatKho);
            this.groupBox2.Controls.Add(this.txtPhuGia1);
            this.groupBox2.Controls.Add(this.txtSoMe);
            this.groupBox2.Controls.Add(this.txtTroKhoang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 366);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(268, 255);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(121, 26);
            this.dtpTime.TabIndex = 23;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(48, 256);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 26);
            this.dtpDate.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Thời gian";
            // 
            // cbMAC
            // 
            this.cbMAC.FormattingEnabled = true;
            this.cbMAC.Location = new System.Drawing.Point(48, 38);
            this.cbMAC.Name = "cbMAC";
            this.cbMAC.Size = new System.Drawing.Size(121, 28);
            this.cbMAC.TabIndex = 20;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(145, 293);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(133, 41);
            this.btnXacNhan.TabIndex = 19;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Xi măng";
            // 
            // txtXiMang
            // 
            this.txtXiMang.Location = new System.Drawing.Point(48, 201);
            this.txtXiMang.Name = "txtXiMang";
            this.txtXiMang.Size = new System.Drawing.Size(121, 26);
            this.txtXiMang.TabIndex = 17;
            // 
            // txtPhuGia2
            // 
            this.txtPhuGia2.Location = new System.Drawing.Point(268, 200);
            this.txtPhuGia2.Name = "txtPhuGia2";
            this.txtPhuGia2.Size = new System.Drawing.Size(121, 26);
            this.txtPhuGia2.TabIndex = 16;
            // 
            // txtCatKho
            // 
            this.txtCatKho.Location = new System.Drawing.Point(48, 144);
            this.txtCatKho.Name = "txtCatKho";
            this.txtCatKho.Size = new System.Drawing.Size(121, 26);
            this.txtCatKho.TabIndex = 15;
            // 
            // txtPhuGia1
            // 
            this.txtPhuGia1.Location = new System.Drawing.Point(268, 143);
            this.txtPhuGia1.Name = "txtPhuGia1";
            this.txtPhuGia1.Size = new System.Drawing.Size(121, 26);
            this.txtPhuGia1.TabIndex = 14;
            // 
            // txtSoMe
            // 
            this.txtSoMe.Location = new System.Drawing.Point(268, 91);
            this.txtSoMe.Name = "txtSoMe";
            this.txtSoMe.Size = new System.Drawing.Size(121, 26);
            this.txtSoMe.TabIndex = 13;
            // 
            // txtTroKhoang
            // 
            this.txtTroKhoang.Location = new System.Drawing.Point(48, 92);
            this.txtTroKhoang.Name = "txtTroKhoang";
            this.txtTroKhoang.Size = new System.Drawing.Size(121, 26);
            this.txtTroKhoang.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tro khoáng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cát khô";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phụ gia 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phụ gia 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số mẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAC";
            // 
            // FrmNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Picturebox.Properties.Resources.test3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1700, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNormal";
            this.Text = "Giao diện người giám sát";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNormal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHdOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarnOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAutoOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHdOff)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cảnhBáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picWarnOff;
        private System.Windows.Forms.PictureBox picAutoOff;
        private System.Windows.Forms.PictureBox picHdOn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picWarnOn;
        private System.Windows.Forms.PictureBox picAutoOn;
        private System.Windows.Forms.PictureBox picHdOff;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMAC;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXiMang;
        private System.Windows.Forms.TextBox txtPhuGia2;
        private System.Windows.Forms.TextBox txtCatKho;
        private System.Windows.Forms.TextBox txtPhuGia1;
        private System.Windows.Forms.TextBox txtSoMe;
        private System.Windows.Forms.TextBox txtTroKhoang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
    }
}