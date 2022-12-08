using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Shooter_Game
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 10;
        int ammo = 10;
        int score;
        int zombieSpeed = 3;

        Random randNum = new Random();

        List<PictureBox> zombiesList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1) healthBar.Value = playerHealth;

            else gameOver = true;

            txtAmmo.Text = "Ammo: " + ammo;
            txtScore.Text = "Kills: " + score;

            if (goLeft == true && player.Left > 0) player.Left -= speed;

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width) player.Left += speed;

            if(goUp == true && player.Top > 45) player.Top -= speed;

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height) player.Top += speed;
            

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.left;
            }

            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.right;
            }

            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.up;
            }

            if(e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.down;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;


            if (e.KeyCode == Keys.Right) goRight = false;

            if (e.KeyCode == Keys.Up) goUp = false;

            if (e.KeyCode == Keys.Down) goDown = false;

            if (e.KeyCode == Keys.Space) ShootBullet(facing);

        }

        private void ShootBullet(string direction)
        {

        }

        private void MakeZombies()
        {

        }

        private void RestartGame()
        {

        }
    }
}
