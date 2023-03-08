using System.Numerics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pong
{
    
    
    public partial class Form1 : Form
    {
        bool goup;
        bool godown;
        int speed = 5;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        int cpuPoint = 0;
     

        public Form1()
        {
            InitializeComponent();
        }

       

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
              goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
              godown = true;
            }
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
              goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
              godown = false;
            }
        }
        private void timerTick(object sender, EventArgs e)
        {
            
            PlayerScore.Text = "" + score; 
            CPUScore.Text = "" + cpuPoint; 
            Ball.Top -= bally; 
            Ball.Left -= ballx; 
            CPU.Top += speed; 
            
            if (score < 5)
            {
               
                if (CPU.Top < 0 || CPU.Top > 455)
                {
                    
                    speed = -speed;
                }
            }
            else
            {
                
                CPU.Top = Ball.Top + 30;
            }
            
            if (Ball.Left < 0)
            {
                
                Ball.Left = 434; 
                ballx = -ballx; 
                ballx -= 2; 
                cpuPoint++; 
            }
            
            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
               
                Ball.Left = 434;  
                ballx = -ballx; 
                ballx += 2; 
                score++; 
            }
            
            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                
                bally = -bally;
            }
            
            if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(CPU.Bounds))
            {
               
                ballx = -ballx;
            }
           
            if (goup == true && Player1.Top > 0)
            {

                Player1.Top -= 8;
            }
           
            if (godown == true && Player1.Top < 455)
            {

                Player1.Top += 8;
            }
            
            if (score > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("You win this game");
            }
            
            if (cpuPoint > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("CPU wins, you lose");
            }



        }

    }


}
