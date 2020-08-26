namespace Padaria_UI
{
    partial class MetodoPagamento
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
            this.checkDinheiro = new System.Windows.Forms.CheckBox();
            this.checkCartao = new System.Windows.Forms.CheckBox();
            this.checkCheque = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkDinheiro
            // 
            this.checkDinheiro.AutoSize = true;
            this.checkDinheiro.Location = new System.Drawing.Point(82, 62);
            this.checkDinheiro.Name = "checkDinheiro";
            this.checkDinheiro.Size = new System.Drawing.Size(65, 17);
            this.checkDinheiro.TabIndex = 0;
            this.checkDinheiro.Text = "Dinheiro";
            this.checkDinheiro.UseVisualStyleBackColor = true;
            this.checkDinheiro.CheckedChanged += new System.EventHandler(this.checkDinheiro_CheckedChanged);
            // 
            // checkCartao
            // 
            this.checkCartao.AutoSize = true;
            this.checkCartao.Location = new System.Drawing.Point(82, 86);
            this.checkCartao.Name = "checkCartao";
            this.checkCartao.Size = new System.Drawing.Size(57, 17);
            this.checkCartao.TabIndex = 1;
            this.checkCartao.Text = "Cartão";
            this.checkCartao.UseVisualStyleBackColor = true;
            this.checkCartao.CheckedChanged += new System.EventHandler(this.checkCartao_CheckedChanged);
            // 
            // checkCheque
            // 
            this.checkCheque.AutoSize = true;
            this.checkCheque.Location = new System.Drawing.Point(82, 110);
            this.checkCheque.Name = "checkCheque";
            this.checkCheque.Size = new System.Drawing.Size(63, 17);
            this.checkCheque.TabIndex = 2;
            this.checkCheque.Text = "Cheque";
            this.checkCheque.UseVisualStyleBackColor = true;
            this.checkCheque.CheckedChanged += new System.EventHandler(this.checkCheque_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(25, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(144, 160);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // MetodoPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 218);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.checkCheque);
            this.Controls.Add(this.checkCartao);
            this.Controls.Add(this.checkDinheiro);
            this.Name = "MetodoPagamento";
            this.Text = "Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkDinheiro;
        private System.Windows.Forms.CheckBox checkCartao;
        private System.Windows.Forms.CheckBox checkCheque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
    }
}