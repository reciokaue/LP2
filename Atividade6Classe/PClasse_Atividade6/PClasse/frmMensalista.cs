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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void BtnInstanMensal_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();

            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalMensal.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "\n" +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome());
        }

        private void BtnInstan_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text,
                Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalMensal.Text)
           );

        MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
            "Nome: " + objMensalista.NomeEmpregado + "\n" +
            "Data Entrada: " +
            objMensalista.DataEntradaEmpresa.ToShortDateString() +
            "\n" +
            "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
            "\n" +
            "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
            "\n" + objMensalista.VerificaHome());
        }
    }
}
