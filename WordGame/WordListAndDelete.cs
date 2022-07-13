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
    public partial class WordListAndDelete : Form
    {
        public WordListAndDelete()
        {
            InitializeComponent();
        }

        WordDAL _wordDAL = new WordDAL();

        private void WordListAndDelete_Load(object sender, EventArgs e)
        {
            LoadWords();
        }

        private void LoadWords()
        {
            dgvWords.DataSource = _wordDAL.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvWords.CurrentRow.Cells[0].Value);

            _wordDAL.Delete(id);

            LoadWords();

            MessageBox.Show("Kelime Silindi");
        }
    }
}
