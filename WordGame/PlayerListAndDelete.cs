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
    public partial class PlayerListAndDelete : Form
    {
        public PlayerListAndDelete()
        {
            InitializeComponent();
        }

        PlayerDAL _playerDAL = new PlayerDAL();
        private void PlayerListAndDelete_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            dgvPlayers.DataSource = _playerDAL.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvPlayers.CurrentRow.Cells[0].Value);
            _playerDAL.Delete(id);
            LoadPlayers();
            MessageBox.Show("Oyuncu Silindi");
        }
    }
}
