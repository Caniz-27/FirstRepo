namespace TestCalcolatrice
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestSomma()
        {
            CalcolatriceGitHub.Calcolatrice calcolatrice = new CalcolatriceGitHub.Calcolatrice();
            double risultato = calcolatrice.Somma(2, 3);
            Assert.AreEqual(5, risultato, 0.0001, "La somma di 2 e 3 dovrebbe essere 5.");
        }
        [TestMethod]
        public void TestSommaNegativa()
        {
            CalcolatriceGitHub.Calcolatrice calcolatrice = new CalcolatriceGitHub.Calcolatrice();
            double risultato = calcolatrice.Somma(-2, -3);
            Assert.AreEqual(-5, risultato, 0.0001, "La somma di -2 e -3 dovrebbe essere -5.");
        }
    }
}
