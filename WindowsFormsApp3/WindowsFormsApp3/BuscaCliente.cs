using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class BuscaDivulgador : Form
    {
        public BuscaDivulgador()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {   //inicia conexao com banco
                MySqlConnection objConexao = new MySqlConnection("server=localhost;port=3306;UID=root;PWD=0206Flash*@;database=db_pessoas");
                objConexao.Open();
                //chama comando buscar
                MySqlCommand cmdBuscar = new MySqlCommand("select * from tb_dados where cd_divulgador = ?", objConexao);
                cmdBuscar.Parameters.Clear();
                cmdBuscar.Parameters.Add("@cd_divulgador", MySqlDbType.VarChar).Value = txtBuscaNome.Text;
                cmdBuscar.CommandType = CommandType.Text;
                //le o campo buscado
                MySqlDataReader dr;
                dr = cmdBuscar.ExecuteReader();
                dr.Read();
                //ativa os campos e retorna os dados
                TxtBoxPrimeiroNome.Enabled = true;
                TxtBoxPrimeiroNome.Text = dr.GetString("nm_primeironome");
                TxtBoxSobreNome.Enabled = true;
                TxtBoxSobreNome.Text = dr.GetString("sn_sobrenome");
                TxtBoxEmail.Enabled = true;
                TxtBoxEmail.Text = dr.GetString("em_email");
                TxtBoxTelefone.Enabled = true;
                TxtBoxTelefone.Text = dr.GetString("tel_telefone");
                txtBoxRG.Enabled = true;
                txtBoxRG.Text = dr.GetString("rg_rg");
                TxtBoxCpfReturn.Enabled = true;
                TxtBoxCpfReturn.Text = dr.GetString("cpf_cpf");
                //fecha conexao com banco
                objConexao.Close();
                MessageBox.Show("Código encontrado");

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao buscar: CÓDIGO INVALIDO \n\n Detalhes do erro: \n" + Erro);
                //desativa e limpa os campos
                TxtBoxPrimeiroNome.Enabled = false;
                TxtBoxSobreNome.Enabled = false;
                TxtBoxEmail.Enabled = false;
                TxtBoxTelefone.Enabled = false;
                txtBoxRG.Enabled = false;
                TxtBoxCpfReturn.Enabled = false;
                TxtBoxPrimeiroNome.Clear();
                TxtBoxSobreNome.Clear();
                TxtBoxEmail.Clear();
                TxtBoxTelefone.Clear();
                txtBoxRG.Clear();
                TxtBoxCpfReturn.Clear();
            }

        }
    }
}
