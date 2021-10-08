
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.campoCep = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.campoMasculino = new System.Windows.Forms.CheckBox();
            this.campoFeminino = new System.Windows.Forms.CheckBox();
            this.campoOutro = new System.Windows.Forms.CheckBox();
            this.btCadastro = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(364, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 18);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Data de nascimento:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(347, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Dados Pessoais:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(347, 331);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Contato:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(347, 253);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Endereço:";
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
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(364, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 27);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Cadastro";
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
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(29, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Digite o CEP...";
            this.textBox5.Size = new System.Drawing.Size(128, 18);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Orientação Sexual:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 539);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.campoOutro);
            this.Controls.Add(this.campoFeminino);
            this.Controls.Add(this.campoMasculino);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.campoCep);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.TextBox campoCep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox campoMasculino;
        private System.Windows.Forms.CheckBox campoFeminino;
        private System.Windows.Forms.CheckBox campoOutro;
        private System.Windows.Forms.Button btCadastro;
    }
}

