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
    public partial class hardQuestion2 : Form

    {
        public bool AnsweredCorrectly
        {
            get;
            private set;
        }
        public hardQuestion2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AnsweredCorrectly = true;
            MessageBox.Show("Incorrect");
            Medium med = new Medium();
            med.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AnsweredCorrectly = true;
            MessageBox.Show("Correct");
            Medium med = new Medium();
            med.Show();
            this.Hide();
        }
    }
}
