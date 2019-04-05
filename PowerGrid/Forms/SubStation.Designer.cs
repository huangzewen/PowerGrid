namespace PowerGrid.Forms
{
    partial class SubStation
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
            this.maxPagesLabel = new System.Windows.Forms.Label();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.SubStationdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SubStationdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maxPagesLabel
            // 
            this.maxPagesLabel.AutoSize = true;
            this.maxPagesLabel.Location = new System.Drawing.Point(593, 482);
            this.maxPagesLabel.Name = "maxPagesLabel";
            this.maxPagesLabel.Size = new System.Drawing.Size(29, 12);
            this.maxPagesLabel.TabIndex = 27;
            this.maxPagesLabel.Text = "of 0";
            this.maxPagesLabel.Click += new System.EventHandler(this.maxPagesLabel_Click);
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastPageBtn.Location = new System.Drawing.Point(689, 473);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(37, 30);
            this.lastPageBtn.TabIndex = 26;
            this.lastPageBtn.Text = ">>";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            this.lastPageBtn.Click += new System.EventHandler(this.lastPageBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextPageBtn.Location = new System.Drawing.Point(647, 473);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(37, 30);
            this.nextPageBtn.TabIndex = 25;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Location = new System.Drawing.Point(535, 478);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(50, 21);
            this.currentPageTextBox.TabIndex = 24;
            this.currentPageTextBox.TextChanged += new System.EventHandler(this.currentPageTextBox_TextChanged);
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(492, 474);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(37, 30);
            this.previousPageBtn.TabIndex = 23;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            this.previousPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Location = new System.Drawing.Point(449, 474);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(37, 30);
            this.firstPageBtn.TabIndex = 22;
            this.firstPageBtn.Text = "<<";
            this.firstPageBtn.UseVisualStyleBackColor = true;
            this.firstPageBtn.Click += new System.EventHandler(this.firstPageBtn_Click);
            // 
            // SubStationdataGridView
            // 
            this.SubStationdataGridView.AllowUserToOrderColumns = true;
            this.SubStationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubStationdataGridView.Location = new System.Drawing.Point(-5, 2);
            this.SubStationdataGridView.Name = "SubStationdataGridView";
            this.SubStationdataGridView.RowTemplate.Height = 23;
            this.SubStationdataGridView.Size = new System.Drawing.Size(835, 466);
            this.SubStationdataGridView.TabIndex = 21;
            this.SubStationdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LineLeveldataGridView_CellContentClick);
            // 
            // SubStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 529);
            this.Controls.Add(this.maxPagesLabel);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.firstPageBtn);
            this.Controls.Add(this.SubStationdataGridView);
            this.Name = "SubStation";
            this.Text = "SubStation";
            ((System.ComponentModel.ISupportInitialize)(this.SubStationdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxPagesLabel;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Button previousPageBtn;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.DataGridView SubStationdataGridView;
    }
}