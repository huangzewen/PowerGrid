﻿namespace PowerGrid.Forms
{
    partial class MainTformer
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
            this.MainTformerdataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainTformerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maxPagesLabel
            // 
            this.maxPagesLabel.AutoSize = true;
            this.maxPagesLabel.Location = new System.Drawing.Point(562, 473);
            this.maxPagesLabel.Name = "maxPagesLabel";
            this.maxPagesLabel.Size = new System.Drawing.Size(29, 12);
            this.maxPagesLabel.TabIndex = 20;
            this.maxPagesLabel.Text = "of 0";
            // 
            // lastPageBtn
            // 
            this.lastPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastPageBtn.Location = new System.Drawing.Point(658, 464);
            this.lastPageBtn.Name = "lastPageBtn";
            this.lastPageBtn.Size = new System.Drawing.Size(37, 30);
            this.lastPageBtn.TabIndex = 19;
            this.lastPageBtn.Text = ">>";
            this.lastPageBtn.UseVisualStyleBackColor = true;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextPageBtn.Location = new System.Drawing.Point(616, 464);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(37, 30);
            this.nextPageBtn.TabIndex = 18;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // currentPageTextBox
            // 
            this.currentPageTextBox.Location = new System.Drawing.Point(504, 469);
            this.currentPageTextBox.Name = "currentPageTextBox";
            this.currentPageTextBox.Size = new System.Drawing.Size(50, 21);
            this.currentPageTextBox.TabIndex = 17;
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.Location = new System.Drawing.Point(461, 465);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(37, 30);
            this.previousPageBtn.TabIndex = 16;
            this.previousPageBtn.Text = "<";
            this.previousPageBtn.UseVisualStyleBackColor = true;
            // 
            // firstPageBtn
            // 
            this.firstPageBtn.Location = new System.Drawing.Point(418, 465);
            this.firstPageBtn.Name = "firstPageBtn";
            this.firstPageBtn.Size = new System.Drawing.Size(37, 30);
            this.firstPageBtn.TabIndex = 15;
            this.firstPageBtn.Text = "<<";
            this.firstPageBtn.UseVisualStyleBackColor = true;
            // 
            // MainTformerdataGridView
            // 
            this.MainTformerdataGridView.AllowUserToOrderColumns = true;
            this.MainTformerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTformerdataGridView.Location = new System.Drawing.Point(4, 2);
            this.MainTformerdataGridView.Name = "MainTformerdataGridView";
            this.MainTformerdataGridView.RowTemplate.Height = 23;
            this.MainTformerdataGridView.Size = new System.Drawing.Size(835, 457);
            this.MainTformerdataGridView.TabIndex = 14;
            // 
            // MainTformer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 506);
            this.Controls.Add(this.maxPagesLabel);
            this.Controls.Add(this.lastPageBtn);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.currentPageTextBox);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.firstPageBtn);
            this.Controls.Add(this.MainTformerdataGridView);
            this.Name = "MainTformer";
            this.Text = "MainTformer";
            ((System.ComponentModel.ISupportInitialize)(this.MainTformerdataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView MainTformerdataGridView;
    }
}