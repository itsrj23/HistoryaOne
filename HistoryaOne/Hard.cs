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
    public partial class Hard : Form
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
        public Hard()
        {
            InitializeComponent();

            character = Image.FromFile("character.png");
        }
       private void timer1_Tick(object sender, EventArgs e)
        {
            rabbit.Left -= 1;

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

        private void timer1_Tick_1(object sender, EventArgs e)
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
        }
        
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            Canvas.DrawImage(character, positionX, positionY, width, height);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

       

        private void Hard_Load(object sender, EventArgs e)
        {
           timerEasy.Start();
            timer1.Start();
        }
    }
}
