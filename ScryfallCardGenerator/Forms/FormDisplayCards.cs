using ScryfallCardGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ScryfallCardGenerator.Forms
{
    public partial class FormDisplayCards : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        Dictionary<ColorCategory, FlowLayoutPanel> colorPanels = new Dictionary<ColorCategory, FlowLayoutPanel>();
        private List<CardInfo> allCards;
        private Dictionary<ColorCategory, List<CardInfo>> categorizedCards;

        public FormDisplayCards(List<CardInfo> cardInfos)
        {
            this.WindowState = FormWindowState.Maximized;

            allCards = cardInfos;
            InitializeComponent();
        }
        private void FormDisplayCards_Shown(object sender, EventArgs e)
        {
            InitializeColorPanels();
            OrganizeAndAssignCards();
        }

        void InitializeColorPanels()
        {
            // Initialize the dictionary to store panels
            colorPanels = new Dictionary<ColorCategory, FlowLayoutPanel>();
            int colorCount = Enum.GetValues(typeof(ColorCategory)).Length;

            // Create the panels for each ColorCategory
            foreach (ColorCategory category in Enum.GetValues(typeof(ColorCategory)))
            {
                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Width = (int)(this.ClientSize.Width / (colorCount + .1)),  // Adjust based on UI
                    Height = (int)(this.ClientSize.Height * 0.75), // Adjust based on UI
                    AutoScroll = true,  // Allow vertical scrolling within each panel
                    BorderStyle = BorderStyle.FixedSingle
                };

                colorPanels[category] = panel;  // Use the ColorCategory enum as the key
                flowPanVerticalScroll.Controls.Add(panel); // Add panel to the container (Vertical scroll panel)
            }
        }

        #region Top Panel
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }
        private void panMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion Top Panel

        #region Data Mangement
        enum ColorCategory
        {
            Legendary, Multicolor, White, Blue, Black, Red, Green, Colorless
        }
        void OrganizeAndAssignCards()
        {
            // Initialize dictionary with empty lists
            categorizedCards = new Dictionary<ColorCategory, List<CardInfo>>();
            foreach (ColorCategory category in Enum.GetValues(typeof(ColorCategory)))
            {
                categorizedCards[category] = new List<CardInfo>();
            }

            // Categorize and assign each card
            foreach (CardInfo card in allCards)
            {
                ColorCategory category;

                // Check if card is a Legendary Creature
                if (card.TypeLine.Contains("Legendary Creature"))
                {
                    category = ColorCategory.Legendary;
                }
                // Check if ColorIdentity is empty (colorless)
                else if (card.ColorIdentity == null || card.ColorIdentity.Count == 0)
                {
                    category = ColorCategory.Colorless;
                }
                // If the card has only one color
                else if (card.ColorIdentity.Count == 1)
                {
                    switch (card.ColorIdentity[0])
                    {
                        case "W": category = ColorCategory.White; break;
                        case "U": category = ColorCategory.Blue; break;
                        case "B": category = ColorCategory.Black; break;
                        case "R": category = ColorCategory.Red; break;
                        case "G": category = ColorCategory.Green; break;
                        default: category = ColorCategory.Multicolor; break;
                    }
                }
                // If the card has multiple colors
                else
                {
                    category = ColorCategory.Multicolor;
                }

                // Add to dictionary
                categorizedCards[category].Add(card);

                // Assign to UI panel if it exists
                if (colorPanels.ContainsKey(category))
                {
                    AddCardToPanel(colorPanels[category], card);
                }
            }
        }
        #endregion Data Mangement

        #region Carousel
        async Task AddCardToPanel(FlowLayoutPanel panel, CardInfo card)
        {
            const double ASPECT_RATIO = 0.714; // Width:Height
            const int IMAGE_MULTIPLIER = 2; // Scale factor for enlargement

            int originalWidth = (int)(panel.Width / 1.5);
            int originalHeight = (int)(originalWidth / ASPECT_RATIO);
            int enlargedWidth = originalWidth * IMAGE_MULTIPLIER;
            int enlargedHeight = (int)(enlargedWidth / ASPECT_RATIO);

            PictureBox pb = new PictureBox
            {
                Image = await card.GetImageAsync(card.ImageUrl),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = originalWidth,
                Height = originalHeight,
                Margin = new Padding(5),
                Tag = new Size(originalWidth, originalHeight) // Store original size
            };

            // Overlay PictureBox (hidden by default)
            PictureBox enlargedPb = new PictureBox
            {
                Image = pb.Image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = enlargedWidth,
                Height = enlargedHeight,
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.None
            };

            // Add event handlers
            pb.MouseHover += (sender, e) =>
            {
                // Convert the PictureBox's position to form coordinates
                Point screenPos = pb.PointToScreen(Point.Empty);
                Point formPos = this.PointToClient(screenPos);

                // Ensure enlarged PictureBox is not inside FlowLayoutPanel
                if (!this.Controls.Contains(enlargedPb))
                {
                    this.Controls.Add(enlargedPb);
                }
                enlargedPb.BringToFront();

                // Set image, size, and position
                enlargedPb.Image = pb.Image;
                enlargedPb.Size = new Size(enlargedWidth, enlargedHeight);
                enlargedPb.Location = new Point(
                    formPos.X - (enlargedPb.Width - pb.Width) / 2,
                    formPos.Y - (enlargedPb.Height - pb.Height) / 2
                );


                // Get the lowest Y coordinate on the screen (furthest bottom)
                Screen screen = Screen.PrimaryScreen;
                int lowestY = screen.Bounds.Bottom;
                int furthestRight = screen.Bounds.Right;

                if (enlargedPb.Location.Y < 0) { enlargedPb.Location = new Point(enlargedPb.Location.X, 0); }
                if (enlargedPb.Location.Y > lowestY + enlargedHeight) { enlargedPb.Location = new Point(enlargedPb.Location.X, lowestY - enlargedHeight); }
                if (enlargedPb.Location.X < 0) { enlargedPb.Location = new Point(0, enlargedPb.Location.Y); }
                if (enlargedPb.Location.X > furthestRight + enlargedWidth) { enlargedPb.Location = new Point(furthestRight - enlargedWidth, enlargedPb.Location.Y); }

                enlargedPb.Visible = true;
                enlargedPb.MouseLeave += (sender, e) =>
                {
                    enlargedPb.Visible = false;
                    enlargedPb.Parent?.Controls.Remove(enlargedPb);
                };
            };

            panel.Controls.Add(pb);
        }
        #endregion Carousel
    }
}
