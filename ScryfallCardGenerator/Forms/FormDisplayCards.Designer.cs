namespace ScryfallCardGenerator.Forms
{
    partial class FormDisplayCards
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
            panMain = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panMainDisplay = new Panel();
            tblLayPanDisplay = new TableLayoutPanel();
            flowLayPanTop = new FlowLayoutPanel();
            flowLayPanMiddle = new FlowLayoutPanel();
            flowLayPanBottom = new FlowLayoutPanel();
            panMain.SuspendLayout();
            panMainDisplay.SuspendLayout();
            tblLayPanDisplay.SuspendLayout();
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
            panMain.Size = new Size(793, 34);
            panMain.TabIndex = 2;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Location = new Point(719, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 34);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.Location = new Point(756, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 34);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panMainDisplay
            // 
            panMainDisplay.Controls.Add(tblLayPanDisplay);
            panMainDisplay.Dock = DockStyle.Fill;
            panMainDisplay.Location = new Point(0, 34);
            panMainDisplay.Name = "panMainDisplay";
            panMainDisplay.Size = new Size(793, 623);
            panMainDisplay.TabIndex = 3;
            // 
            // tblLayPanDisplay
            // 
            tblLayPanDisplay.ColumnCount = 2;
            tblLayPanDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.1551056F));
            tblLayPanDisplay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.8448925F));
            tblLayPanDisplay.Controls.Add(flowLayPanTop, 0, 0);
            tblLayPanDisplay.Controls.Add(flowLayPanMiddle, 0, 1);
            tblLayPanDisplay.Controls.Add(flowLayPanBottom, 0, 2);
            tblLayPanDisplay.Dock = DockStyle.Fill;
            tblLayPanDisplay.Location = new Point(0, 0);
            tblLayPanDisplay.Name = "tblLayPanDisplay";
            tblLayPanDisplay.RowCount = 3;
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayPanDisplay.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblLayPanDisplay.Size = new Size(793, 623);
            tblLayPanDisplay.TabIndex = 0;
            // 
            // flowLayPanTop
            // 
            flowLayPanTop.Dock = DockStyle.Fill;
            flowLayPanTop.Location = new Point(3, 3);
            flowLayPanTop.Name = "flowLayPanTop";
            flowLayPanTop.Size = new Size(701, 201);
            flowLayPanTop.TabIndex = 0;
            // 
            // flowLayPanMiddle
            // 
            flowLayPanMiddle.Dock = DockStyle.Fill;
            flowLayPanMiddle.Location = new Point(3, 210);
            flowLayPanMiddle.Name = "flowLayPanMiddle";
            flowLayPanMiddle.Size = new Size(701, 201);
            flowLayPanMiddle.TabIndex = 1;
            // 
            // flowLayPanBottom
            // 
            flowLayPanBottom.Dock = DockStyle.Fill;
            flowLayPanBottom.Location = new Point(3, 417);
            flowLayPanBottom.Name = "flowLayPanBottom";
            flowLayPanBottom.Size = new Size(701, 203);
            flowLayPanBottom.TabIndex = 2;
            // 
            // FormDisplayCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 7, 109);
            ClientSize = new Size(793, 657);
            Controls.Add(panMainDisplay);
            Controls.Add(panMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDisplayCards";
            Text = "FormDisplayCards";
            panMain.ResumeLayout(false);
            panMainDisplay.ResumeLayout(false);
            tblLayPanDisplay.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panMain;
        private Button btnMinimize;
        private Button btnClose;
        private Panel panMainDisplay;
        private TableLayoutPanel tblLayPanDisplay;
        private FlowLayoutPanel flowLayPanTop;
        private FlowLayoutPanel flowLayPanMiddle;
        private FlowLayoutPanel flowLayPanBottom;
    }
}