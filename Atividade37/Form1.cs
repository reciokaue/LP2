using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CompareArrays(int[] arrayA, int[] arrayB)
        {
            string message = "Comparação:\n\n";

            for (int i = 0; i < arrayA.Length && i < arrayB.Length; i++)
            {
                message += $"Index {i}: {arrayA[i]} | {arrayB[i]}\n";
            }

            return message;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int[] arrayA = new int[10];
            int[] arrayB = new int[10];

            for(int index = 0; index < 10; index++)
            {
                string input = Interaction.InputBox("Digite um numero:", "Entrada de dados");

                //validacao()
                int number;
                if(int.TryParse(input, out number))
                {
                    //add vetor A
                    arrayA[index] = number;

                    //add vetor A
                    if (index%2 == 0)
                    {
                        arrayB[index] = number * 5;
                    }
                    else
                    {
                        arrayB[index] = number + 5;
                    }

                }
                else
                {
                    MessageBox.Show("Número invalido");
                    index--;
                    break; 
                }

            }
            MessageBox.Show(CompareArrays(arrayA, arrayB));
        }
    }
}
