namespace WindowsFormsApp3
{
    partial class Sistema
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.btncadastrarDivulgador = new System.Windows.Forms.Button();
            this.btnbuscarDivulgador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVerDivulgadores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncadastrarDivulgador
            // 
            this.btncadastrarDivulgador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarDivulgador.Location = new System.Drawing.Point(270, 199);
            this.btncadastrarDivulgador.Name = "btncadastrarDivulgador";
            this.btncadastrarDivulgador.Size = new System.Drawing.Size(206, 50);
            this.btncadastrarDivulgador.TabIndex = 1;
            this.btncadastrarDivulgador.Text = "Cadastrar Divulgador";
            this.btncadastrarDivulgador.UseVisualStyleBackColor = true;
            this.btncadastrarDivulgador.Click += new System.EventHandler(this.btncadastrarDivulgador_Click);
            // 
            // btnbuscarDivulgador
            // 
            this.btnbuscarDivulgador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarDivulgador.Location = new System.Drawing.Point(270, 266);
            this.btnbuscarDivulgador.Name = "btnbuscarDivulgador";
            this.btnbuscarDivulgador.Size = new System.Drawing.Size(206, 48);
            this.btnbuscarDivulgador.TabIndex = 2;
            this.btnbuscarDivulgador.Text = "Buscar Divulgador";
            this.btnbuscarDivulgador.UseVisualStyleBackColor = true;
            this.btnbuscarDivulgador.Click += new System.EventHandler(this.btnbuscarDivulgador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seja bem-vindo!";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha a opção desejada.";
            // 
            // btnVerDivulgadores
            // 
            this.btnVerDivulgadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDivulgadores.Location = new System.Drawing.Point(270, 338);
            this.btnVerDivulgadores.Name = "btnVerDivulgadores";
            this.btnVerDivulgadores.Size = new System.Drawing.Size(206, 48);
            this.btnVerDivulgadores.TabIndex = 5;
            this.btnVerDivulgadores.Text = "Ver Divulgadores";
            this.btnVerDivulgadores.UseVisualStyleBackColor = true;
            this.btnVerDivulgadores.Click += new System.EventHandler(this.btnVerDivulgadores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(742, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerDivulgadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscarDivulgador);
            this.Controls.Add(this.btncadastrarDivulgador);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncadastrarDivulgador;
        private System.Windows.Forms.Button btnbuscarDivulgador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVerDivulgadores;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

