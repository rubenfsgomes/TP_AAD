using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Database_csharp
{
    public partial class Form1 : Form
    {
        List<Consulta> consultas = new List<Consulta>();
        public Form1()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            listBox1.DataSource = consultas;
            listBox1.DisplayMember = "FullInfo";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            listBox1.DataSource = db.QueryConsultas(Convert.ToInt32(CIDqueryText.Text), Convert.ToInt32(PIDqueryText.Text));

            UpdateBinding();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoInserir_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string targetDateFormat = "dd/MM/yyyy";

            DateTime dt = DateTime.ParseExact(DataNascimentotext.Text, targetDateFormat, CultureInfo.InvariantCulture);

            db.InsertCrianca(Convert.ToInt32(TutorTIDtext.Text), Convert.ToInt32(EscolaEIDtext.Text), Convert.ToInt32(PsicologoPIDtext.Text), Nometext.Text, Convert.ToChar(Sexotext.Text), dt);

            TutorTIDtext.Text = "";
            EscolaEIDtext.Text = "";
            PsicologoPIDtext.Text = "";
            Nometext.Text = "";
            Sexotext.Text = "";
            DataNascimentotext.Text = "";
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeleteCrianca(Convert.ToInt32(CIDtext.Text));

            CIDtext.Text = "";
        }

        private void InserirPsicologo_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPsicologo(Convert.ToInt32(EquipaEIDtext.Text), NomePsitext.Text);

            EquipaEIDtext.Text = "";
            NomePsitext.Text = "";
        }

        private void AlterarCrianca_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string targetDateFormat = "dd/MM/yyyy";

            DateTime dt = DateTime.ParseExact(DataNascimentotext.Text, targetDateFormat, CultureInfo.InvariantCulture);

            db.UpdateCrianca(Convert.ToInt32(CIDtext.Text) ,Convert.ToInt32(TutorTIDtext.Text), Convert.ToInt32(EscolaEIDtext.Text), Convert.ToInt32(PsicologoPIDtext.Text), Nometext.Text, Convert.ToChar(Sexotext.Text), dt);

            CIDtext.Text = "";
            TutorTIDtext.Text = "";
            EscolaEIDtext.Text = "";
            PsicologoPIDtext.Text = "";
            Nometext.Text = "";
            Sexotext.Text = "";
            DataNascimentotext.Text = "";
        }      

        private void EliminarPsicologo_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeletePsicologo(Convert.ToInt32(PIDtext.Text));

            PIDtext.Text = "";
        }

        private void AlterarPsicologo_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.UpdatePsicologo(Convert.ToInt32(PIDtext.Text), Convert.ToInt32(EquipaEIDtext.Text), NomePsitext.Text);

            PIDtext.Text = "";
            EquipaEIDtext.Text = "";
            NomePsitext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string targetDateFormat = "dd/MM/yyyy";

            DateTime dt = DateTime.ParseExact(DataRealizacaotext.Text, targetDateFormat, CultureInfo.InvariantCulture);

            db.InsertConsulta(Convert.ToInt32(Psicologotext.Text), Convert.ToInt32(CriancaCIDtext.Text), dt);

            Psicologotext.Text = "";
            CriancaCIDtext.Text = "";
            DataRealizacaotext.Text = "";
        }

        private void EliminarConsulta_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.DeleteConsulta(Convert.ToInt32(ConsultaCIDtext.Text));

            ConsultaCIDtext.Text = "";
        }

        private void AlterarConsulta_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            string targetDateFormat = "dd/MM/yyyy";

            DateTime dt = DateTime.ParseExact(DataRealizacaotext.Text, targetDateFormat, CultureInfo.InvariantCulture);

            db.UpdateConsulta(Convert.ToInt32(ConsultaCIDtext.Text), Convert.ToInt32(Psicologotext.Text), Convert.ToInt32(CriancaCIDtext.Text), dt);

            ConsultaCIDtext.Text = "";
            Psicologotext.Text = "";
            CriancaCIDtext.Text = "";
            DataRealizacaotext.Text = "";
        }
    }
}
