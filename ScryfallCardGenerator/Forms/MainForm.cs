using ScryfallCardGenerator.Forms;
using ScryfallCardGenerator.Tools;

namespace ScryfallCardGenerator
{
    public partial class MainForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        int activeCount;
        int totalCount;
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
            if (String.IsNullOrEmpty(rtbCardCount.Text))
            {
                rtbCardCount.Text = "0";
            }
            if (!int.TryParse(rtbCardCount.Text, out totalCount) || totalCount < 0)
            {
                MessageBox.Show("Please enter a valid positive number.");
                return;
            }
            UpdateLiveCount();
        }
        private void rtbCardCount_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnRandomize_Click(sender, e);
            }
        }
        private async void btnRandomize_Click(object sender, EventArgs e)
        {
            if (activeCount == 0)
            {
                if (!int.TryParse(rtbCardCount.Text, out int randomCount) || randomCount < 0)
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
                    formDisplayCards.ShowDialog();

                    activeCount = 0;
                    UpdateLiveCount();
                }));

            }
        }
        #endregion Main UI Events
        void UpdateLiveCount()
        {
            if (lblLiveCount.InvokeRequired)
            {
                lblLiveCount.Invoke(new Action(UpdateLiveCount), activeCount, totalCount);
            }
            else
            {
                lblLiveCount.Text = $"{activeCount:000}/{totalCount:000}";
            }
        }
        private async Task<List<CardInfo>> RandomizeAmountOfCards(int randomCount)
        {
            ScryfallClient client = new ScryfallClient();
            List<CardInfo> cardInfos = new List<CardInfo>();
            for (int i = 0; i < randomCount; i++)
            {
                activeCount = i;
                CardInfo cardInfo = new CardInfo();
                cardInfo = await client.GetRandomCardAsync();
                cardInfos.Add(cardInfo);
                Thread.Sleep(150);
                UpdateLiveCount();
            }
            return cardInfos;
        }

        
    }
}