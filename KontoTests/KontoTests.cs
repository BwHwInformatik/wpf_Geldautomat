using NUnit.Framework;
using WpfGeldautomat;

namespace KontoTests
{
    public class KontoTests
    {
        [SetUp]
        public void Setup()
        {
            //Setup-Methode wird vor jedem Test ausgeführt !
        }

        [Test]
        public void Test1()
        {
            Assert.Pass("Test1 fail");
        }

        [Test]
        public void GeldVerbuchen_GueltigerBetrag_AktualisiertSaldo()
        {
            // Arrange (Arrangieren)
            double startSaldo = 12.34;
            double verbuchungBetrag = 5.55;
            double erwarteterSaldo = 17.89;
            Konto testKonto = new Konto("Max Testermann", startSaldo);

            // Act (Agieren)
            testKonto.GeldVerbuchen(verbuchungBetrag);

            // Assert (Feststellen)
            double aktuellerSaldo = testKonto.Saldo;
            Assert.AreEqual(erwarteterSaldo, aktuellerSaldo, 0.0001, "Saldo nicht korrekt !");
        }

        [Test]
        public void GeldVerbuchen_BetragNegativ_ExceptionAusloesen()
        {
            // Arrange (Arrangieren)
            double startSaldo = 123.345;
            double verbuchungBetrag = -225.77;
            Konto testKonto = new Konto("Max Testermann", startSaldo);

            // Act
            try
            {
                testKonto.GeldAbbuchen(verbuchungBetrag);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains("Betrag negativ!", e.Message);
                return;
            }
            Assert.Fail("Erwartete Exception nicht ausgelöst.");
        }

        [Test]
        public void GeldAbbuchen_GueltigerBetrag_AktualisiertSaldo()
        {
            // Arrange (Arrangieren)
            double startSaldo = 12.34;
            double abbuchungBetrag = 2.34;
            double erwarteterSaldo = 10.00;
            Konto testKonto = new Konto("Max Testermann", startSaldo);

            // Act (Agieren)
            testKonto.GeldAbbuchen(abbuchungBetrag);

            // Assert (Feststellen)
            double aktuellerSaldo = testKonto.Saldo;
            Assert.AreEqual(erwarteterSaldo, aktuellerSaldo, 0.0001, "Saldo nicht korrekt !");
        }

        [Test]
        public void GeldAbbuchen_BetragGroesserSaldo_ExceptionAusloesen()
        {
            // Arrange (Arrangieren)
            double startSaldo = 12.34;
            double abbuchungBetrag = 15.55;
            Konto testKonto = new Konto("Max Testermann", startSaldo);

            // Act
            try
            {
                testKonto.GeldAbbuchen(abbuchungBetrag);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains("Betrag größer Saldo!", e.Message);
                return;
            }
            Assert.Fail("Erwartete Exception nicht ausgelöst.");
        }
        [Test]
        public void GeldAbbuchen_BetragNegativ_ExceptionAusloesen()
        {
            // Arrange (Arrangieren)
            double startSaldo = 123.345;
            double abbuchungBetrag = -225.77;
            Konto testKonto = new Konto("Max Testermann", startSaldo);

            // Act
            try
            {
                testKonto.GeldAbbuchen(abbuchungBetrag);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains("Betrag negativ!", e.Message);
                return;
            }
            Assert.Fail("Erwartete Exception nicht ausgelöst.");
        }
    }
}