namespace Matricula_de_Aluno
{
    partial class FrmListagem
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
            btnFechar = new Button();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbMatricula = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnFechar);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbMatricula);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(600, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alunos Cadastrados";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(446, 164);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(119, 139);
            txtIdade.Name = "txtIdade";
            txtIdade.ReadOnly = true;
            txtIdade.Size = new Size(125, 27);
            txtIdade.TabIndex = 5;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(119, 89);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(125, 27);
            txtNome.TabIndex = 4;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 142);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 3;
            label3.Text = "Idade";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // cmbMatricula
            // 
            cmbMatricula.FormattingEnabled = true;
            cmbMatricula.Location = new Point(223, 31);
            cmbMatricula.Name = "cmbMatricula";
            cmbMatricula.Size = new Size(151, 28);
            cmbMatricula.TabIndex = 1;
            cmbMatricula.SelectedIndexChanged += cmbMatricula_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Selecione uma matrícula";
            // 
            // FrmListagem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "FrmListagem";
            Text = "FrmListagem";
            Load += FrmListagem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private ComboBox cmbMatricula;
        private Label label1;
        private Button btnFechar;
        private TextBox txtIdade;
        private TextBox txtNome;
    }
}