using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOpcao_Click(object sender, EventArgs e)
        {
            if(rbIncluir.Checked)
            {
                Aluno a = new Aluno();
                try
                {
                    a.prontuario = txtProntuario.Text;
                    a.nome = txtNome.Text;
                    a.cpf = txtCPF.Text;
                    a.rg = txtRG.Text;
                    a.email = txtEmail.Text;
                    a.cadastrarAluno();
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if(rbConsultar.Checked)
            {
                MessageBox.Show("consulta");
                Aluno a = new Aluno();
                try
                {
                    a.prontuario = txtProntuario.Text;

                    if (a.consultarAluno())
                    {
                        txtNome.Text = a.nome;
                        txtCPF.Text = a.cpf;
                        txtRG.Text = a.rg;
                        txtEmail.Text = a.email;
                    }
                    else
                    {
                        MessageBox.Show("Aluno não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (rbAlterar.Checked)
            {
            }
            else if(rbExcluir.Checked)
            {
            }

        }
        private void rbConsultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsultar.Checked == true) { 
                btnOpcao.Text = "Consultar Aluno"; btnOpcao.Enabled = true;
            }

            foreach (TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Enabled = false;
            }
            txtProntuario.Enabled = true;
            txtProntuario.Focus();
        }

        private void rbAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAlterar.Checked == true) { btnOpcao.Text = "Alterar Aluno"; btnOpcao.Enabled = true; }

            foreach (TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Enabled = true;
            }
            txtProntuario.Focus();
        }

        private void rbIncluir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIncluir.Checked == true) { btnOpcao.Text = "Incluir Aluno"; btnOpcao.Enabled = true; }

            foreach (TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Enabled = true;
            }
            txtProntuario.Focus();
        }

        private void rbExcluir_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExcluir.Checked == true) { btnOpcao.Text = "Excluir Aluno"; btnOpcao.Enabled = true; }

            foreach (TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Enabled = false;
            }
            txtProntuario.Enabled = true;
            txtProntuario.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Clear();
            }
            txtProntuario.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
    }
}
