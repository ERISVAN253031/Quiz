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
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = Variaveisglobais.Acertos.ToString();
            lblErros.Text = Variaveisglobais.Erros.ToString();

        }
    }
}
