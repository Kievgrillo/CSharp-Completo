using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        public string NomeAluno;
        public double Nota1, Nota2, Nota3;

        public double NotaAnual()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovacao()
        {
            if (NotaAnual() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovacao())
            {
                return 0.00;
            }
            else
            {
                return 60.00 - NotaAnual();
            }
        }
    }
}
