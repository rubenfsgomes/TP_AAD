using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Database_csharp
{
    public class DataAccess
    {
        List<Crianca> criancas = new List<Crianca>();
        List<Psicologo> psicologos = new List<Psicologo>();
        List<Consulta> consultas = new List<Consulta>();

       
        public List<Consulta> QueryConsultas(int CID, int PID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                var output = connection.Query<Consulta>($"Select PsícólogoPID, CriançaCID, DataRealização From Consulta where PsícólogoPID = '{PID}' and CriançaCID = '{CID}'").ToList();
                return output;
            }
        }

        public void InsertPsicologo(int text1, string text2)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {

                psicologos.Add(new Psicologo {EquipaGestaoEGID = text1, Nome = text2});

                connection.Execute("dbo.ADDPsicologo @EquipaGestaoEGID, @Nome", psicologos);

            }
        }

        public void DeletePsicologo(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute($"dbo.DELETEPsicologo @PID", new { PID = ID });
            }
        }

        public void UpdatePsicologo(int text1, int text2, string text3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute("dbo.UPDATEPsicologo @PID, @EquipaGestaoEGID, @Nome", new
                {
                    PID = text1,
                    EquipaGestaoEGID = text2,
                    Nome = text3
                });
            }
        }

        public void InsertCrianca(int text2, int text3, int text4, string text5, char text6, DateTime text7)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {

                criancas.Add(new Crianca { TutorTID = text2, EscolaEID = text3, PsicólogoPID = text4, Nome = text5, Sexo = text6, DataNascimento = text7 });

                connection.Execute("dbo.ADDCrianca @TutorTID, @EscolaEID, @PsicólogoPID, @Nome, @Sexo, @DataNascimento", criancas);

            }
        }

        public void DeleteCrianca (int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute($"dbo.DELETECrianca @CID", new { CID = ID });
            }
        }

        public void UpdateCrianca (int text1, int text2, int text3, int text4, string text5, char text6, DateTime text7)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute("dbo.UPDATECrianca @CID, @TutorTID, @EscolaEID, @PsicologoPID, @Nome, @Sexo, @DataNascimento", new
                {
                    CID=text1,
                    TutorTID = text2,
                    EscolaEID = text3,
                    PsicologoPID = text4,
                    Nome = text5,
                    Sexo = text6,
                    DataNascimento = text7
                });
            }
        }

        public void InsertConsulta(int text1, int text2, DateTime text3)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {

                consultas.Add(new Consulta {PsicologoPID = text1, CriancaCID = text2, DataRealizacao = text3});

                connection.Execute("dbo.ADDConsulta @PsicologoPID, @CriancaCID, @DataRealizacao", consultas);

            }
        }

        public void DeleteConsulta(int ID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute($"dbo.DELETEConsulta @CID", new { CID = ID });
            }
        }

        public void UpdateConsulta(int text1, int text2, int text3, DateTime text4)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("C-Happy")))
            {
                connection.Execute("dbo.UPDATEConsulta @CID, @PsicologoPID, @CriancaCID, @DataRealizacao", new
                {
                    CID = text1,
                    PsicologoPID = text2,
                    CriancaCID = text3,
                    DataRealizacao = text4
                });
            }
        }
    }
}
