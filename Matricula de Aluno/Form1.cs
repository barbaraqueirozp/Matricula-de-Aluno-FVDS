namespace Matricula_de_Aluno
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();

            cadastro.MdiParent = this;

            cadastro.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem listagem = new FrmListagem();

            listagem.MdiParent = this;

            listagem.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
