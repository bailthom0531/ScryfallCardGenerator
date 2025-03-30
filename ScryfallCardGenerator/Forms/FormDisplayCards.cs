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

        private List<CardInfo> allCards;
        List<CardInfo> displayedCards; // Holds the 5 currently displayed cards

        System.Timers.Timer scrollTimer;
        private Dictionary<ColorCategory, List<CardInfo>> categorizedCards;
        int shiftDirection = 0; // -1 for left, 1 for righ

        public enum ColorCategory
        {
            Legendary,
            Colorless,
            Multicolor,
            White,
            Blue,
            Black,
            Red,
            Green
        }

        public FormDisplayCards(List<CardInfo> cardInfos)
        {
            InitializeComponent();
            InitializeCarousel();
            allCards = cardInfos;
            OrganizeCardsByColor();
        }

        #region Top Panel
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void OrganizeCardsByColor()
        {
            // Initialize dictionary with empty lists
            categorizedCards = new Dictionary<ColorCategory, List<CardInfo>>();
            foreach (ColorCategory category in Enum.GetValues(typeof(ColorCategory)))
            {
                categorizedCards[category] = new List<CardInfo>();
            }

            // Categorize each card
            foreach (CardInfo card in allCards)
            {
                if (card.TypeLine.Contains("Legendary Creature"))
                {
                    categorizedCards[ColorCategory.Legendary].Add(card);
                }
                else if (string.IsNullOrEmpty(card.ColorIdentity))
                {
                    categorizedCards[ColorCategory.Colorless].Add(card);
                }
                else if (card.ColorIdentity.Length == 1) // Only monocolor cards
                {
                    switch (card.ColorIdentity)
                    {
                        case "W": categorizedCards[ColorCategory.White].Add(card); break;
                        case "U": categorizedCards[ColorCategory.Blue].Add(card); break;
                        case "B": categorizedCards[ColorCategory.Black].Add(card); break;
                        case "R": categorizedCards[ColorCategory.Red].Add(card); break;
                        case "G": categorizedCards[ColorCategory.Green].Add(card); break;
                    }
                }
                else
                {
                    categorizedCards[ColorCategory.Multicolor].Add(card);
                }
            }
        }
        #endregion Data Mangement

        #region Carousel
        void InitializeCarousel()
        {
            // Initialize display list with first 5 images
            displayedCards = allCards.Take(5).ToList();

            // Setup Timer for smooth animation
            scrollTimer = new System.Timers.Timer { Interval = 50 };
            scrollTimer.Tick += ScrollTimer_Tick;

            // Populate initial images
            UpdateFlowPanel();
        }
        void UpdateFlowPanel(FlowLayoutPanel flowPanel)
        {
            flowPanel.Controls.Clear();
            foreach (var img in displayedImages)
            {
                PictureBox pb = new PictureBox
                {
                    Image = img,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5)
                };
                flowPanel.Controls.Add(pb);
            }
        }
        void ScrollLeft()
        {
            shiftDirection = -1;
            scrollTimer.Start();
        }

        void ScrollRight()
        {
            shiftDirection = 1;
            scrollTimer.Start();
        }
        #endregion
    }
}
