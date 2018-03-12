using SGTECH.Project.TDD;
using SGTECH.Project.TDD.Controllers;
using System.Linq;
using Xunit;

namespace SGTECH.TestProjectTDD
{
    public class TestControllers
    {
        //Teste de um controller
        [Fact]
        public void TestControllerValueActionGet()
        {
            var controller = new ValuesController();
            var result = controller.Get();
            Assert.Equal(3, result.Count());
        }

        //[Fact]
        //public void Teste1JurosCompostos()
        //{
        //    double valor = CalculoFinanceiro
        //        .CalculaValorComJurosCompostos(10000, 12, 2);
        //    Assert.Equal(valor, 12682.42);
        //}

        //[Fact]
        //public void Teste2JurosCompostos()
        //{
        //    double valor = CalculoFinanceiro
        //        .CalculaValorComJurosCompostos(11937.28, 24, 4);
        //    Assert.Equal(valor, 30598.88);
        //}

        //[Fact]
        //public void Teste3JurosCompostos()
        //{
        //    double valor = CalculoFinanceiro
        //        .CalculaValorComJurosCompostos(15000, 36, 6);
        //    Assert.Equal(valor, 122208.78);
        //}



        //Data-Driven Unit Testing
        [Theory]
        [InlineData(10000, 12, 2, 12682.42)]
        [InlineData(11937.28, 24, 4, 30598.88)]
        [InlineData(15000, 36, 6, 122208.78)]
        [InlineData(20000, 36, 6, 162945.04)]
        [InlineData(25000, 48, 6, 409846.79)]
        public void TesteJurosCompostos(double valorEmprestimo, int numMeses, double percTaxa, double valorEsperado)
        {
            double valor = CalculoFinanceiro
                .CalculaValorComJurosCompostos(valorEmprestimo, numMeses, percTaxa);
            Assert.Equal(valor, valorEsperado);
        }
    }
}

