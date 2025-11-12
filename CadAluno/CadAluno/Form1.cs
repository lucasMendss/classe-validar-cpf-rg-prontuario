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
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();
            try
            {
                a.prontuario = txtProntuario.Text;
                a.nome = txtNome.Text;
                a.cpf = txtCPF.Text;
                a.rg = txtRG.Text;
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
            foreach(TextBox textbox in gbCampos.Controls.OfType<System.Windows.Forms.TextBox>())
            {
                textbox.Clear();
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
