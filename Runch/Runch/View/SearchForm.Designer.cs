﻿namespace Runch.View
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(382, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtUser.Location = new System.Drawing.Point(137, 142);
            this.txtUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(220, 20);
            this.txtUser.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(127, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 28);
            this.label5.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(32, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "사용자";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(40, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "카테고리";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(163)))), ((int)(((byte)(166)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("이사만루체 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(45, 185);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(318, 38);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(255, 45);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(112, 27);
            this.dtpEnd.TabIndex = 25;
            this.dtpEnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvalidateInput);
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(127, 45);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(112, 27);
            this.dtpStart.TabIndex = 24;
            this.dtpStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvalidateInput);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(32, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "선정 기간";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(127, 94);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(240, 27);
            this.cmbCategory.TabIndex = 27;
            this.cmbCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvalidateInput);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(32, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "카테고리";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSlash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSlash.Location = new System.Drawing.Point(237, 48);
            this.lblSlash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(20, 22);
            this.lblSlash.TabIndex = 28;
            this.lblSlash.Text = "-";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 242);
            this.ControlBox = false;
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSlash);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSlash;
    }
}