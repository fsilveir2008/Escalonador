namespace Escalonador
{
    partial class FrmEscalonador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.numTempoServico = new System.Windows.Forms.NumericUpDown();
            this.lbTempoServico = new System.Windows.Forms.Label();
            this.lbQuantum = new System.Windows.Forms.Label();
            this.lbTempoChegada = new System.Windows.Forms.Label();
            this.lbEscalonador = new System.Windows.Forms.Label();
            this.btnAdicionarProcesso = new System.Windows.Forms.Button();
            this.numPrioridade = new System.Windows.Forms.NumericUpDown();
            this.numQuantum = new System.Windows.Forms.NumericUpDown();
            this.numTempoChegada = new System.Windows.Forms.NumericUpDown();
            this.txtTipoEscalonador = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoServico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoChegada)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecutar);
            this.groupBox1.Controls.Add(this.lbPrioridade);
            this.groupBox1.Controls.Add(this.numTempoServico);
            this.groupBox1.Controls.Add(this.lbTempoServico);
            this.groupBox1.Controls.Add(this.lbQuantum);
            this.groupBox1.Controls.Add(this.lbTempoChegada);
            this.groupBox1.Controls.Add(this.lbEscalonador);
            this.groupBox1.Controls.Add(this.btnAdicionarProcesso);
            this.groupBox1.Controls.Add(this.numPrioridade);
            this.groupBox1.Controls.Add(this.numQuantum);
            this.groupBox1.Controls.Add(this.numTempoChegada);
            this.groupBox1.Controls.Add(this.txtTipoEscalonador);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criação dos Processos";
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(195, 169);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 23);
            this.btnExecutar.TabIndex = 11;
            this.btnExecutar.Text = "Disparar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.AutoSize = true;
            this.lbPrioridade.Location = new System.Drawing.Point(18, 129);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(54, 13);
            this.lbPrioridade.TabIndex = 10;
            this.lbPrioridade.Text = "Prioridade";
            // 
            // numTempoServico
            // 
            this.numTempoServico.Location = new System.Drawing.Point(130, 75);
            this.numTempoServico.Name = "numTempoServico";
            this.numTempoServico.Size = new System.Drawing.Size(205, 20);
            this.numTempoServico.TabIndex = 9;
            // 
            // lbTempoServico
            // 
            this.lbTempoServico.AutoSize = true;
            this.lbTempoServico.Location = new System.Drawing.Point(18, 77);
            this.lbTempoServico.Name = "lbTempoServico";
            this.lbTempoServico.Size = new System.Drawing.Size(94, 13);
            this.lbTempoServico.TabIndex = 8;
            this.lbTempoServico.Text = "Tempo de Serviço";
            // 
            // lbQuantum
            // 
            this.lbQuantum.AutoSize = true;
            this.lbQuantum.Location = new System.Drawing.Point(18, 103);
            this.lbQuantum.Name = "lbQuantum";
            this.lbQuantum.Size = new System.Drawing.Size(50, 13);
            this.lbQuantum.TabIndex = 7;
            this.lbQuantum.Text = "Quantum";
            // 
            // lbTempoChegada
            // 
            this.lbTempoChegada.AutoSize = true;
            this.lbTempoChegada.Location = new System.Drawing.Point(18, 51);
            this.lbTempoChegada.Name = "lbTempoChegada";
            this.lbTempoChegada.Size = new System.Drawing.Size(101, 13);
            this.lbTempoChegada.TabIndex = 6;
            this.lbTempoChegada.Text = "Tempo de Chegada";
            // 
            // lbEscalonador
            // 
            this.lbEscalonador.AutoSize = true;
            this.lbEscalonador.Location = new System.Drawing.Point(18, 25);
            this.lbEscalonador.Name = "lbEscalonador";
            this.lbEscalonador.Size = new System.Drawing.Size(105, 13);
            this.lbEscalonador.TabIndex = 5;
            this.lbEscalonador.Text = "Tipo de Escalonador";
            // 
            // btnAdicionarProcesso
            // 
            this.btnAdicionarProcesso.Location = new System.Drawing.Point(80, 169);
            this.btnAdicionarProcesso.Name = "btnAdicionarProcesso";
            this.btnAdicionarProcesso.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarProcesso.TabIndex = 4;
            this.btnAdicionarProcesso.Text = "Adicionar";
            this.btnAdicionarProcesso.UseVisualStyleBackColor = true;
            this.btnAdicionarProcesso.Click += new System.EventHandler(this.btnAdicionarProcesso_Click);
            // 
            // numPrioridade
            // 
            this.numPrioridade.Location = new System.Drawing.Point(130, 127);
            this.numPrioridade.Name = "numPrioridade";
            this.numPrioridade.Size = new System.Drawing.Size(205, 20);
            this.numPrioridade.TabIndex = 3;
            // 
            // numQuantum
            // 
            this.numQuantum.Location = new System.Drawing.Point(130, 101);
            this.numQuantum.Name = "numQuantum";
            this.numQuantum.Size = new System.Drawing.Size(205, 20);
            this.numQuantum.TabIndex = 2;
            // 
            // numTempoChegada
            // 
            this.numTempoChegada.Location = new System.Drawing.Point(129, 49);
            this.numTempoChegada.Name = "numTempoChegada";
            this.numTempoChegada.Size = new System.Drawing.Size(205, 20);
            this.numTempoChegada.TabIndex = 1;
            // 
            // txtTipoEscalonador
            // 
            this.txtTipoEscalonador.FormattingEnabled = true;
            this.txtTipoEscalonador.Location = new System.Drawing.Point(129, 22);
            this.txtTipoEscalonador.Name = "txtTipoEscalonador";
            this.txtTipoEscalonador.Size = new System.Drawing.Size(206, 21);
            this.txtTipoEscalonador.TabIndex = 0;
            this.txtTipoEscalonador.SelectedIndexChanged += new System.EventHandler(this.txtTipoEscalonador_SelectedIndexChanged);
            // 
            // FrmEscalonador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEscalonador";
            this.Text = "Escalonador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoServico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoChegada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtTipoEscalonador;
        private System.Windows.Forms.Button btnAdicionarProcesso;
        private System.Windows.Forms.NumericUpDown numPrioridade;
        private System.Windows.Forms.NumericUpDown numQuantum;
        private System.Windows.Forms.NumericUpDown numTempoChegada;
        private System.Windows.Forms.Label lbTempoChegada;
        private System.Windows.Forms.Label lbEscalonador;
        private System.Windows.Forms.NumericUpDown numTempoServico;
        private System.Windows.Forms.Label lbTempoServico;
        private System.Windows.Forms.Label lbQuantum;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.Button btnExecutar;
    }
}

