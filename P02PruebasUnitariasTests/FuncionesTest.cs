using Microsoft.VisualStudio.TestTools.UnitTesting;
using P02_PruebasUnitarias;

namespace P02PruebasUnitariasTests
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-3, -1L)]
        [DataRow(0, 1L)]
        [DataRow(1, 1L)]
        [DataRow(5, 120L)]
        public void CalcularFactorial_DevuelveResultadoEsperado(int n, long esperado)
        {
            Assert.AreEqual(esperado, Funciones.CalcularFactorial(n));
        }

        [TestMethod]
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("abc#123", false)]
        [DataRow("abcdefgh", false)]
        [DataRow("abc#1234", true)]
        public void EsContrasenyaValida_DevuelveResultadoEsperado(string? contrasenya, bool esperado)
        {
            Assert.AreEqual(esperado, Funciones.EsContrasenyaValida(contrasenya));
        }
    }
}
