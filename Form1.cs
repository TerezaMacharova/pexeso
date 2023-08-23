using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace pexeso
{
    public partial class Form1 : Form
    {
        private int NumberOfCards = 20; 
        private List<Button> cards = new List<Button>();
        private Button firstCard;
        private Button secondCard;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Interval = 650;

            panelChooseCards.Visible = true;
            panelLetsPlay.Visible = false;
            PanelGame.Visible = false;
        }

        private void btnConfirmCards_Click(object sender, EventArgs e)
        {
            if (numericUpDownCards.Value % 2 != 0)
            {
                MessageBox.Show("Oh, you have chosen an odd number! Please choose even one!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            panelChooseCards.Visible = false;
            panelLetsPlay.Visible = true;
        }

        private void btnLetsPlay (object sender, EventArgs e)
        {
            NumberOfCards = (int)numericUpDownCards.Value;
           // System.Diagnostics.Debug.WriteLine($"Number of cards: {NumberOfCards}");


            panelLetsPlay.Visible = false;
            PanelGame.Visible = true;

            StartGame();
        }
        private void StartGame()
        {
            var imageList = new List<Image>
            {
                Image.FromFile("resources/img1.jpg"),
                Image.FromFile("resources/img2.jpg"),
                Image.FromFile("resources/img3.jpg"),
                Image.FromFile("resources/img4.jpg"),
                Image.FromFile("resources/img5.jpg"),
                Image.FromFile("resources/img6.jpg"),
                Image.FromFile("resources/img7.jpg"),
                Image.FromFile("resources/img8.jpg"),
                Image.FromFile("resources/img9.jpg"),
                Image.FromFile("resources/img10.png"),
        };

            for (int i = 0; i < NumberOfCards; i++)
            {
                //System.Diagnostics.Debug.WriteLine($"Creating card {i + 1}");
                var btn = new Button
                {
                    Width = 100,
                    Height = 100,
                    Tag = new CardInfo
                    {
                        Value = i % (NumberOfCards / 2) + 1,
                        Image = imageList[i % (NumberOfCards / 2)],
                        IsMatched = false
                    },
                    BackColor = Color.LightPink,
                };

                btn.Click += CardClick;
                cards.Add(btn);
                PanelGame.Controls.Add(btn);
            }

            var rnd = new Random();
            var shuffledCards = cards.OrderBy(item => rnd.Next()).ToList();
            PanelGame.Controls.Clear();
            foreach (var Card in shuffledCards)
            {
                PanelGame.Controls.Add(Card);
            }
        }

        private void CardClick(object sender, EventArgs e)
        {
            var clickedCard = (Button)sender;
            var cardInfo = (CardInfo)clickedCard.Tag;

            if (clickedCard.BackColor == Color.LightGreen)
                return;

            if (cardInfo.IsMatched)
                return;

            clickedCard.BackgroundImage = cardInfo.Image;
            clickedCard.BackgroundImageLayout = ImageLayout.Stretch;

            if (firstCard == null)
            {
                firstCard = clickedCard;
            }
            else
            {
                secondCard = clickedCard;

                if (((CardInfo)firstCard.Tag).Value == ((CardInfo)secondCard.Tag).Value)
                {
                    firstCard.BackColor = Color.Green;
                    secondCard.BackColor = Color.Green;
                    ((CardInfo)firstCard.Tag).IsMatched = true;
                    ((CardInfo)secondCard.Tag).IsMatched = true;
                    firstCard = null;
                    secondCard = null;
                }
                else
                {
                    timer1.Start();
                }
            }

            if (AllPairsAreFound())
            {
                DialogResult result = MessageBox.Show("YOU WON! Do you want to play again?", "CONGRATULATIONS", MessageBoxButtons.YesNo);
                
            if (result == DialogResult.Yes)
                {
                    restartGameButton_Click(this, new EventArgs());
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            firstCard.BackgroundImage = null;
            secondCard.BackgroundImage = null;
            firstCard.BackColor = Color.LightPink;
            secondCard.BackColor = Color.LightPink;
            firstCard = null;
            secondCard = null;
            timer1.Stop();
        }

        private void restartGameButton_Click (object sender, EventArgs e)
        {
            cards.Clear();
            PanelGame.Controls.Clear();
            firstCard = null;
            secondCard= null;
            StartGame();
        }

        private bool AllPairsAreFound()
        {
            return cards.All(Card => ((CardInfo)Card.Tag).IsMatched);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void labelLetsPlay_Click(object sender, EventArgs e)
        {

        }
    }

    public class CardInfo
    {
        public int Value { get; set; }
        public Image Image { get; set; }
        public bool IsMatched { get; set; }
    }
}

