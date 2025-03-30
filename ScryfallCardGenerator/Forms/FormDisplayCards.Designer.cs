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
            flowPanVerticalScroll = new FlowLayoutPanel();
            panMain.SuspendLayout();
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
            // flowPanVerticalScroll
            // 
            flowPanVerticalScroll.AutoScroll = true;
            flowPanVerticalScroll.Dock = DockStyle.Fill;
            flowPanVerticalScroll.FlowDirection = FlowDirection.TopDown;
            flowPanVerticalScroll.Location = new Point(0, 34);
            flowPanVerticalScroll.Name = "flowPanVerticalScroll";
            flowPanVerticalScroll.Size = new Size(793, 623);
            flowPanVerticalScroll.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panMain;
        private Button btnClose;
        private FlowLayoutPanel flowPanVerticalScroll;
        private Button btnMaximize;
        private Button btnMinimize;
    }
}