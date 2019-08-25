using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SimpleLexer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSplitWords_Click(object sender, EventArgs e)
        {
            string[] words;
            string textContent1;
            string pattern = @"\s+";

            if(textBoxContent1.Text != "")
            {
                textContent1 = textBoxContent1.Text;
                
                words = Regex.Split(textContent1, pattern);
                textBoxContent2.Text = textContent1;
                dataGridViewWords.Rows.Clear();

                foreach(string word in words)
                {
                    dataGridViewWords.Rows.Add(word);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxContent1.Clear();
            textBoxContent2.Clear();
            dataGridViewWords.Rows.Clear();
        }
    }
}
