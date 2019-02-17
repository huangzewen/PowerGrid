namespace PowerGrid
{
    partial class Index
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
            this.Login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsn = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.labelUsn = new System.Windows.Forms.Label();
            this.labelPwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Login.Font = new System.Drawing.Font("SimSun", 10F);
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(56, 292);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(112, 31);
            this.Login.TabIndex = 0;
            this.Login.Text = "登录";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.register.Font = new System.Drawing.Font("SimSun", 10F);
            this.register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register.Location = new System.Drawing.Point(208, 292);
            this.register.Margin = new System.Windows.Forms.Padding(4);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(112, 31);
            this.register.TabIndex = 1;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.registBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "密 码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsn
            // 
            this.txtUsn.Location = new System.Drawing.Point(147, 95);
            this.txtUsn.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsn.Name = "txtUsn";
            this.txtUsn.Size = new System.Drawing.Size(185, 25);
            this.txtUsn.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(147, 169);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(185, 25);
            this.txtPwd.TabIndex = 5;
            // 
            // labelUsn
            // 
            this.labelUsn.AutoSize = true;
            this.labelUsn.Font = new System.Drawing.Font("SimSun", 10F);
            this.labelUsn.ForeColor = System.Drawing.Color.Red;
            this.labelUsn.Location = new System.Drawing.Point(144, 74);
            this.labelUsn.Name = "labelUsn";
            this.labelUsn.Size = new System.Drawing.Size(0, 17);
            this.labelUsn.TabIndex = 6;
            // 
            // labelPwd
            // 
            this.labelPwd.AutoSize = true;
            this.labelPwd.Font = new System.Drawing.Font("SimSun", 10F);
            this.labelPwd.ForeColor = System.Drawing.Color.Red;
            this.labelPwd.Location = new System.Drawing.Point(144, 148);
            this.labelPwd.Name = "labelPwd";
            this.labelPwd.Size = new System.Drawing.Size(0, 17);
            this.labelPwd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 402);
            this.Controls.Add(this.labelPwd);
            this.Controls.Add(this.labelUsn);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUsn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "电源路径管理项目";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsn;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label labelUsn;
        private System.Windows.Forms.Label labelPwd;
    }
}

