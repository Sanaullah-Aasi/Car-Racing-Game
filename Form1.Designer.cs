namespace CAR_RACING_GAME
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            AI3 = new PictureBox();
            AI1 = new PictureBox();
            award = new PictureBox();
            player = new PictureBox();
            explosion = new PictureBox();
            AI2 = new PictureBox();
            roadtrack2 = new PictureBox();
            roadtrack1 = new PictureBox();
            btnStart = new Button();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AI3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)award).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(AI3);
            panel1.Controls.Add(AI1);
            panel1.Controls.Add(award);
            panel1.Controls.Add(player);
            panel1.Controls.Add(explosion);
            panel1.Controls.Add(AI2);
            panel1.Controls.Add(roadtrack2);
            panel1.Controls.Add(roadtrack1);
            panel1.Location = new Point(9, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 521);
            panel1.TabIndex = 0;
            // 
            // AI3
            // 
            AI3.Image = Properties.Resources.carGrey;
            AI3.Location = new Point(567, 4);
            AI3.Name = "AI3";
            AI3.Size = new Size(50, 100);
            AI3.SizeMode = PictureBoxSizeMode.AutoSize;
            AI3.TabIndex = 3;
            AI3.TabStop = false;
            AI3.Tag = "carMiddle";
            // 
            // AI1
            // 
            AI1.Image = Properties.Resources.carGreen;
            AI1.Location = new Point(263, 3);
            AI1.Name = "AI1";
            AI1.Size = new Size(50, 101);
            AI1.SizeMode = PictureBoxSizeMode.AutoSize;
            AI1.TabIndex = 4;
            AI1.TabStop = false;
            AI1.Tag = "carLeft";
            // 
            // award
            // 
            award.Image = Properties.Resources.bronze;
            award.Location = new Point(351, 177);
            award.Name = "award";
            award.Size = new Size(250, 100);
            award.SizeMode = PictureBoxSizeMode.AutoSize;
            award.TabIndex = 3;
            award.TabStop = false;
            // 
            // player
            // 
            player.Image = Properties.Resources.carYellow;
            player.Location = new Point(439, 403);
            player.Name = "player";
            player.Size = new Size(50, 99);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 3;
            player.TabStop = false;
            // 
            // explosion
            // 
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(412, 321);
            explosion.Name = "explosion";
            explosion.Size = new Size(64, 64);
            explosion.SizeMode = PictureBoxSizeMode.AutoSize;
            explosion.TabIndex = 3;
            explosion.TabStop = false;
            // 
            // AI2
            // 
            AI2.Image = Properties.Resources.carOrange;
            AI2.Location = new Point(859, 4);
            AI2.Name = "AI2";
            AI2.Size = new Size(50, 100);
            AI2.SizeMode = PictureBoxSizeMode.AutoSize;
            AI2.TabIndex = 3;
            AI2.TabStop = false;
            AI2.Tag = "carRight";
            AI2.Click += AI2_Click;
            // 
            // roadtrack2
            // 
            roadtrack2.Image = Properties.Resources.roadTrack;
            roadtrack2.Location = new Point(0, 0);
            roadtrack2.Name = "roadtrack2";
            roadtrack2.Size = new Size(912, 521);
            roadtrack2.SizeMode = PictureBoxSizeMode.StretchImage;
            roadtrack2.TabIndex = 0;
            roadtrack2.TabStop = false;
            roadtrack2.Click += roadtrack2_Click;
            // 
            // roadtrack1
            // 
            roadtrack1.Image = Properties.Resources.roadTrack;
            roadtrack1.Location = new Point(0, -639);
            roadtrack1.Name = "roadtrack1";
            roadtrack1.Size = new Size(912, 521);
            roadtrack1.SizeMode = PictureBoxSizeMode.StretchImage;
            roadtrack1.TabIndex = 0;
            roadtrack1.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.Location = new Point(391, 588);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += restartGame;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(204, 539);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(476, 46);
            txtScore.TabIndex = 2;
            txtScore.Text = "SCORE: 0";
            txtScore.TextAlign = ContentAlignment.TopCenter;
            txtScore.Click += txtScore_Click;
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 640);
            Controls.Add(txtScore);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "CAR RACING GAME";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AI3).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)award).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roadtrack1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnStart;
        private Label txtScore;
        private PictureBox roadtrack1;
        private PictureBox roadtrack2;
        private PictureBox award;
        private PictureBox player;
        private PictureBox explosion;
        private PictureBox AI2;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox AI1;
        private PictureBox AI3;
    }
}