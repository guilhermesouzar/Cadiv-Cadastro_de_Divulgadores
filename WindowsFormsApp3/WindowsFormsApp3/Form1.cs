using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }


        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_de_Divulgadores Cadastro = new Cadastro_de_Divulgadores();
            Cadastro.ShowDialog();
        }

        private void buscaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
             BuscaDivulgador Busca = new BuscaDivulgador();
            Busca.ShowDialog();
        }

        private void tollBar_Vendas_Click(object sender, EventArgs e)
        {
            formBanco Venda = new formBanco();
            Venda.ShowDialog();
        }


        private void btncadastrarDivulgador_Click(object sender, EventArgs e)
        {
            Cadastro_de_Divulgadores Cadastro = new Cadastro_de_Divulgadores();
            Cadastro.ShowDialog();
        }

        private void btnbuscarDivulgador_Click(object sender, EventArgs e)
        {
            BuscaDivulgador Busca = new BuscaDivulgador();
            Busca.ShowDialog();
        }

        private void btnVerDivulgadores_Click(object sender, EventArgs e)
        {
            {
                formBanco Venda = new formBanco();
                Venda.ShowDialog();
            }
        }
    }
}
