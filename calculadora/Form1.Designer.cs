namespace calculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 9);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(221, 20);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnN4
            // 
            this.btnN4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN4.Location = new System.Drawing.Point(24, 144);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(48, 42);
            this.btnN4.TabIndex = 1;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = false;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN6
            // 
            this.btnN6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN6.Location = new System.Drawing.Point(132, 144);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(48, 42);
            this.btnN6.TabIndex = 2;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = false;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnN3
            // 
            this.btnN3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN3.Location = new System.Drawing.Point(132, 203);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(48, 42);
            this.btnN3.TabIndex = 3;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = false;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnN2
            // 
            this.btnN2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN2.Location = new System.Drawing.Point(78, 203);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(48, 42);
            this.btnN2.TabIndex = 4;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = false;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN8
            // 
            this.btnN8.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN8.Location = new System.Drawing.Point(78, 85);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(48, 42);
            this.btnN8.TabIndex = 5;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = false;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnN9
            // 
            this.btnN9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN9.Location = new System.Drawing.Point(132, 85);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(48, 42);
            this.btnN9.TabIndex = 6;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = false;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnN1
            // 
            this.btnN1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN1.Location = new System.Drawing.Point(24, 203);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(48, 42);
            this.btnN1.TabIndex = 7;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = false;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN7
            // 
            this.btnN7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN7.Location = new System.Drawing.Point(24, 85);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(48, 42);
            this.btnN7.TabIndex = 8;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = false;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnN5
            // 
            this.btnN5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN5.Location = new System.Drawing.Point(78, 144);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(48, 42);
            this.btnN5.TabIndex = 9;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = false;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN0
            // 
            this.btnN0.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnN0.Location = new System.Drawing.Point(78, 260);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(48, 42);
            this.btnN0.TabIndex = 10;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = false;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.LightCyan;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(132, 260);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 42);
            this.btnIgual.TabIndex = 11;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.LightCyan;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(24, 260);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(48, 42);
            this.btnVirgula.TabIndex = 12;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.LightCyan;
            this.btnSubtracao.Location = new System.Drawing.Point(186, 203);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(48, 42);
            this.btnSubtracao.TabIndex = 13;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.Color.LightCyan;
            this.btnAdicao.Location = new System.Drawing.Point(186, 260);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(48, 42);
            this.btnAdicao.TabIndex = 14;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.LightCyan;
            this.btnMultiplicacao.Location = new System.Drawing.Point(186, 144);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(48, 42);
            this.btnMultiplicacao.TabIndex = 15;
            this.btnMultiplicacao.Text = "X";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.LightCyan;
            this.btnDivisao.Location = new System.Drawing.Point(186, 85);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(48, 42);
            this.btnDivisao.TabIndex = 16;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.LightCyan;
            this.btnClean.Location = new System.Drawing.Point(188, 53);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(48, 26);
            this.btnClean.TabIndex = 17;
            this.btnClean.Text = "C";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Location = new System.Drawing.Point(21, 12);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 13);
            this.lblOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(248, 313);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblOperacao;
    }
}

