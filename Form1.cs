namespace CAR_RACING_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            playSound2();
            resetgame();
        }

        int roadSpeed;
        int playerSpeed = 12;
        int trafficSpeed;
        int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goLeft;
        bool goRight;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }


        private void gameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "SCORE: " + score;
            score++;

            if (goLeft == true && player.Left > 5)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Right < 899)
            {
                player.Left += playerSpeed;
            }

            roadtrack1.Top += roadSpeed;
            roadtrack2.Top += roadSpeed;

            if (roadtrack2.Top > 521)
            {
                roadtrack2.Top = -521;
            }
            if (roadtrack1.Top > 521)
            {
                roadtrack1.Top = -521;
            }
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;
            AI3.Top += trafficSpeed;
            if (AI1.Top > 522)
            {
                changeAIcars(AI1);
            }
            if (AI2.Top > 522)
            {
                changeAIcars(AI2);
            }
            if (AI3.Top > 522)
            {
                changeAIcars(AI3);
            }
            if (player.Bounds.IntersectsWith(AI1.Bounds) || player.Bounds.IntersectsWith(AI2.Bounds) || player.Bounds.IntersectsWith(AI3.Bounds))
            {
                gameover();
            }
            if (score > 40 && score < 500)
            {
                award.Image = Properties.Resources.bronze;
            }
            if (score > 500 && score < 1000)
            {

                award.Image = Properties.Resources.silver;
                roadSpeed = 18;
                trafficSpeed = 20;
            }
            if (score > 1000 && score < 1500)
            {
                award.Image = Properties.Resources.gold;
                roadSpeed = 23;
                trafficSpeed = 25;
            }
            if (score > 1500)
            {
                award.Image = Properties.Resources.plat;
                roadSpeed = 25;
                trafficSpeed = 28;
            }
        }
        private void gameover()
        {
            playSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-8, 5);
            explosion.BackColor = Color.Transparent;
            award.Visible = true;
            award.BringToFront();
            btnStart.Enabled = true;

        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 8);
            switch (carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;

                case 2:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;

                case 3:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;

                case 4:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;

                case 5:
                    tempCar.Image = Properties.Resources.carPink;
                    break;

                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;

                case 7:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;

                case 8:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;

            }
            tempCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(3, 263);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(635, 860);
            }
            if ((string)tempCar.Tag == "carMiddle")
            {
                tempCar.Left = carPosition.Next(329, 567);
            }



        }
        private void resetgame()
        {
            
            btnStart.Enabled = false;
            explosion.Visible = false;
            award.Visible = false;
            goLeft = false;
            goRight = false;
            score = 0;
            award.Image = Properties.Resources.bronze;

            roadSpeed = 12;
            trafficSpeed = 15;

            AI1.Top = carPosition.Next(200, 500) * -1;
            AI1.Left = carPosition.Next(3, 263);

            AI2.Top = carPosition.Next(200, 500) * -1;
            AI2.Left = carPosition.Next(635, 860);

            AI3.Top = carPosition.Next(200, 500) * -1;
            AI3.Left = carPosition.Next(329,567);

            gameTimer.Start();
        }

        private void playSound()
        {
            System.Media.SoundPlayer crash = new System.Media.SoundPlayer(Properties.Resources.hit);
            crash.Play();

        }

        private void playSound2()
        {
            System.Media.SoundPlayer music = new System.Media.SoundPlayer(Properties.Resources.gamminnnnng);
            music.Play();

        }

        private void restartGame(object sender, EventArgs e)
        {
            playSound2 ();
            resetgame();
        }

        private void roadtrack2_Click(object sender, EventArgs e)
        {

        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void AI3_Click(object sender, EventArgs e)
        {

        }

        private void AI2_Click(object sender, EventArgs e)
        {

        }
    }
}