namespace SimplePaint
{
    partial class SampleDialog
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
            this.panelRed = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGreen = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBlue = new System.Windows.Forms.FlowLayoutPanel();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(64, 138);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(120, 120);
            this.panelRed.TabIndex = 0;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(244, 138);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(120, 120);
            this.panelGreen.TabIndex = 1;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(413, 138);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(120, 120);
            this.panelBlue.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(64, 343);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(182, 59);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "Ok";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.BtOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(351, 343);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(182, 59);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // SampleDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 444);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.panelBlue);
            this.Controls.Add(this.panelGreen);
            this.Controls.Add(this.panelRed);
            this.Name = "SampleDialog";
            this.Text = "Color Dialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelRed;
        private System.Windows.Forms.FlowLayoutPanel panelGreen;
        private System.Windows.Forms.FlowLayoutPanel panelBlue;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}