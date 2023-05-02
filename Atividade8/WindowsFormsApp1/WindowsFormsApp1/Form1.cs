using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        void Soma1()
        {
            Double resultado = 1 + 1;
            MessageBox.Show(resultado.ToString());
        }
        double Soma2()
        {
            return 1 + 1;
        }
        void Soma3(double x, double y)
        {
            x = 40;
            double resultado = x + y;
            MessageBox.Show("O resultado é: " + resultado.ToString());
        }
        double Soma4(double x, double y)
        {
            return x + y;
        }
        void Soma5(ref double resultado, ref double a)
        {
            a = 4;
            resultado = 2 + 3;
        }
        double Soma6 (ref double resultado){
            resultado = 2 + 3;
            return resultado;
        }
        void Soma7(out double resultado)
        {
            resultado = 2 + 3;
        }
        double Soma8(out double resultado)
        {
            return resultado = 2 + 3;
        }
        void Soma9(out double retorno, double x ,double y, double z = 0)
        {
            if (z != 0)
                retorno = (x + y + z) / 3;
            else
                retorno = (x + y) / 2;
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            //função void
            Soma1();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //função return
            MessageBox.Show(Soma2().ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //função void parametro
            Soma3(1, 10);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // função return parametro
            MessageBox.Show(Soma4(10, 20).ToString());
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double a = 10;
            double b = 20;

            Soma5(ref b, ref a);

            MessageBox.Show("O resultado é " + b + "valor de b " + a);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double resultado = 10;

            Soma6(ref resultado);

            MessageBox.Show("O resultado é " + resultado + "o return é" + Soma6(ref resultado));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            double a = 50;
            Soma7(out a);
            MessageBox.Show(a.ToString());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            double a = 50;
            double b = Soma8(out a);
            MessageBox.Show("valor a: " + a + " Valor b: " + b);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            double a = 10, b = 10;

            Soma9(out a, a, b);

            MessageBox.Show("Valor resultado:" + a);
        }
    }
}
