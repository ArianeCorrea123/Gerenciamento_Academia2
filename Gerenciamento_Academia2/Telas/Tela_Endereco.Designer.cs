namespace Gerenciamento_Academia2
{
    partial class Tela_Endereco
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
            this.bt_Limpar_Endereco = new System.Windows.Forms.Button();
            this.bt_Cadastrar_Endereco = new System.Windows.Forms.Button();
            this.bt_Fechar_Endereco = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Endereco = new System.Windows.Forms.Label();
            this.cbx_Uf = new System.Windows.Forms.ComboBox();
            this.lb_UF = new System.Windows.Forms.Label();
            this.txb_Cidade = new System.Windows.Forms.TextBox();
            this.lb_Cidade = new System.Windows.Forms.Label();
            this.txb_Cep = new System.Windows.Forms.TextBox();
            this.lb_Cep = new System.Windows.Forms.Label();
            this.txb_Bairro = new System.Windows.Forms.TextBox();
            this.lb_Bairro = new System.Windows.Forms.Label();
            this.txb_Complemento = new System.Windows.Forms.TextBox();
            this.lb_Complemento = new System.Windows.Forms.Label();
            this.txb_Numero = new System.Windows.Forms.TextBox();
            this.lb_Numero = new System.Windows.Forms.Label();
            this.txb_Endereco = new System.Windows.Forms.TextBox();
            this.lb_Enderco = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Limpar_Endereco
            // 
            this.bt_Limpar_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpar_Endereco.Location = new System.Drawing.Point(6, 315);
            this.bt_Limpar_Endereco.Name = "bt_Limpar_Endereco";
            this.bt_Limpar_Endereco.Size = new System.Drawing.Size(131, 34);
            this.bt_Limpar_Endereco.TabIndex = 9;
            this.bt_Limpar_Endereco.Text = "Limpar";
            this.bt_Limpar_Endereco.UseVisualStyleBackColor = true;
            this.bt_Limpar_Endereco.Click += new System.EventHandler(this.bt_Limpar_Endereco_Click);
            // 
            // bt_Cadastrar_Endereco
            // 
            this.bt_Cadastrar_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cadastrar_Endereco.Location = new System.Drawing.Point(6, 250);
            this.bt_Cadastrar_Endereco.Name = "bt_Cadastrar_Endereco";
            this.bt_Cadastrar_Endereco.Size = new System.Drawing.Size(131, 32);
            this.bt_Cadastrar_Endereco.TabIndex = 8;
            this.bt_Cadastrar_Endereco.Text = "Cadastrar";
            this.bt_Cadastrar_Endereco.UseVisualStyleBackColor = true;
            this.bt_Cadastrar_Endereco.Click += new System.EventHandler(this.bt_Cadastrar_Endereco_Click);
            // 
            // bt_Fechar_Endereco
            // 
            this.bt_Fechar_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Fechar_Endereco.Location = new System.Drawing.Point(6, 380);
            this.bt_Fechar_Endereco.Name = "bt_Fechar_Endereco";
            this.bt_Fechar_Endereco.Size = new System.Drawing.Size(131, 33);
            this.bt_Fechar_Endereco.TabIndex = 10;
            this.bt_Fechar_Endereco.Text = "Fechar";
            this.bt_Fechar_Endereco.UseVisualStyleBackColor = true;
            this.bt_Fechar_Endereco.Click += new System.EventHandler(this.bt_Fechar_Endereco_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.lb_Endereco);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 67);
            this.panel1.TabIndex = 64;
            // 
            // lb_Endereco
            // 
            this.lb_Endereco.AutoSize = true;
            this.lb_Endereco.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Endereco.Location = new System.Drawing.Point(252, 9);
            this.lb_Endereco.Name = "lb_Endereco";
            this.lb_Endereco.Size = new System.Drawing.Size(341, 42);
            this.lb_Endereco.TabIndex = 2;
            this.lb_Endereco.Text = "Cadastro de Endereço";
            // 
            // cbx_Uf
            // 
            this.cbx_Uf.FormattingEnabled = true;
            this.cbx_Uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbx_Uf.Location = new System.Drawing.Point(669, 178);
            this.cbx_Uf.Name = "cbx_Uf";
            this.cbx_Uf.Size = new System.Drawing.Size(69, 21);
            this.cbx_Uf.TabIndex = 7;
            // 
            // lb_UF
            // 
            this.lb_UF.AutoSize = true;
            this.lb_UF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UF.Location = new System.Drawing.Point(665, 155);
            this.lb_UF.Name = "lb_UF";
            this.lb_UF.Size = new System.Drawing.Size(31, 20);
            this.lb_UF.TabIndex = 62;
            this.lb_UF.Text = "UF";
            // 
            // txb_Cidade
            // 
            this.txb_Cidade.Location = new System.Drawing.Point(438, 178);
            this.txb_Cidade.Name = "txb_Cidade";
            this.txb_Cidade.Size = new System.Drawing.Size(209, 20);
            this.txb_Cidade.TabIndex = 6;
            // 
            // lb_Cidade
            // 
            this.lb_Cidade.AutoSize = true;
            this.lb_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cidade.Location = new System.Drawing.Point(445, 155);
            this.lb_Cidade.Name = "lb_Cidade";
            this.lb_Cidade.Size = new System.Drawing.Size(59, 20);
            this.lb_Cidade.TabIndex = 60;
            this.lb_Cidade.Text = "Cidade";
            // 
            // txb_Cep
            // 
            this.txb_Cep.Location = new System.Drawing.Point(258, 178);
            this.txb_Cep.Name = "txb_Cep";
            this.txb_Cep.Size = new System.Drawing.Size(147, 20);
            this.txb_Cep.TabIndex = 5;
            // 
            // lb_Cep
            // 
            this.lb_Cep.AutoSize = true;
            this.lb_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Cep.Location = new System.Drawing.Point(254, 155);
            this.lb_Cep.Name = "lb_Cep";
            this.lb_Cep.Size = new System.Drawing.Size(41, 20);
            this.lb_Cep.TabIndex = 58;
            this.lb_Cep.Text = "CEP";
            // 
            // txb_Bairro
            // 
            this.txb_Bairro.Location = new System.Drawing.Point(6, 178);
            this.txb_Bairro.Name = "txb_Bairro";
            this.txb_Bairro.Size = new System.Drawing.Size(215, 20);
            this.txb_Bairro.TabIndex = 4;
            // 
            // lb_Bairro
            // 
            this.lb_Bairro.AutoSize = true;
            this.lb_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Bairro.Location = new System.Drawing.Point(2, 155);
            this.lb_Bairro.Name = "lb_Bairro";
            this.lb_Bairro.Size = new System.Drawing.Size(51, 20);
            this.lb_Bairro.TabIndex = 56;
            this.lb_Bairro.Text = "Bairro";
            // 
            // txb_Complemento
            // 
            this.txb_Complemento.Location = new System.Drawing.Point(547, 114);
            this.txb_Complemento.Name = "txb_Complemento";
            this.txb_Complemento.Size = new System.Drawing.Size(262, 20);
            this.txb_Complemento.TabIndex = 3;
            // 
            // lb_Complemento
            // 
            this.lb_Complemento.AutoSize = true;
            this.lb_Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Complemento.Location = new System.Drawing.Point(558, 91);
            this.lb_Complemento.Name = "lb_Complemento";
            this.lb_Complemento.Size = new System.Drawing.Size(108, 20);
            this.lb_Complemento.TabIndex = 54;
            this.lb_Complemento.Text = "Complemento";
            // 
            // txb_Numero
            // 
            this.txb_Numero.Location = new System.Drawing.Point(426, 114);
            this.txb_Numero.Name = "txb_Numero";
            this.txb_Numero.Size = new System.Drawing.Size(74, 20);
            this.txb_Numero.TabIndex = 2;
            // 
            // lb_Numero
            // 
            this.lb_Numero.AutoSize = true;
            this.lb_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Numero.Location = new System.Drawing.Point(422, 91);
            this.lb_Numero.Name = "lb_Numero";
            this.lb_Numero.Size = new System.Drawing.Size(26, 20);
            this.lb_Numero.TabIndex = 52;
            this.lb_Numero.Text = "Nº";
            // 
            // txb_Endereco
            // 
            this.txb_Endereco.Location = new System.Drawing.Point(6, 114);
            this.txb_Endereco.Name = "txb_Endereco";
            this.txb_Endereco.Size = new System.Drawing.Size(359, 20);
            this.txb_Endereco.TabIndex = 1;
            // 
            // lb_Enderco
            // 
            this.lb_Enderco.AutoSize = true;
            this.lb_Enderco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Enderco.Location = new System.Drawing.Point(2, 91);
            this.lb_Enderco.Name = "lb_Enderco";
            this.lb_Enderco.Size = new System.Drawing.Size(91, 20);
            this.lb_Enderco.TabIndex = 50;
            this.lb_Enderco.Text = "Logradouro";
            // 
            // Tela_Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.bt_Limpar_Endereco);
            this.Controls.Add(this.bt_Cadastrar_Endereco);
            this.Controls.Add(this.bt_Fechar_Endereco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbx_Uf);
            this.Controls.Add(this.lb_UF);
            this.Controls.Add(this.txb_Cidade);
            this.Controls.Add(this.lb_Cidade);
            this.Controls.Add(this.txb_Cep);
            this.Controls.Add(this.lb_Cep);
            this.Controls.Add(this.txb_Bairro);
            this.Controls.Add(this.lb_Bairro);
            this.Controls.Add(this.txb_Complemento);
            this.Controls.Add(this.lb_Complemento);
            this.Controls.Add(this.txb_Numero);
            this.Controls.Add(this.lb_Numero);
            this.Controls.Add(this.txb_Endereco);
            this.Controls.Add(this.lb_Enderco);
            this.Name = "Tela_Endereco";
            this.Text = "Tela_Cadastro_Endereco";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Limpar_Endereco;
        private System.Windows.Forms.Button bt_Cadastrar_Endereco;
        private System.Windows.Forms.Button bt_Fechar_Endereco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Endereco;
        private System.Windows.Forms.ComboBox cbx_Uf;
        private System.Windows.Forms.Label lb_UF;
        private System.Windows.Forms.TextBox txb_Cidade;
        private System.Windows.Forms.Label lb_Cidade;
        private System.Windows.Forms.TextBox txb_Cep;
        private System.Windows.Forms.Label lb_Cep;
        private System.Windows.Forms.TextBox txb_Bairro;
        private System.Windows.Forms.Label lb_Bairro;
        private System.Windows.Forms.TextBox txb_Complemento;
        private System.Windows.Forms.Label lb_Complemento;
        private System.Windows.Forms.TextBox txb_Numero;
        private System.Windows.Forms.Label lb_Numero;
        private System.Windows.Forms.TextBox txb_Endereco;
        private System.Windows.Forms.Label lb_Enderco;
    }
}