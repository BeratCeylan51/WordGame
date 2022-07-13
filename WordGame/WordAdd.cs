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
    public partial class WordAdd : Form
    {
        public WordAdd()
        {
            InitializeComponent();
        }

        WordDAL _wordDAL = new WordDAL();
        private int level = 1;
        private bool check = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdBtnEasy.Checked && tbxWord.Text.Length == 2)
            {
                check = true;
                level = 1;
            }
            else if (rdBtnMiddle.Checked && tbxWord.Text.Length == 3)
            {
                check = true;
                level = 2;
            }
            else if (rdBtnHard.Checked && tbxWord.Text.Length == 5)
            {
                check = true;
                level = 3;
            }
            else
            {
                MessageBox.Show("Lütfen Seçtiğiniz Zorluğa Göre Kelime Giriniz\nKolay : 2 kelime\nOrta : 3 Kelime\nZor : 5 Kelime");
            }
            if (check)
            {
                _wordDAL.Add(new Word
                {
                    Level = level,
                    _Word = tbxWord.Text,
                });
                tbxWord.Clear();
                MessageBox.Show("Kelime Eklendi");
            }
        }
    }
}
