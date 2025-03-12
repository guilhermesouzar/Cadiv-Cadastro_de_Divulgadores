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

namespace WindowsFormsApp3
{
    public partial class Cadastro_de_Divulgadores : Form
    {
        public Cadastro_de_Divulgadores()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (TxtBoxPrimeiroNome.Text.Trim() == "")
            {
                TxtBoxPrimeiroNome.Text.Trim();
                MessageBox.Show("Campo PRIMEIRO NOME deve ser preenchido");
                TxtBoxPrimeiroNome.Focus();
            }

            else if (MkdBoxTelefone.MaskFull == false)
            {
                MessageBox.Show("Campo TELEFONE deve ser preenchido corretamente.");
                MkdBoxTelefone.Focus();

            }

            else if (txtBoxSobrenome.Text.Trim() == "")
            {
                TxtBoxPrimeiroNome.Text.Trim();
                MessageBox.Show("Campo SOBRENOME deve ser preenchido");
                TxtBoxPrimeiroNome.Focus();
            }
            else if (TxtBoxEmail.Text.Trim() == "")
            {
                MessageBox.Show("Campo EMAIL deve ser preenchido corretamente.");
                TxtBoxEmail.Focus();
            }

            else
            {
                MessageBox.Show("Dados salvos com sucesso.");

                StreamWriter Dados = new StreamWriter("Dados21.txt", true);

                string primeironome, sobrenome, cpf, rg, email, celular, pessoa;

                primeironome = TxtBoxPrimeiroNome.Text;
                sobrenome = txtBoxSobrenome.Text;
                email = TxtBoxEmail.Text;
                rg = txtBoxRG.Text;

                MkdTxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                cpf = MkdTxtCPF.Text;

                MkdBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                celular = MkdBoxTelefone.Text;

                pessoa = primeironome + ";" + sobrenome + ";" + email + ";" + celular + ";" + rg + ";" + cpf + ";";
                Dados.Write(pessoa);

                Dados.Dispose();
                Dados.Close();

               
                btnGeraCodigo.Enabled = true;
            }
        }

        private void MkdTxtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show(" O campo CPF deve ser preenchido com 11 números.", "ERRO");
        }

        private void MkdBoxCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("O campo celular deve ser preenchido com DDD e 9 numeros.", "ERRO");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            using (StreamReader LeituraDados = new StreamReader("Dados21.txt"))
            {
                string linha;

                while ((linha = LeituraDados.ReadLine()) != null)
                {

                    int Index = linha.IndexOf(';', 0);
                    MkdTxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                    if (linha.Substring(0, Index) == MkdTxtCPF.Text)
                    {
                        string primeironomeencontrado, sobrenome, email, celular, rg, cpf;
                        int aux = 0, pos = 0;

                        pos = linha.IndexOf(';', pos);
                        primeironomeencontrado = linha.Substring(0, pos);
                        pos++;
                        aux = pos;

                        pos = linha.IndexOf(';', aux);
                        sobrenome = linha.Substring(aux, (pos - aux));
                        pos++;
                        aux = pos;

                        pos = linha.IndexOf(';', aux);
                        email = linha.Substring(aux, (pos - aux));
                        pos++;
                        aux = pos;

                        pos = linha.IndexOf(';', aux);
                        celular = linha.Substring(aux, (pos - aux));
                        pos++;
                        aux = pos;

                        pos = linha.IndexOf(';', aux);
                        rg = linha.Substring(aux, (pos - aux));
                        pos++;
                        aux = pos;

                        pos = linha.IndexOf(';', aux);
                        cpf = linha.Substring(aux, (pos - aux));

                        TxtBoxPrimeiroNome.Text = primeironomeencontrado;
                        txtBoxRG.Text = sobrenome;

                        MkdTxtCPF.Text = cpf;
                        MkdBoxTelefone.Text = celular;
                        TxtBoxEmail.Text = email;
                        MkdTxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                        MessageBox.Show("CPF Encontrado.");
                        return;
                    }
                }
                MessageBox.Show("CPF não encontrado", "ERRO");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtBoxPrimeiroNome.Text = "";
            txtBoxRG.Text = "";

            TxtBoxEmail.Text = "";
            MkdBoxTelefone.Text = "";
            MkdTxtCPF.Text = "";
            TxtBoxPrimeiroNome.Focus();
        }

        private void btnGeraCodigo_Click(object sender, EventArgs e)
        {
            using (StreamReader LeituraDados = new StreamReader("Dados21.txt"))
            {
                string linha;
                int numeroLinhas = File.ReadAllLines("Dados21.txt").Length;


                MessageBox.Show("Numer de linhas " + numeroLinhas);

                while ((linha = LeituraDados.ReadLine()) != null)
                {

                    int Index = linha.IndexOf(';', 0);
                    int pos = 0, aux = 0;
                    string primeironome, codigo;

                    pos = linha.IndexOf(';', pos);
                    primeironome = linha.Substring(0, pos);
                    pos++;
                    aux = pos;

                    codigo = primeironome + numeroLinhas;

                    TxtBoxCod.Text = codigo;
                }

                LeituraDados.Dispose();
                LeituraDados.Close();

            }
            StreamWriter Dados = new StreamWriter("Dados21.txt", true);
            
                string codigodiv = TxtBoxCod.Text;

                Dados.WriteLine(codigodiv);

                MessageBox.Show(codigodiv);

                Dados.Dispose();
                Dados.Close();

            TxtBoxCod.Visible = true;


            MkdTxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            MkdBoxTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            TxtBoxPrimeiroNome.Text = "";
            txtBoxRG.Text = "";
            txtBoxSobrenome.Text = "";
            TxtBoxEmail.Text = "";
            MkdBoxTelefone.Text = "";
            MkdTxtCPF.Text = "";




        }
    }
}


