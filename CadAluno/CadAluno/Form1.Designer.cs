namespace CadAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbCampos = new System.Windows.Forms.GroupBox();
            this.gbCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Aluno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(75, 72);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(269, 20);
            this.txtProntuario.TabIndex = 1;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(253, 239);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(125, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prontuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(75, 109);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(269, 20);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RG (de SP):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(75, 155);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(269, 20);
            this.txtRG.TabIndex = 8;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(17, 239);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(126, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbCampos
            // 
            this.gbCampos.Controls.Add(this.txtNome);
            this.gbCampos.Controls.Add(this.txtProntuario);
            this.gbCampos.Controls.Add(this.label5);
            this.gbCampos.Controls.Add(this.txtCPF);
            this.gbCampos.Controls.Add(this.label4);
            this.gbCampos.Controls.Add(this.txtRG);
            this.gbCampos.Controls.Add(this.label2);
            this.gbCampos.Controls.Add(this.label3);
            this.gbCampos.Location = new System.Drawing.Point(17, 37);
            this.gbCampos.Name = "gbCampos";
            this.gbCampos.Size = new System.Drawing.Size(361, 196);
            this.gbCampos.TabIndex = 11;
            this.gbCampos.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 274);
            this.Controls.Add(this.gbCampos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCampos.ResumeLayout(false);
            this.gbCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbCampos;
    }
}

