using ScryfallCardGenerator.Forms;
using ScryfallCardGenerator.Tools;

namespace ScryfallCardGenerator
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public MainForm()
        {
            InitializeComponent();
        }
        #region Main UI Events
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

        private void rtbCardCount_TextChanged(object sender, EventArgs e)
        {

        }
        private async void btnRandomize_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(rtbCardCount.Text, out int randomCount) || randomCount <= 0)
            {
                MessageBox.Show("Please enter a valid positive number.");
                return;
            }

            // Fetch cards asynchronously
            List<CardInfo> cardInfos = await RandomizeAmountOfCards(randomCount);

            // Ensure UI thread access for Windows Forms
            this.BeginInvoke(new Action(() =>
            {
                FormDisplayCards formDisplayCards = new FormDisplayCards(cardInfos);
                formDisplayCards.Show();
            }));
        }
        #endregion Main UI Events
        private async Task<List<CardInfo>> RandomizeAmountOfCards(int randomCount)
        {
            ScryfallClient client = new ScryfallClient();
            List<CardInfo> cardInfos = new List<CardInfo>();
            for (int i = 0; i < randomCount; i++)
            {
                CardInfo cardInfo = new CardInfo();
                cardInfo = await client.GetRandomCardAsync();
                cardInfos.Add(cardInfo);
                Thread.Sleep(150);
            }
            return cardInfos;
        }
    }
}