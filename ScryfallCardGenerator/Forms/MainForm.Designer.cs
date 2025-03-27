﻿namespace ScryfallCardGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panMain = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            tblPanMain = new TableLayoutPanel();
            lblCardCount = new Label();
            rtbCardCount = new RichTextBox();
            btnRandomize = new Button();
            panMain.SuspendLayout();
            tblPanMain.SuspendLayout();
            SuspendLayout();
            // 
            // panMain
            // 
            panMain.BackColor = SystemColors.ControlDarkDark;
            panMain.Controls.Add(btnMinimize);
            panMain.Controls.Add(btnClose);
            panMain.Dock = DockStyle.Top;
            panMain.Location = new Point(0, 0);
            panMain.Name = "panMain";
            panMain.Size = new Size(431, 34);
            panMain.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = SystemColors.GrayText;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = SystemColors.Control;
            btnMinimize.Location = new Point(357, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 34);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Dock = DockStyle.Right;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.Control;
            btnClose.Location = new Point(394, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tblPanMain
            // 
            tblPanMain.ColumnCount = 2;
            tblPanMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.4129944F));
            tblPanMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5870056F));
            tblPanMain.Controls.Add(lblCardCount, 0, 0);
            tblPanMain.Controls.Add(rtbCardCount, 1, 1);
            tblPanMain.Controls.Add(btnRandomize, 1, 2);
            tblPanMain.Dock = DockStyle.Fill;
            tblPanMain.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tblPanMain.Location = new Point(0, 34);
            tblPanMain.Name = "tblPanMain";
            tblPanMain.RowCount = 3;
            tblPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 31.034483F));
            tblPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 48.2758636F));
            tblPanMain.Size = new Size(431, 146);
            tblPanMain.TabIndex = 1;
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Dock = DockStyle.Fill;
            lblCardCount.ForeColor = SystemColors.ButtonHighlight;
            lblCardCount.Location = new Point(3, 0);
            lblCardCount.Name = "lblCardCount";
            tblPanMain.SetRowSpan(lblCardCount, 2);
            lblCardCount.Size = new Size(263, 74);
            lblCardCount.TabIndex = 0;
            lblCardCount.Text = "How many cards are you randomizing?";
            // 
            // rtbCardCount
            // 
            rtbCardCount.BackColor = Color.FromArgb(40, 7, 109);
            rtbCardCount.BorderStyle = BorderStyle.None;
            rtbCardCount.Dock = DockStyle.Fill;
            rtbCardCount.ForeColor = SystemColors.ButtonHighlight;
            rtbCardCount.Location = new Point(272, 32);
            rtbCardCount.Multiline = false;
            rtbCardCount.Name = "rtbCardCount";
            rtbCardCount.Size = new Size(156, 39);
            rtbCardCount.TabIndex = 1;
            rtbCardCount.Text = "100";
            rtbCardCount.WordWrap = false;
            // 
            // btnRandomize
            // 
            btnRandomize.Dock = DockStyle.Fill;
            btnRandomize.Location = new Point(272, 77);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(156, 66);
            btnRandomize.TabIndex = 2;
            btnRandomize.Text = "Randomize";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 7, 109);
            ClientSize = new Size(431, 180);
            Controls.Add(tblPanMain);
            Controls.Add(panMain);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            panMain.ResumeLayout(false);
            tblPanMain.ResumeLayout(false);
            tblPanMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panMain;
        private Button btnMinimize;
        private Button btnClose;
        private TableLayoutPanel tblPanMain;
        private Label lblCardCount;
        private RichTextBox rtbCardCount;
        private Button btnRandomize;
    }
}