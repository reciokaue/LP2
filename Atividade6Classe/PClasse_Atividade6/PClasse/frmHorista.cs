using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
                   }

        private void FrmHorista_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Horista objHorista= new Horista();

            objHorista.Matricula = Convert.ToInt32(matricula.Text);
            objHorista.NomeEmpregado = nome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(entradaEmpresa.Text);
            objHorista.SalarioHora = Convert.ToDouble(salarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(numeroHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(faltas.Text);
            if (radioButton1.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show(
                "Matricula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome()
           );
        }
    }
}
