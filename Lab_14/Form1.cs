using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "Белый":; BackColor = Color.White; break;
                case "Красный":; BackColor= Color.Red; break;
                case "Чёрный":; BackColor = Color.Black; break;
                case "Синий":; BackColor = Color.Blue; break;
                case "Жёлтый":; BackColor = Color.Yellow; break;
                default: BackColor = SystemColors.Control; break;
            }
        }



        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BackColor = Color.FromArgb(
                    Convert.ToInt32(toolStripTextBox1.Text),
                    Convert.ToInt32(toolStripTextBox2.Text),
                    Convert.ToInt32(toolStripTextBox3.Text));
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое чмсло от 0 до 255", "Ошибка в задании цвета");
            }
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripComboBox1_SelectedIndexChanged(sender, e);
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);
        }

        private void toolStripTextBox5_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);

        }

        private void toolStripTextBox6_TextChanged(object sender, EventArgs e)
        {
            toolStripTextBox1_TextChanged(sender, e);

        }
    }
}
