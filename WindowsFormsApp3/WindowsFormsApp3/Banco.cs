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
    public partial class formBanco : Form
    {
        DataTable data;
        MySqlDataAdapter adapter;
        public formBanco()
        {
            InitializeComponent();
        }
        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                //abre conexao com banco
                MySqlConnection objConexao = new MySqlConnection("server = localhost; port = 3306; UID = root; PWD =0206Flash*@; database = db_pessoas");
                objConexao.Open();
                //seleciona todos os dados
                adapter = new MySqlDataAdapter("SELECT * FROM tb_dados", objConexao);
                //retorna no datagrid
                data = new DataTable();
                adapter.Fill(data);
                dgvDivulgadores.DataSource = data;
                //fecha conexao com banco
                objConexao.Close();

            }
            catch (Exception Erro)
            {
                MessageBox.Show("erro ao conectar" + Erro);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objConexao = new MySqlConnection("server = localhost; port = 3306; UID = root; PWD =0206Flash*@; database = db_pessoas");
                objConexao.Open();
                //instancia o comando update
                MySqlCommandBuilder alterar = new MySqlCommandBuilder(adapter);
                //altera o dado no banco
                adapter.Update(data);
                MessageBox.Show("Dado alterado com sucesso.");

            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao editar : \n " + Erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Seleciona o cod da pessoa para excluir no banco
            int cd_codToRemove = (int)dgvDivulgadores.SelectedRows[0].Cells["cd_cod"].Value;

            try
            {
                MySqlConnection objConexao = new MySqlConnection("server = localhost; port = 3306; UID = root; PWD =0206Flash*@; database = db_pessoas");
                objConexao.Open();

                //executa o Procedure dentro do banco para deletar da tbl principal e enviar para excluidos.
                MySqlCommand cmddeleteMoveProcedure = new MySqlCommand();
                cmddeleteMoveProcedure.Connection = objConexao;
                cmddeleteMoveProcedure.CommandType = CommandType.StoredProcedure;
                cmddeleteMoveProcedure.CommandText = "deleteMove";
                cmddeleteMoveProcedure.Parameters.AddWithValue("cd_codToRemove", cd_codToRemove);
                cmddeleteMoveProcedure.ExecuteNonQuery();
                //remove a linha do excluido do dgv
                dgvDivulgadores.Rows.RemoveAt(dgvDivulgadores.SelectedRows[0].Index);

                MessageBox.Show("Dado excluido com sucesso.");
                objConexao.Close();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ao excluir : \n " + Erro);
            }
        }


        private void dgvDivulgadores_SelectionChanged(object sender, EventArgs e)
        {
            //limita o botão excluir para ativar apenas quando selecionar a linha inteira
            if (dgvDivulgadores.SelectedRows.Count > 0)
            {
                DataRowView dr = (DataRowView)dgvDivulgadores.Rows[dgvDivulgadores.SelectedRows[0].Index].DataBoundItem;
                string teste = dr["cd_cod"].ToString();
                btnExcluir.Enabled = true;
            }
            else btnExcluir.Enabled = false;

        }

        private void dgvDivulgadores_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Forço a entrada de caracteres maiusculos nos campos nome e sobrenome
            if (dgvDivulgadores.CurrentCell.ColumnIndex == 1 || dgvDivulgadores.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                prodCode.CharacterCasing = CharacterCasing.Upper;
            }
            else
            {
                TextBox prodCode = e.Control as TextBox;
                prodCode.CharacterCasing = CharacterCasing.Normal;
            }

        }

        private void formBanco_Load(object sender, EventArgs e)
        {

        }
    }
}

