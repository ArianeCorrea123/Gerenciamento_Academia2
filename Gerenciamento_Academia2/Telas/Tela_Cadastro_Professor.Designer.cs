namespace Gerenciamento_Academia2
{
    partial class Tela_Cadastro_Professor
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
            this.txb_Nome_Mod = new System.Windows.Forms.TextBox();
            this.lb_Nome_Mod = new System.Windows.Forms.Label();
            this.listViewProf = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_Excluir_Prof = new System.Windows.Forms.Button();
            this.bt_Limpar_Prof = new System.Windows.Forms.Button();
            this.bt_Cadastrar_Professor = new System.Windows.Forms.Button();
            this.bt_Fechar_Prof = new System.Windows.Forms.Button();
            this.txb_Nome_Profe = new System.Windows.Forms.TextBox();
            this.lb_Valor = new System.Windows.Forms.Label();
            this.lb_Nome_Profe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Professor = new System.Windows.Forms.Label();
            this.mtb_Tel_Prof = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Nome_Mod
            // 
            this.txb_Nome_Mod.Location = new System.Drawing.Point(16, 211);
            this.txb_Nome_Mod.Name = "txb_Nome_Mod";
            this.txb_Nome_Mod.Size = new System.Drawing.Size(266, 20);
            this.txb_Nome_Mod.TabIndex = 102;
            // 
            // lb_Nome_Mod
            // 
            this.lb_Nome_Mod.AutoSize = true;
            this.lb_Nome_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome_Mod.Location = new System.Drawing.Point(12, 188);
            this.lb_Nome_Mod.Name = "lb_Nome_Mod";
            this.lb_Nome_Mod.Size = new System.Drawing.Size(91, 20);
            this.lb_Nome_Mod.TabIndex = 101;
            this.lb_Nome_Mod.Text = "Modalidade";
            // 
            // listViewProf
            // 
            this.listViewProf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewProf.HideSelection = false;
            this.listViewProf.Location = new System.Drawing.Point(387, 90);
            this.listViewProf.Name = "listViewProf";
            this.listViewProf.Size = new System.Drawing.Size(406, 285);
            this.listViewProf.TabIndex = 100;
            this.listViewProf.UseCompatibleStateImageBehavior = false;
            this.listViewProf.View = System.Windows.Forms.View.Details;
            this.listViewProf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Professor";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Modalidade";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 120;
            // 
            // bt_Excluir_Prof
            // 
            this.bt_Excluir_Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir_Prof.Location = new System.Drawing.Point(437, 411);
            this.bt_Excluir_Prof.Name = "bt_Excluir_Prof";
            this.bt_Excluir_Prof.Size = new System.Drawing.Size(131, 33);
            this.bt_Excluir_Prof.TabIndex = 99;
            this.bt_Excluir_Prof.Text = "Excluir";
            this.bt_Excluir_Prof.UseVisualStyleBackColor = true;
            this.bt_Excluir_Prof.Click += new System.EventHandler(this.bt_Excluir_Prof_Click);
            // 
            // bt_Limpar_Prof
            // 
            this.bt_Limpar_Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar_Prof.Location = new System.Drawing.Point(238, 411);
            this.bt_Limpar_Prof.Name = "bt_Limpar_Prof";
            this.bt_Limpar_Prof.Size = new System.Drawing.Size(131, 34);
            this.bt_Limpar_Prof.TabIndex = 97;
            this.bt_Limpar_Prof.Text = "Limpar";
            this.bt_Limpar_Prof.UseVisualStyleBackColor = true;
            this.bt_Limpar_Prof.Click += new System.EventHandler(this.bt_Limpar_Prof_Click);
            // 
            // bt_Cadastrar_Professor
            // 
            this.bt_Cadastrar_Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar_Professor.Location = new System.Drawing.Point(35, 411);
            this.bt_Cadastrar_Professor.Name = "bt_Cadastrar_Professor";
            this.bt_Cadastrar_Professor.Size = new System.Drawing.Size(131, 32);
            this.bt_Cadastrar_Professor.TabIndex = 96;
            this.bt_Cadastrar_Professor.Text = "Cadastrar";
            this.bt_Cadastrar_Professor.UseVisualStyleBackColor = true;
            this.bt_Cadastrar_Professor.Click += new System.EventHandler(this.bt_Cadastrar_Professor_Click);
            // 
            // bt_Fechar_Prof
            // 
            this.bt_Fechar_Prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar_Prof.Location = new System.Drawing.Point(626, 410);
            this.bt_Fechar_Prof.Name = "bt_Fechar_Prof";
            this.bt_Fechar_Prof.Size = new System.Drawing.Size(131, 33);
            this.bt_Fechar_Prof.TabIndex = 98;
            this.bt_Fechar_Prof.Text = "Fechar";
            this.bt_Fechar_Prof.UseVisualStyleBackColor = true;
            this.bt_Fechar_Prof.Click += new System.EventHandler(this.bt_Fechar_Prof_Click);
            // 
            // txb_Nome_Profe
            // 
            this.txb_Nome_Profe.Location = new System.Drawing.Point(16, 149);
            this.txb_Nome_Profe.Name = "txb_Nome_Profe";
            this.txb_Nome_Profe.Size = new System.Drawing.Size(266, 20);
            this.txb_Nome_Profe.TabIndex = 91;
            // 
            // lb_Valor
            // 
            this.lb_Valor.AutoSize = true;
            this.lb_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Valor.Location = new System.Drawing.Point(12, 246);
            this.lb_Valor.Name = "lb_Valor";
            this.lb_Valor.Size = new System.Drawing.Size(71, 20);
            this.lb_Valor.TabIndex = 86;
            this.lb_Valor.Text = "Telefone";
            // 
            // lb_Nome_Profe
            // 
            this.lb_Nome_Profe.AutoSize = true;
            this.lb_Nome_Profe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome_Profe.Location = new System.Drawing.Point(12, 126);
            this.lb_Nome_Profe.Name = "lb_Nome_Profe";
            this.lb_Nome_Profe.Size = new System.Drawing.Size(51, 20);
            this.lb_Nome_Profe.TabIndex = 85;
            this.lb_Nome_Profe.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_Professor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 67);
            this.panel1.TabIndex = 84;
            // 
            // lb_Professor
            // 
            this.lb_Professor.AutoSize = true;
            this.lb_Professor.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Professor.Location = new System.Drawing.Point(231, 9);
            this.lb_Professor.Name = "lb_Professor";
            this.lb_Professor.Size = new System.Drawing.Size(381, 42);
            this.lb_Professor.TabIndex = 2;
            this.lb_Professor.Text = "Cadastro de Professores";
            // 
            // mtb_Tel_Prof
            // 
            this.mtb_Tel_Prof.Location = new System.Drawing.Point(16, 269);
            this.mtb_Tel_Prof.Mask = "(00)000-000000";
            this.mtb_Tel_Prof.Name = "mtb_Tel_Prof";
            this.mtb_Tel_Prof.Size = new System.Drawing.Size(100, 20);
            this.mtb_Tel_Prof.TabIndex = 103;
            // 
            // Cadastro_Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 460);
            this.Controls.Add(this.mtb_Tel_Prof);
            this.Controls.Add(this.txb_Nome_Mod);
            this.Controls.Add(this.lb_Nome_Mod);
            this.Controls.Add(this.listViewProf);
            this.Controls.Add(this.bt_Excluir_Prof);
            this.Controls.Add(this.bt_Limpar_Prof);
            this.Controls.Add(this.bt_Cadastrar_Professor);
            this.Controls.Add(this.bt_Fechar_Prof);
            this.Controls.Add(this.txb_Nome_Profe);
            this.Controls.Add(this.lb_Valor);
            this.Controls.Add(this.lb_Nome_Profe);
            this.Controls.Add(this.panel1);
            this.Name = "Cadastro_Professor";
            this.Text = "Cadastro_Professor";
            this.Load += new System.EventHandler(this.Cadastro_Professor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Nome_Mod;
        private System.Windows.Forms.Label lb_Nome_Mod;
        private System.Windows.Forms.ListView listViewProf;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button bt_Excluir_Prof;
        private System.Windows.Forms.Button bt_Limpar_Prof;
        private System.Windows.Forms.Button bt_Cadastrar_Professor;
        private System.Windows.Forms.Button bt_Fechar_Prof;
        private System.Windows.Forms.TextBox txb_Nome_Profe;
        private System.Windows.Forms.Label lb_Valor;
        private System.Windows.Forms.Label lb_Nome_Profe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Professor;
        private System.Windows.Forms.MaskedTextBox mtb_Tel_Prof;
    }
}