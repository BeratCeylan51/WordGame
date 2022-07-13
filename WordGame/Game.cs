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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public Game(int check)
        {
            this.check = check;
            InitializeComponent();
        }

        WordDAL _wordDAL = new WordDAL();

        private int check = 1;
        private int _random = 0;
        private int wordCount = 0;
        public static int count = 0;
        public static int timeCount = 0;

        List<string> ikiHarf = new List<string>();
        List<string> ucHarf = new List<string>();
        List<string> besHarf = new List<string>();
        List<char> openLetter = new List<char>();

        private void Game_Load(object sender, EventArgs e)
        {
            LoadWord();
            
            Random random = new Random();
            _random = random.Next(wordCount);

            timeCount = 0;
            count = 0;
            tmrCount.Start();

            tbx1.MaxLength = 1;
            tbx2.MaxLength = 1;
            tbx3.MaxLength = 1;
            tbx4.MaxLength = 1;
            tbx5.MaxLength = 1;
            tbxWord.MaxLength = 1;
            tbxWord.Focus();


            tbx1.ReadOnly = true;
            tbx2.ReadOnly = true;
            tbx3.ReadOnly = true;
            tbx4.ReadOnly = true;
            tbx5.ReadOnly = true;


            tbxOpen();
        }

        private void LoadWord()
        {
            if (check == 1)
            {
                ikiHarf = _wordDAL.GetLevelAll(check);
                wordCount = ikiHarf.Count;
            }
            else if (check == 2)
            {
                ucHarf = _wordDAL.GetLevelAll(check);
                wordCount = ucHarf.Count;
            }
            else if (check == 3)
            {
                besHarf = _wordDAL.GetLevelAll(check);
                wordCount = besHarf.Count;
            }
            else
            {
                MessageBox.Show("Lütfen Zorluk Seviyesi Seçiniz !!!");
                Close();
            }
        }

        private void tbxOpen()
        {
            if (check == 1)
            {
                tbx1.Visible = true;
                tbx2.Visible = true;
                tbx3.Visible = false;
                tbx4.Visible = false;
                tbx5.Visible = false;
            }
            else if (check == 2)
            {
                tbx1.Visible = true;
                tbx2.Visible = true;
                tbx3.Visible = true;
                tbx4.Visible = false;
                tbx5.Visible = false;
            }
            else if (check == 3)
            {
                tbx1.Visible = true;
                tbx2.Visible = true;
                tbx3.Visible = true;
                tbx4.Visible = true;
                tbx5.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen Zorluk Seviyesi Seçiniz !!!");
                Close();
            }
        }

        private bool letterCheck(char letter)
        {
            foreach (char item in openLetter)
            {
                if (item == letter)
                    return false;
            }
            return true;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                ikiharfWrite();
            }
            if (check == 2)
            {
                ucharfWrite();
            }
            if (check == 3)
            {
                besharfWrite();
            }

            tbxWord.Clear();
            tbxWord.Focus();
        }

        private void besharfWrite()
        {
            if (besHarf[_random].ToLower().Contains(tbxWord.Text.ToLower()))
            {
                if (letterCheck(Convert.ToChar(tbxWord.Text)))
                {
                    openLetter.Add(Convert.ToChar(tbxWord.Text));
                    if (besHarf[_random][0].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx1.Text = besHarf[_random][0].ToString();
                        Finished();
                    }
                    if (besHarf[_random][1].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx2.Text = besHarf[_random][1].ToString();
                        Finished();
                    }
                    if (besHarf[_random][2].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx3.Text = besHarf[_random][2].ToString();
                        Finished();
                    }
                    if (besHarf[_random][3].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx4.Text = besHarf[_random][3].ToString();
                        Finished();
                    }
                    if (besHarf[_random][4].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx5.Text = besHarf[_random][4].ToString();
                        Finished();
                    }
                }
                else
                    MessageBox.Show("Harf Zaten Açılmış !!! ");
            }
            else
            {
                count++;
                MessageBox.Show("Harf Bulunamadı");
            }
        }

        private void ucharfWrite()
        {
            if (ucHarf[_random].ToLower().Contains(tbxWord.Text.ToLower()))
            {
                if (letterCheck(Convert.ToChar(tbxWord.Text)))
                {
                    openLetter.Add(Convert.ToChar(tbxWord.Text));
                    if (ucHarf[_random][0].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx1.Text = ucHarf[_random][0].ToString();
                        Finished();
                    }
                    if (ucHarf[_random][1].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx2.Text = ucHarf[_random][1].ToString();
                        Finished();
                    }
                    if (ucHarf[_random][2].ToString().ToLower() == tbxWord.Text.ToLower())
                    {
                        tbx3.Text = ucHarf[_random][2].ToString();
                        Finished();
                    }
                }
                else
                    MessageBox.Show("Harf Zaten Açılmış !!! ");
            }
            else
            {
                count++;
                MessageBox.Show("Harf Bulunamadı");
            }
        }

        private void ikiharfWrite()
        {
            if (ikiHarf[_random].ToLower().Contains(tbxWord.Text))
            {
                if (letterCheck(Convert.ToChar(tbxWord.Text)))
                {
                    openLetter.Add(Convert.ToChar(tbxWord.Text));
                    if (tbxWord.Text.ToLower() == ikiHarf[_random][0].ToString().ToLower())
                    {
                        tbx1.Text = ikiHarf[_random][0].ToString();
                        Finished();
                    }
                    if (tbxWord.Text.ToLower() == ikiHarf[_random][1].ToString().ToLower())
                    {
                        tbx2.Text = ikiHarf[_random][1].ToString();
                        Finished();
                    }
                }
                else
                    MessageBox.Show("Harf Zaten Açılmış !!! ");
            }
            else
            {
                count++;
                MessageBox.Show("Harf Bulunamadı");
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = Application.OpenForms["Form1"];

            if (form != null)
            {
                form.Show();
            }
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            timeCount++;
            lblTimeValue.Text = timeCount.ToString();
        }

        private void Finished()
        {
            if (check == 1 && (tbx1.Text.Length == 1 && tbx2.Text.Length == 1))
            {
                tmrCount.Stop();
                Finished finished = new Finished(check);
                finished.Show();
            }
            if (check == 2 && (tbx1.Text.Length == 1 && tbx2.Text.Length == 1 && tbx3.Text.Length == 1))
            {
                tmrCount.Stop();
                Finished finished = new Finished(check);
                finished.Show();
            }
            if (check == 3 && (tbx1.Text.Length == 1 && tbx2.Text.Length == 1 && tbx3.Text.Length == 1 && tbx4.Text.Length == 1 && tbx5.Text.Length == 1))
            {
                tmrCount.Stop();
                Finished finished = new Finished(check);
                finished.Show();
            }
        }
    }
}
