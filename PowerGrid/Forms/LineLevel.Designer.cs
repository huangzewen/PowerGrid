namespace PowerGrid.Forms
{
    partial class LineLevel
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
            this.LineLeveldataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.LineLeveldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maxPagesLabel
            // 
            this.maxPagesLabel.AutoSize = true;
            this.maxPagesLabel.Location = new System.Drawing.Point(601, 484);
            this.maxPagesLabel.Name = "maxPagesLabel";
            this.maxPagesLabel.Size = new System.Drawing.Size(29, 12);
            this.maxPagesLabel.TabIndex = 20;
            this.maxPagesLabel.Text = "of 0";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastPageBtn.Location = new System.Drawing.Point(697, 475);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(37, 30);
            this.lastPageBtn.TabIndex = 19;
            this.lastPageBtn.Text = ">>";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextPageBtn.Location = new System.Drawing.Point(655, 475);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(37, 30);
            this.nextPageBtn.TabIndex = 18;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Location = new System.Drawing.Point(543, 480);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(50, 21);
            this.currentPageTextBox.TabIndex = 17;
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(500, 476);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(37, 30);
            this.previousPageBtn.TabIndex = 16;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Location = new System.Drawing.Point(457, 476);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(37, 30);
            this.firstPageBtn.TabIndex = 15;
            this.firstPageBtn.Text = "<<";
            this.firstPageBtn.UseVisualStyleBackColor = true;
            // 
            // LineLeveldataGridView
            // 
            this.LineLeveldataGridView.AllowUserToOrderColumns = true;
            this.LineLeveldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LineLeveldataGridView.Location = new System.Drawing.Point(3, 0);
            this.LineLeveldataGridView.Name = "LineLeveldataGridView";
            this.LineLeveldataGridView.RowTemplate.Height = 23;
            this.LineLeveldataGridView.Size = new System.Drawing.Size(835, 470);
            this.LineLeveldataGridView.TabIndex = 14;
            // 
            // LineLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 529);
            this.Controls.Add(this.maxPagesLabel);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.firstPageBtn);
            this.Controls.Add(this.LineLeveldataGridView);
            this.Name = "LineLevel";
            this.Text = "LineLevel";
            ((System.ComponentModel.ISupportInitialize)(this.LineLeveldataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView LineLeveldataGridView;
    }
}