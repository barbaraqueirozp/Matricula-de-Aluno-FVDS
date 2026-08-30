using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matricula_de_Aluno
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string matricula = txtMatricula.Text;
            int idade = Convert.ToInt32(txtIdade.Text);

            Dados.nomes.Add(nome);
            Dados.matriculas.Add(matricula);
            Dados.idades.Add(idade);

            MessageBox.Show(
                "Aluno cadastrado com sucesso!",
                "Cadastro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            txtNome.Clear();
            txtMatricula.Clear();
            txtIdade.Clear();

            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtIdade.Clear();

            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
