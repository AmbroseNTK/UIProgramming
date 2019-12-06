namespace W12_01
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.custID = new System.Windows.Forms.TextBox();
            this.custName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.requiredDate = new System.Windows.Forms.TextBox();
            this.orderDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shipName = new System.Windows.Forms.TextBox();
            this.shipDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shipCity = new System.Windows.Forms.TextBox();
            this.shipAddress = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 413);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1447, 723);
            this.dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(3, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 1102);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 1139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(401, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1453, 1139);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btModify);
            this.groupBox3.Controls.Add(this.btDelete);
            this.groupBox3.Controls.Add(this.btUpdate);
            this.groupBox3.Controls.Add(this.btAdd);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.shipCity);
            this.groupBox3.Controls.Add(this.shipAddress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.shipName);
            this.groupBox3.Controls.Add(this.shipDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.requiredDate);
            this.groupBox3.Controls.Add(this.orderDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.custName);
            this.groupBox3.Controls.Add(this.custID);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1447, 379);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            // 
            // custID
            // 
            this.custID.Location = new System.Drawing.Point(256, 58);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(369, 38);
            this.custID.TabIndex = 0;
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(256, 114);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(369, 38);
            this.custName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Required Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order Date";
            // 
            // requiredDate
            // 
            this.requiredDate.Location = new System.Drawing.Point(256, 224);
            this.requiredDate.Name = "requiredDate";
            this.requiredDate.Size = new System.Drawing.Size(369, 38);
            this.requiredDate.TabIndex = 5;
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(256, 168);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(369, 38);
            this.orderDate.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(668, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ship Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(668, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shipped Date";
            // 
            // shipName
            // 
            this.shipName.Location = new System.Drawing.Point(876, 108);
            this.shipName.Name = "shipName";
            this.shipName.Size = new System.Drawing.Size(439, 38);
            this.shipName.TabIndex = 9;
            // 
            // shipDate
            // 
            this.shipDate.Location = new System.Drawing.Point(876, 52);
            this.shipDate.Name = "shipDate";
            this.shipDate.Size = new System.Drawing.Size(439, 38);
            this.shipDate.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ship City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ship Address";
            // 
            // shipCity
            // 
            this.shipCity.Location = new System.Drawing.Point(876, 218);
            this.shipCity.Name = "shipCity";
            this.shipCity.Size = new System.Drawing.Size(439, 38);
            this.shipCity.TabIndex = 13;
            // 
            // shipAddress
            // 
            this.shipAddress.Location = new System.Drawing.Point(876, 162);
            this.shipAddress.Name = "shipAddress";
            this.shipAddress.Size = new System.Drawing.Size(439, 38);
            this.shipAddress.TabIndex = 12;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(84, 288);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(141, 64);
            this.btAdd.TabIndex = 16;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(256, 288);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(141, 64);
            this.btUpdate.TabIndex = 17;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(420, 288);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(141, 64);
            this.btDelete.TabIndex = 18;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // btModify
            // 
            this.btModify.Location = new System.Drawing.Point(1132, 288);
            this.btModify.Name = "btModify";
            this.btModify.Size = new System.Drawing.Size(183, 64);
            this.btModify.TabIndex = 19;
            this.btModify.Text = "Modify items";
            this.btModify.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1854, 1139);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox shipCity;
        private System.Windows.Forms.TextBox shipAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shipName;
        private System.Windows.Forms.TextBox shipDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox requiredDate;
        private System.Windows.Forms.TextBox orderDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.TextBox custID;
        private System.Windows.Forms.Button btModify;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
    }
}

