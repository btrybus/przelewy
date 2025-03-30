using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WzajemneWykluczanie
{
    class Konto
    {
        public double Stan { get; private set; }

        public string HistoriaOperacji { get; private set; } = string.Empty;

        public Konto(double stan)
        {
            this.Stan = stan;
        }

        public void RobWieleWyplat()
        {
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                Wyplata(r.Next(1, 10));
            }

        }


        public bool Wyplata(double kwota)
        {
           {
  
                if (Stan < 0.0)
                {
                    DodajDoHistorii($"Przed: {Stan}, Debet, Odrzucono !");

                    return false;
                }
                else
                {
                    {
                        if (Stan >= kwota)
                        {                            
                            string info = $"Przed: {Stan}, Po: {Stan-kwota}, Sukces !";
                            DodajDoHistorii(info);

                            Stan = Stan - kwota;

                            return true;

                        }
                        else
                        {  
                            DodajDoHistorii($"Przed: {Stan}, Po: {Stan - kwota}, Odrzucono !");

                            return false;
                        }
                    }
                }

            }


        }

        private void DodajDoHistorii(string info)
        {
            StringBuilder sb = new StringBuilder(HistoriaOperacji);
            int ktoryWpis = HistoriaOperacji.Split('\r').Count();
            sb.Append(ktoryWpis);
            sb.Append(" ");
            sb.Append(Thread.CurrentThread.Name);
            sb.Append(" ");
            sb.Append(info);
            sb.Append("\r\n");
            HistoriaOperacji = sb.ToString();
        }
    }
}
