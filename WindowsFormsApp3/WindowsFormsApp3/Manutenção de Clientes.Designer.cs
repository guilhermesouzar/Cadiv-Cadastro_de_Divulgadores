namespace WindowsFormsApp3
{
    partial class Cadastro_de_Divulgadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxPrimeiroNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.MkdTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxRG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MkdBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxSobrenome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGeraCodigo = new System.Windows.Forms.Button();
            this.TxtBoxCod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(242, 358);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(122, 46);
            this.BtnSalvar.TabIndex = 7;
            this.BtnSalvar.Text = "Cadastrar novo divulgador";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Divulgadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(59, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primeiro nome:";
            // 
            // TxtBoxPrimeiroNome
            // 
            this.TxtBoxPrimeiroNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtBoxPrimeiroNome.Location = new System.Drawing.Point(179, 120);
            this.TxtBoxPrimeiroNome.Name = "TxtBoxPrimeiroNome";
            this.TxtBoxPrimeiroNome.Size = new System.Drawing.Size(185, 20);
            this.TxtBoxPrimeiroNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(177, 214);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(187, 20);
            this.TxtBoxEmail.TabIndex = 4;
            // 
            // MkdTxtCPF
            // 
            this.MkdTxtCPF.Location = new System.Drawing.Point(178, 299);
            this.MkdTxtCPF.Mask = "000,000,000-00";
            this.MkdTxtCPF.Name = "MkdTxtCPF";
            this.MkdTxtCPF.Size = new System.Drawing.Size(115, 20);
            this.MkdTxtCPF.TabIndex = 6;
            this.MkdTxtCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MkdTxtCPF_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "RG:";
            // 
            // txtBoxRG
            // 
            this.txtBoxRG.Location = new System.Drawing.Point(177, 255);
            this.txtBoxRG.Name = "txtBoxRG";
            this.txtBoxRG.Size = new System.Drawing.Size(116, 20);
            this.txtBoxRG.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(119, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(98, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone:";
            // 
            // MkdBoxTelefone
            // 
            this.MkdBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MkdBoxTelefone.Location = new System.Drawing.Point(179, 169);
            this.MkdBoxTelefone.Mask = "(00)0000-0000";
            this.MkdBoxTelefone.Name = "MkdBoxTelefone";
            this.MkdBoxTelefone.Size = new System.Drawing.Size(115, 20);
            this.MkdBoxTelefone.TabIndex = 3;
            this.MkdBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MkdBoxCelular_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(479, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Os campos em vermelho devem obrigatóriamente ser preenchidos.";
            // 
            // txtBoxSobrenome
            // 
            this.txtBoxSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxSobrenome.Location = new System.Drawing.Point(504, 118);
            this.txtBoxSobrenome.Name = "txtBoxSobrenome";
            this.txtBoxSobrenome.Size = new System.Drawing.Size(191, 20);
            this.txtBoxSobrenome.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(392, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sobrenome:";
            // 
            // btnGeraCodigo
            // 
            this.btnGeraCodigo.Enabled = false;
            this.btnGeraCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraCodigo.Location = new System.Drawing.Point(573, 358);
            this.btnGeraCodigo.Name = "btnGeraCodigo";
            this.btnGeraCodigo.Size = new System.Drawing.Size(122, 46);
            this.btnGeraCodigo.TabIndex = 17;
            this.btnGeraCodigo.Text = "Gerar código";
            this.btnGeraCodigo.UseVisualStyleBackColor = true;
            this.btnGeraCodigo.Click += new System.EventHandler(this.btnGeraCodigo_Click);
            // 
            // TxtBoxCod
            // 
            this.TxtBoxCod.Location = new System.Drawing.Point(529, 303);
            this.TxtBoxCod.Name = "TxtBoxCod";
            this.TxtBoxCod.Size = new System.Drawing.Size(185, 20);
            this.TxtBoxCod.TabIndex = 18;
            this.TxtBoxCod.Visible = false;
            // 
            // Cadastro_de_Divulgadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.TxtBoxCod);
            this.Controls.Add(this.btnGeraCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxSobrenome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MkdBoxTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxRG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MkdTxtCPF);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxPrimeiroNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalvar);
            this.MaximizeBox = false;
            this.Name = "Cadastro_de_Divulgadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Divulgador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxPrimeiroNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.MaskedTextBox MkdTxtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxRG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MkdBoxTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxSobrenome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGeraCodigo;
        private System.Windows.Forms.TextBox TxtBoxCod;
    }
}