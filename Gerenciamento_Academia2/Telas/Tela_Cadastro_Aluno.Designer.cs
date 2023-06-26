namespace Gerenciamento_Academia2
{
    partial class Tela_Cadastro_Aluno
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
            this.cmb_Sexo_Aluno = new System.Windows.Forms.ComboBox();
            this.bt_Endereco = new System.Windows.Forms.Button();
            this.mtb_DataNiver_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Cpf_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.mtb_Tel_Aluno = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_Senha_Aluno = new System.Windows.Forms.Label();
            this.txb_Senha_Aluno = new System.Windows.Forms.TextBox();
            this.lb_DataNiver_Aluno = new System.Windows.Forms.Label();
            this.lb_Sexo_Aluno = new System.Windows.Forms.Label();
            this.lb_Cpf_Usuario = new System.Windows.Forms.Label();
            this.txb_Rg_Aluno = new System.Windows.Forms.TextBox();
            this.lb_Rg_Aluno = new System.Windows.Forms.Label();
            this.lb_Telefone_Aluno = new System.Windows.Forms.Label();
            this.txb_Nome_Aluno = new System.Windows.Forms.TextBox();
            this.lb_Nome_Aluno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_CadastroAluno = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Sexo_Aluno
            // 
            this.cmb_Sexo_Aluno.FormattingEnabled = true;
            this.cmb_Sexo_Aluno.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmb_Sexo_Aluno.Location = new System.Drawing.Point(373, 164);
            this.cmb_Sexo_Aluno.Name = "cmb_Sexo_Aluno";
            this.cmb_Sexo_Aluno.Size = new System.Drawing.Size(121, 21);
            this.cmb_Sexo_Aluno.TabIndex = 5;
            // 
            // bt_Endereco
            // 
            this.bt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Endereco.Location = new System.Drawing.Point(570, 156);
            this.bt_Endereco.Name = "bt_Endereco";
            this.bt_Endereco.Size = new System.Drawing.Size(219, 34);
            this.bt_Endereco.TabIndex = 8;
            this.bt_Endereco.Text = "Endereço";
            this.bt_Endereco.UseVisualStyleBackColor = true;
            this.bt_Endereco.Click += new System.EventHandler(this.bt_Endereco_Click);
            // 
            // mtb_DataNiver_Aluno
            // 
            this.mtb_DataNiver_Aluno.Location = new System.Drawing.Point(20, 226);
            this.mtb_DataNiver_Aluno.Mask = "00/00/0000";
            this.mtb_DataNiver_Aluno.Name = "mtb_DataNiver_Aluno";
            this.mtb_DataNiver_Aluno.Size = new System.Drawing.Size(130, 20);
            this.mtb_DataNiver_Aluno.TabIndex = 6;
            this.mtb_DataNiver_Aluno.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_Cpf_Aluno
            // 
            this.mtb_Cpf_Aluno.Location = new System.Drawing.Point(230, 165);
            this.mtb_Cpf_Aluno.Mask = "000,000,000-00";
            this.mtb_Cpf_Aluno.Name = "mtb_Cpf_Aluno";
            this.mtb_Cpf_Aluno.Size = new System.Drawing.Size(100, 20);
            this.mtb_Cpf_Aluno.TabIndex = 4;
            // 
            // mtb_Tel_Aluno
            // 
            this.mtb_Tel_Aluno.Location = new System.Drawing.Point(586, 100);
            this.mtb_Tel_Aluno.Mask = "(00)000-000000";
            this.mtb_Tel_Aluno.Name = "mtb_Tel_Aluno";
            this.mtb_Tel_Aluno.Size = new System.Drawing.Size(168, 20);
            this.mtb_Tel_Aluno.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 278);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(791, 186);
            this.listView1.TabIndex = 48;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "CPF";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Data de Aniversário";
            this.columnHeader5.Width = 150;
            // 
            // lb_Senha_Aluno
            // 
            this.lb_Senha_Aluno.AutoSize = true;
            this.lb_Senha_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha_Aluno.Location = new System.Drawing.Point(204, 202);
            this.lb_Senha_Aluno.Name = "lb_Senha_Aluno";
            this.lb_Senha_Aluno.Size = new System.Drawing.Size(56, 20);
            this.lb_Senha_Aluno.TabIndex = 47;
            this.lb_Senha_Aluno.Text = "Senha";
            // 
            // txb_Senha_Aluno
            // 
            this.txb_Senha_Aluno.Location = new System.Drawing.Point(205, 226);
            this.txb_Senha_Aluno.Name = "txb_Senha_Aluno";
            this.txb_Senha_Aluno.Size = new System.Drawing.Size(209, 20);
            this.txb_Senha_Aluno.TabIndex = 7;
            // 
            // lb_DataNiver_Aluno
            // 
            this.lb_DataNiver_Aluno.AutoSize = true;
            this.lb_DataNiver_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataNiver_Aluno.Location = new System.Drawing.Point(16, 202);
            this.lb_DataNiver_Aluno.Name = "lb_DataNiver_Aluno";
            this.lb_DataNiver_Aluno.Size = new System.Drawing.Size(148, 20);
            this.lb_DataNiver_Aluno.TabIndex = 45;
            this.lb_DataNiver_Aluno.Text = "Data de Aniversário";
            // 
            // lb_Sexo_Aluno
            // 
            this.lb_Sexo_Aluno.AutoSize = true;
            this.lb_Sexo_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sexo_Aluno.Location = new System.Drawing.Point(369, 138);
            this.lb_Sexo_Aluno.Name = "lb_Sexo_Aluno";
            this.lb_Sexo_Aluno.Size = new System.Drawing.Size(45, 20);
            this.lb_Sexo_Aluno.TabIndex = 44;
            this.lb_Sexo_Aluno.Text = "Sexo";
            // 
            // lb_Cpf_Usuario
            // 
            this.lb_Cpf_Usuario.AutoSize = true;
            this.lb_Cpf_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cpf_Usuario.Location = new System.Drawing.Point(226, 138);
            this.lb_Cpf_Usuario.Name = "lb_Cpf_Usuario";
            this.lb_Cpf_Usuario.Size = new System.Drawing.Size(34, 20);
            this.lb_Cpf_Usuario.TabIndex = 43;
            this.lb_Cpf_Usuario.Text = "Cpf";
            // 
            // txb_Rg_Aluno
            // 
            this.txb_Rg_Aluno.Location = new System.Drawing.Point(20, 161);
            this.txb_Rg_Aluno.Name = "txb_Rg_Aluno";
            this.txb_Rg_Aluno.Size = new System.Drawing.Size(130, 20);
            this.txb_Rg_Aluno.TabIndex = 3;
            // 
            // lb_Rg_Aluno
            // 
            this.lb_Rg_Aluno.AutoSize = true;
            this.lb_Rg_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rg_Aluno.Location = new System.Drawing.Point(16, 138);
            this.lb_Rg_Aluno.Name = "lb_Rg_Aluno";
            this.lb_Rg_Aluno.Size = new System.Drawing.Size(30, 20);
            this.lb_Rg_Aluno.TabIndex = 41;
            this.lb_Rg_Aluno.Text = "Rg";
            // 
            // lb_Telefone_Aluno
            // 
            this.lb_Telefone_Aluno.AutoSize = true;
            this.lb_Telefone_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefone_Aluno.Location = new System.Drawing.Point(582, 77);
            this.lb_Telefone_Aluno.Name = "lb_Telefone_Aluno";
            this.lb_Telefone_Aluno.Size = new System.Drawing.Size(71, 20);
            this.lb_Telefone_Aluno.TabIndex = 40;
            this.lb_Telefone_Aluno.Text = "Telefone";
            // 
            // txb_Nome_Aluno
            // 
            this.txb_Nome_Aluno.Location = new System.Drawing.Point(20, 100);
            this.txb_Nome_Aluno.Name = "txb_Nome_Aluno";
            this.txb_Nome_Aluno.Size = new System.Drawing.Size(526, 20);
            this.txb_Nome_Aluno.TabIndex = 1;
            // 
            // lb_Nome_Aluno
            // 
            this.lb_Nome_Aluno.AutoSize = true;
            this.lb_Nome_Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome_Aluno.Location = new System.Drawing.Point(16, 77);
            this.lb_Nome_Aluno.Name = "lb_Nome_Aluno";
            this.lb_Nome_Aluno.Size = new System.Drawing.Size(123, 20);
            this.lb_Nome_Aluno.TabIndex = 38;
            this.lb_Nome_Aluno.Text = "Nome Completo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_CadastroAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 67);
            this.panel1.TabIndex = 37;
            // 
            // lb_CadastroAluno
            // 
            this.lb_CadastroAluno.AutoSize = true;
            this.lb_CadastroAluno.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadastroAluno.Location = new System.Drawing.Point(252, 9);
            this.lb_CadastroAluno.Name = "lb_CadastroAluno";
            this.lb_CadastroAluno.Size = new System.Drawing.Size(304, 42);
            this.lb_CadastroAluno.TabIndex = 2;
            this.lb_CadastroAluno.Text = "Cadastro de Alunos";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(670, 479);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(131, 34);
            this.bt_Fechar.TabIndex = 12;
            this.bt_Fechar.Text = "Fehar";
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(466, 479);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(131, 34);
            this.bt_Limpar.TabIndex = 11;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Location = new System.Drawing.Point(241, 479);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(131, 32);
            this.bt_Cadastrar.TabIndex = 10;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Location = new System.Drawing.Point(39, 476);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(131, 33);
            this.bt_Excluir.TabIndex = 9;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // Tela_Cadastro_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 523);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.cmb_Sexo_Aluno);
            this.Controls.Add(this.bt_Endereco);
            this.Controls.Add(this.mtb_DataNiver_Aluno);
            this.Controls.Add(this.mtb_Cpf_Aluno);
            this.Controls.Add(this.mtb_Tel_Aluno);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lb_Senha_Aluno);
            this.Controls.Add(this.txb_Senha_Aluno);
            this.Controls.Add(this.lb_DataNiver_Aluno);
            this.Controls.Add(this.lb_Sexo_Aluno);
            this.Controls.Add(this.lb_Cpf_Usuario);
            this.Controls.Add(this.txb_Rg_Aluno);
            this.Controls.Add(this.lb_Rg_Aluno);
            this.Controls.Add(this.lb_Telefone_Aluno);
            this.Controls.Add(this.txb_Nome_Aluno);
            this.Controls.Add(this.lb_Nome_Aluno);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Cadastro_Aluno";
            this.Load += new System.EventHandler(this.Tela_Cadastro_Aluno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Sexo_Aluno;
        private System.Windows.Forms.Button bt_Endereco;
        private System.Windows.Forms.MaskedTextBox mtb_DataNiver_Aluno;
        private System.Windows.Forms.MaskedTextBox mtb_Cpf_Aluno;
        private System.Windows.Forms.MaskedTextBox mtb_Tel_Aluno;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lb_Senha_Aluno;
        private System.Windows.Forms.TextBox txb_Senha_Aluno;
        private System.Windows.Forms.Label lb_DataNiver_Aluno;
        private System.Windows.Forms.Label lb_Sexo_Aluno;
        private System.Windows.Forms.Label lb_Cpf_Usuario;
        private System.Windows.Forms.TextBox txb_Rg_Aluno;
        private System.Windows.Forms.Label lb_Rg_Aluno;
        private System.Windows.Forms.Label lb_Telefone_Aluno;
        private System.Windows.Forms.TextBox txb_Nome_Aluno;
        private System.Windows.Forms.Label lb_Nome_Aluno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_CadastroAluno;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Excluir;
    }
}