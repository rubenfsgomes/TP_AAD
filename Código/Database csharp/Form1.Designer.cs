
namespace Database_csharp
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CIDqueryText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CIDtext = new System.Windows.Forms.TextBox();
            this.Nometext = new System.Windows.Forms.TextBox();
            this.Sexotext = new System.Windows.Forms.TextBox();
            this.DataNascimentotext = new System.Windows.Forms.TextBox();
            this.PsicologoPIDtext = new System.Windows.Forms.TextBox();
            this.TutorTIDtext = new System.Windows.Forms.TextBox();
            this.EscolaEIDtext = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.Label();
            this.TutorTID = new System.Windows.Forms.Label();
            this.EscolaEID = new System.Windows.Forms.Label();
            this.PsicologoPID = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.Label();
            this.InserirCrianca = new System.Windows.Forms.Button();
            this.EliminarCrianca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EquipaEIDtext = new System.Windows.Forms.TextBox();
            this.NomePsitext = new System.Windows.Forms.TextBox();
            this.PIDtext = new System.Windows.Forms.TextBox();
            this.EliminarPsicologo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.InserirPsicologo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AlterarCrianca = new System.Windows.Forms.Button();
            this.AlterarPsicologo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ConsultaCIDtext = new System.Windows.Forms.TextBox();
            this.EliminarConsulta = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.DataRealizacaotext = new System.Windows.Forms.TextBox();
            this.CriancaCIDtext = new System.Windows.Forms.TextBox();
            this.Psicologotext = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.AlterarConsulta = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PIDqueryText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(331, 336);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // CIDqueryText
            // 
            this.CIDqueryText.Location = new System.Drawing.Point(651, 390);
            this.CIDqueryText.Name = "CIDqueryText";
            this.CIDqueryText.Size = new System.Drawing.Size(100, 20);
            this.CIDqueryText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Executar Query";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CIDtext
            // 
            this.CIDtext.Location = new System.Drawing.Point(127, 90);
            this.CIDtext.Name = "CIDtext";
            this.CIDtext.Size = new System.Drawing.Size(100, 20);
            this.CIDtext.TabIndex = 3;
            // 
            // Nometext
            // 
            this.Nometext.Location = new System.Drawing.Point(127, 250);
            this.Nometext.Name = "Nometext";
            this.Nometext.Size = new System.Drawing.Size(100, 20);
            this.Nometext.TabIndex = 4;
            // 
            // Sexotext
            // 
            this.Sexotext.Location = new System.Drawing.Point(127, 292);
            this.Sexotext.Name = "Sexotext";
            this.Sexotext.Size = new System.Drawing.Size(100, 20);
            this.Sexotext.TabIndex = 5;
            // 
            // DataNascimentotext
            // 
            this.DataNascimentotext.Location = new System.Drawing.Point(127, 333);
            this.DataNascimentotext.Name = "DataNascimentotext";
            this.DataNascimentotext.Size = new System.Drawing.Size(100, 20);
            this.DataNascimentotext.TabIndex = 6;
            // 
            // PsicologoPIDtext
            // 
            this.PsicologoPIDtext.Location = new System.Drawing.Point(127, 213);
            this.PsicologoPIDtext.Name = "PsicologoPIDtext";
            this.PsicologoPIDtext.Size = new System.Drawing.Size(100, 20);
            this.PsicologoPIDtext.TabIndex = 7;
            // 
            // TutorTIDtext
            // 
            this.TutorTIDtext.Location = new System.Drawing.Point(127, 138);
            this.TutorTIDtext.Name = "TutorTIDtext";
            this.TutorTIDtext.Size = new System.Drawing.Size(100, 20);
            this.TutorTIDtext.TabIndex = 8;
            // 
            // EscolaEIDtext
            // 
            this.EscolaEIDtext.Location = new System.Drawing.Point(127, 175);
            this.EscolaEIDtext.Name = "EscolaEIDtext";
            this.EscolaEIDtext.Size = new System.Drawing.Size(100, 20);
            this.EscolaEIDtext.TabIndex = 9;
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Location = new System.Drawing.Point(83, 91);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(25, 13);
            this.CID.TabIndex = 10;
            this.CID.Text = "CID";
            this.CID.Click += new System.EventHandler(this.label1_Click);
            // 
            // TutorTID
            // 
            this.TutorTID.AutoSize = true;
            this.TutorTID.Location = new System.Drawing.Point(71, 138);
            this.TutorTID.Name = "TutorTID";
            this.TutorTID.Size = new System.Drawing.Size(50, 13);
            this.TutorTID.TabIndex = 11;
            this.TutorTID.Text = "TutorTID";
            // 
            // EscolaEID
            // 
            this.EscolaEID.AutoSize = true;
            this.EscolaEID.Location = new System.Drawing.Point(64, 175);
            this.EscolaEID.Name = "EscolaEID";
            this.EscolaEID.Size = new System.Drawing.Size(57, 13);
            this.EscolaEID.TabIndex = 12;
            this.EscolaEID.Text = "EscolaEID";
            // 
            // PsicologoPID
            // 
            this.PsicologoPID.AutoSize = true;
            this.PsicologoPID.Location = new System.Drawing.Point(50, 220);
            this.PsicologoPID.Name = "PsicologoPID";
            this.PsicologoPID.Size = new System.Drawing.Size(71, 13);
            this.PsicologoPID.TabIndex = 13;
            this.PsicologoPID.Text = "PsicologoPID";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(86, 257);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 14;
            this.Nome.Text = "Nome";
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(86, 292);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(31, 13);
            this.Sexo.TabIndex = 15;
            this.Sexo.Text = "Sexo";
            // 
            // DataNascimento
            // 
            this.DataNascimento.AutoSize = true;
            this.DataNascimento.Location = new System.Drawing.Point(17, 336);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(104, 13);
            this.DataNascimento.TabIndex = 16;
            this.DataNascimento.Text = "Data de Nascimento";
            // 
            // InserirCrianca
            // 
            this.InserirCrianca.Location = new System.Drawing.Point(139, 359);
            this.InserirCrianca.Name = "InserirCrianca";
            this.InserirCrianca.Size = new System.Drawing.Size(75, 23);
            this.InserirCrianca.TabIndex = 17;
            this.InserirCrianca.Text = "Inserir";
            this.InserirCrianca.UseVisualStyleBackColor = true;
            this.InserirCrianca.Click += new System.EventHandler(this.BotaoInserir_Click);
            // 
            // EliminarCrianca
            // 
            this.EliminarCrianca.Location = new System.Drawing.Point(233, 88);
            this.EliminarCrianca.Name = "EliminarCrianca";
            this.EliminarCrianca.Size = new System.Drawing.Size(75, 23);
            this.EliminarCrianca.TabIndex = 18;
            this.EliminarCrianca.Text = "Eliminar";
            this.EliminarCrianca.UseVisualStyleBackColor = true;
            this.EliminarCrianca.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Criança";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Não Introduzir dados em CID";
            // 
            // EquipaEIDtext
            // 
            this.EquipaEIDtext.Location = new System.Drawing.Point(383, 138);
            this.EquipaEIDtext.Name = "EquipaEIDtext";
            this.EquipaEIDtext.Size = new System.Drawing.Size(100, 20);
            this.EquipaEIDtext.TabIndex = 23;
            // 
            // NomePsitext
            // 
            this.NomePsitext.Location = new System.Drawing.Point(383, 175);
            this.NomePsitext.Name = "NomePsitext";
            this.NomePsitext.Size = new System.Drawing.Size(100, 20);
            this.NomePsitext.TabIndex = 24;
            // 
            // PIDtext
            // 
            this.PIDtext.Location = new System.Drawing.Point(383, 90);
            this.PIDtext.Name = "PIDtext";
            this.PIDtext.Size = new System.Drawing.Size(100, 20);
            this.PIDtext.TabIndex = 25;
            // 
            // EliminarPsicologo
            // 
            this.EliminarPsicologo.Location = new System.Drawing.Point(489, 86);
            this.EliminarPsicologo.Name = "EliminarPsicologo";
            this.EliminarPsicologo.Size = new System.Drawing.Size(75, 23);
            this.EliminarPsicologo.TabIndex = 26;
            this.EliminarPsicologo.Text = "Eliminar";
            this.EliminarPsicologo.UseVisualStyleBackColor = true;
            this.EliminarPsicologo.Click += new System.EventHandler(this.EliminarPsicologo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dados";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Não Introduzir dados em PID";
            // 
            // InserirPsicologo
            // 
            this.InserirPsicologo.Location = new System.Drawing.Point(398, 201);
            this.InserirPsicologo.Name = "InserirPsicologo";
            this.InserirPsicologo.Size = new System.Drawing.Size(75, 23);
            this.InserirPsicologo.TabIndex = 30;
            this.InserirPsicologo.Text = "Inserir";
            this.InserirPsicologo.UseVisualStyleBackColor = true;
            this.InserirPsicologo.Click += new System.EventHandler(this.InserirPsicologo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "PID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "EquipaGestaoID";
            // 
            // AlterarCrianca
            // 
            this.AlterarCrianca.Location = new System.Drawing.Point(139, 388);
            this.AlterarCrianca.Name = "AlterarCrianca";
            this.AlterarCrianca.Size = new System.Drawing.Size(75, 23);
            this.AlterarCrianca.TabIndex = 34;
            this.AlterarCrianca.Text = "Alterar";
            this.AlterarCrianca.UseVisualStyleBackColor = true;
            this.AlterarCrianca.Click += new System.EventHandler(this.AlterarCrianca_Click);
            // 
            // AlterarPsicologo
            // 
            this.AlterarPsicologo.Location = new System.Drawing.Point(398, 230);
            this.AlterarPsicologo.Name = "AlterarPsicologo";
            this.AlterarPsicologo.Size = new System.Drawing.Size(75, 23);
            this.AlterarPsicologo.TabIndex = 35;
            this.AlterarPsicologo.Text = "Alterar";
            this.AlterarPsicologo.UseVisualStyleBackColor = true;
            this.AlterarPsicologo.Click += new System.EventHandler(this.AlterarPsicologo_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(413, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Psicólogo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(678, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Consulta";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(591, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(241, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "A não ser que queira eliminar ou alterar elementos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(633, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Não Introduzir dados em PID";
            // 
            // ConsultaCIDtext
            // 
            this.ConsultaCIDtext.Location = new System.Drawing.Point(651, 88);
            this.ConsultaCIDtext.Name = "ConsultaCIDtext";
            this.ConsultaCIDtext.Size = new System.Drawing.Size(100, 20);
            this.ConsultaCIDtext.TabIndex = 40;
            // 
            // EliminarConsulta
            // 
            this.EliminarConsulta.Location = new System.Drawing.Point(757, 85);
            this.EliminarConsulta.Name = "EliminarConsulta";
            this.EliminarConsulta.Size = new System.Drawing.Size(75, 23);
            this.EliminarConsulta.TabIndex = 41;
            this.EliminarConsulta.Text = "Eliminar";
            this.EliminarConsulta.UseVisualStyleBackColor = true;
            this.EliminarConsulta.Click += new System.EventHandler(this.EliminarConsulta_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(678, 122);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Dados";
            // 
            // DataRealizacaotext
            // 
            this.DataRealizacaotext.Location = new System.Drawing.Point(651, 213);
            this.DataRealizacaotext.Name = "DataRealizacaotext";
            this.DataRealizacaotext.Size = new System.Drawing.Size(100, 20);
            this.DataRealizacaotext.TabIndex = 43;
            // 
            // CriancaCIDtext
            // 
            this.CriancaCIDtext.Location = new System.Drawing.Point(651, 175);
            this.CriancaCIDtext.Name = "CriancaCIDtext";
            this.CriancaCIDtext.Size = new System.Drawing.Size(100, 20);
            this.CriancaCIDtext.TabIndex = 44;
            // 
            // Psicologotext
            // 
            this.Psicologotext.Location = new System.Drawing.Point(651, 135);
            this.Psicologotext.Name = "Psicologotext";
            this.Psicologotext.Size = new System.Drawing.Size(100, 20);
            this.Psicologotext.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(574, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "PsicologoPID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(584, 178);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "CriançaCID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(544, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Data de Realização";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Inserir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AlterarConsulta
            // 
            this.AlterarConsulta.Location = new System.Drawing.Point(663, 268);
            this.AlterarConsulta.Name = "AlterarConsulta";
            this.AlterarConsulta.Size = new System.Drawing.Size(75, 23);
            this.AlterarConsulta.TabIndex = 50;
            this.AlterarConsulta.Text = "Alterar";
            this.AlterarConsulta.UseVisualStyleBackColor = true;
            this.AlterarConsulta.Click += new System.EventHandler(this.AlterarConsulta_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(332, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(241, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "A não ser que queira eliminar ou alterar elementos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "A não ser que queira eliminar ou alterar elementos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Consulta CID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(584, 393);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 54;
            this.label20.Text = "Criança CID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(576, 422);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Psicólogo PID";
            // 
            // PIDqueryText
            // 
            this.PIDqueryText.Location = new System.Drawing.Point(651, 415);
            this.PIDqueryText.Name = "PIDqueryText";
            this.PIDqueryText.Size = new System.Drawing.Size(100, 20);
            this.PIDqueryText.TabIndex = 56;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(304, 320);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(303, 13);
            this.label22.TabIndex = 57;
            this.label22.Text = "Query que apresenta consultas entre certo psicólogo e criança";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 549);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.PIDqueryText);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.AlterarConsulta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Psicologotext);
            this.Controls.Add(this.CriancaCIDtext);
            this.Controls.Add(this.DataRealizacaotext);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.EliminarConsulta);
            this.Controls.Add(this.ConsultaCIDtext);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AlterarPsicologo);
            this.Controls.Add(this.AlterarCrianca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InserirPsicologo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EliminarPsicologo);
            this.Controls.Add(this.PIDtext);
            this.Controls.Add(this.NomePsitext);
            this.Controls.Add(this.EquipaEIDtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarCrianca);
            this.Controls.Add(this.InserirCrianca);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.PsicologoPID);
            this.Controls.Add(this.EscolaEID);
            this.Controls.Add(this.TutorTID);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.EscolaEIDtext);
            this.Controls.Add(this.TutorTIDtext);
            this.Controls.Add(this.PsicologoPIDtext);
            this.Controls.Add(this.DataNascimentotext);
            this.Controls.Add(this.Sexotext);
            this.Controls.Add(this.Nometext);
            this.Controls.Add(this.CIDtext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CIDqueryText);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "C-Happy DataBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CIDqueryText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CIDtext;
        private System.Windows.Forms.TextBox Nometext;
        private System.Windows.Forms.TextBox Sexotext;
        private System.Windows.Forms.TextBox DataNascimentotext;
        private System.Windows.Forms.TextBox PsicologoPIDtext;
        private System.Windows.Forms.TextBox TutorTIDtext;
        private System.Windows.Forms.TextBox EscolaEIDtext;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.Label TutorTID;
        private System.Windows.Forms.Label EscolaEID;
        private System.Windows.Forms.Label PsicologoPID;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.Label DataNascimento;
        private System.Windows.Forms.Button InserirCrianca;
        private System.Windows.Forms.Button EliminarCrianca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EquipaEIDtext;
        private System.Windows.Forms.TextBox NomePsitext;
        private System.Windows.Forms.TextBox PIDtext;
        private System.Windows.Forms.Button EliminarPsicologo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button InserirPsicologo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AlterarCrianca;
        private System.Windows.Forms.Button AlterarPsicologo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ConsultaCIDtext;
        private System.Windows.Forms.Button EliminarConsulta;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox DataRealizacaotext;
        private System.Windows.Forms.TextBox CriancaCIDtext;
        private System.Windows.Forms.TextBox Psicologotext;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AlterarConsulta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox PIDqueryText;
        private System.Windows.Forms.Label label22;
    }
}

