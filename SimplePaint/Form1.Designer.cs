namespace SimplePaint
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btToggleGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.btToggleCaroMode = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMoreColor = new System.Windows.Forms.Button();
            this.colorBlack = new System.Windows.Forms.Panel();
            this.colorGreen = new System.Windows.Forms.Panel();
            this.colorYellow = new System.Windows.Forms.Panel();
            this.colorRed = new System.Windows.Forms.Panel();
            this.colorBlue = new System.Windows.Forms.Panel();
            this.btErase = new System.Windows.Forms.Button();
            this.btEllipse = new System.Windows.Forms.Button();
            this.btRect = new System.Windows.Forms.Button();
            this.btPen = new System.Windows.Forms.Button();
            this.btMouse = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextDraw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextRect = new System.Windows.Forms.ToolStripMenuItem();
            this.contextEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.contextClear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1643, 60);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNew,
            this.btOpen,
            this.btSave,
            this.btSaveAs,
            this.btPrint,
            this.btExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btNew
            // 
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(285, 54);
            this.btNew.Text = "New";
            this.btNew.Click += new System.EventHandler(this.BtNew_Click);
            // 
            // btOpen
            // 
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(285, 54);
            this.btOpen.Text = "Open";
            this.btOpen.Click += new System.EventHandler(this.BtOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(285, 54);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btSaveAs
            // 
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(285, 54);
            this.btSaveAs.Text = "Save As";
            // 
            // btPrint
            // 
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(285, 54);
            this.btPrint.Text = "Print";
            this.btPrint.Click += new System.EventHandler(this.BtPrint_Click);
            // 
            // btExit
            // 
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(285, 54);
            this.btExit.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btToggleGrid,
            this.btToggleCaroMode});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(106, 45);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // btToggleGrid
            // 
            this.btToggleGrid.Name = "btToggleGrid";
            this.btToggleGrid.Size = new System.Drawing.Size(431, 54);
            this.btToggleGrid.Text = "Toggle Grid";
            this.btToggleGrid.Click += new System.EventHandler(this.BtToggleGrid_Click);
            // 
            // btToggleCaroMode
            // 
            this.btToggleCaroMode.Name = "btToggleCaroMode";
            this.btToggleCaroMode.Size = new System.Drawing.Size(431, 54);
            this.btToggleCaroMode.Text = "Toggle Caro Mode";
            this.btToggleCaroMode.Click += new System.EventHandler(this.BtToggleCaroMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btMoreColor);
            this.panel1.Controls.Add(this.colorBlack);
            this.panel1.Controls.Add(this.colorGreen);
            this.panel1.Controls.Add(this.colorYellow);
            this.panel1.Controls.Add(this.colorRed);
            this.panel1.Controls.Add(this.colorBlue);
            this.panel1.Controls.Add(this.btErase);
            this.panel1.Controls.Add(this.btEllipse);
            this.panel1.Controls.Add(this.btRect);
            this.panel1.Controls.Add(this.btPen);
            this.panel1.Controls.Add(this.btMouse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 1052);
            this.panel1.TabIndex = 1;
            // 
            // btMoreColor
            // 
            this.btMoreColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMoreColor.Location = new System.Drawing.Point(0, 505);
            this.btMoreColor.Name = "btMoreColor";
            this.btMoreColor.Size = new System.Drawing.Size(209, 72);
            this.btMoreColor.TabIndex = 10;
            this.btMoreColor.Text = "More Color";
            this.btMoreColor.UseVisualStyleBackColor = true;
            this.btMoreColor.Click += new System.EventHandler(this.BtMoreColor_Click);
            // 
            // colorBlack
            // 
            this.colorBlack.BackColor = System.Drawing.Color.Black;
            this.colorBlack.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBlack.Location = new System.Drawing.Point(0, 457);
            this.colorBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(209, 48);
            this.colorBlack.TabIndex = 9;
            // 
            // colorGreen
            // 
            this.colorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.colorGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorGreen.Location = new System.Drawing.Point(0, 409);
            this.colorGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(209, 48);
            this.colorGreen.TabIndex = 8;
            // 
            // colorYellow
            // 
            this.colorYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.colorYellow.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorYellow.Location = new System.Drawing.Point(0, 361);
            this.colorYellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorYellow.Name = "colorYellow";
            this.colorYellow.Size = new System.Drawing.Size(209, 48);
            this.colorYellow.TabIndex = 7;
            // 
            // colorRed
            // 
            this.colorRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.colorRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorRed.Location = new System.Drawing.Point(0, 313);
            this.colorRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(209, 48);
            this.colorRed.TabIndex = 6;
            // 
            // colorBlue
            // 
            this.colorBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.colorBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorBlue.Location = new System.Drawing.Point(0, 265);
            this.colorBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(209, 48);
            this.colorBlue.TabIndex = 5;
            // 
            // btErase
            // 
            this.btErase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btErase.Location = new System.Drawing.Point(0, 212);
            this.btErase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btErase.Name = "btErase";
            this.btErase.Size = new System.Drawing.Size(209, 53);
            this.btErase.TabIndex = 4;
            this.btErase.Text = "Erase";
            this.btErase.UseVisualStyleBackColor = true;
            this.btErase.Click += new System.EventHandler(this.btErase_Click);
            // 
            // btEllipse
            // 
            this.btEllipse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEllipse.Location = new System.Drawing.Point(0, 159);
            this.btEllipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btEllipse.Name = "btEllipse";
            this.btEllipse.Size = new System.Drawing.Size(209, 53);
            this.btEllipse.TabIndex = 3;
            this.btEllipse.Text = "Ellipse";
            this.btEllipse.UseVisualStyleBackColor = true;
            this.btEllipse.Click += new System.EventHandler(this.btEllipse_Click);
            // 
            // btRect
            // 
            this.btRect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRect.Location = new System.Drawing.Point(0, 106);
            this.btRect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRect.Name = "btRect";
            this.btRect.Size = new System.Drawing.Size(209, 53);
            this.btRect.TabIndex = 2;
            this.btRect.Text = "Rectangle";
            this.btRect.UseVisualStyleBackColor = true;
            this.btRect.Click += new System.EventHandler(this.btRect_Click);
            // 
            // btPen
            // 
            this.btPen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPen.Location = new System.Drawing.Point(0, 53);
            this.btPen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPen.Name = "btPen";
            this.btPen.Size = new System.Drawing.Size(209, 53);
            this.btPen.TabIndex = 1;
            this.btPen.Text = "Pen";
            this.btPen.UseVisualStyleBackColor = true;
            this.btPen.Click += new System.EventHandler(this.btPen_Click);
            // 
            // btMouse
            // 
            this.btMouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMouse.Location = new System.Drawing.Point(0, 0);
            this.btMouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMouse.Name = "btMouse";
            this.btMouse.Size = new System.Drawing.Size(209, 53);
            this.btMouse.TabIndex = 0;
            this.btMouse.Text = "Mouse";
            this.btMouse.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPosition});
            this.statusStrip1.Location = new System.Drawing.Point(209, 1058);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1434, 54);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPosition
            // 
            this.statusPosition.Name = "statusPosition";
            this.statusPosition.Size = new System.Drawing.Size(168, 41);
            this.statusPosition.Text = "x = 0; y = 0";
            // 
            // contextDraw
            // 
            this.contextDraw.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawHereToolStripMenuItem,
            this.contextClear});
            this.contextDraw.Name = "contextDraw";
            this.contextDraw.Size = new System.Drawing.Size(361, 155);
            // 
            // drawHereToolStripMenuItem
            // 
            this.drawHereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextPen,
            this.contextRect,
            this.contextEllipse});
            this.drawHereToolStripMenuItem.Name = "drawHereToolStripMenuItem";
            this.drawHereToolStripMenuItem.Size = new System.Drawing.Size(360, 48);
            this.drawHereToolStripMenuItem.Text = "Draw here";
            // 
            // contextPen
            // 
            this.contextPen.Name = "contextPen";
            this.contextPen.Size = new System.Drawing.Size(448, 54);
            this.contextPen.Text = "Pen";
            // 
            // contextRect
            // 
            this.contextRect.Name = "contextRect";
            this.contextRect.Size = new System.Drawing.Size(448, 54);
            this.contextRect.Text = "Rectangle";
            // 
            // contextEllipse
            // 
            this.contextEllipse.Name = "contextEllipse";
            this.contextEllipse.Size = new System.Drawing.Size(448, 54);
            this.contextEllipse.Text = "Ellipse";
            // 
            // contextClear
            // 
            this.contextClear.Name = "contextClear";
            this.contextClear.Size = new System.Drawing.Size(360, 48);
            this.contextClear.Text = "Clear All";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 1112);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextDraw.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btMouse;
        private System.Windows.Forms.Button btPen;
        private System.Windows.Forms.Button btRect;
        private System.Windows.Forms.Button btEllipse;
        private System.Windows.Forms.Button btErase;
        private System.Windows.Forms.Panel colorYellow;
        private System.Windows.Forms.Panel colorGreen;
        private System.Windows.Forms.Panel colorBlack;
        private System.Windows.Forms.Panel colorRed;
        private System.Windows.Forms.Panel colorBlue;
        private System.Windows.Forms.ToolStripMenuItem btNew;
        private System.Windows.Forms.ToolStripMenuItem btOpen;
        private System.Windows.Forms.ToolStripMenuItem btSave;
        private System.Windows.Forms.ToolStripMenuItem btSaveAs;
        private System.Windows.Forms.ToolStripMenuItem btExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btToggleGrid;
        private System.Windows.Forms.ToolStripMenuItem btToggleCaroMode;
        private System.Windows.Forms.ToolStripMenuItem btPrint;
        private System.Windows.Forms.Button btMoreColor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPosition;
        private System.Windows.Forms.ContextMenuStrip contextDraw;
        private System.Windows.Forms.ToolStripMenuItem drawHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextPen;
        private System.Windows.Forms.ToolStripMenuItem contextRect;
        private System.Windows.Forms.ToolStripMenuItem contextEllipse;
        private System.Windows.Forms.ToolStripMenuItem contextClear;
    }
}