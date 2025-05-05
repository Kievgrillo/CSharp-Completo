using System;
using System.Security.Cryptography.X509Certificates;

namespace Curso
{
    //Usando pascal case
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }

        //usando camel case
        public double GetSaldo()
        {
            //_saldo atributo interno da classe
            return _saldo;
        }
    }
}
