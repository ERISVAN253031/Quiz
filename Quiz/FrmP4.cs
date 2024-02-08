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
    public partial class FrmP4 : Form
    {
        public FrmP4()
        {
            InitializeComponent();
        }

        private void FrmP5_Load(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (btnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ACERTOS
                Variaveisglobais.Acertos+=1;
                FrmP5 P5 = new FrmP5(); // chamar o formulario
                P5.ShowDialog();
                this.Dispose();
            }
            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ERROS
                Variaveisglobais.Erros+=1;
                FrmP5 P5 = new FrmP5(); // chamar o formulario
                P5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (btnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ACERTOS
                FrmP5 P5 = new FrmP5(); // chamar o formulario
                P5.ShowDialog();
                this.Dispose();
            }
            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ERROS
                FrmP5 P5 = new FrmP5(); // chamar o formulario
                P5.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
    }


