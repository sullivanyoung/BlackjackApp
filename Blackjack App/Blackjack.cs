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
        public static int dealerCard1;
        public static int dealerCard2;
        public static int dealtCard1;
        public static int dealtCard2;
        public static int dealtCard3;
        public static int user1;
        public static int user2;
        public static int dealer1;
        public static int dealer2;
        public static int dealt1;
        public static int dealt2;
        public static int dealt3;
        public static int lossAmount;
        public static int winAmount;
        public static int userTotal;
        public static int dealerTotal;

        public Blackjack()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            userCard1 = cards[random.Next(cards.Length)];
            userCard2 = cards[random.Next(cards.Length)];
            dealerCard1 = cards[random.Next(cards.Length)];
            dealerCard2 = cards[random.Next(cards.Length)];

            pbxTopDealer2.BringToFront();

            switch (userCard1)
            {
                case 2:
                    pbx2C.BringToFront();
                    user1 = 2;
                    break;
                case 3:
                    pbx3C.BringToFront();
                    user1 = 3;
                    break;
                case 4:
                    pbx4C.BringToFront();
                    user1 = 4;
                    break;
                case 5:
                    pbx5C.BringToFront();
                    user1 = 5;
                    break;
                case 6:
                    pbx6C.BringToFront();
                    user1 = 6;
                    break;
                case 7:
                    pbx7C.BringToFront();
                    user1 = 7;
                    break;
                case 8:
                    pbx8C.BringToFront();
                    user1 = 8;
                    break;
                case 9:
                    pbx9C.BringToFront();
                    user1 = 9;
                    break;
                case 10:
                    pbx10C.BringToFront();
                    user1 = 10;
                    break;
                case 11:
                    pbxJC.BringToFront();
                    user1 = 10;
                    break;
                case 12:
                    pbxQC.BringToFront();
                    user1 = 10;
                    break;
                case 13:
                    pbxKC.BringToFront();
                    user1 = 10;
                    break;
                case 14:
                    pbxAC.BringToFront();
                    user1 = 11;
                    break;
            }

            switch (userCard2)
            {
                case 2:
                    pbx2CUser2.BringToFront();
                    user2 = 2;
                    break;
                case 3:
                    pbx3CUser2.BringToFront();
                    user2 = 3;
                    break;
                case 4:
                    pbx4CUser2.BringToFront();
                    user2 = 4;
                    break;
                case 5:
                    pbx5CUser2.BringToFront();
                    user2 = 5;
                    break;
                case 6:
                    pbx6CUser2.BringToFront();
                    user2 = 6;
                    break;
                case 7:
                    pbx7CUser2.BringToFront();
                    user2 = 7;
                    break;
                case 8:
                    pbx8CUser2.BringToFront();
                    user2 = 8;
                    break;
                case 9:
                    pbx9CUser2.BringToFront();
                    user2 = 9;
                    break;
                case 10:
                    pbx10CUser2.BringToFront();
                    user2 = 10;
                    break;
                case 11:
                    pbxJCUser2.BringToFront();
                    user2 = 10;
                    break;
                case 12:
                    pbxQCUser2.BringToFront();
                    user2 = 10;
                    break;
                case 13:
                    pbxKCUser2.BringToFront();
                    user2 = 10;
                    break;
                case 14:
                    pbxACUser2.BringToFront();
                    user2 = 11;
                    break;
            }

            switch (dealerCard1)
            {
                case 2:
                    pbx2CDealer1.BringToFront();
                    dealer1 = 2;
                    break;
                case 3:
                    pbx3CDealer1.BringToFront();
                    dealer1 = 3;
                    break;
                case 4:
                    pbx4CDealer1.BringToFront();
                    dealer1 = 4;
                    break;
                case 5:
                    pbx5CDealer1.BringToFront();
                    dealer1 = 5;
                    break;
                case 6:
                    pbx6CDealer1.BringToFront();
                    dealer1 = 6;
                    break;
                case 7:
                    pbx7CDealer1.BringToFront();
                    dealer1 = 7;
                    break;
                case 8:
                    pbx8CDealer1.BringToFront();
                    dealer1 = 8;
                    break;
                case 9:
                    pbx9CDealer1.BringToFront();
                    dealer1 = 9;
                    break;
                case 10:
                    pbx10CDealer1.BringToFront();
                    dealer1 = 10;
                    break;
                case 11:
                    pbxJCDealer1.BringToFront();
                    dealer1 = 10;
                    break;
                case 12:
                    pbxQCDealer1.BringToFront();
                    dealer1 = 10;
                    break;
                case 13:
                    pbxKCDealer1.BringToFront();
                    dealer1 = 10;
                    break;
                case 14:
                    pbxACDealer1.BringToFront();
                    dealer1 = 11;
                    break;
            }

            switch (dealerCard2)
            {
                case 2:
                    dealer2 = 2;
                    break;
                case 3:
                    dealer2 = 3;
                    break;
                case 4:
                    dealer2 = 4;
                    break;
                case 5:
                    dealer2 = 5;
                    break;
                case 6:
                    dealer2 = 6;
                    break;
                case 7:
                    dealer2 = 7;
                    break;
                case 8:
                    dealer2 = 8;
                    break;
                case 9:
                    dealer2 = 9;
                    break;
                case 10:
                    dealer2 = 10;
                    break;
                case 11:
                    dealer2 = 10;
                    break;
                case 12:
                    dealer2 = 10;
                    break;
                case 13:
                    dealer2 = 10;
                    break;
                case 14:
                    dealer2 = 11;
                    break;                    
            }

            userTotal = user1 + user2;
            dealerTotal = dealer1 + dealer2;

            pbxTopDealt1.BringToFront();

            btnHit.Visible = true;
            btnReady.Visible = true;
            btnDeal.Visible = false;
        }

        private void Blackjack_Load(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnReady.Visible = false;
            btnHit2.Visible = false;
            btnHit3.Visible = false;
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
            lblWinAmount.Text = "";
            lblLossAmount.Text = "";
            winAmount = 0;
            lossAmount = 0;
            btnHit.Visible = false;
            btnDeal.Visible = true;
            btnReady.Visible = false;
            btnHit2.Visible = false;
            btnHit3.Visible = false;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            dealtCard1 = cards[random.Next(cards.Length)];

            switch (dealtCard1)
            {
                case 2:
                    pbx2CDealt1.BringToFront();
                    dealt1 = 2;
                    break;
                case 3:
                    pbx3CDealt1.BringToFront();
                    dealt1 = 3;
                    break;
                case 4:
                    pbx4CDealt1.BringToFront();
                    dealt1 = 4;
                    break;
                case 5:
                    pbx5CDealt1.BringToFront();
                    dealt1 = 5;
                    break;
                case 6:
                    pbx6CDealt1.BringToFront();
                    dealt1 = 6;
                    break;
                case 7:
                    pbx7CDealt1.BringToFront();
                    dealt1 = 7;
                    break;
                case 8:
                    pbx8CDealt1.BringToFront();
                    dealt1 = 8;
                    break;
                case 9:
                    pbx9CDealt1.BringToFront();
                    dealt1 = 9;
                    break;
                case 10:
                    pbx10CDealt1.BringToFront();
                    dealt1 = 10;
                    break;
                case 11:
                    pbxJCDealt1.BringToFront();
                    dealt1 = 10;
                    break;
                case 12:
                    pbxQCDealt1.BringToFront();
                    dealt1 = 10;
                    break;
                case 13:
                    pbxKCDealt1.BringToFront();
                    dealt1 = 10;
                    break;
                case 14:
                    pbxACDealt1.BringToFront();
                    dealt1 = 11;
                    break;
            }

            userTotal = userTotal + dealt1;
            if(userTotal > 21)
            {
                MessageBox.Show($"You broke 21. You lost.");
                lossAmount = lossAmount + 1;
                lblLossAmount.Text = Convert.ToString(lossAmount);
                btnReady.Visible = false;
                btnHit.Visible = false;
                btnDeal.Visible = true;
            }
            else
            {
                btnHit2.Visible = true;
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            switch (dealerCard2)
            {
                case 2:
                    pbx2CDealer2.BringToFront();
                    break;
                case 3:
                    pbx3CDealer2.BringToFront();
                    break;
                case 4:
                    pbx4CDealer2.BringToFront();
                    break;
                case 5:
                    pbx5CDealer2.BringToFront();
                    break;
                case 6:
                    pbx6CDealer2.BringToFront();
                    break;
                case 7:
                    pbx7CDealer2.BringToFront();
                    break;
                case 8:
                    pbx8CDealer2.BringToFront();
                    break;
                case 9:
                    pbx9CDealer2.BringToFront();
                    break;
                case 10:
                    pbx10CDealer2.BringToFront();
                    break;
                case 11:
                    pbxJCDealer2.BringToFront();
                    break;
                case 12:
                    pbxQCDealer2.BringToFront();
                    break;
                case 13:
                    pbxKCDealer2.BringToFront();
                    break;
                case 14:
                    pbxACDealer2.BringToFront();
                    break;
            }

            if (dealerTotal >= userTotal && dealerTotal < 21)
            {
                MessageBox.Show($"You lost. The dealer had {dealerTotal} points and you had {userTotal} points.");
                lossAmount = lossAmount + 1;
                lblLossAmount.Text = Convert.ToString(lossAmount);
            }
            else if(dealerTotal == 21)
            {
                MessageBox.Show($"The dealer had blackjack, {dealerTotal}! You lost.");
                lossAmount = lossAmount + 1;
                lblLossAmount.Text = Convert.ToString(lossAmount);
            }
            else if (userTotal == 21)
            {
                MessageBox.Show($"You had blackjack {userTotal}! You won!");
                winAmount = winAmount + 1;
                lblWinAmount.Text = Convert.ToString(winAmount);
            }
            else
            {
                MessageBox.Show($"You won! The dealer had {dealerTotal} points and you had {userTotal} points.");
                winAmount = winAmount + 1;
                lblWinAmount.Text = Convert.ToString(winAmount);
            }

            pbxTopUser1.BringToFront();
            pbxTopUser2.BringToFront();
            pbxTopDealer1.BringToFront();
            pbxTopDealer2.BringToFront();
            pbxTopDealt1.BringToFront();
            pbxTopDealt2.BringToFront();
            pbxTopDealt3.BringToFront();

            btnDeal.Visible = true;
            btnReady.Visible = false;
            btnHit.Visible = false;
            btnHit3.Visible = false;
            btnHit2.Visible = false;


        }

        private void btnHit2_Click(object sender, EventArgs e)
        {
            dealtCard2 = cards[random.Next(cards.Length)];

            switch (dealtCard2)
            {
                case 2:
                    pbx2CDealt2.BringToFront();
                    dealt2 = 2;
                    break;
                case 3:
                    pbx3CDealt2.BringToFront();
                    dealt2 = 3;
                    break;
                case 4:
                    pbx4CDealt2.BringToFront();
                    dealt2 = 4;
                    break;
                case 5:
                    pbx5CDealt2.BringToFront();
                    dealt2 = 5;
                    break;
                case 6:
                    pbx6CDealt2.BringToFront();
                    dealt2 = 6;
                    break;
                case 7:
                    pbx7CDealt2.BringToFront();
                    dealt2 = 7;
                    break;
                case 8:
                    pbx8CDealt2.BringToFront();
                    dealt2 = 8;
                    break;
                case 9:
                    pbx9CDealt2.BringToFront();
                    dealt2 = 9;
                    break;
                case 10:
                    pbx10CDealt2.BringToFront();
                    dealt2 = 10;
                    break;
                case 11:
                    pbxJCDealt2.BringToFront();
                    dealt2 = 10;
                    break;
                case 12:
                    pbxQCDealt2.BringToFront();
                    dealt2 = 10;
                    break;
                case 13:
                    pbxKCDealt2.BringToFront();
                    dealt2 = 10;
                    break;
                case 14:
                    pbxACDealt2.BringToFront();
                    dealt2 = 11;
                    break;
            }

            userTotal = userTotal + dealt2;
            if (userTotal > 21)
            {
                MessageBox.Show($"You broke 21. You lost.");
                lossAmount = lossAmount + 1;
                lblLossAmount.Text = Convert.ToString(lossAmount);
                btnReady.Visible = false;
                btnHit2.Visible = false;
                btnDeal.Visible = true;
            }
            else
            {
                btnHit3.Visible = true;
            }
        }

        private void btnHit3_Click(object sender, EventArgs e)
        {
            dealtCard3 = cards[random.Next(cards.Length)];

            switch (dealtCard3)
            {
                case 2:
                    pbx2CDealt3.BringToFront();
                    dealt3 = 2;
                    break;
                case 3:
                    pbx3CDealt3.BringToFront();
                    dealt3 = 3;
                    break;
                case 4:
                    pbx4CDealt3.BringToFront();
                    dealt3 = 4;
                    break;
                case 5:
                    pbx5CDealt3.BringToFront();
                    dealt3 = 5;
                    break;
                case 6:
                    pbx6CDealt3.BringToFront();
                    dealt3 = 6;
                    break;
                case 7:
                    pbx7CDealt3.BringToFront();
                    dealt3 = 7;
                    break;
                case 8:
                    pbx8CDealt3.BringToFront();
                    dealt3 = 8;
                    break;
                case 9:
                    pbx9CDealt3.BringToFront();
                    dealt3 = 9;
                    break;
                case 10:
                    pbx10CDealt3.BringToFront();
                    dealt3 = 10;
                    break;
                case 11:
                    pbxJCDealt3.BringToFront();
                    dealt3 = 10;
                    break;
                case 12:
                    pbxQCDealt3.BringToFront();
                    dealt3 = 10;
                    break;
                case 13:
                    pbxKCDealt3.BringToFront();
                    dealt3 = 10;
                    break;
                case 14:
                    pbxACDealt3.BringToFront();
                    dealt3 = 11;
                    break;
            }

            userTotal = userTotal + dealt3;
            if (userTotal > 21)
            {
                MessageBox.Show($"You broke 21. You lost.");
                lossAmount = lossAmount + 1;
                lblLossAmount.Text = Convert.ToString(lossAmount);
                btnReady.Visible = false;
                btnHit3.Visible = false;
                btnDeal.Visible = true;
            }
        }
    }
}
