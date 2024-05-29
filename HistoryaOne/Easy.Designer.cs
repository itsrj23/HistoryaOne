
namespace HistoryaOne
{
    partial class Easy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easy));
            this.door1Easy = new System.Windows.Forms.PictureBox();
            this.door2Easy = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.door1Easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2Easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            this.SuspendLayout();
            // 
            // door1Easy
            // 
            this.door1Easy.BackColor = System.Drawing.Color.Transparent;
            this.door1Easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door1Easy.BackgroundImage")));
            this.door1Easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1Easy.Location = new System.Drawing.Point(361, 494);
            this.door1Easy.Name = "door1Easy";
            this.door1Easy.Size = new System.Drawing.Size(114, 122);
            this.door1Easy.TabIndex = 1;
            this.door1Easy.TabStop = false;
            // 
            // door2Easy
            // 
            this.door2Easy.BackColor = System.Drawing.Color.Transparent;
            this.door2Easy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door2Easy.BackgroundImage")));
            this.door2Easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2Easy.Location = new System.Drawing.Point(1160, 302);
            this.door2Easy.Name = "door2Easy";
            this.door2Easy.Size = new System.Drawing.Size(123, 140);
            this.door2Easy.TabIndex = 2;
            this.door2Easy.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(1281, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 44);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(733, 688);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 55);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Transparent;
            this.heart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart1.BackgroundImage")));
            this.heart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart1.Location = new System.Drawing.Point(245, 30);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(62, 50);
            this.heart1.TabIndex = 8;
            this.heart1.TabStop = false;
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Transparent;
            this.heart2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart2.BackgroundImage")));
            this.heart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart2.Location = new System.Drawing.Point(313, 30);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(62, 50);
            this.heart2.TabIndex = 9;
            this.heart2.TabStop = false;
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Transparent;
            this.heart3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heart3.BackgroundImage")));
            this.heart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heart3.Location = new System.Drawing.Point(381, 30);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(62, 50);
            this.heart3.TabIndex = 10;
            this.heart3.TabStop = false;
            // 
            // Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 784);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.door2Easy);
            this.Controls.Add(this.door1Easy);
            this.DoubleBuffered = true;
            this.Name = "Easy";
            this.Text = "Easy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClosed);
            this.Load += new System.EventHandler(this.Easy_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.door1Easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2Easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox door1Easy;
        private System.Windows.Forms.PictureBox door2Easy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
    }
}