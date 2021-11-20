using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGeldautomat
{
    /// <summary>
    /// KundenKonto Klasse.
    /// </summary>
    public class Konto
    {
        private readonly string m_kundenNummer;
        private readonly string m_kundenName;
        private double m_saldo;
        public Konto(string pKundenName, double pSaldo)
        {
            pKundenName = String.Concat(pKundenName.Where(c => !Char.IsWhiteSpace(c)));

            int querSummeKundenName = 0;
            foreach (Char c in pKundenName)
            {
                querSummeKundenName += ((short)c);
            }

            string generiereKundenNummer = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}",
                            DateTime.Now.Year.ToString("D4"),
                            DateTime.Now.Month.ToString("D2"),
                            DateTime.Now.Day.ToString("D2"),
                            DateTime.Now.Hour.ToString("D2"),
                            DateTime.Now.Minute.ToString("D2"),
                            DateTime.Now.Second.ToString("D2"),
                            DateTime.Now.Millisecond.ToString("D3"),
                            querSummeKundenName);

            m_kundenNummer = generiereKundenNummer;
            m_kundenName = pKundenName;
            m_saldo = pSaldo;
        }

        public string KundenNummer
        {
            get { return m_kundenNummer; }
        }
        public string KundenName
        {
            get { return m_kundenName; }
        }
        public double Saldo
        {
            get { return m_saldo; }
        }
        public void GeldAbbuchen(double pBetrag) // "Auszahlung"
        {
            if (pBetrag > m_saldo)
            {
                throw new ArgumentOutOfRangeException("Betrag größer Saldo!");
            }
            if (pBetrag < 0)
            {
                throw new ArgumentOutOfRangeException("Betrag negativ!");
            }
            m_saldo -= pBetrag;
        }
        public void GeldVerbuchen(double pBetrag) // "Einzahlung"
        {
            if (pBetrag < 0)
            {
                throw new ArgumentOutOfRangeException("Betrag negativ!");
            }
            m_saldo += pBetrag;
        }
    }

}
