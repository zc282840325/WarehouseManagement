namespace WarehouseManagement
{
    partial class MainForm
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
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租赁管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.資產管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.租赁管理ToolStripMenuItem,
            this.資產管理ToolStripMenuItem,
            this.商品入库管理ToolStripMenuItem,
            this.商品出库管理ToolStripMenuItem,
            this.注销管理ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            this.客户管理ToolStripMenuItem.Click += new System.EventHandler(this.客户管理ToolStripMenuItem_Click);
            // 
            // 租赁管理ToolStripMenuItem
            // 
            this.租赁管理ToolStripMenuItem.Name = "租赁管理ToolStripMenuItem";
            this.租赁管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.租赁管理ToolStripMenuItem.Text = "租賃管理";
            this.租赁管理ToolStripMenuItem.Click += new System.EventHandler(this.租赁管理ToolStripMenuItem_Click);
            // 
            // 資產管理ToolStripMenuItem
            // 
            this.資產管理ToolStripMenuItem.Name = "資產管理ToolStripMenuItem";
            this.資產管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.資產管理ToolStripMenuItem.Text = "資產管理";
            // 
            // 商品入库管理ToolStripMenuItem
            // 
            this.商品入库管理ToolStripMenuItem.Name = "商品入库管理ToolStripMenuItem";
            this.商品入库管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.商品入库管理ToolStripMenuItem.Text = "商品入庫管理";
            // 
            // 商品出库管理ToolStripMenuItem
            // 
            this.商品出库管理ToolStripMenuItem.Name = "商品出库管理ToolStripMenuItem";
            this.商品出库管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.商品出库管理ToolStripMenuItem.Text = "商品出庫管理";
            // 
            // 注销管理ToolStripMenuItem
            // 
            this.注销管理ToolStripMenuItem.Name = "注销管理ToolStripMenuItem";
            this.注销管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.注销管理ToolStripMenuItem.Text = "注销管理";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租赁管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 資產管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}