namespace PowerGrid.Forms
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.metaDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.变电站等级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.母线等级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线路等级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.变电站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.母线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主变ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线路ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统用户类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看系统用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电源路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metaDataMenuItem,
            this.UserInfoMenuItem,
            this.CustomerInfoMenuItem,
            this.pathInfoMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // metaDataMenuItem
            // 
            this.metaDataMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.变电站等级ToolStripMenuItem,
            this.母线等级ToolStripMenuItem,
            this.线路等级ToolStripMenuItem,
            this.变电站ToolStripMenuItem,
            this.母线ToolStripMenuItem,
            this.主变ToolStripMenuItem,
            this.线路ToolStripMenuItem});
            this.metaDataMenuItem.Image = global::PowerGrid.Properties.Resources.入住报表;
            this.metaDataMenuItem.Name = "metaDataMenuItem";
            this.metaDataMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.metaDataMenuItem.Size = new System.Drawing.Size(104, 24);
            this.metaDataMenuItem.Text = "元数据（&M）";
            this.metaDataMenuItem.Click += new System.EventHandler(this.metaDataMenuItem_Click);
            // 
            // 变电站等级ToolStripMenuItem
            // 
            this.变电站等级ToolStripMenuItem.Name = "变电站等级ToolStripMenuItem";
            this.变电站等级ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.变电站等级ToolStripMenuItem.Text = "变电站等级";
            this.变电站等级ToolStripMenuItem.Click += new System.EventHandler(this.变电站等级ToolStripMenuItem_Click);
            // 
            // 母线等级ToolStripMenuItem
            // 
            this.母线等级ToolStripMenuItem.Name = "母线等级ToolStripMenuItem";
            this.母线等级ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.母线等级ToolStripMenuItem.Text = "母线等级";
            this.母线等级ToolStripMenuItem.Click += new System.EventHandler(this.母线等级ToolStripMenuItem_Click);
            // 
            // 线路等级ToolStripMenuItem
            // 
            this.线路等级ToolStripMenuItem.Name = "线路等级ToolStripMenuItem";
            this.线路等级ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.线路等级ToolStripMenuItem.Text = "线路等级";
            this.线路等级ToolStripMenuItem.Click += new System.EventHandler(this.线路等级ToolStripMenuItem_Click);
            // 
            // 变电站ToolStripMenuItem
            // 
            this.变电站ToolStripMenuItem.Name = "变电站ToolStripMenuItem";
            this.变电站ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.变电站ToolStripMenuItem.Text = "变电站";
            this.变电站ToolStripMenuItem.Click += new System.EventHandler(this.变电站ToolStripMenuItem_Click);
            // 
            // 母线ToolStripMenuItem
            // 
            this.母线ToolStripMenuItem.Name = "母线ToolStripMenuItem";
            this.母线ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.母线ToolStripMenuItem.Text = "母线";
            this.母线ToolStripMenuItem.Click += new System.EventHandler(this.母线ToolStripMenuItem_Click);
            // 
            // 主变ToolStripMenuItem
            // 
            this.主变ToolStripMenuItem.Name = "主变ToolStripMenuItem";
            this.主变ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.主变ToolStripMenuItem.Text = "主变";
            this.主变ToolStripMenuItem.Click += new System.EventHandler(this.主变ToolStripMenuItem_Click);
            // 
            // 线路ToolStripMenuItem
            // 
            this.线路ToolStripMenuItem.Name = "线路ToolStripMenuItem";
            this.线路ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.线路ToolStripMenuItem.Text = "线路";
            this.线路ToolStripMenuItem.Click += new System.EventHandler(this.线路ToolStripMenuItem_Click);
            // 
            // UserInfoMenuItem
            // 
            this.UserInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统用户类型ToolStripMenuItem,
            this.查看系统用户ToolStripMenuItem});
            this.UserInfoMenuItem.Image = global::PowerGrid.Properties.Resources.预订入住;
            this.UserInfoMenuItem.Name = "UserInfoMenuItem";
            this.UserInfoMenuItem.Size = new System.Drawing.Size(144, 24);
            this.UserInfoMenuItem.Text = "系统用户信息（&C）";
            this.UserInfoMenuItem.Click += new System.EventHandler(this.UserInfoMenuItem_Click);
            // 
            // 系统用户类型ToolStripMenuItem
            // 
            this.系统用户类型ToolStripMenuItem.Name = "系统用户类型ToolStripMenuItem";
            this.系统用户类型ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.系统用户类型ToolStripMenuItem.Text = "系统用户类型";
            // 
            // 查看系统用户ToolStripMenuItem
            // 
            this.查看系统用户ToolStripMenuItem.Name = "查看系统用户ToolStripMenuItem";
            this.查看系统用户ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看系统用户ToolStripMenuItem.Text = "系统用户";
            // 
            // CustomerInfoMenuItem
            // 
            this.CustomerInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户类型ToolStripMenuItem,
            this.客户信息ToolStripMenuItem});
            this.CustomerInfoMenuItem.Image = global::PowerGrid.Properties.Resources.消费登记;
            this.CustomerInfoMenuItem.Name = "CustomerInfoMenuItem";
            this.CustomerInfoMenuItem.Size = new System.Drawing.Size(129, 24);
            this.CustomerInfoMenuItem.Text = "用电客户信息(&U)";
            // 
            // 客户类型ToolStripMenuItem
            // 
            this.客户类型ToolStripMenuItem.Name = "客户类型ToolStripMenuItem";
            this.客户类型ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客户类型ToolStripMenuItem.Text = "用电客户类型";
            // 
            // 客户信息ToolStripMenuItem
            // 
            this.客户信息ToolStripMenuItem.Name = "客户信息ToolStripMenuItem";
            this.客户信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客户信息ToolStripMenuItem.Text = "用电客户";
            // 
            // pathInfoMenuItem
            // 
            this.pathInfoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.电源路径ToolStripMenuItem});
            this.pathInfoMenuItem.Image = global::PowerGrid.Properties.Resources.餐费报表;
            this.pathInfoMenuItem.Name = "pathInfoMenuItem";
            this.pathInfoMenuItem.Size = new System.Drawing.Size(143, 24);
            this.pathInfoMenuItem.Text = "电源路径信息（&E）";
            // 
            // 电源路径ToolStripMenuItem
            // 
            this.电源路径ToolStripMenuItem.Name = "电源路径ToolStripMenuItem";
            this.电源路径ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.电源路径ToolStripMenuItem.Text = "电源路径";
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1043, 563);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1034, 573);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "电源路径管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem metaDataMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 变电站等级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 母线等级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线路等级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 变电站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 母线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主变ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线路ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统用户类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看系统用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathInfoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电源路径ToolStripMenuItem;
        private System.Windows.Forms.Panel mainPanel;
    }
}