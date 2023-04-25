using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasse
{
    class Mensalista : Empregado //especialização --> Herança
    {
        public Double SalarioMensal { get; set; }

        //sobreescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;

        }
        public Mensalista()
        {

        }
        //////construtor --> new
        public Mensalista(double x)
        {

        }
        public Mensalista(int matx, string nomex, DateTime datax, double salariox){
            Matricula = matx;
            NomeEmpregado = nomex;
            DataEntradaEmpresa = datax;
            SalarioMensal = salariox;
        }
    }
}
