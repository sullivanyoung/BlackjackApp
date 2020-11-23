using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_App
{
    public partial class Blackjack : Form
    {
        /*
        11 = Jack
        12 = Queen
        13 = King
        14 = Ace
         */
        public static int[] cards = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public static Random random = new Random();
        public static int userCard1;
        public static int userCard2;

        public Blackjack()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            userCard1 = cards[random.Next(cards.Length)];

            switch (userCard1)
            {
                case 0:
                    pbx2C.BringToFront();
                    break;
                case 1:
                    pbx3C.BringToFront();
                    break;
            }
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pbxTopUser1.BringToFront();
            pbxTopUser2.BringToFront();
            pbxTopDealer1.BringToFront();
            pbxTopDealer2.BringToFront();
            pbxTopDealt1.BringToFront();
            pbxTopDealt2.BringToFront();
            pbxTopDealt3.BringToFront();
        }
    }
}
