namespace W02_04
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSV = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSVName = new System.Windows.Forms.TextBox();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btReEnter = new System.Windows.Forms.Button();
            this.btCheckout = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTongKH = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "iCoffee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSVName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1667, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // cbSV
            // 
            this.cbSV.AutoSize = true;
            this.cbSV.Location = new System.Drawing.Point(192, 127);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(171, 36);
            this.cbSV.TabIndex = 2;
            this.cbSV.Text = "Sinh viên";
            this.cbSV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên KH";
            // 
            // tbSVName
            // 
            this.tbSVName.Location = new System.Drawing.Point(192, 63);
            this.tbSVName.Name = "tbSVName";
            this.tbSVName.Size = new System.Drawing.Size(528, 38);
            this.tbSVName.TabIndex = 0;
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.radioButton5);
            this.groupMenu.Controls.Add(this.radioButton4);
            this.groupMenu.Controls.Add(this.radioButton3);
            this.groupMenu.Controls.Add(this.radioButton2);
            this.groupMenu.Controls.Add(this.radioButton1);
            this.groupMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMenu.Location = new System.Drawing.Point(0, 310);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(1667, 227);
            this.groupMenu.TabIndex = 2;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "Menu";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(147, 161);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(177, 36);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "35";
            this.radioButton5.Text = "Cafe Kem";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(420, 102);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(213, 36);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "30";
            this.radioButton4.Text = "Cafe Sữa Đá";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(420, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(170, 36);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "25";
            this.radioButton3.Text = "Cafe Sữa";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(148, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(155, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "25";
            this.radioButton2.Text = "Cafe Đá";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(147, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(171, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "20";
            this.radioButton1.Text = "Cafe Đen";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExit);
            this.groupBox3.Controls.Add(this.btReEnter);
            this.groupBox3.Controls.Add(this.btCheckout);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 537);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1667, 150);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(574, 60);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(166, 64);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // btReEnter
            // 
            this.btReEnter.Location = new System.Drawing.Point(358, 60);
            this.btReEnter.Name = "btReEnter";
            this.btReEnter.Size = new System.Drawing.Size(166, 64);
            this.btReEnter.TabIndex = 1;
            this.btReEnter.Text = "Nhập lại";
            this.btReEnter.UseVisualStyleBackColor = true;
            this.btReEnter.Click += new System.EventHandler(this.BtReEnter_Click);
            // 
            // btCheckout
            // 
            this.btCheckout.Location = new System.Drawing.Point(147, 60);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(166, 64);
            this.btCheckout.TabIndex = 0;
            this.btCheckout.Text = "Tính tiền";
            this.btCheckout.UseVisualStyleBackColor = true;
            this.btCheckout.Click += new System.EventHandler(this.BtCheckout_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbTongTien);
            this.groupBox4.Controls.Add(this.lbTongKH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 687);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1667, 349);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thanh toán";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(137, 190);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(278, 61);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "Tổng Tiền:";
            // 
            // lbTongKH
            // 
            this.lbTongKH.AutoSize = true;
            this.lbTongKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongKH.Location = new System.Drawing.Point(136, 79);
            this.lbTongKH.Name = "lbTongKH";
            this.lbTongKH.Size = new System.Drawing.Size(248, 61);
            this.lbTongKH.TabIndex = 0;
            this.lbTongKH.Text = "Tổng KH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 1065);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSVName;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btReEnter;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbTongKH;
    }
}

