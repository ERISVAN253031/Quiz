﻿using System;
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
    public partial class FrmP3 : Form
    {
        public FrmP3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (btnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ACERTOS
                FrmP3 p3 = new FrmP3(); // chamar o formulario
                p3.ShowDialog();
                this.Dispose();
            }
            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ERROS
                FrmP3 p3 = new FrmP3(); // chamar o formulario
                p3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }

        private void FrmP3_Load(object sender, EventArgs e)
        {
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (btnCerta.Checked==true)
            {
                MessageBox.Show("Certa Resposta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ACERTOS
                Variaveisglobais.Acertos+=1;
                FrmP4 P4 = new FrmP4(); // chamar o formulario
                P4.ShowDialog();
                this.Dispose();
            }
            else if (rbtn1.Checked || rbtn2.Checked || rbtn3.Checked)
            {
                MessageBox.Show("Resposta Incorreta", "QUIZ");
                // SOMAR NA VARIAVEL GLOBAL ERROS
                Variaveisglobais.Erros+=1;
                FrmP4 P4 = new FrmP4(); // chamar o formulario
                P4.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma alternativa");
            }
        }
    }
    }
    

