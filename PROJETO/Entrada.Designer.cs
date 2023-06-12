namespace PROJETO
{
    partial class lvEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvtEntrada = new System.Windows.Forms.ListView();
            this.clnIdEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnValorEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDataEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDescricaoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTipoEntrada = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbDescricaoEntrada = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txbDataEntrada = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnLimparEntrada = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnCadastrarEntrada = new System.Windows.Forms.Button();
            this.txbTipoEntrada = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txbValorEntrada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvtEntrada
            // 
            this.lvtEntrada.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnIdEntrada,
            this.clnValorEntrada,
            this.clnDataEntrada,
            this.clnDescricaoEntrada,
            this.clnTipoEntrada});
            this.lvtEntrada.HideSelection = false;
            this.lvtEntrada.Location = new System.Drawing.Point(34, 198);
            this.lvtEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.lvtEntrada.Name = "lvtEntrada";
            this.lvtEntrada.Size = new System.Drawing.Size(735, 216);
            this.lvtEntrada.TabIndex = 16;
            this.lvtEntrada.UseCompatibleStateImageBehavior = false;
            this.lvtEntrada.View = System.Windows.Forms.View.Details;
            // 
            // clnIdEntrada
            // 
            this.clnIdEntrada.Text = "ID";
            this.clnIdEntrada.Width = 47;
            // 
            // clnValorEntrada
            // 
            this.clnValorEntrada.Text = "VALOR";
            this.clnValorEntrada.Width = 103;
            // 
            // clnDataEntrada
            // 
            this.clnDataEntrada.Text = "DATA";
            this.clnDataEntrada.Width = 100;
            // 
            // clnDescricaoEntrada
            // 
            this.clnDescricaoEntrada.Text = "DESCRIÇÃO";
            this.clnDescricaoEntrada.Width = 188;
            // 
            // clnTipoEntrada
            // 
            this.clnTipoEntrada.Text = "Tipo de Entrada";
            this.clnTipoEntrada.Width = 149;
            // 
            // txbDescricaoEntrada
            // 
            this.txbDescricaoEntrada.Location = new System.Drawing.Point(265, 56);
            this.txbDescricaoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescricaoEntrada.Name = "txbDescricaoEntrada";
            this.txbDescricaoEntrada.Size = new System.Drawing.Size(278, 22);
            this.txbDescricaoEntrada.TabIndex = 14;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(261, 37);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 16);
            this.lblDescricao.TabIndex = 15;
            this.lblDescricao.Text = "Descrição";
            // 
            // txbDataEntrada
            // 
            this.txbDataEntrada.Location = new System.Drawing.Point(34, 120);
            this.txbDataEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txbDataEntrada.Name = "txbDataEntrada";
            this.txbDataEntrada.Size = new System.Drawing.Size(144, 22);
            this.txbDataEntrada.TabIndex = 9;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(32, 100);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data ";
            // 
            // btnLimparEntrada
            // 
            this.btnLimparEntrada.Location = new System.Drawing.Point(640, 93);
            this.btnLimparEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparEntrada.Name = "btnLimparEntrada";
            this.btnLimparEntrada.Size = new System.Drawing.Size(129, 49);
            this.btnLimparEntrada.TabIndex = 11;
            this.btnLimparEntrada.Text = "LIMPAR";
            this.btnLimparEntrada.UseVisualStyleBackColor = true;
            this.btnLimparEntrada.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(34, 37);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(128, 16);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "Valor da Entrada R$";
            // 
            // btnCadastrarEntrada
            // 
            this.btnCadastrarEntrada.Location = new System.Drawing.Point(640, 30);
            this.btnCadastrarEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarEntrada.Name = "btnCadastrarEntrada";
            this.btnCadastrarEntrada.Size = new System.Drawing.Size(129, 49);
            this.btnCadastrarEntrada.TabIndex = 13;
            this.btnCadastrarEntrada.Text = "CADASTRAR";
            this.btnCadastrarEntrada.UseVisualStyleBackColor = true;
            this.btnCadastrarEntrada.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txbTipoEntrada
            // 
            this.txbTipoEntrada.Location = new System.Drawing.Point(265, 120);
            this.txbTipoEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txbTipoEntrada.Name = "txbTipoEntrada";
            this.txbTipoEntrada.Size = new System.Drawing.Size(278, 22);
            this.txbTipoEntrada.TabIndex = 17;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(261, 101);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(103, 16);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo de entrada";
            // 
            // txbValorEntrada
            // 
            this.txbValorEntrada.Location = new System.Drawing.Point(34, 57);
            this.txbValorEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.txbValorEntrada.Name = "txbValorEntrada";
            this.txbValorEntrada.Size = new System.Drawing.Size(144, 22);
            this.txbValorEntrada.TabIndex = 8;
            // 
            // lvEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbTipoEntrada);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lvtEntrada);
            this.Controls.Add(this.txbDescricaoEntrada);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txbDataEntrada);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.btnLimparEntrada);
            this.Controls.Add(this.txbValorEntrada);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCadastrarEntrada);
            this.Name = "lvEntrada";
            this.Text = "Cadastro de Entradas";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvtEntrada;
        private System.Windows.Forms.ColumnHeader clnIdEntrada;
        private System.Windows.Forms.ColumnHeader clnValorEntrada;
        private System.Windows.Forms.ColumnHeader clnDataEntrada;
        private System.Windows.Forms.ColumnHeader clnDescricaoEntrada;
        private System.Windows.Forms.TextBox txbDescricaoEntrada;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txbDataEntrada;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnLimparEntrada;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnCadastrarEntrada;
        private System.Windows.Forms.TextBox txbTipoEntrada;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ColumnHeader clnTipoEntrada;
        private System.Windows.Forms.TextBox txbValorEntrada;
    }
}