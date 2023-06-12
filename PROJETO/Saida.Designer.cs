namespace PROJETO
{
    partial class lvSaida
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
            this.txbValorSaida = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvtSaida = new System.Windows.Forms.ListView();
            this.clnIdSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnValorSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDataSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDescricaoSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTipoSaida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCadastrarSaida = new System.Windows.Forms.Button();
            this.btnLimparSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbValorSaida
            // 
            this.txbValorSaida.Location = new System.Drawing.Point(38, 72);
            this.txbValorSaida.Name = "txbValorSaida";
            this.txbValorSaida.Size = new System.Drawing.Size(145, 22);
            this.txbValorSaida.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor de Saída R$";
            // 
            // txbDataSaida
            // 
            this.txbDataSaida.Location = new System.Drawing.Point(38, 143);
            this.txbDataSaida.Name = "txbDataSaida";
            this.txbDataSaida.Size = new System.Drawing.Size(145, 22);
            this.txbDataSaida.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(293, 70);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(272, 22);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(293, 145);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(271, 22);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Saída";
            // 
            // lvtSaida
            // 
            this.lvtSaida.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnIdSaida,
            this.clnValorSaida,
            this.clnDataSaida,
            this.clnDescricaoSaida,
            this.clnTipoSaida});
            this.lvtSaida.HideSelection = false;
            this.lvtSaida.Location = new System.Drawing.Point(37, 219);
            this.lvtSaida.Name = "lvtSaida";
            this.lvtSaida.Size = new System.Drawing.Size(722, 203);
            this.lvtSaida.TabIndex = 8;
            this.lvtSaida.UseCompatibleStateImageBehavior = false;
            this.lvtSaida.View = System.Windows.Forms.View.Details;
            // 
            // clnIdSaida
            // 
            this.clnIdSaida.Text = "ID";
            // 
            // clnValorSaida
            // 
            this.clnValorSaida.Text = "VALOR";
            this.clnValorSaida.Width = 113;
            // 
            // clnDataSaida
            // 
            this.clnDataSaida.Text = "DATA";
            this.clnDataSaida.Width = 122;
            // 
            // clnDescricaoSaida
            // 
            this.clnDescricaoSaida.Text = "DESCRIÇÃO";
            this.clnDescricaoSaida.Width = 236;
            // 
            // clnTipoSaida
            // 
            this.clnTipoSaida.Text = "TIPO ";
            this.clnTipoSaida.Width = 185;
            // 
            // btnCadastrarSaida
            // 
            this.btnCadastrarSaida.Location = new System.Drawing.Point(633, 41);
            this.btnCadastrarSaida.Name = "btnCadastrarSaida";
            this.btnCadastrarSaida.Size = new System.Drawing.Size(126, 53);
            this.btnCadastrarSaida.TabIndex = 9;
            this.btnCadastrarSaida.Text = "CADASTRAR";
            this.btnCadastrarSaida.UseVisualStyleBackColor = true;
            // 
            // btnLimparSaida
            // 
            this.btnLimparSaida.Location = new System.Drawing.Point(633, 118);
            this.btnLimparSaida.Name = "btnLimparSaida";
            this.btnLimparSaida.Size = new System.Drawing.Size(125, 51);
            this.btnLimparSaida.TabIndex = 10;
            this.btnLimparSaida.Text = "LIMPAR";
            this.btnLimparSaida.UseVisualStyleBackColor = true;
            // 
            // lvSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimparSaida);
            this.Controls.Add(this.btnCadastrarSaida);
            this.Controls.Add(this.lvtSaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDataSaida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbValorSaida);
            this.Name = "lvSaida";
            this.Text = "Cadastro de Saídas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txbValorSaida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txbDataSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvtSaida;
        private System.Windows.Forms.ColumnHeader clnIdSaida;
        private System.Windows.Forms.ColumnHeader clnValorSaida;
        private System.Windows.Forms.ColumnHeader clnDataSaida;
        private System.Windows.Forms.ColumnHeader clnDescricaoSaida;
        private System.Windows.Forms.ColumnHeader clnTipoSaida;
        private System.Windows.Forms.Button btnCadastrarSaida;
        private System.Windows.Forms.Button btnLimparSaida;
    }
}