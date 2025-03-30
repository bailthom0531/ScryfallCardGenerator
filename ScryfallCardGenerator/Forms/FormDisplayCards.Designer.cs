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
            flowPanVerticalScroll = new FlowLayoutPanel();
            flowPanLegendaryCards = new FlowLayoutPanel();
            flowPanColorlessCards = new FlowLayoutPanel();
            flowPanMultiColorCards = new FlowLayoutPanel();
            flowPanWhiteCards = new FlowLayoutPanel();
            flowPanBlueCards = new FlowLayoutPanel();
            flowPanBlackCards = new FlowLayoutPanel();
            flowPanRedCards = new FlowLayoutPanel();
            flowPanGreenCards = new FlowLayoutPanel();
            panMain.SuspendLayout();
            flowPanVerticalScroll.SuspendLayout();
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
            btnMinimize.Location = new Point(719, 0);
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
            // flowPanVerticalScroll
            // 
            flowPanVerticalScroll.AutoScroll = true;
            flowPanVerticalScroll.Controls.Add(flowPanLegendaryCards);
            flowPanVerticalScroll.Controls.Add(flowPanColorlessCards);
            flowPanVerticalScroll.Controls.Add(flowPanMultiColorCards);
            flowPanVerticalScroll.Controls.Add(flowPanWhiteCards);
            flowPanVerticalScroll.Controls.Add(flowPanBlueCards);
            flowPanVerticalScroll.Controls.Add(flowPanBlackCards);
            flowPanVerticalScroll.Controls.Add(flowPanRedCards);
            flowPanVerticalScroll.Controls.Add(flowPanGreenCards);
            flowPanVerticalScroll.Dock = DockStyle.Fill;
            flowPanVerticalScroll.FlowDirection = FlowDirection.TopDown;
            flowPanVerticalScroll.Location = new Point(0, 34);
            flowPanVerticalScroll.Name = "flowPanVerticalScroll";
            flowPanVerticalScroll.Size = new Size(793, 623);
            flowPanVerticalScroll.TabIndex = 3;
            // 
            // flowPanLegendaryCards
            // 
            flowPanLegendaryCards.BackColor = Color.Yellow;
            flowPanLegendaryCards.Dock = DockStyle.Top;
            flowPanLegendaryCards.Location = new Point(3, 3);
            flowPanLegendaryCards.Name = "flowPanLegendaryCards";
            flowPanLegendaryCards.Size = new Size(200, 89);
            flowPanLegendaryCards.TabIndex = 0;
            // 
            // flowPanColorlessCards
            // 
            flowPanColorlessCards.BackColor = Color.Gray;
            flowPanColorlessCards.Dock = DockStyle.Top;
            flowPanColorlessCards.Location = new Point(3, 98);
            flowPanColorlessCards.Name = "flowPanColorlessCards";
            flowPanColorlessCards.Size = new Size(200, 100);
            flowPanColorlessCards.TabIndex = 1;
            // 
            // flowPanMultiColorCards
            // 
            flowPanMultiColorCards.BackColor = Color.FromArgb(192, 192, 0);
            flowPanMultiColorCards.Dock = DockStyle.Top;
            flowPanMultiColorCards.Location = new Point(3, 204);
            flowPanMultiColorCards.Name = "flowPanMultiColorCards";
            flowPanMultiColorCards.Size = new Size(200, 87);
            flowPanMultiColorCards.TabIndex = 2;
            // 
            // flowPanWhiteCards
            // 
            flowPanWhiteCards.BackColor = Color.White;
            flowPanWhiteCards.Dock = DockStyle.Top;
            flowPanWhiteCards.Location = new Point(3, 297);
            flowPanWhiteCards.Name = "flowPanWhiteCards";
            flowPanWhiteCards.Size = new Size(200, 60);
            flowPanWhiteCards.TabIndex = 3;
            // 
            // flowPanBlueCards
            // 
            flowPanBlueCards.BackColor = Color.Blue;
            flowPanBlueCards.Location = new Point(3, 363);
            flowPanBlueCards.Name = "flowPanBlueCards";
            flowPanBlueCards.Size = new Size(200, 37);
            flowPanBlueCards.TabIndex = 4;
            // 
            // flowPanBlackCards
            // 
            flowPanBlackCards.BackColor = Color.Black;
            flowPanBlackCards.Dock = DockStyle.Top;
            flowPanBlackCards.Location = new Point(3, 406);
            flowPanBlackCards.Name = "flowPanBlackCards";
            flowPanBlackCards.Size = new Size(200, 53);
            flowPanBlackCards.TabIndex = 5;
            // 
            // flowPanRedCards
            // 
            flowPanRedCards.BackColor = Color.FromArgb(192, 0, 0);
            flowPanRedCards.Dock = DockStyle.Top;
            flowPanRedCards.Location = new Point(3, 465);
            flowPanRedCards.Name = "flowPanRedCards";
            flowPanRedCards.Size = new Size(200, 78);
            flowPanRedCards.TabIndex = 6;
            // 
            // flowPanGreenCards
            // 
            flowPanGreenCards.BackColor = Color.Green;
            flowPanGreenCards.Dock = DockStyle.Fill;
            flowPanGreenCards.Location = new Point(3, 549);
            flowPanGreenCards.Name = "flowPanGreenCards";
            flowPanGreenCards.Size = new Size(200, 8);
            flowPanGreenCards.TabIndex = 7;
            // 
            // FormDisplayCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 7, 109);
            ClientSize = new Size(793, 657);
            Controls.Add(flowPanVerticalScroll);
            Controls.Add(panMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDisplayCards";
            Text = "FormDisplayCards";
            panMain.ResumeLayout(false);
            flowPanVerticalScroll.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panMain;
        private Button btnMinimize;
        private Button btnClose;
        private FlowLayoutPanel flowPanVerticalScroll;
        private FlowLayoutPanel flowPanLegendaryCards;
        private FlowLayoutPanel flowPanColorlessCards;
        private FlowLayoutPanel flowPanMultiColorCards;
        private FlowLayoutPanel flowPanWhiteCards;
        private FlowLayoutPanel flowPanBlueCards;
        private FlowLayoutPanel flowPanBlackCards;
        private FlowLayoutPanel flowPanRedCards;
        private FlowLayoutPanel flowPanGreenCards;
    }
}