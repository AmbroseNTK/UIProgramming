namespace W03_05
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
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btViewCalendar = new System.Windows.Forms.Button();
            this.groupCalendar = new System.Windows.Forms.GroupBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDay = new System.Windows.Forms.Label();
            this.lbDayOfWeek = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            this.groupCalendar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(206, 28);
            this.numYear.Maximum = new decimal(new int[] {
            2900,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 38);
            this.numYear.TabIndex = 0;
            this.numYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(206, 119);
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
            this.numMonth.Size = new System.Drawing.Size(120, 38);
            this.numMonth.TabIndex = 1;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(206, 200);
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
            this.numDay.Size = new System.Drawing.Size(120, 38);
            this.numDay.TabIndex = 2;
            this.numDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày";
            // 
            // btViewCalendar
            // 
            this.btViewCalendar.Location = new System.Drawing.Point(51, 287);
            this.btViewCalendar.Name = "btViewCalendar";
            this.btViewCalendar.Size = new System.Drawing.Size(275, 77);
            this.btViewCalendar.TabIndex = 6;
            this.btViewCalendar.Text = "Xem lịch";
            this.btViewCalendar.UseVisualStyleBackColor = true;
            this.btViewCalendar.Click += new System.EventHandler(this.BtViewCalendar_Click);
            // 
            // groupCalendar
            // 
            this.groupCalendar.Controls.Add(this.lbDayOfWeek);
            this.groupCalendar.Controls.Add(this.lbDay);
            this.groupCalendar.Controls.Add(this.lbMonth);
            this.groupCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCalendar.Location = new System.Drawing.Point(512, 89);
            this.groupCalendar.Name = "groupCalendar";
            this.groupCalendar.Size = new System.Drawing.Size(946, 802);
            this.groupCalendar.TabIndex = 1;
            this.groupCalendar.TabStop = false;
            this.groupCalendar.Text = "Lịch năm XXXX";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonth.Location = new System.Drawing.Point(90, 90);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(274, 69);
            this.lbMonth.TabIndex = 0;
            this.lbMonth.Text = "Tháng XX";
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(317, 277);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(248, 272);
            this.lbDay.TabIndex = 1;
            this.lbDay.Text = "1";
            // 
            // lbDayOfWeek
            // 
            this.lbDayOfWeek.AutoSize = true;
            this.lbDayOfWeek.Font = new System.Drawing.Font("Lucida Sans Unicode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDayOfWeek.Location = new System.Drawing.Point(317, 708);
            this.lbDayOfWeek.Name = "lbDayOfWeek";
            this.lbDayOfWeek.Size = new System.Drawing.Size(237, 73);
            this.lbDayOfWeek.TabIndex = 2;
            this.lbDayOfWeek.Text = "Thứ XX";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btViewCalendar);
            this.panel1.Controls.Add(this.numMonth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numDay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 404);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1169);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCalendar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            this.groupCalendar.ResumeLayout(false);
            this.groupCalendar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btViewCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDay;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.GroupBox groupCalendar;
        private System.Windows.Forms.Label lbDayOfWeek;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Panel panel1;
    }
}

