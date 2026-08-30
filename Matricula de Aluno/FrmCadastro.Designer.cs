namespace Matricula_de_Aluno
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblIdade = new Label();
            lblMatricula = new Label();
            lblNome = new Label();
            btnSalvar = new Button();
            btnLimpar = new Button();
            btnCancelar = new Button();
            txtNome = new TextBox();
            txtMatricula = new TextBox();
            txtIdade = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(lblIdade);
            groupBox1.Controls.Add(lblMatricula);
            groupBox1.Controls.Add(lblNome);
            groupBox1.Location = new Point(22, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(461, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Aluno";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(24, 142);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(47, 20);
            lblIdade.TabIndex = 2;
            lblIdade.Text = "Idade";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(24, 94);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(150, 20);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Número de matrícula";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(24, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(120, 20);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(22, 274);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(223, 274);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(138, 29);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar campos";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(453, 274);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(270, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(270, 91);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(125, 27);
            txtMatricula.TabIndex = 4;
            txtMatricula.TextChanged += txtMatricula_TextChanged;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(270, 139);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 5;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 336);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpar);
            Controls.Add(btnSalvar);
            Controls.Add(groupBox1);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblIdade;
        private Label lblMatricula;
        private Label lblNome;
        private Button btnSalvar;
        private Button btnLimpar;
        private Button btnCancelar;
        private TextBox txtIdade;
        private TextBox txtMatricula;
        private TextBox txtNome;
    }
}