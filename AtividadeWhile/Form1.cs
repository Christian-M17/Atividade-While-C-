using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMultiplo3_Click(object sender, EventArgs e)
        {
            int num = 1;

            while (num <= 99)
            {
                if (num % 3 == 0)
                {
                    MessageBox.Show(num + " É multiplo de 3");
                }
                num = num + 1;
            }
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            int num = 100;

                while (num <= 1000)
            {
                MessageBox.Show("Número" + num);
                num = num + 1;
            }
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            int aluno = 1;
            int nota;

            while (aluno <= 5)
            {
                nota = aluno * 10;
                MessageBox.Show("Aluno " + aluno + ":" + nota);
                aluno = aluno + 1;
            }
        }
        
    }
}
