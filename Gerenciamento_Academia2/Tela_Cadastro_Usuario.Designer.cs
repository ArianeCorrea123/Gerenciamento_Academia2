namespace Gerenciamento_Academia2
{
    partial class Tela_Cadastro_Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_CadastroAluno = new System.Windows.Forms.Label();
            this.txb_Nome_Usuario = new System.Windows.Forms.TextBox();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Senha = new System.Windows.Forms.Label();
            this.lb_Conf_Senha = new System.Windows.Forms.Label();
            this.lb_Nivel = new System.Windows.Forms.Label();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Senha_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Conf_Senha = new System.Windows.Forms.TextBox();
            this.cmb_Nivel = new System.Windows.Forms.ComboBox();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Limpar = new System.Windows.Forms.Button();
            this.bt_Fechar = new System.Windows.Forms.Button();
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_CadastroAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 67);
            this.panel1.TabIndex = 38;
            // 
            // lb_CadastroAluno
            // 
            this.lb_CadastroAluno.AutoSize = true;
            this.lb_CadastroAluno.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CadastroAluno.Location = new System.Drawing.Point(220, 9);
            this.lb_CadastroAluno.Name = "lb_CadastroAluno";
            this.lb_CadastroAluno.Size = new System.Drawing.Size(291, 42);
            this.lb_CadastroAluno.TabIndex = 2;
            this.lb_CadastroAluno.Text = "Cadastro Usuários";
            // 
            // txb_Nome_Usuario
            // 
            this.txb_Nome_Usuario.Location = new System.Drawing.Point(122, 118);
            this.txb_Nome_Usuario.Name = "txb_Nome_Usuario";
            this.txb_Nome_Usuario.Size = new System.Drawing.Size(229, 20);
            this.txb_Nome_Usuario.TabIndex = 39;
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(49, 116);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(51, 20);
            this.lb_Nome.TabIndex = 40;
            this.lb_Nome.Text = "Nome";
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Usuario.Location = new System.Drawing.Point(49, 155);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(64, 20);
            this.lb_Usuario.TabIndex = 41;
            this.lb_Usuario.Text = "Usuário";
            // 
            // lb_Senha
            // 
            this.lb_Senha.AutoSize = true;
            this.lb_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Senha.Location = new System.Drawing.Point(49, 195);
            this.lb_Senha.Name = "lb_Senha";
            this.lb_Senha.Size = new System.Drawing.Size(56, 20);
            this.lb_Senha.TabIndex = 42;
            this.lb_Senha.Text = "Senha";
            // 
            // lb_Conf_Senha
            // 
            this.lb_Conf_Senha.AutoSize = true;
            this.lb_Conf_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Conf_Senha.Location = new System.Drawing.Point(49, 231);
            this.lb_Conf_Senha.Name = "lb_Conf_Senha";
            this.lb_Conf_Senha.Size = new System.Drawing.Size(129, 20);
            this.lb_Conf_Senha.TabIndex = 43;
            this.lb_Conf_Senha.Text = "Confirmar Senha";
            // 
            // lb_Nivel
            // 
            this.lb_Nivel.AutoSize = true;
            this.lb_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nivel.Location = new System.Drawing.Point(49, 271);
            this.lb_Nivel.Name = "lb_Nivel";
            this.lb_Nivel.Size = new System.Drawing.Size(42, 20);
            this.lb_Nivel.TabIndex = 44;
            this.lb_Nivel.Text = "Nivel";
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(122, 154);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.Size = new System.Drawing.Size(229, 20);
            this.txb_Usuario.TabIndex = 45;
            // 
            // txb_Senha_Usuario
            // 
            this.txb_Senha_Usuario.Location = new System.Drawing.Point(122, 194);
            this.txb_Senha_Usuario.Name = "txb_Senha_Usuario";
            this.txb_Senha_Usuario.Size = new System.Drawing.Size(229, 20);
            this.txb_Senha_Usuario.TabIndex = 46;
            // 
            // txb_Conf_Senha
            // 
            this.txb_Conf_Senha.Location = new System.Drawing.Point(185, 230);
            this.txb_Conf_Senha.Name = "txb_Conf_Senha";
            this.txb_Conf_Senha.Size = new System.Drawing.Size(166, 20);
            this.txb_Conf_Senha.TabIndex = 47;
            // 
            // cmb_Nivel
            // 
            this.cmb_Nivel.FormattingEnabled = true;
            this.cmb_Nivel.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Recepcionista",
            "Professor"});
            this.cmb_Nivel.Location = new System.Drawing.Point(122, 269);
            this.cmb_Nivel.Name = "cmb_Nivel";
            this.cmb_Nivel.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nivel.TabIndex = 48;
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar.Location = new System.Drawing.Point(25, 364);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(104, 31);
            this.bt_Cadastrar.TabIndex = 49;
            this.bt_Cadastrar.Text = "Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir.Location = new System.Drawing.Point(143, 364);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(104, 31);
            this.bt_Excluir.TabIndex = 50;
            this.bt_Excluir.Text = "Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // bt_Limpar
            // 
            this.bt_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar.Location = new System.Drawing.Point(276, 364);
            this.bt_Limpar.Name = "bt_Limpar";
            this.bt_Limpar.Size = new System.Drawing.Size(104, 31);
            this.bt_Limpar.TabIndex = 51;
            this.bt_Limpar.Text = "Limpar";
            this.bt_Limpar.UseVisualStyleBackColor = true;
            this.bt_Limpar.Click += new System.EventHandler(this.bt_Limpar_Click);
            // 
            // bt_Fechar
            // 
            this.bt_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar.Location = new System.Drawing.Point(416, 364);
            this.bt_Fechar.Name = "bt_Fechar";
            this.bt_Fechar.Size = new System.Drawing.Size(104, 31);
            this.bt_Fechar.TabIndex = 52;
            this.bt_Fechar.Text = "Fechar";
            this.bt_Fechar.UseVisualStyleBackColor = true;
            this.bt_Fechar.Click += new System.EventHandler(this.bt_Fechar_Click);
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewUsuarios.HideSelection = false;
            this.listViewUsuarios.Location = new System.Drawing.Point(416, 118);
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(325, 227);
            this.listViewUsuarios.TabIndex = 53;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            this.listViewUsuarios.DoubleClick += new System.EventHandler(this.listViewUsuarios_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Usuário";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nivel de acesso";
            this.columnHeader3.Width = 120;
            // 
            // Tela_Cadastro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.listViewUsuarios);
            this.Controls.Add(this.bt_Fechar);
            this.Controls.Add(this.bt_Limpar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Cadastrar);
            this.Controls.Add(this.cmb_Nivel);
            this.Controls.Add(this.txb_Conf_Senha);
            this.Controls.Add(this.txb_Senha_Usuario);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.lb_Nivel);
            this.Controls.Add(this.lb_Conf_Senha);
            this.Controls.Add(this.lb_Senha);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.txb_Nome_Usuario);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Cadastro_Usuario";
            this.Text = "Tela_Cadastro_Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_CadastroAluno;
        private System.Windows.Forms.TextBox txb_Nome_Usuario;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label lb_Usuario;
        private System.Windows.Forms.Label lb_Senha;
        private System.Windows.Forms.Label lb_Conf_Senha;
        private System.Windows.Forms.Label lb_Nivel;
        private System.Windows.Forms.TextBox txb_Usuario;
        private System.Windows.Forms.TextBox txb_Senha_Usuario;
        private System.Windows.Forms.TextBox txb_Conf_Senha;
        private System.Windows.Forms.ComboBox cmb_Nivel;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Excluir;
        private System.Windows.Forms.Button bt_Limpar;
        private System.Windows.Forms.Button bt_Fechar;
        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}