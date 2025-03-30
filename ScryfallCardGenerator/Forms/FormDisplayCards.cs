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

        const int IMAGE_MULTIPLIER = 3;

        public FormDisplayCards(List<CardInfo> cardInfos)
        {
            allCards = cardInfos;
            InitializeComponent();
            InitializeColorPanels();
            OrganizeAndAssignCards();

            this.Resize += FormDisplayCards_Resize; // Attach event
        }
        private void FormDisplayCards_Resize(object sender, EventArgs e)
        {
            int newOriginalWidth = this.ClientSize.Width / 10; // Adjust width dynamically
            int newOriginalHeight = (int)(newOriginalWidth * 1.5); // Maintain aspect ratio
            int newEnlargedWidth = newOriginalWidth * IMAGE_MULTIPLIER;
            int newEnlargedHeight = newOriginalHeight * IMAGE_MULTIPLIER;

            foreach (var panel in colorPanels.Values)
            {
                panel.Width = this.ClientSize.Width / 5; 
                panel.Height = this.ClientSize.Height;  // Match form height

                foreach(PictureBox pb  in panel.Controls)
                {
                    pb.Width = panel.Width / 3;
                    pb.Height = panel.Height / 3;
                    // Update event handlers to use new sizes
                    pb.MouseHover += (s, ev) =>
                    {
                        pb.Width = newEnlargedWidth;
                        pb.Height = newEnlargedHeight;
                        pb.BringToFront();
                    };

                    pb.MouseLeave += (s, ev) =>
                    {
                        pb.Width = newOriginalWidth;
                        pb.Height = newOriginalHeight;
                    };
                }
            }
        }
        void InitializeColorPanels()
        {
            // Initialize the dictionary to store panels
            colorPanels = new Dictionary<ColorCategory, FlowLayoutPanel>();

            // Create the panels for each ColorCategory
            foreach (ColorCategory category in Enum.GetValues(typeof(ColorCategory)))
            {
                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Width = 300,  // Adjust based on UI
                    Height = this.Height, // Adjust based on UI
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
            int originalWidth = 100;
            int originalHeight = 150;
            int enlargedWidth = originalWidth * IMAGE_MULTIPLIER;
            int enlargedHeight = originalHeight * IMAGE_MULTIPLIER;
            PictureBox pb = new PictureBox
            {
                Image = await card.GetImageAsync(card.ImageUrl),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 100,
                Height = 150,
                Margin = new Padding(5)
            };

            // Add event handlers
            pb.MouseHover += (sender, e) =>
            {
                PictureBox pic = sender as PictureBox;
                pic.Width = enlargedWidth;
                pic.Height = enlargedHeight;
                pic.BringToFront(); // Ensure it appears above other controls
            };

            pb.MouseLeave += (sender, e) =>
            {
                PictureBox pic = sender as PictureBox;
                pic.Width = originalWidth;
                pic.Height = originalHeight;
            };

            panel.Controls.Add(pb);
        }

        #endregion Carousel

        
    }
}
