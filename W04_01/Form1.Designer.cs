namespace W04_01
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
            this.adsBox1 = new W04_01.AdsBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btDK = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.cbJob = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.SuspendLayout();
            // 
            // adsBox1
            // 
            this.adsBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adsBox1.DisplayText = "";
            this.adsBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.adsBox1.Font = new System.Drawing.Font("Google Sans Display", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adsBox1.ForeColor = System.Drawing.Color.OrangeRed;
            this.adsBox1.Location = new System.Drawing.Point(0, 0);
            this.adsBox1.Margin = new System.Windows.Forms.Padding(4);
            this.adsBox1.Name = "adsBox1";
            this.adsBox1.Size = new System.Drawing.Size(1673, 128);
            this.adsBox1.TabIndex = 0;
            this.adsBox1.Velocity = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã số KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1137, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 576);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 50);
            this.label6.TabIndex = 6;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Google Sans Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 701);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 50);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nghề nghiệp";
            // 
            // btDK
            // 
            this.btDK.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDK.Location = new System.Drawing.Point(346, 874);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(224, 60);
            this.btDK.TabIndex = 8;
            this.btDK.Text = "Đăng ký";
            this.btDK.UseVisualStyleBackColor = true;
            this.btDK.Click += new System.EventHandler(this.BtDK_Click);
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(599, 874);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(224, 60);
            this.btNew.TabIndex = 9;
            this.btNew.Text = "Nhập mới";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.BtNew_Click);
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(852, 874);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(224, 60);
            this.btEnd.TabIndex = 10;
            this.btEnd.Text = "Tổng kết";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.BtEnd_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1105, 874);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(224, 60);
            this.btExit.TabIndex = 11;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(346, 201);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(1174, 49);
            this.tbID.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(346, 326);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(1174, 49);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(346, 580);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1174, 49);
            this.tbAddress.TabIndex = 6;
            // 
            // numDay
            // 
            this.numDay.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDay.Location = new System.Drawing.Point(346, 456);
            this.numDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(215, 49);
            this.numDay.TabIndex = 3;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMonth.Location = new System.Drawing.Point(712, 456);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(419, 49);
            this.numMonth.TabIndex = 4;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numYear
            // 
            this.numYear.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numYear.Location = new System.Drawing.Point(1251, 456);
            this.numYear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(269, 49);
            this.numYear.TabIndex = 5;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // cbJob
            // 
            this.cbJob.Font = new System.Drawing.Font("Google Sans Display", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Items.AddRange(new object[] {
            "Lao công",
            "IT",
            "Designer",
            "Giám đốc",
            "Chủ tịch"});
            this.cbJob.Location = new System.Drawing.Point(346, 710);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(1174, 49);
            this.cbJob.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 1016);
            this.Controls.Add(this.cbJob);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.numMonth);
            this.Controls.Add(this.numDay);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btDK);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adsBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdsBox adsBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDK;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.ComboBox cbJob;
    }
}

