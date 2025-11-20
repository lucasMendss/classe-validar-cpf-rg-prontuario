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
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.btnOpcao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbCampos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbConsultar = new System.Windows.Forms.RadioButton();
            this.rbAlterar = new System.Windows.Forms.RadioButton();
            this.rbIncluir = new System.Windows.Forms.RadioButton();
            this.rbExcluir = new System.Windows.Forms.RadioButton();
            this.gbCampos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProntuario
            // 
            this.txtProntuario.Enabled = false;
            this.txtProntuario.Location = new System.Drawing.Point(76, 28);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(388, 20);
            this.txtProntuario.TabIndex = 1;
            this.txtProntuario.TextChanged += new System.EventHandler(this.txtProntuario_TextChanged);
            // 
            // btnOpcao
            // 
            this.btnOpcao.Enabled = false;
            this.btnOpcao.Location = new System.Drawing.Point(314, 285);
            this.btnOpcao.Name = "btnOpcao";
            this.btnOpcao.Size = new System.Drawing.Size(162, 23);
            this.btnOpcao.TabIndex = 2;
            this.btnOpcao.Text = "Incluir Aluno";
            this.btnOpcao.UseVisualStyleBackColor = true;
            this.btnOpcao.Click += new System.EventHandler(this.btnOpcao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prontuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(76, 72);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(76, 110);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(388, 20);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RG (de SP):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRG
            // 
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(76, 152);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(388, 20);
            this.txtRG.TabIndex = 8;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(7, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(158, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gbCampos
            // 
            this.gbCampos.Controls.Add(this.label6);
            this.gbCampos.Controls.Add(this.txtEmail);
            this.gbCampos.Controls.Add(this.txtNome);
            this.gbCampos.Controls.Add(this.txtProntuario);
            this.gbCampos.Controls.Add(this.label5);
            this.gbCampos.Controls.Add(this.txtCPF);
            this.gbCampos.Controls.Add(this.label4);
            this.gbCampos.Controls.Add(this.txtRG);
            this.gbCampos.Controls.Add(this.label2);
            this.gbCampos.Controls.Add(this.label3);
            this.gbCampos.Location = new System.Drawing.Point(7, 35);
            this.gbCampos.Name = "gbCampos";
            this.gbCampos.Size = new System.Drawing.Size(470, 244);
            this.gbCampos.TabIndex = 11;
            this.gbCampos.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(76, 197);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // rbConsultar
            // 
            this.rbConsultar.AutoSize = true;
            this.rbConsultar.Location = new System.Drawing.Point(7, 12);
            this.rbConsultar.Name = "rbConsultar";
            this.rbConsultar.Size = new System.Drawing.Size(99, 17);
            this.rbConsultar.TabIndex = 12;
            this.rbConsultar.TabStop = true;
            this.rbConsultar.Text = "Consultar Aluno";
            this.rbConsultar.UseVisualStyleBackColor = true;
            this.rbConsultar.CheckedChanged += new System.EventHandler(this.rbConsultar_CheckedChanged);
            // 
            // rbAlterar
            // 
            this.rbAlterar.AutoSize = true;
            this.rbAlterar.Location = new System.Drawing.Point(122, 12);
            this.rbAlterar.Name = "rbAlterar";
            this.rbAlterar.Size = new System.Drawing.Size(85, 17);
            this.rbAlterar.TabIndex = 13;
            this.rbAlterar.TabStop = true;
            this.rbAlterar.Text = "Alterar Aluno";
            this.rbAlterar.UseVisualStyleBackColor = true;
            this.rbAlterar.CheckedChanged += new System.EventHandler(this.rbAlterar_CheckedChanged);
            // 
            // rbIncluir
            // 
            this.rbIncluir.AutoSize = true;
            this.rbIncluir.Location = new System.Drawing.Point(223, 12);
            this.rbIncluir.Name = "rbIncluir";
            this.rbIncluir.Size = new System.Drawing.Size(83, 17);
            this.rbIncluir.TabIndex = 14;
            this.rbIncluir.TabStop = true;
            this.rbIncluir.Text = "Incluir Aluno";
            this.rbIncluir.UseVisualStyleBackColor = true;
            this.rbIncluir.CheckedChanged += new System.EventHandler(this.rbIncluir_CheckedChanged);
            // 
            // rbExcluir
            // 
            this.rbExcluir.AutoSize = true;
            this.rbExcluir.Location = new System.Drawing.Point(314, 12);
            this.rbExcluir.Name = "rbExcluir";
            this.rbExcluir.Size = new System.Drawing.Size(86, 17);
            this.rbExcluir.TabIndex = 15;
            this.rbExcluir.TabStop = true;
            this.rbExcluir.Text = "Excluir Aluno";
            this.rbExcluir.UseVisualStyleBackColor = true;
            this.rbExcluir.CheckedChanged += new System.EventHandler(this.rbExcluir_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 319);
            this.Controls.Add(this.rbExcluir);
            this.Controls.Add(this.rbIncluir);
            this.Controls.Add(this.rbAlterar);
            this.Controls.Add(this.rbConsultar);
            this.Controls.Add(this.gbCampos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnOpcao);
            this.Name = "Form1";
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCampos.ResumeLayout(false);
            this.gbCampos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Button btnOpcao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gbCampos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton rbConsultar;
        private System.Windows.Forms.RadioButton rbAlterar;
        private System.Windows.Forms.RadioButton rbIncluir;
        private System.Windows.Forms.RadioButton rbExcluir;
    }
}

