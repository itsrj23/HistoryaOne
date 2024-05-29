using System;
using System.Windows.Forms;

namespace HistoryaOne
{
    public partial class easyQuestion1 : Form
    {
        private Easy easyForm;
        public bool AnsweredCorrectly
        {
            get;
            private set;
        }
        public easyQuestion1(Easy easyForm)
        {
            InitializeComponent();
            this.easyForm = easyForm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnsweredCorrectly = false;
            MessageBox.Show("Incorrect answer");
            easyForm.ProcessAnswer(AnsweredCorrectly);
            Easy easy = new Easy();
            easy.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AnsweredCorrectly = true;
            MessageBox.Show("Correct");
            easyForm.ProcessAnswer(AnsweredCorrectly);
            Easy easy = new Easy();
            easy.Show();
            this.Close();
            this.Close();
        }
    }
}
