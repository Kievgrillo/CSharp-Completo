namespace ConversorDeMoeda
{
    class ConversorDeMoeda
    {
        public static double ConverterDolarParaReal(double cotacaoDolar, double quantidadeDolar)
        {
            double valorSemIOF = cotacaoDolar * quantidadeDolar;
            double iof = valorSemIOF * 0.06; // 6% de IOF
            return valorSemIOF + iof;
        }
    }
}

