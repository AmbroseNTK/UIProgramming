namespace W02_01
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
            this.tbNum1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.radioSub = new System.Windows.Forms.RadioButton();
            this.radioMul = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.groupOps = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNum2 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupOps.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNum1
            // 
            this.tbNum1.Location = new System.Drawing.Point(179, 58);
            this.tbNum1.Name = "tbNum1";
            this.tbNum1.Size = new System.Drawing.Size(462, 38);
            this.tbNum1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Num#1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num#2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNum2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNum1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1666, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(64, 56);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(103, 36);
            this.radioAdd.TabIndex = 5;
            this.radioAdd.TabStop = true;
            this.radioAdd.Tag = "Add";
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            // 
            // radioSub
            // 
            this.radioSub.AutoSize = true;
            this.radioSub.Location = new System.Drawing.Point(348, 56);
            this.radioSub.Name = "radioSub";
            this.radioSub.Size = new System.Drawing.Size(103, 36);
            this.radioSub.TabIndex = 6;
            this.radioSub.TabStop = true;
            this.radioSub.Tag = "Sub";
            this.radioSub.Text = "Sub";
            this.radioSub.UseVisualStyleBackColor = true;
            // 
            // radioMul
            // 
            this.radioMul.AutoSize = true;
            this.radioMul.Location = new System.Drawing.Point(640, 56);
            this.radioMul.Name = "radioMul";
            this.radioMul.Size = new System.Drawing.Size(98, 36);
            this.radioMul.TabIndex = 7;
            this.radioMul.TabStop = true;
            this.radioMul.Tag = "Mul";
            this.radioMul.Text = "Mul";
            this.radioMul.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(883, 56);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(93, 36);
            this.radioDiv.TabIndex = 8;
            this.radioDiv.TabStop = true;
            this.radioDiv.Tag = "Div";
            this.radioDiv.Text = "Div";
            this.radioDiv.UseVisualStyleBackColor = true;
            // 
            // groupOps
            // 
            this.groupOps.Controls.Add(this.radioAdd);
            this.groupOps.Controls.Add(this.radioSub);
            this.groupOps.Controls.Add(this.radioDiv);
            this.groupOps.Controls.Add(this.radioMul);
            this.groupOps.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOps.Location = new System.Drawing.Point(0, 208);
            this.groupOps.Name = "groupOps";
            this.groupOps.Size = new System.Drawing.Size(1666, 124);
            this.groupOps.TabIndex = 9;
            this.groupOps.TabStop = false;
            this.groupOps.Text = "Operators";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbResult);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 790);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1666, 178);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // tbNum2
            // 
            this.tbNum2.Location = new System.Drawing.Point(179, 124);
            this.tbNum2.Name = "tbNum2";
            this.tbNum2.Size = new System.Drawing.Size(462, 38);
            this.tbNum2.TabIndex = 4;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(56, 74);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(200, 46);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Result = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 968);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupOps);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupOps.ResumeLayout(false);
            this.groupOps.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNum2;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.RadioButton radioSub;
        private System.Windows.Forms.RadioButton radioMul;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.GroupBox groupOps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbResult;
    }
}

