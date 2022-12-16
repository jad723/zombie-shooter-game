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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();
            gameWindow.Show();
            this.Hide();
            gameWindow.FormClosed += new FormClosedEventHandler(CloseGame);
            
        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            Help helpWindow = new Help();
            helpWindow.Show();
            this.Hide();
            helpWindow.FormClosed += new FormClosedEventHandler(CloseHelp);
        }

        private void CloseHelp(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
