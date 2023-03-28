using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double validateNumber(string ValidatingNumber)
        {
            if (!double.TryParse(ValidatingNumber, out double result)){
                MessageBox.Show("O nome não deve conter digitos númericos");
                return 0;
            }
            else if (result > 0)
            {
                return result;
            }
            return 0;
        }
        public double calcINSS(double salary)
        {
            double aliquota =
                salary > 800.47 ? 0.0765 :
                salary > 1050 ? 0.0865 :
                salary > 1400.77 ? 0.09 :
                salary > 2801.56 ? 0.11 : 308.17;

            return aliquota;
        }
        public double calcIRPF(double salary)
        {
            double aliquota =
                salary > 1257.12 ? 0 :
                salary > 2512.08 ? 0.15 : 0.275;

            return aliquota;
        }
        public double calcFamilia(double salary)
        {
            double aliquota =
                salary > 435.52 ? 22.33 :
                salary > 654.61 ? 15.74 : 0;
            return (double)ChildrenAmount.Value * aliquota;
        }

        private void Calc_button_Click(object sender, EventArgs e)
        {
            double salary = validateNumber(TextSalary.Text);

            double salarioFamilia = calcFamilia(salary);
            double aliquotaIRPF = calcIRPF(salary);
            double aliquotaINSS = calcINSS(salary);

            AliquotaINNS.Text = (aliquotaINSS*100).ToString() + "%";
            AliquotaIRPF.Text = (aliquotaIRPF*100).ToString() + "%";
            AliquotaIRPF.Text = salarioFamilia.ToString();

        }

        private void TextUserName_Validating(object sender, CancelEventArgs e)
        {
            if (TextUserName.Text.Any(char.IsDigit))
            {
                MessageBox.Show("O nome não deve conter digitos númericos");
                TextUserName.Focus();
            }
        }
    }
}
