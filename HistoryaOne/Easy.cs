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
    public partial class Easy : Form
    {
        private bool questionAnsweredCorrectly = false;
        Image character;
        bool goLeft, goRight, goUp, goDown;
        int speed = 10;
        int positionX = 200;
        int positionY = 200;
        int height = 100;
        int width = 100;
        private bool questionShown = false;

        private int livesRemaining = 3;
        private List<PictureBox> heartPictureBoxes;
        public Easy()
        {
            InitializeComponent();

            character = Image.FromFile("character.png");
            InitializeHeartPictureBoxes();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void InitializeHeartPictureBoxes()
        {
            heartPictureBoxes = new List<PictureBox> { heart1, heart2, heart3 };
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

            Rectangle doorRect = door1Easy.Bounds;
            Rectangle characterRect = new Rectangle(positionX, positionY, width, height);
            if (characterRect.IntersectsWith(doorRect) && !questionShown)
            {
                easyQuestion1 questionForm = new easyQuestion1(this);
                questionForm.Show();
                this.Hide();
                questionShown = true;
            }

          
            Rectangle doorRect2 = door2Easy.Bounds;
            Rectangle characterRect1 = new Rectangle(positionX, positionY, width, height);
            if (characterRect1.IntersectsWith(doorRect2) && !questionShown)
            {
                easyQuestion2 questionForm = new easyQuestion2();
                questionForm.Show();
                this.Hide();
                questionShown = true;
            }

            this.Invalidate();
        }




        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Easy_Load(object sender, EventArgs e)
        {

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

        // Method to deduct a heart when the user answers a question incorrectly
        private void DeductHeart()
        {
            if (livesRemaining > 0)
            {
                livesRemaining--;
                heartPictureBoxes[livesRemaining].Visible = false; // Hide the PictureBox representing the deducted heart
            }

            if (livesRemaining == 0)
            {
                MessageBox.Show("Game Over!");
                // Optionally, reset the game or go back to the main menu
            }
        }


        // Example usage of DeductHeart method
        private void CheckAnswer(string userAnswer)
        {
            // Assume userAnswer is the answer provided by the user
            bool isAnswerCorrect = false; // Check if the answer is correct

            if (!isAnswerCorrect)
            {
                DeductHeart(); // Call the method to deduct a heart
            }
        }
        public void ProcessAnswer(bool isAnswerCorrect)
        {
            if (!isAnswerCorrect)
            {
                DeductHeart();
                questionAnsweredCorrectly = false;// Call the method to deduct a heart
            }
            else
            {
                questionAnsweredCorrectly = true;
            }
        }

    }
}
