using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_csharp
{
    public class Consulta
    {
        public int PsicologoPID { get; set; }
        public int CriancaCID { get; set; }
        public DateTime DataRealizacao { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{PsicologoPID} {CriancaCID} {DataRealizacao}";
            }
        }
    }
}
