namespace W03_02
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
            this.lbFlag = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupCountries = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.pictureFlag = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFlag
            // 
            this.lbFlag.AutoSize = true;
            this.lbFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFlag.Location = new System.Drawing.Point(600, 48);
            this.lbFlag.Name = "lbFlag";
            this.lbFlag.Size = new System.Drawing.Size(181, 69);
            this.lbFlag.TabIndex = 0;
            this.lbFlag.Text = "Flags";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbFlag);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1454, 179);
            this.panel1.TabIndex = 1;
            // 
            // groupCountries
            // 
            this.groupCountries.Controls.Add(this.radioButton5);
            this.groupCountries.Controls.Add(this.radioButton4);
            this.groupCountries.Controls.Add(this.radioButton3);
            this.groupCountries.Controls.Add(this.radioButton2);
            this.groupCountries.Controls.Add(this.radioButton1);
            this.groupCountries.Location = new System.Drawing.Point(30, 218);
            this.groupCountries.Name = "groupCountries";
            this.groupCountries.Size = new System.Drawing.Size(430, 682);
            this.groupCountries.TabIndex = 2;
            this.groupCountries.TabStop = false;
            this.groupCountries.Text = "Countries";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 57);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a4/Flag_of_the_United_Stat" +
    "es.svg/250px-Flag_of_the_United_States.svg.png";
            this.radioButton1.Text = "USA";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/03/Flag_of_Italy.svg/250px" +
    "-Flag_of_Italy.svg.png";
            this.radioButton2.Text = "Italy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(20, 185);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(212, 36);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f2/Flag_of_Great_Britain_%" +
    "281707%E2%80%931800%29.svg/1200px-Flag_of_Great_Britain_%281707%E2%80%931800%29." +
    "svg.png";
            this.radioButton3.Text = "Great Britain";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 313);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(157, 36);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "https://flagpolefarm.com/wp-content/uploads/2018/01/vietnam-flag-3.jpg";
            this.radioButton4.Text = "Vietnam";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(21, 252);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(158, 36);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "https://upload.wikimedia.org/wikipedia/en/thumb/b/be/Flag_of_England.svg/1200px-F" +
    "lag_of_England.svg.png";
            this.radioButton5.Text = "England";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // pictureFlag
            // 
            this.pictureFlag.Location = new System.Drawing.Point(525, 218);
            this.pictureFlag.Name = "pictureFlag";
            this.pictureFlag.Size = new System.Drawing.Size(743, 682);
            this.pictureFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFlag.TabIndex = 3;
            this.pictureFlag.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 1192);
            this.Controls.Add(this.pictureFlag);
            this.Controls.Add(this.groupCountries);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupCountries.ResumeLayout(false);
            this.groupCountries.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFlag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupCountries;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox pictureFlag;
    }
}

