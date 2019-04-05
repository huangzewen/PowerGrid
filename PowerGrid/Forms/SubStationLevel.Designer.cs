namespace PowerGrid.Forms
{
    partial class SubStationLevel
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
            this.SubStaionLeveldataGridView = new System.Windows.Forms.DataGridView();
            this.firstPageBtn = new System.Windows.Forms.Button();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.currentPageTextBox = new System.Windows.Forms.TextBox();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.lastPageBtn = new System.Windows.Forms.Button();
            this.maxPagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubStaionLeveldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SubStaionLeveldataGridView
            // 
            this.SubStaionLeveldataGridView.AllowUserToOrderColumns = true;
            this.SubStaionLeveldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubStaionLeveldataGridView.Location = new System.Drawing.Point(1, 1);
            this.SubStaionLeveldataGridView.Name = "SubStaionLeveldataGridView";
            this.SubStaionLeveldataGridView.RowTemplate.Height = 23;
            this.SubStaionLeveldataGridView.Size = new System.Drawing.Size(835, 491);
            this.SubStaionLeveldataGridView.TabIndex = 0;
            this.SubStaionLeveldataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubStaionLeveldataGridView_CellContentClick);
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Location = new System.Drawing.Point(455, 498);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(37, 30);
            this.firstPageBtn.TabIndex = 1;
            this.firstPageBtn.Text = "<<";
            this.firstPageBtn.UseVisualStyleBackColor = true;
            this.firstPageBtn.Click += new System.EventHandler(this.firstPageBtn_Click);
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(498, 498);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(37, 30);
            this.previousPageBtn.TabIndex = 2;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            this.previousPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Location = new System.Drawing.Point(541, 502);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(50, 21);
            this.currentPageTextBox.TabIndex = 3;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextPageBtn.Location = new System.Drawing.Point(653, 497);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(37, 30);
            this.nextPageBtn.TabIndex = 4;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastPageBtn.Location = new System.Drawing.Point(695, 497);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(37, 30);
            this.lastPageBtn.TabIndex = 5;
            this.lastPageBtn.Text = ">>";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            this.lastPageBtn.Click += new System.EventHandler(this.lastPageBtn_Click);
            // 
            // maxPagesLabel
            // 
            this.maxPagesLabel.AutoSize = true;
            this.maxPagesLabel.Location = new System.Drawing.Point(599, 506);
            this.maxPagesLabel.Name = "maxPagesLabel";
            this.maxPagesLabel.Size = new System.Drawing.Size(29, 12);
            this.maxPagesLabel.TabIndex = 6;
            this.maxPagesLabel.Text = "of 0";
            // 
            // SubStationLevel
            // 
            this.ClientSize = new System.Drawing.Size(837, 530);
            this.Controls.Add(this.maxPagesLabel);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.firstPageBtn);
            this.Controls.Add(this.SubStaionLeveldataGridView);
            this.Name = "SubStationLevel";
            this.Load += new System.EventHandler(this.SubStationLevel_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.SubStaionLeveldataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.DataGridView SubStaionLeveldataGridView;
        private System.Windows.Forms.Button firstPageBtn;
        private System.Windows.Forms.Button previousPageBtn;
        private System.Windows.Forms.TextBox currentPageTextBox;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button lastPageBtn;
        private System.Windows.Forms.Label maxPagesLabel;
    }
}