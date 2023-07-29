using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        int Score = 0;
        int Miss = 0;
        bool EndGame = false;
        List<ScoresModel> TopScores = new List<ScoresModel>();
        int MovementSpeed = 5;
        double TargetSize = 80;
        int Level = 1;
        double MovementTimerInterval = 1000;
        double CountDown = 30;

        public Form1()
        {
            InitializeComponent();
            MovementTimer.Enabled = false;
            TargetButton.Visible = false;
            LevelLabel.Text = Level.ToString();
            label1.Text = String.Format("{0:0.00}", CountDown);
            //populate top scores with fake scores
            if (TopScores.Count <= 0)
            {
                TopScores.Add(new ScoresModel("Michael", 6));
                TopScores.Add(new ScoresModel("Jim", 5));
                TopScores.Add(new ScoresModel("Stanley", 4));
                TopScores.Add(new ScoresModel("Dwight", 3));
                TopScores.Add(new ScoresModel("Andy", 2));
                TopScores.Sort();
            }
        }

        //start the game
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!EndGame)
            {
                watch.Start();
                MovementTimer.Enabled = true;
                LabelTimer.Enabled = true;
                StatusLabel.Visible = false;
                button1.Visible = false;
            }
        }

        //pause the game
        private void StopButton_Click(object sender, EventArgs e)
        {
            watch.Stop();
            TargetButton.Visible = false;
            MovementTimer.Enabled = false;
            if (!EndGame)
            {
                LabelTimer.Enabled = false;
            }
        }

        //reset the game
        private void ResetButton_Click(object sender, EventArgs e)
        {
            EndGame = false;
            TargetButton.Visible = false;
            FalseTarget.Visible = false;
            watch.Reset();
            Score = 0;
            Miss = 0;
            MissLabel.Text = Miss.ToString();
            ScoreLabel.Text = Score.ToString();
            CountDown = 30;
            label1.Text = String.Format("{0:0.00}", CountDown);
            MovementTimer.Enabled = false;
            LabelTimer.Enabled = false;
            StatusLabel.Visible = false;
            button1.Visible = false;
            MovementSpeed = 5;
            TargetSize = 80;
            TargetButton.Size = new Size(Convert.ToInt32(TargetSize), Convert.ToInt32(TargetSize));
            FalseTarget.Size = new Size(Convert.ToInt32(TargetSize), Convert.ToInt32(TargetSize));
            MovementTimerInterval = 1000;
            Level = 1;
            LevelLabel.Text = Level.ToString();
        }

        //move the target around the panel
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            //change color back if it was red
            if (panel1.BackColor == Color.DarkRed) panel1.BackColor = Color.LightGray;

            int randomCount = random.Next(0, 10);
            if (!EndGame)
            {
                //false target. 20% chance
                if (randomCount > 8)
                {
                    FalseTarget.Left = random.Next(0, panel1.Width - Convert.ToInt32(TargetSize));
                    FalseTarget.Top = random.Next(0, panel1.Height - Convert.ToInt32(TargetSize));
                    FalseTarget.Visible = true;
                    TargetButton.Visible = false;
                }
                //real target
                else if (randomCount < MovementSpeed)//50% chance of moving, then increases at the last 10 sec of the level
                {
                    //move the target around the panel, -60 to keep it inside
                    TargetButton.Left = random.Next(0, panel1.Width - Convert.ToInt32(TargetSize));
                    TargetButton.Top = random.Next(0, panel1.Height - Convert.ToInt32(TargetSize));
                    TargetButton.Visible = true;
                    FalseTarget.Visible = false;
                }
            }
        }

        //when target is hit
        private void TargetButton_Click(object sender, EventArgs e)
        {
            if (!EndGame)
            {
                TargetButton.Visible = false;
                Score += 1; //add to the score
                ScoreLabel.Text = Score.ToString(); //display the score 
            }
        }

        //hit false target, loose 2 points
        private void FalseTarget_Click(object sender, EventArgs e)
        {
            FalseTarget.Visible = false;
            panel1.BackColor = Color.DarkRed;
            Score -= 2;
            ScoreLabel.Text = Score.ToString();
        }

        //timer for the time label that counts as the game is played
        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            //display the time
            CountDown -= 0.01;
            label1.Text = String.Format("{0:0.00}", CountDown);

            //increase difficulty with 10 seconds left
            //needed to use a range for this to work
            //so if countdown is between 10.00 and 9.9
            if (10.00 >= CountDown && CountDown >= 9.99)
            {
                IncreaseDifficulty();
            }

            //when time runs out
            if (CountDown <= 0)//end game after 30 sec
            {
                CountDown = 0;
                label1.Text = CountDown.ToString();
                GameOver();
            }
        }

        //missed hit
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!EndGame && watch.IsRunning)
            {
                Miss += 1;
                MissLabel.Text = Miss.ToString();

                //end game at 3 misses
                if (Miss >= 3)
                {
                    GameOver();
                }
            }
        }

        //check for high score
        //if new highscore, then remove the last score and add the new score
        private void GetHighScore(int score)
        {
            if (score >= TopScores.ElementAt(4).Score)
            {
                TopScores.Remove(TopScores.ElementAt(4));
                TopScores.Add(new ScoresModel("You", score));
                TopScores.Sort();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ResetButton_Click(this, new EventArgs());
            button1.Visible = false;
        }

        private void GameOver()
        {
            TargetButton.Visible = false;
            FalseTarget.Visible = false;
            //if qualify for next level based on score
            if (Level == 1 && Score >= 10 || Level == 2 && Score >= 20 || Level == 3 && Score >= 30)
            {
                LevelUp();
                StopButton_Click(this, new EventArgs());
                LabelTimer.Enabled = false;
                TargetButton.Visible = false;
                ContinueButton.Visible = true;
                StatusLabel.Text = "Next Level";
                StatusLabel.Visible = true;
            }

            //else game over
            else
            {
                EndGame = true;
                LabelTimer.Enabled = false;
                TargetButton.Visible = false;
                FalseTarget.Visible = false;
                StopButton_Click(this, new EventArgs());
                StatusLabel.Visible = true;
                StatusLabel.Text = "Game Over";
                button1.Visible = true;
                GetHighScore(Score);
                Form2 form = new Form2(TopScores);
                form.ShowDialog();
            }
        }

        //make the targets smaller and faster for increased difficulty
        private void IncreaseDifficulty()
        {
            TargetSize *= .7;
            TargetButton.Size = new Size(Convert.ToInt32(TargetSize), Convert.ToInt32(TargetSize));
            FalseTarget.Size = new Size(Convert.ToInt32(TargetSize), Convert.ToInt32(TargetSize));
            MovementSpeed = 8;//make it move faster
        }

        //level up increase speed
        private void LevelUp()
        {
            Level += 1;
            MovementTimerInterval *= .8;
            MovementTimer.Interval = Convert.ToInt32(MovementTimerInterval);
        }

        //continue to next level
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            watch.Reset();
            CountDown = 30;
            Miss = 0;
            MissLabel.Text = Miss.ToString();
            LevelLabel.Text = Level.ToString();
            MovementSpeed = 5;
            panel1.BackColor = Color.DarkGray;
            ContinueButton.Visible = false;
            StartButton_Click(this, new EventArgs());
        }
    }
}