using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryaOne
{
    public partial class Medium : Form
    {
        private bool questionAnsweredCorrectly = false;
        Image character;
        bool goLeft, goRight, goUp, goDown;
        int speed = 10;
        int positionX = 400;
        int positionY = 400;
        int height = 100;
        int width = 100;
        private bool questionShown = false;
        public Medium()
        {
            InitializeComponent();

            character = Image.FromFile("character.png");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void TimerEvent(object sender, EventArgs e)
        {
            if (goLeft && positionX > 0)
            {
                positionX -= speed;
            }
            if (goRight && positionX + width < this.ClientSize.Width)
            {
                positionX += speed;
            }
            if (goUp && positionY > 0)
            {
                positionY -= speed;
            }
            if (goDown && positionY + height < this.ClientSize.Height)
            {
                positionY += speed;
            }

            Rectangle doorRect = door1Medium.Bounds;
            Rectangle characterRect = new Rectangle(positionX, positionY, width, height);
            if (characterRect.IntersectsWith(doorRect) && !questionShown)
            {
                mediumQuestion1 questionForm = new mediumQuestion1();
                questionForm.Show();
                this.Hide();
                questionShown = true;
            }
            Rectangle doorRect1 = door2Medium.Bounds;
            Rectangle characterRect1 = new Rectangle(positionX, positionY, width, height);
            if (characterRect1.IntersectsWith(doorRect1) && !questionShown)
            {
                mediumQuestion2 questionForm = new mediumQuestion2();
                questionForm.Show();
                this.Hide();
                questionShown = true;
            }
            Rectangle doorRect2 = door3Medium.Bounds;
            Rectangle characterRect2 = new Rectangle(positionX, positionY, width, height);
            if (characterRect2.IntersectsWith(doorRect2) && !questionShown)
            {
                mediumQuestion3 questionForm = new mediumQuestion3();
                questionForm.Show();
                this.Hide();
                questionShown = true;
            }
            this.Invalidate();
        }
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            Canvas.DrawImage(character, positionX, positionY, width, height);
        }
    }
}
