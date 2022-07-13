using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordGame.DAL;

namespace WordGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PlayerDAL _playerDAL = new PlayerDAL();

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityAdd cityAdd = new CityAdd();

            cityAdd.Show();
        }

        private void ilSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CityListAndDelete cityListAndDelete = new CityListAndDelete();

            cityListAndDelete.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistrictAdd districtAdd = new DistrictAdd();

            districtAdd.Show();
        }

        private void oyuncuSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerListAndDelete playerListAndDelete = new PlayerListAndDelete();

            playerListAndDelete.Show();
        }

        private void oyuncuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerAdd playerAdd = new PlayerAdd();

            playerAdd.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int check = 0;

            if (rdBtnEasy.Checked)
                check = 1;
            else if (rdBtnMiddle.Checked)
                check = 2;
            else if (rdBtnHard.Checked)
                check = 3;
            Game game = new Game(check);
            if (btnStart.CanSelect)
            {
                Hide();
                foreach (Form item in Application.OpenForms)
                {
                    if (item.Text == "Game")
                    {
                        item.Close();
                        break;
                    }
                }
            }
            game.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            dgvPlayers.DataSource = _playerDAL.GetAll();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void kelimeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordAdd wordAdd = new WordAdd();

            wordAdd.Show();
        }

        private void kelimeSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WordListAndDelete wordListAndDelete = new WordListAndDelete();

            wordListAndDelete.Show();
        }
    }
}
