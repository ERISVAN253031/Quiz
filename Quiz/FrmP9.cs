using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class FrmP9 : Form
    {
        public FrmP9()
        {
            InitializeComponent();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (btnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ACERTOS
                Variaveisglobais.Acertos+=1;
                FrmP10 P10 = new FrmP10(); // chamar o formulario
                P10.ShowDialog();
                this.Dispose();
            }
            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ERROS
                Variaveisglobais.Erros+=1;
                FrmP10 P10 = new FrmP10(); // chamar o formulario
                P10.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
}
