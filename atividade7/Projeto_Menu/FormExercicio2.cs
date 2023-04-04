using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Menu
{
    public partial class FormExercicio2 : Form
    {
        public FormExercicio2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(String.Compare(textBox1.Text, textBox2.Text, true) == 0)
            {
                MessageBox.Show("Os textos são iguais!");
            }else
            {
                MessageBox.Show("Os textos não são iguais!");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string novoTexto, inicio, fim;
            int metadePalavra = textBox1.Text.Length / 2;

            inicio = textBox1.Text.Substring(0, metadePalavra);
            fim = textBox1.Text.Substring(metadePalavra, textBox1.Text.Length - metadePalavra);

            novoTexto = inicio + textBox2.Text + fim;

            MessageBox.Show(novoTexto);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string novoTexto;
            int metadePalavra = textBox1.Text.Length / 2;

            novoTexto = textBox1.Text.Insert(metadePalavra, "**");
            MessageBox.Show(novoTexto);
        }
    }
}
