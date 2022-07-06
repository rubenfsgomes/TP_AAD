using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_csharp
{
    public class Crianca
    {
        #region
        public int TutorTID { get; set; }
        public int EscolaEID { get; set; }
        public int PsicólogoPID { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }

        #endregion
    }
}
