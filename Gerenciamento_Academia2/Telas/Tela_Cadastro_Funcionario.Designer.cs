namespace Gerenciamento_Academia2
{
    partial class Tela_Cadastro_Funcionario
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
            this.cbx_Nivel_acesso = new System.Windows.Forms.ComboBox();
            this.lb_Nivel_acesso = new System.Windows.Forms.Label();
            this.cmb_Sexo_Func = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_CadastroAluno = new System.Windows.Forms.Label();
            this.bt_Endereco = new System.Windows.Forms.Button();
            this.listViewFunc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mtb_DataNiver_Func = new System.Windows.Forms.MaskedTextBox();
            this.lb_Nome_Func = new System.Windows.Forms.Label();
            this.mtb_Cpf_Func = new System.Windows.Forms.MaskedTextBox();
            this.txb_Nome_Func = new System.Windows.Forms.TextBox();
            this.mtb_Tel_Func = new System.Windows.Forms.MaskedTextBox();
            this.lb_Telefone_Func = new System.Windows.Forms.Label();
            this.lb_Rg_Func = new System.Windows.Forms.Label();
            this.txb_Rg_Func = new System.Windows.Forms.TextBox();
            this.lb_Cpf_Func = new System.Windows.Forms.Label();
            this.lb_Senha_Func = new System.Windows.Forms.Label();
            this.lb_Sexo_Func = new System.Windows.Forms.Label();
            this.txb_Senha_Func = new System.Windows.Forms.TextBox();
            this.lb_DataNiver_Func = new System.Windows.Forms.Label();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_Nivel_acesso
            // 
            this.cbx_Nivel_acesso.FormattingEnabled = true;
            this.cbx_Nivel_acesso.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Professor",
            "Recepcionista"});
            this.cbx_Nivel_acesso.Location = new System.Drawing.Point(595, 169);
            this.cbx_Nivel_acesso.Name = "cbx_Nivel_acesso";
            this.cbx_Nivel_acesso.Size = new System.Drawing.Size(121, 21);
            this.cbx_Nivel_acesso.TabIndex = 8;
            // 
            // lb_Nivel_acesso
            // 
            this.lb_Nivel_acesso.AutoSize = true;
            this.lb_Nivel_acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nivel_acesso.Location = new System.Drawing.Point(591, 146);
            this.lb_Nivel_acesso.Name = "lb_Nivel_acesso";
            this.lb_Nivel_acesso.Size = new System.Drawing.Size(121, 20);
            this.lb_Nivel_acesso.TabIndex = 78;
            this.lb_Nivel_acesso.Text = "Nivel de Acesso";
            // 
            // cmb_Sexo_Func
            // 
            this.cmb_Sexo_Func.FormattingEnabled = true;
            this.cmb_Sexo_Func.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmb_Sexo_Func.Location = new System.Drawing.Point(382, 166);
            this.cmb_Sexo_Func.Name = "cmb_Sexo_Func";
            this.cmb_Sexo_Func.Size = new System.Drawing.Size(121, 21);
            this.cmb_Sexo_Func.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_CadastroAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 67);
            this.panel1.TabIndex = 61;
            // 
            // lb_CadastroAluno
            // 
            this.lb_CadastroAluno.AutoSize = true;
            this.lb_CadastroAluno.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadastroAluno.Location = new System.Drawing.Point(221, 9);
            this.lb_CadastroAluno.Name = "lb_CadastroAluno";
            this.lb_CadastroAluno.Size = new System.Drawing.Size(397, 42);
            this.lb_CadastroAluno.TabIndex = 2;
            this.lb_CadastroAluno.Text = "Cadastro de Funcionários";
            // 
            // bt_Endereco
            // 
            this.bt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Endereco.Location = new System.Drawing.Point(509, 214);
            this.bt_Endereco.Name = "bt_Endereco";
            this.bt_Endereco.Size = new System.Drawing.Size(219, 34);
            this.bt_Endereco.TabIndex = 9;
            this.bt_Endereco.Text = "Endereço";
            this.bt_Endereco.UseVisualStyleBackColor = true;
            this.bt_Endereco.Click += new System.EventHandler(this.bt_Endereco_Click);
            // 
            // listViewFunc
            // 
            this.listViewFunc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFunc.FullRowSelect = true;
            this.listViewFunc.HideSelection = false;
            this.listViewFunc.Location = new System.Drawing.Point(11, 278);
            this.listViewFunc.Name = "listViewFunc";
            this.listViewFunc.Size = new System.Drawing.Size(757, 186);
            this.listViewFunc.TabIndex = 72;
            this.listViewFunc.UseCompatibleStateImageBehavior = false;
            this.listViewFunc.View = System.Windows.Forms.View.Details;
            this.listViewFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFunc_MouseDoubleClick);
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
            // mtb_DataNiver_Func
            // 
            this.mtb_DataNiver_Func.Location = new System.Drawing.Point(29, 228);
            this.mtb_DataNiver_Func.Mask = "00/00/0000";
            this.mtb_DataNiver_Func.Name = "mtb_DataNiver_Func";
            this.mtb_DataNiver_Func.Size = new System.Drawing.Size(130, 20);
            this.mtb_DataNiver_Func.TabIndex = 6;
            this.mtb_DataNiver_Func.ValidatingType = typeof(System.DateTime);
            // 
            // lb_Nome_Func
            // 
            this.lb_Nome_Func.AutoSize = true;
            this.lb_Nome_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome_Func.Location = new System.Drawing.Point(25, 79);
            this.lb_Nome_Func.Name = "lb_Nome_Func";
            this.lb_Nome_Func.Size = new System.Drawing.Size(123, 20);
            this.lb_Nome_Func.TabIndex = 62;
            this.lb_Nome_Func.Text = "Nome Completo";
            // 
            // mtb_Cpf_Func
            // 
            this.mtb_Cpf_Func.Location = new System.Drawing.Point(244, 167);
            this.mtb_Cpf_Func.Mask = "000,000,000-00";
            this.mtb_Cpf_Func.Name = "mtb_Cpf_Func";
            this.mtb_Cpf_Func.Size = new System.Drawing.Size(100, 20);
            this.mtb_Cpf_Func.TabIndex = 4;
            // 
            // txb_Nome_Func
            // 
            this.txb_Nome_Func.Location = new System.Drawing.Point(29, 102);
            this.txb_Nome_Func.Name = "txb_Nome_Func";
            this.txb_Nome_Func.Size = new System.Drawing.Size(526, 20);
            this.txb_Nome_Func.TabIndex = 1;
            // 
            // mtb_Tel_Func
            // 
            this.mtb_Tel_Func.Location = new System.Drawing.Point(595, 102);
            this.mtb_Tel_Func.Mask = "(00)000-000000";
            this.mtb_Tel_Func.Name = "mtb_Tel_Func";
            this.mtb_Tel_Func.Size = new System.Drawing.Size(150, 20);
            this.mtb_Tel_Func.TabIndex = 2;
            // 
            // lb_Telefone_Func
            // 
            this.lb_Telefone_Func.AutoSize = true;
            this.lb_Telefone_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Telefone_Func.Location = new System.Drawing.Point(591, 79);
            this.lb_Telefone_Func.Name = "lb_Telefone_Func";
            this.lb_Telefone_Func.Size = new System.Drawing.Size(71, 20);
            this.lb_Telefone_Func.TabIndex = 64;
            this.lb_Telefone_Func.Text = "Telefone";
            // 
            // lb_Rg_Func
            // 
            this.lb_Rg_Func.AutoSize = true;
            this.lb_Rg_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rg_Func.Location = new System.Drawing.Point(25, 140);
            this.lb_Rg_Func.Name = "lb_Rg_Func";
            this.lb_Rg_Func.Size = new System.Drawing.Size(30, 20);
            this.lb_Rg_Func.TabIndex = 65;
            this.lb_Rg_Func.Text = "Rg";
            // 
            // txb_Rg_Func
            // 
            this.txb_Rg_Func.Location = new System.Drawing.Point(29, 163);
            this.txb_Rg_Func.Name = "txb_Rg_Func";
            this.txb_Rg_Func.Size = new System.Drawing.Size(130, 20);
            this.txb_Rg_Func.TabIndex = 3;
            // 
            // lb_Cpf_Func
            // 
            this.lb_Cpf_Func.AutoSize = true;
            this.lb_Cpf_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cpf_Func.Location = new System.Drawing.Point(235, 140);
            this.lb_Cpf_Func.Name = "lb_Cpf_Func";
            this.lb_Cpf_Func.Size = new System.Drawing.Size(34, 20);
            this.lb_Cpf_Func.TabIndex = 67;
            this.lb_Cpf_Func.Text = "Cpf";
            // 
            // lb_Senha_Func
            // 
            this.lb_Senha_Func.AutoSize = true;
            this.lb_Senha_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha_Func.Location = new System.Drawing.Point(213, 204);
            this.lb_Senha_Func.Name = "lb_Senha_Func";
            this.lb_Senha_Func.Size = new System.Drawing.Size(56, 20);
            this.lb_Senha_Func.TabIndex = 71;
            this.lb_Senha_Func.Text = "Senha";
            // 
            // lb_Sexo_Func
            // 
            this.lb_Sexo_Func.AutoSize = true;
            this.lb_Sexo_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sexo_Func.Location = new System.Drawing.Point(378, 140);
            this.lb_Sexo_Func.Name = "lb_Sexo_Func";
            this.lb_Sexo_Func.Size = new System.Drawing.Size(45, 20);
            this.lb_Sexo_Func.TabIndex = 68;
            this.lb_Sexo_Func.Text = "Sexo";
            // 
            // txb_Senha_Func
            // 
            this.txb_Senha_Func.Location = new System.Drawing.Point(214, 228);
            this.txb_Senha_Func.Name = "txb_Senha_Func";
            this.txb_Senha_Func.Size = new System.Drawing.Size(209, 20);
            this.txb_Senha_Func.TabIndex = 7;
            // 
            // lb_DataNiver_Func
            // 
            this.lb_DataNiver_Func.AutoSize = true;
            this.lb_DataNiver_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DataNiver_Func.Location = new System.Drawing.Point(25, 204);
            this.lb_DataNiver_Func.Name = "lb_DataNiver_Func";
            this.lb_DataNiver_Func.Size = new System.Drawing.Size(148, 20);
            this.lb_DataNiver_Func.TabIndex = 69;
            this.lb_DataNiver_Func.Text = "Data de Aniversário";
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(646, 479);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(131, 34);
            this.bt_Fechar.TabIndex = 13;
            this.bt_Fechar.Text = "Fehar";
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(442, 479);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(131, 34);
            this.bt_Limpar.TabIndex = 12;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Location = new System.Drawing.Point(217, 479);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(131, 32);
            this.bt_Cadastrar.TabIndex = 11;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Location = new System.Drawing.Point(15, 476);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(131, 33);
            this.bt_Excluir.TabIndex = 10;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // Tela_Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 521);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.cbx_Nivel_acesso);
            this.Controls.Add(this.lb_Nivel_acesso);
            this.Controls.Add(this.cmb_Sexo_Func);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_Endereco);
            this.Controls.Add(this.listViewFunc);
            this.Controls.Add(this.mtb_DataNiver_Func);
            this.Controls.Add(this.lb_Nome_Func);
            this.Controls.Add(this.mtb_Cpf_Func);
            this.Controls.Add(this.txb_Nome_Func);
            this.Controls.Add(this.mtb_Tel_Func);
            this.Controls.Add(this.lb_Telefone_Func);
            this.Controls.Add(this.lb_Rg_Func);
            this.Controls.Add(this.txb_Rg_Func);
            this.Controls.Add(this.lb_Cpf_Func);
            this.Controls.Add(this.lb_Senha_Func);
            this.Controls.Add(this.lb_Sexo_Func);
            this.Controls.Add(this.txb_Senha_Func);
            this.Controls.Add(this.lb_DataNiver_Func);
            this.Name = "Tela_Cadastro_Funcionario";
            this.Load += new System.EventHandler(this.Tela_Cadastro_Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_Nivel_acesso;
        private System.Windows.Forms.Label lb_Nivel_acesso;
        private System.Windows.Forms.ComboBox cmb_Sexo_Func;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_CadastroAluno;
        private System.Windows.Forms.Button bt_Endereco;
        private System.Windows.Forms.ListView listViewFunc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MaskedTextBox mtb_DataNiver_Func;
        private System.Windows.Forms.Label lb_Nome_Func;
        private System.Windows.Forms.MaskedTextBox mtb_Cpf_Func;
        private System.Windows.Forms.TextBox txb_Nome_Func;
        private System.Windows.Forms.MaskedTextBox mtb_Tel_Func;
        private System.Windows.Forms.Label lb_Telefone_Func;
        private System.Windows.Forms.Label lb_Rg_Func;
        private System.Windows.Forms.TextBox txb_Rg_Func;
        private System.Windows.Forms.Label lb_Cpf_Func;
        private System.Windows.Forms.Label lb_Senha_Func;
        private System.Windows.Forms.Label lb_Sexo_Func;
        private System.Windows.Forms.TextBox txb_Senha_Func;
        private System.Windows.Forms.Label lb_DataNiver_Func;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Excluir;
    }
}