using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace flybird
{
    public partial class Form1 : Form
    {
        int pipespeed = 50;
        int gravity = 10;
        int score = 0;
        int highscore;
        public Form1()
        {
            InitializeComponent();
            rstart.Hide();
            high_value.Text = Properties.Settings.Default.h_score;
        }

        private void gametimerevent(object sender, EventArgs e)


        {
            flybird.Top += gravity;
            pipebottom.Left -= pipespeed;
            pipetop.Left -= pipespeed;
            pipebottom1.Left-=pipespeed;
            pipetop1.Left-=pipespeed;
            int a = Int32.Parse(high_value.Text);
            scoreText.Text = "score: " + score.ToString();

            if (pipebottom.Left<-90)
            {

                pipebottom.Left = 1250;
                score++;

            }

            if(pipetop.Left<-100)
            {

                pipetop.Left = 1200;
                score++;

            }
            if(pipetop1.Left<-90)
            {

                pipetop1.Left = 1200;
                score++;

            }

            if(pipebottom1.Left<-80)
            {

                pipebottom1.Left = 1250;
                score++;

            }
            if(flybird.Bounds.IntersectsWith(pipebottom.Bounds)||
                flybird.Bounds.IntersectsWith(pipetop.Bounds)||
                flybird.Bounds.IntersectsWith(ground.Bounds)||
                flybird.Bounds.IntersectsWith(pipebottom1.Bounds) ||
                flybird.Bounds.IntersectsWith(pipetop1.Bounds) ||
                flybird.Top<-10
                )
            {
                endGame();
            }

            if(score>5&&score<10)
            {
                pipespeed = 50;
            }
            if(score>10&&score<15)
            {
                pipespeed = 50;
            }
            if (score > 15 && score < 25)
            {
                pipespeed = 17;
            }
            if (score>30&& score<40)
            {
                pipespeed = 20;
            }
            if(score>40)
            {
                pipespeed = 30;
                pipetop.Height = 226;
                pipetop1.Height = 200;
            }
            if(score>a)
            {
                high_value.Text = score.ToString();
                Properties.Settings.Default.h_score = high_value.Text;
                Properties.Settings.Default.Save();

            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -7;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 7;
            }
        }


        private void endGame()
        {
            timer.Stop();
            gameover.Text = "                Game Over!!!" + " your score - " + score.ToString();
            gameover.Show();
            rstart.Show();
            flybird.Hide();
            pipetop.Hide();
            pipetop1.Hide();
            pipebottom1.Hide();
            pipebottom.Hide();
            
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void high_value_Click(object sender, EventArgs e)
        {

        }

        

        private void rstart_Click_1(object sender, EventArgs e)
        {
            timer.Start();
            score = 0;
            pipespeed = 5;
            gravity = 10;
            
            pipetop.Height = 170;
            pipetop1.Height = 157;
            flybird.Show();
            pipetop.Show();
            pipebottom1.Show();
            pipebottom.Show();
            pipetop1.Show();
            rstart.Hide();
            gameover.Hide();

            
            flybird.Location = new Point(59, 140);
            pipetop1.Location = new Point(1278, -1);
            pipebottom.Location = new Point(535, 345);
            pipetop.Location = new Point(698, -1);
            pipebottom1.Location = new Point(1278, 305);
        }

       
    }
}
