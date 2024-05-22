using SistemaFinanceiro.Model;

namespace TesteSistemaFinanceiro


{
    [TestClass]
    public class ContaTeste
    {
        [TestMethod]
        public void DepositarSucesso()
        {
            var conta1 = new Conta(123,100);

            conta1.deposito(100);

            Assert.AreEqual(200, conta1.Saldo);
        }

        [TestMethod]
        public void SacarSucesso()
        {
            var conta1 = new Conta(123, 100);

            conta1.saque(100);

            Assert.AreEqual(0, conta1.Saldo);
        }
    }
}