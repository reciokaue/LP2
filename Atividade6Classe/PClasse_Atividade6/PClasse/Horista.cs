using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    class Horista : Empregado
        //Não posso herdar mais de uma classe não existe múltipla
    {
        //prop e 2 x tab cria a estrutura da propriedade
        public double SalarioHora { get; set; }
        public double NumeroHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return SalarioHora * NumeroHora;
        }

        //override indica sobreescrever
        public override int TempoTrabalho()
        {
            //método retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
