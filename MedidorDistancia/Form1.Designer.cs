namespace MedidorDistancia
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPorta = new System.Windows.Forms.Label();
            this.cmbPorta = new System.Windows.Forms.ComboBox();
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.lblDistanciaTitulo = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(68, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(303, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "MEDIDOR DE DISTÂNCIA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(40, 80);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(62, 13);
            this.lblPorta.TabIndex = 1;
            this.lblPorta.Text = "Porta COM:";
            // 
            // cmbPorta
            // 
            this.cmbPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorta.FormattingEnabled = true;
            this.cmbPorta.Location = new System.Drawing.Point(43, 109);
            this.cmbPorta.Name = "cmbPorta";
            this.cmbPorta.Size = new System.Drawing.Size(121, 21);
            this.cmbPorta.TabIndex = 2;
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.Lime;
            this.btnLigar.Location = new System.Drawing.Point(43, 174);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(142, 51);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = false;
            // 
            // btnDesligar
            // 
            this.btnDesligar.BackColor = System.Drawing.Color.Red;
            this.btnDesligar.Enabled = false;
            this.btnDesligar.Location = new System.Drawing.Point(191, 174);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(140, 51);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = false;
            // 
            // lblDistanciaTitulo
            // 
            this.lblDistanciaTitulo.AutoSize = true;
            this.lblDistanciaTitulo.Location = new System.Drawing.Point(138, 248);
            this.lblDistanciaTitulo.Name = "lblDistanciaTitulo";
            this.lblDistanciaTitulo.Size = new System.Drawing.Size(102, 13);
            this.lblDistanciaTitulo.TabIndex = 5;
            this.lblDistanciaTitulo.Text = "DISTÂNCIA ATUAL";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(54, 275);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.ReadOnly = true;
            this.txtDistancia.Size = new System.Drawing.Size(258, 44);
            this.txtDistancia.TabIndex = 6;
            this.txtDistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(159, 335);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Desligado";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(128, 367);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 23);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "ATUALIZAR PORTAS";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistanciaTitulo);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.cmbPorta);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.ComboBox cmbPorta;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Label lblDistanciaTitulo;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

