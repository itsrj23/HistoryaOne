
namespace HistoryaOne
{
    partial class Medium
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medium));
            this.door1Medium = new System.Windows.Forms.PictureBox();
            this.door2Medium = new System.Windows.Forms.PictureBox();
            this.door3Medium = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.door1Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // door1Medium
            // 
            this.door1Medium.BackColor = System.Drawing.Color.Transparent;
            this.door1Medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door1Medium.BackgroundImage")));
            this.door1Medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1Medium.Location = new System.Drawing.Point(238, 192);
            this.door1Medium.Name = "door1Medium";
            this.door1Medium.Size = new System.Drawing.Size(102, 131);
            this.door1Medium.TabIndex = 2;
            this.door1Medium.TabStop = false;
            // 
            // door2Medium
            // 
            this.door2Medium.BackColor = System.Drawing.Color.Transparent;
            this.door2Medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door2Medium.BackgroundImage")));
            this.door2Medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2Medium.Location = new System.Drawing.Point(733, 147);
            this.door2Medium.Name = "door2Medium";
            this.door2Medium.Size = new System.Drawing.Size(114, 122);
            this.door2Medium.TabIndex = 3;
            this.door2Medium.TabStop = false;
            // 
            // door3Medium
            // 
            this.door3Medium.BackColor = System.Drawing.Color.Transparent;
            this.door3Medium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door3Medium.BackgroundImage")));
            this.door3Medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3Medium.Location = new System.Drawing.Point(804, 427);
            this.door3Medium.Name = "door3Medium";
            this.door3Medium.Size = new System.Drawing.Size(114, 122);
            this.door3Medium.TabIndex = 4;
            this.door3Medium.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1210, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 44);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(571, 689);
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
            // Medium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1322, 787);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.door3Medium);
            this.Controls.Add(this.door2Medium);
            this.Controls.Add(this.door1Medium);
            this.DoubleBuffered = true;
            this.Name = "Medium";
            this.Text = "Medium";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.door1Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door2Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door3Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox door1Medium;
        private System.Windows.Forms.PictureBox door2Medium;
        private System.Windows.Forms.PictureBox door3Medium;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
    }
}