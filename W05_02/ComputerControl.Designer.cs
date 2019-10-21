namespace W05_02
{
    partial class ComputerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.btEnd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Google Sans Display", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Computer 01";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::W05_02.Properties.Resources.responsive;
            this.pictureBox1.Location = new System.Drawing.Point(3, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Google Sans Display", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(494, 103);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(202, 69);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Google Sans Display", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStart.Location = new System.Drawing.Point(744, 103);
            this.tbStart.Name = "tbStart";
            this.tbStart.ReadOnly = true;
            this.tbStart.Size = new System.Drawing.Size(398, 66);
            this.tbStart.TabIndex = 2;
            // 
            // tbEnd
            // 
            this.tbEnd.Font = new System.Drawing.Font("Google Sans Display", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnd.Location = new System.Drawing.Point(744, 201);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.ReadOnly = true;
            this.tbEnd.Size = new System.Drawing.Size(398, 66);
            this.tbEnd.TabIndex = 4;
            // 
            // btEnd
            // 
            this.btEnd.Font = new System.Drawing.Font("Google Sans Display", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(494, 201);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(202, 69);
            this.btEnd.TabIndex = 3;
            this.btEnd.Text = "End";
            this.btEnd.UseVisualStyleBackColor = true;
            // 
            // ComputerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "ComputerControl";
            this.Size = new System.Drawing.Size(1223, 371);
            this.Load += new System.EventHandler(this.ComputerControl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Button btEnd;
    }
}
