using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaraOuCoroa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CRIA VALOR ALEATORIO
            Random rnd = new Random();
            int nums = rnd.Next(0, 100);
            int result = 0;
            int rb = 0;


            if (nums <= 50)
            {
                //MessageBox.Show("O resultado é cara!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = 1;
            }
            else if (nums >= 50)
            {
                //MessageBox.Show("O resultado é coroa!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = 2;
            }

            //PEGA VALOR DO CHECKBOX
            if (radioButton1.Checked)
            {
                rb = 1;
                MessageBox.Show("Você selecionou cara!");
            }
            else if (radioButton2.Checked)
            {
                rb = 2;
                MessageBox.Show("Você selecionou coroa!");
            }
            else
            {
                rb = 0;
                MessageBox.Show("Não houve nenhuma seleção!");
            }

            if ((result == 1))
            {
                if ((rb == result))
                {
                    //resultado está certo e é cara
                    MessageBox.Show("O resultado é cara!", "Acertou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //resultado está errado e é cara
                    MessageBox.Show("O resultado é cara!", "Errou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if ((result == 2))
            {
                if ((rb == result))
                {
                    //resultado está certo e é coroa
                    MessageBox.Show("O resultado é coroa!", "Acertou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //resultado está errado e é coroa
                    MessageBox.Show("O resultado é coroa!", "Errou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
