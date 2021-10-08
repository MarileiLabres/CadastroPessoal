
namespace CadastroPessoal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoNome = new System.Windows.Forms.TextBox();
            this.campoSobrenome = new System.Windows.Forms.TextBox();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.campoData = new System.Windows.Forms.DateTimePicker();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.campoCep = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.campoMasculino = new System.Windows.Forms.CheckBox();
            this.campoFeminino = new System.Windows.Forms.CheckBox();
            this.campoOutro = new System.Windows.Forms.CheckBox();
            this.btCadastro = new System.Windows.Forms.Button();
            this.lCadastro = new System.Windows.Forms.Label();
            this.labelDadosPessoais = new System.Windows.Forms.Label();
            this.labelDataNasc = new System.Windows.Forms.Label();
            this.labelContato = new System.Windows.Forms.Label();
            this.labelOrient = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(30, 147);
            this.campoNome.Name = "campoNome";
            this.campoNome.PlaceholderText = "Digite seu nome...";
            this.campoNome.Size = new System.Drawing.Size(127, 23);
            this.campoNome.TabIndex = 0;
            this.campoNome.TextChanged += new System.EventHandler(this.campoNome_TextChanged);
            // 
            // campoSobrenome
            // 
            this.campoSobrenome.Location = new System.Drawing.Point(197, 147);
            this.campoSobrenome.Name = "campoSobrenome";
            this.campoSobrenome.PlaceholderText = "Digite seu sobrenome...";
            this.campoSobrenome.Size = new System.Drawing.Size(131, 23);
            this.campoSobrenome.TabIndex = 1;
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(29, 294);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.PlaceholderText = "Digite seu endereço...";
            this.campoEndereco.Size = new System.Drawing.Size(128, 23);
            this.campoEndereco.TabIndex = 2;
            this.campoEndereco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // campoData
            // 
            this.campoData.CustomFormat = "";
            this.campoData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.campoData.Location = new System.Drawing.Point(512, 142);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(230, 23);
            this.campoData.TabIndex = 3;
            this.campoData.Value = new System.DateTime(2021, 10, 8, 17, 59, 11, 0);
            // 
            // campoCidade
            // 
            this.campoCidade.Location = new System.Drawing.Point(197, 294);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.PlaceholderText = "digite o nome da cidade...";
            this.campoCidade.Size = new System.Drawing.Size(148, 23);
            this.campoCidade.TabIndex = 8;
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(197, 368);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.PlaceholderText = "Digite seu e-mail...";
            this.campoEmail.Size = new System.Drawing.Size(131, 23);
            this.campoEmail.TabIndex = 9;
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(30, 368);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.PlaceholderText = "Digite o telefone...";
            this.campoTelefone.Size = new System.Drawing.Size(131, 23);
            this.campoTelefone.TabIndex = 11;
            // 
            // campoCep
            // 
            this.campoCep.Location = new System.Drawing.Point(398, 294);
            this.campoCep.Name = "campoCep";
            this.campoCep.PlaceholderText = "Digite o CEP...";
            this.campoCep.Size = new System.Drawing.Size(128, 23);
            this.campoCep.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
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
            " SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox1.Location = new System.Drawing.Point(579, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 23);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "UF";
            // 
            // campoMasculino
            // 
            this.campoMasculino.AutoSize = true;
            this.campoMasculino.Location = new System.Drawing.Point(214, 193);
            this.campoMasculino.Name = "campoMasculino";
            this.campoMasculino.Size = new System.Drawing.Size(81, 19);
            this.campoMasculino.TabIndex = 15;
            this.campoMasculino.Text = "Masculino";
            this.campoMasculino.UseVisualStyleBackColor = true;
            // 
            // campoFeminino
            // 
            this.campoFeminino.AutoSize = true;
            this.campoFeminino.Location = new System.Drawing.Point(364, 193);
            this.campoFeminino.Name = "campoFeminino";
            this.campoFeminino.Size = new System.Drawing.Size(76, 19);
            this.campoFeminino.TabIndex = 16;
            this.campoFeminino.Text = "Feminino";
            this.campoFeminino.UseVisualStyleBackColor = true;
            // 
            // campoOutro
            // 
            this.campoOutro.AutoSize = true;
            this.campoOutro.Location = new System.Drawing.Point(543, 193);
            this.campoOutro.Name = "campoOutro";
            this.campoOutro.Size = new System.Drawing.Size(57, 19);
            this.campoOutro.TabIndex = 17;
            this.campoOutro.Text = "Outro";
            this.campoOutro.UseVisualStyleBackColor = true;
            this.campoOutro.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // btCadastro
            // 
            this.btCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCadastro.Location = new System.Drawing.Point(364, 442);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(80, 40);
            this.btCadastro.TabIndex = 18;
            this.btCadastro.Text = "Cadastrar";
            this.btCadastro.UseVisualStyleBackColor = false;
            // 
            // lCadastro
            // 
            this.lCadastro.AutoSize = true;
            this.lCadastro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lCadastro.Location = new System.Drawing.Point(364, 33);
            this.lCadastro.Name = "lCadastro";
            this.lCadastro.Size = new System.Drawing.Size(123, 37);
            this.lCadastro.TabIndex = 19;
            this.lCadastro.Text = "Cadastro";
            this.lCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDadosPessoais
            // 
            this.labelDadosPessoais.AutoSize = true;
            this.labelDadosPessoais.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDadosPessoais.Location = new System.Drawing.Point(347, 88);
            this.labelDadosPessoais.Name = "labelDadosPessoais";
            this.labelDadosPessoais.Size = new System.Drawing.Size(148, 28);
            this.labelDadosPessoais.TabIndex = 20;
            this.labelDadosPessoais.Text = "Dados Pessoais:";
            // 
            // labelDataNasc
            // 
            this.labelDataNasc.AutoSize = true;
            this.labelDataNasc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataNasc.Location = new System.Drawing.Point(375, 142);
            this.labelDataNasc.Name = "labelDataNasc";
            this.labelDataNasc.Size = new System.Drawing.Size(134, 19);
            this.labelDataNasc.TabIndex = 21;
            this.labelDataNasc.Text = "Data de nascimento:";
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContato.Location = new System.Drawing.Point(357, 331);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(87, 28);
            this.labelContato.TabIndex = 22;
            this.labelContato.Text = "Contato:";
            // 
            // labelOrient
            // 
            this.labelOrient.AutoSize = true;
            this.labelOrient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrient.Location = new System.Drawing.Point(29, 193);
            this.labelOrient.Name = "labelOrient";
            this.labelOrient.Size = new System.Drawing.Size(121, 19);
            this.labelOrient.TabIndex = 23;
            this.labelOrient.Text = "Orientação Sexual:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndereco.Location = new System.Drawing.Point(347, 248);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(97, 28);
            this.labelEndereco.TabIndex = 24;
            this.labelEndereco.Text = "Endereço:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 539);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelOrient);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.labelDataNasc);
            this.Controls.Add(this.labelDadosPessoais);
            this.Controls.Add(this.lCadastro);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.campoOutro);
            this.Controls.Add(this.campoFeminino);
            this.Controls.Add(this.campoMasculino);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.campoCep);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.campoData);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.campoSobrenome);
            this.Controls.Add(this.campoNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.TextBox campoSobrenome;
        private System.Windows.Forms.TextBox campoEndereco;
        protected System.Windows.Forms.DateTimePicker campoData;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.TextBox campoCep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox campoMasculino;
        private System.Windows.Forms.CheckBox campoFeminino;
        private System.Windows.Forms.CheckBox campoOutro;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Label lCadastro;
        private System.Windows.Forms.Label labelDadosPessoais;
        private System.Windows.Forms.Label labelDataNasc;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Label labelOrient;
        private System.Windows.Forms.Label labelEndereco;
    }
}

