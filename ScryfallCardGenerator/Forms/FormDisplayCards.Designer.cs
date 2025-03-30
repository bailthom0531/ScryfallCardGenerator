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
            btnMaximize = new Button();
            btnClose = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblColorlessCards = new Label();
            lblGreenCards = new Label();
            lblRedCards = new Label();
            lblBlackCards = new Label();
            lblBlueCards = new Label();
            lblWhiteCards = new Label();
            lblMulticolorCards = new Label();
            lblLengendaryCards = new Label();
            flowPanVerticalScroll = new FlowLayoutPanel();
            panMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panMain
            // 
            panMain.BackColor = SystemColors.ControlDarkDark;
            panMain.Controls.Add(btnMinimize);
            panMain.Controls.Add(btnMaximize);
            panMain.Controls.Add(btnClose);
            panMain.Dock = DockStyle.Top;
            panMain.Location = new Point(0, 0);
            panMain.Name = "panMain";
            panMain.Size = new Size(793, 34);
            panMain.TabIndex = 2;
            panMain.MouseDown += panMain_MouseDown;
            panMain.MouseMove += panMain_MouseMove;
            panMain.MouseUp += panMain_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = SystemColors.GrayText;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.Location = new Point(682, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 34);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "-";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.BackColor = SystemColors.GrayText;
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = SystemColors.ButtonHighlight;
            btnMaximize.Location = new Point(719, 0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(37, 34);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Dock = DockStyle.Right;
            btnClose.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(756, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(lblColorlessCards, 7, 0);
            tableLayoutPanel1.Controls.Add(lblGreenCards, 6, 0);
            tableLayoutPanel1.Controls.Add(lblRedCards, 5, 0);
            tableLayoutPanel1.Controls.Add(lblBlackCards, 4, 0);
            tableLayoutPanel1.Controls.Add(lblBlueCards, 3, 0);
            tableLayoutPanel1.Controls.Add(lblWhiteCards, 2, 0);
            tableLayoutPanel1.Controls.Add(lblMulticolorCards, 1, 0);
            tableLayoutPanel1.Controls.Add(lblLengendaryCards, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(793, 76);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblColorlessCards
            // 
            lblColorlessCards.AutoSize = true;
            lblColorlessCards.Dock = DockStyle.Fill;
            lblColorlessCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblColorlessCards.ForeColor = SystemColors.ButtonHighlight;
            lblColorlessCards.Location = new Point(696, 0);
            lblColorlessCards.Name = "lblColorlessCards";
            lblColorlessCards.Size = new Size(94, 76);
            lblColorlessCards.TabIndex = 7;
            lblColorlessCards.Text = "Colorless";
            lblColorlessCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenCards
            // 
            lblGreenCards.AutoSize = true;
            lblGreenCards.Dock = DockStyle.Fill;
            lblGreenCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreenCards.ForeColor = SystemColors.ButtonHighlight;
            lblGreenCards.Location = new Point(597, 0);
            lblGreenCards.Name = "lblGreenCards";
            lblGreenCards.Size = new Size(93, 76);
            lblGreenCards.TabIndex = 6;
            lblGreenCards.Text = "Green";
            lblGreenCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRedCards
            // 
            lblRedCards.AutoSize = true;
            lblRedCards.Dock = DockStyle.Fill;
            lblRedCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblRedCards.ForeColor = SystemColors.ButtonHighlight;
            lblRedCards.Location = new Point(498, 0);
            lblRedCards.Name = "lblRedCards";
            lblRedCards.Size = new Size(93, 76);
            lblRedCards.TabIndex = 5;
            lblRedCards.Text = "Red";
            lblRedCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlackCards
            // 
            lblBlackCards.AutoSize = true;
            lblBlackCards.Dock = DockStyle.Fill;
            lblBlackCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlackCards.ForeColor = SystemColors.ButtonHighlight;
            lblBlackCards.Location = new Point(399, 0);
            lblBlackCards.Name = "lblBlackCards";
            lblBlackCards.Size = new Size(93, 76);
            lblBlackCards.TabIndex = 4;
            lblBlackCards.Text = "Black";
            lblBlackCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlueCards
            // 
            lblBlueCards.AutoSize = true;
            lblBlueCards.Dock = DockStyle.Fill;
            lblBlueCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlueCards.ForeColor = SystemColors.ButtonHighlight;
            lblBlueCards.Location = new Point(300, 0);
            lblBlueCards.Name = "lblBlueCards";
            lblBlueCards.Size = new Size(93, 76);
            lblBlueCards.TabIndex = 3;
            lblBlueCards.Text = "Blue";
            lblBlueCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWhiteCards
            // 
            lblWhiteCards.AutoSize = true;
            lblWhiteCards.Dock = DockStyle.Fill;
            lblWhiteCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblWhiteCards.ForeColor = SystemColors.ButtonHighlight;
            lblWhiteCards.Location = new Point(201, 0);
            lblWhiteCards.Name = "lblWhiteCards";
            lblWhiteCards.Size = new Size(93, 76);
            lblWhiteCards.TabIndex = 2;
            lblWhiteCards.Text = "White";
            lblWhiteCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMulticolorCards
            // 
            lblMulticolorCards.AutoSize = true;
            lblMulticolorCards.Dock = DockStyle.Fill;
            lblMulticolorCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMulticolorCards.ForeColor = SystemColors.ButtonHighlight;
            lblMulticolorCards.Location = new Point(102, 0);
            lblMulticolorCards.Name = "lblMulticolorCards";
            lblMulticolorCards.Size = new Size(93, 76);
            lblMulticolorCards.TabIndex = 1;
            lblMulticolorCards.Text = "Multicolor";
            lblMulticolorCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLengendaryCards
            // 
            lblLengendaryCards.AutoSize = true;
            lblLengendaryCards.Dock = DockStyle.Fill;
            lblLengendaryCards.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblLengendaryCards.ForeColor = SystemColors.ButtonHighlight;
            lblLengendaryCards.Location = new Point(3, 0);
            lblLengendaryCards.Name = "lblLengendaryCards";
            lblLengendaryCards.Size = new Size(93, 76);
            lblLengendaryCards.TabIndex = 0;
            lblLengendaryCards.Text = "Legends";
            lblLengendaryCards.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowPanVerticalScroll
            // 
            flowPanVerticalScroll.AutoScroll = true;
            flowPanVerticalScroll.Dock = DockStyle.Fill;
            flowPanVerticalScroll.FlowDirection = FlowDirection.TopDown;
            flowPanVerticalScroll.Location = new Point(0, 110);
            flowPanVerticalScroll.Name = "flowPanVerticalScroll";
            flowPanVerticalScroll.Size = new Size(793, 547);
            flowPanVerticalScroll.TabIndex = 5;
            // 
            // FormDisplayCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 7, 109);
            ClientSize = new Size(793, 657);
            Controls.Add(flowPanVerticalScroll);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDisplayCards";
            Text = "FormDisplayCards";
            Shown += FormDisplayCards_Shown;
            panMain.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panMain;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblLengendaryCards;
        private Label lblColorlessCards;
        private Label lblGreenCards;
        private Label lblRedCards;
        private Label lblBlackCards;
        private Label lblBlueCards;
        private Label lblWhiteCards;
        private Label lblMulticolorCards;
        private FlowLayoutPanel flowPanVerticalScroll;
    }
}