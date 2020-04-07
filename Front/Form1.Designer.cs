namespace Front
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dgvFerramentas = new System.Windows.Forms.DataGridView();
            this.gbxFerrmenta = new System.Windows.Forms.GroupBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.gbxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).BeginInit();
            this.gbxFerrmenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 246);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(93, 246);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 13;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 27);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(62, 13);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição *";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 43);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(337, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(6, 76);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo *";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(6, 92);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(262, 20);
            this.txtTipo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(6, 128);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 13);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca *";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(6, 144);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(262, 20);
            this.txtMarca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(6, 177);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(42, 13);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço *";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(6, 193);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(131, 20);
            this.txtPreco.TabIndex = 12;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.txtDescricao);
            this.gbxDados.Controls.Add(this.lblDescricao);
            this.gbxDados.Controls.Add(this.txtPreco);
            this.gbxDados.Controls.Add(this.txtTipo);
            this.gbxDados.Controls.Add(this.lblPreco);
            this.gbxDados.Controls.Add(this.lblTipo);
            this.gbxDados.Controls.Add(this.label5);
            this.gbxDados.Controls.Add(this.txtMarca);
            this.gbxDados.Controls.Add(this.label4);
            this.gbxDados.Controls.Add(this.lblMarca);
            this.gbxDados.Location = new System.Drawing.Point(12, 12);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(349, 228);
            this.gbxDados.TabIndex = 14;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 246);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dgvFerramentas
            // 
            this.dgvFerramentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFerramentas.Location = new System.Drawing.Point(6, 19);
            this.dgvFerramentas.Name = "dgvFerramentas";
            this.dgvFerramentas.Size = new System.Drawing.Size(337, 182);
            this.dgvFerramentas.TabIndex = 16;
            // 
            // gbxFerrmenta
            // 
            this.gbxFerrmenta.Controls.Add(this.dgvFerramentas);
            this.gbxFerrmenta.Location = new System.Drawing.Point(12, 294);
            this.gbxFerrmenta.Name = "gbxFerrmenta";
            this.gbxFerrmenta.Size = new System.Drawing.Size(349, 207);
            this.gbxFerrmenta.TabIndex = 17;
            this.gbxFerrmenta.TabStop = false;
            this.gbxFerrmenta.Text = "Ferramentas";
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(255, 246);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(106, 23);
            this.btnGerarRelatorio.TabIndex = 18;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 525);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.gbxFerrmenta);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta";
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFerramentas)).EndInit();
            this.gbxFerrmenta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dgvFerramentas;
        private System.Windows.Forms.GroupBox gbxFerrmenta;
        private System.Windows.Forms.Button btnGerarRelatorio;
    }
}

