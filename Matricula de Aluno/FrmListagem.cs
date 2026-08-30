using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Matricula_de_Aluno
{
    public partial class FrmListagem : Form
    {
        public FrmListagem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmListagem_Load(object sender, EventArgs e)
        {
            cmbMatricula.Items.Clear();

            for (int i = 0; i < Dados.matriculas.Count; i++)
            {
                cmbMatricula.Items.Add(Dados.matriculas[i]);
            }
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicao = cmbMatricula.SelectedIndex;

            if (posicao >= 0)
            {
                txtNome.Text = Dados.nomes[posicao];
                txtIdade.Text = Dados.idades[posicao].ToString();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
