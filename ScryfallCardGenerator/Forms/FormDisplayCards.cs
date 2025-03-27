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

namespace ScryfallCardGenerator.Forms
{
    public partial class FormDisplayCards : Form
    {
        public FormDisplayCards(List<CardInfo> cardInfos)
        {
            InitializeComponent();
        }
    }
}
