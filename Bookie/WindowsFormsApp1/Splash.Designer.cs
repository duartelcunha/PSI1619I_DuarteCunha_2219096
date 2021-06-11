
namespace WindowsFormsApp1
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PB = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            // 
            // PB
            // 
            this.PB.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.PB.AnimationSpeed = 1000;
            this.PB.BackColor = System.Drawing.Color.Transparent;
            this.PB.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PB.InnerColor = System.Drawing.Color.White;
            this.PB.InnerMargin = 2;
            this.PB.InnerWidth = -1;
            this.PB.Location = new System.Drawing.Point(187, 134);
            this.PB.MarqueeAnimationSpeed = 200;
            this.PB.Name = "PB";
            this.PB.OuterColor = System.Drawing.Color.White;
            this.PB.OuterMargin = -25;
            this.PB.OuterWidth = 26;
            this.PB.ProgressColor = System.Drawing.Color.Chocolate;
            this.PB.ProgressWidth = 15;
            this.PB.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PB.Size = new System.Drawing.Size(196, 188);
            this.PB.StartAngle = 270;
            this.PB.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB.SubscriptColor = System.Drawing.Color.White;
            this.PB.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PB.SubscriptText = ".23";
            this.PB.SuperscriptColor = System.Drawing.Color.White;
            this.PB.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PB.SuperscriptText = "°C";
            this.PB.TabIndex = 0;
            this.PB.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PB.Value = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(242, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar PB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}