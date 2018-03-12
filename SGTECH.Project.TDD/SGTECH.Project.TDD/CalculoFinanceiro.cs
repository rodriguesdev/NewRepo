using System;

namespace SGTECH.Project.TDD
{
    public class CalculoFinanceiro
    {
        public static double CalculaValorComJurosCompostos(double valorEmprestimo, int numMeses, double percTaxa)
        {
            return Math.Round(valorEmprestimo * Math.Pow(1 + (percTaxa / 100), numMeses), 2);
            //return 0;
        }
    }
}
