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
    public partial class FormularioExercicio3 : Form
    {
        public FormularioExercicio3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string entrada = textBox2.Text;
            string trocar= textBox1.Text;
            string resultado = "";

            for (int i = 0; i < entrada.Length; i++)
            {
                bool teste = entrada.Substring(i, trocar.Length) == trocar;
                if (teste)
                {
                    entrada = entrada.Substring(i + trocar.Length, entrada.Length - i - trocar.Length);
                }
                else
                {
                    resultado = entrada;
                }

            }
            
            textBox2.Text = resultado;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Replace(textBox1.Text, "");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            char[] texto1 = textBox1.Text.ToCharArray();
            Array.Reverse(texto1);
            textBox2.Text = new string(texto1);
        }
    }
}
