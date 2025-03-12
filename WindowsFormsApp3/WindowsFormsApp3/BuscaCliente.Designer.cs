namespace WindowsFormsApp3
{
    partial class BuscaDivulgador
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtBoxSobreNome = new System.Windows.Forms.TextBox();
            this.txtBoxRG = new System.Windows.Forms.TextBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxCpfReturn = new System.Windows.Forms.TextBox();
            this.TxtBoxTelefone = new System.Windows.Forms.TextBox();
            this.TxtBoxPrimeiroNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informe o código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busca de Divulgadores";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(130, 112);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtBoxSobreNome
            // 
            this.TxtBoxSobreNome.Enabled = false;
            this.TxtBoxSobreNome.Location = new System.Drawing.Point(97, 209);
            this.TxtBoxSobreNome.Name = "TxtBoxSobreNome";
            this.TxtBoxSobreNome.Size = new System.Drawing.Size(135, 20);
            this.TxtBoxSobreNome.TabIndex = 6;
            // 
            // txtBoxRG
            // 
            this.txtBoxRG.Enabled = false;
            this.txtBoxRG.Location = new System.Drawing.Point(97, 386);
            this.txtBoxRG.Name = "txtBoxRG";
            this.txtBoxRG.Size = new System.Drawing.Size(137, 20);
            this.txtBoxRG.TabIndex = 7;
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Enabled = false;
            this.TxtBoxEmail.Location = new System.Drawing.Point(97, 250);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(137, 20);
            this.TxtBoxEmail.TabIndex = 8;
            // 
            // TxtBoxCpfReturn
            // 
            this.TxtBoxCpfReturn.Enabled = false;
            this.TxtBoxCpfReturn.Location = new System.Drawing.Point(97, 347);
            this.TxtBoxCpfReturn.Name = "TxtBoxCpfReturn";
            this.TxtBoxCpfReturn.Size = new System.Drawing.Size(137, 20);
            this.TxtBoxCpfReturn.TabIndex = 9;
            // 
            // TxtBoxTelefone
            // 
            this.TxtBoxTelefone.Enabled = false;
            this.TxtBoxTelefone.Location = new System.Drawing.Point(97, 299);
            this.TxtBoxTelefone.Name = "TxtBoxTelefone";
            this.TxtBoxTelefone.Size = new System.Drawing.Size(137, 20);
            this.TxtBoxTelefone.TabIndex = 10;
            // 
            // TxtBoxPrimeiroNome
            // 
            this.TxtBoxPrimeiroNome.Enabled = false;
            this.TxtBoxPrimeiroNome.Location = new System.Drawing.Point(97, 155);
            this.TxtBoxPrimeiroNome.Name = "TxtBoxPrimeiroNome";
            this.TxtBoxPrimeiroNome.Size = new System.Drawing.Size(137, 20);
            this.TxtBoxPrimeiroNome.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "RG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "CPF:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaNome.Location = new System.Drawing.Point(53, 78);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(221, 20);
            this.txtBuscaNome.TabIndex = 1;
            this.txtBuscaNome.Text = "INTERIORAUTOMOVEIS";
            // 
            // BuscaDivulgador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(318, 442);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxPrimeiroNome);
            this.Controls.Add(this.TxtBoxTelefone);
            this.Controls.Add(this.TxtBoxCpfReturn);
            this.Controls.Add(this.TxtBoxEmail);
            this.Controls.Add(this.txtBoxRG);
            this.Controls.Add(this.TxtBoxSobreNome);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "BuscaDivulgador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Divulgador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBoxSobreNome;
        private System.Windows.Forms.TextBox txtBoxRG;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxCpfReturn;
        private System.Windows.Forms.TextBox TxtBoxTelefone;
        private System.Windows.Forms.TextBox TxtBoxPrimeiroNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscaNome;
    }
}