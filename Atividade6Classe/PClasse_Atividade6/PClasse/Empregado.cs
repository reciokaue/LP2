using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasse
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        public String VerificaHome()//método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em Home Office";
            else
                return "Empregado NÃO trabalha em Home Office";
        }

        //virtual --> pode ser sobreescrito
        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (span.Days);
        }

        //deve ser implementado nas classes filhas (subclasses)

        public abstract double SalarioBruto(); //não preciso implementar
        
    }
}
