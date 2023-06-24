namespace Calculadora
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.LABEL_OP = new System.Windows.Forms.Label();
            this.btmulti = new System.Windows.Forms.Button();
            this.btdivisao = new System.Windows.Forms.Button();
            this.btadicao = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btsubtracao = new System.Windows.Forms.Button();
            this.btigual = new System.Windows.Forms.Button();
            this.btponto = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(25, 39);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(351, 50);
            this.txtresultado.TabIndex = 0;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LABEL_OP
            // 
            this.LABEL_OP.AutoSize = true;
            this.LABEL_OP.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LABEL_OP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_OP.Location = new System.Drawing.Point(30, 53);
            this.LABEL_OP.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LABEL_OP.Name = "LABEL_OP";
            this.LABEL_OP.Size = new System.Drawing.Size(0, 25);
            this.LABEL_OP.TabIndex = 1;
            // 
            // btmulti
            // 
            this.btmulti.BackColor = System.Drawing.Color.Black;
            this.btmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmulti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmulti.Location = new System.Drawing.Point(238, 230);
            this.btmulti.Name = "btmulti";
            this.btmulti.Size = new System.Drawing.Size(65, 57);
            this.btmulti.TabIndex = 2;
            this.btmulti.Text = "X";
            this.btmulti.UseVisualStyleBackColor = false;
            this.btmulti.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdivisao
            // 
            this.btdivisao.BackColor = System.Drawing.Color.Black;
            this.btdivisao.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdivisao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btdivisao.Location = new System.Drawing.Point(238, 293);
            this.btdivisao.Name = "btdivisao";
            this.btdivisao.Size = new System.Drawing.Size(65, 57);
            this.btdivisao.TabIndex = 3;
            this.btdivisao.Text = "/";
            this.btdivisao.UseVisualStyleBackColor = false;
            this.btdivisao.Click += new System.EventHandler(this.btdivisao_Click);
            // 
            // btadicao
            // 
            this.btadicao.BackColor = System.Drawing.Color.Black;
            this.btadicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadicao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btadicao.Location = new System.Drawing.Point(238, 104);
            this.btadicao.Name = "btadicao";
            this.btadicao.Size = new System.Drawing.Size(65, 57);
            this.btadicao.TabIndex = 5;
            this.btadicao.Text = "+";
            this.btadicao.UseVisualStyleBackColor = false;
            this.btadicao.Click += new System.EventHandler(this.btadicao_Click);
            // 
            // btCE
            // 
            this.btCE.BackColor = System.Drawing.Color.Brown;
            this.btCE.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(309, 104);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(65, 57);
            this.btCE.TabIndex = 6;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = false;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.Black;
            this.btC.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btC.Location = new System.Drawing.Point(309, 167);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(65, 57);
            this.btC.TabIndex = 11;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btsubtracao
            // 
            this.btsubtracao.BackColor = System.Drawing.Color.Black;
            this.btsubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsubtracao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btsubtracao.Location = new System.Drawing.Point(238, 167);
            this.btsubtracao.Name = "btsubtracao";
            this.btsubtracao.Size = new System.Drawing.Size(65, 57);
            this.btsubtracao.TabIndex = 10;
            this.btsubtracao.Text = "-";
            this.btsubtracao.UseVisualStyleBackColor = false;
            this.btsubtracao.Click += new System.EventHandler(this.btsubtracao_Click);
            // 
            // btigual
            // 
            this.btigual.BackColor = System.Drawing.Color.Black;
            this.btigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btigual.Location = new System.Drawing.Point(311, 230);
            this.btigual.Name = "btigual";
            this.btigual.Size = new System.Drawing.Size(65, 120);
            this.btigual.TabIndex = 9;
            this.btigual.Text = "=";
            this.btigual.UseVisualStyleBackColor = false;
            this.btigual.Click += new System.EventHandler(this.button8_Click);
            // 
            // btponto
            // 
            this.btponto.BackColor = System.Drawing.SystemColors.Desktop;
            this.btponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btponto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btponto.Location = new System.Drawing.Point(167, 293);
            this.btponto.Name = "btponto";
            this.btponto.Size = new System.Drawing.Size(65, 57);
            this.btponto.TabIndex = 8;
            this.btponto.Text = ".";
            this.btponto.UseVisualStyleBackColor = false;
            this.btponto.Click += new System.EventHandler(this.btponto_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Black;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt5.Location = new System.Drawing.Point(96, 167);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(65, 57);
            this.bt5.TabIndex = 16;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Black;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt4.Location = new System.Drawing.Point(25, 167);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(65, 57);
            this.bt4.TabIndex = 15;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Black;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt3.Location = new System.Drawing.Point(167, 230);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(65, 57);
            this.bt3.TabIndex = 14;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Black;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt2.Location = new System.Drawing.Point(95, 230);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(65, 57);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Black;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt1.Location = new System.Drawing.Point(25, 230);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(65, 57);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.Black;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt0.Location = new System.Drawing.Point(25, 293);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(135, 57);
            this.bt0.TabIndex = 21;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.Black;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt9.Location = new System.Drawing.Point(167, 104);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(65, 57);
            this.bt9.TabIndex = 20;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.Black;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt8.Location = new System.Drawing.Point(96, 104);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(65, 57);
            this.bt8.TabIndex = 19;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.Black;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt7.Location = new System.Drawing.Point(25, 104);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(65, 57);
            this.bt7.TabIndex = 18;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.Black;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt6.Location = new System.Drawing.Point(167, 167);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(65, 57);
            this.bt6.TabIndex = 17;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(396, 373);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btsubtracao);
            this.Controls.Add(this.btigual);
            this.Controls.Add(this.btponto);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btadicao);
            this.Controls.Add(this.btdivisao);
            this.Controls.Add(this.btmulti);
            this.Controls.Add(this.LABEL_OP);
            this.Controls.Add(this.txtresultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label LABEL_OP;
        private System.Windows.Forms.Button btmulti;
        private System.Windows.Forms.Button btdivisao;
        private System.Windows.Forms.Button btadicao;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btsubtracao;
        private System.Windows.Forms.Button btigual;
        private System.Windows.Forms.Button btponto;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
    }
}

