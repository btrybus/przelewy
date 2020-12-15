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

        double stan;
        string listaPrzelewow = string.Empty;

        public double Stan { get { return stan; } private set { stan = value; } }
        public string ListaPrzelewow { get { return listaPrzelewow; } }

        public Konto(double stan)
        {
            this.stan = stan;
        }

        public void Przelewy()
        {
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                Przelew(r.Next(1, 10));
            }

        }
        bool Przelew(double kwota)
        {
             {
  
                if (Stan < 0.0)
                {
                    string info = string.Format("Przed: {0}, Debet !", Stan);
                    DodajDoListy(info);

                    return false;
                }
                else
                {
                    {
                        if (Stan >= kwota)
                        {                            
                            string info = string.Format("Przed: {0}, Po: {1}", Stan, Stan - kwota);
                            DodajDoListy(info);

                            Stan = Stan - kwota;

                            return true;

                        }
                        else
                        {
                            string info = string.Format("Przed: {0}, Po: {1}, Odrzucono !", Stan, Stan - kwota);
                            DodajDoListy(info);

                            return false;
                        }
                    }
                }

            }

        }

        void DodajDoListy(string info)
        {
            StringBuilder sb = new StringBuilder(listaPrzelewow);
            int ktoryWpis = listaPrzelewow.Split('\r').Count();
            sb.Append(ktoryWpis);
            sb.Append(" ");
            sb.Append(Thread.CurrentThread.Name);
            sb.Append(" ");
            sb.Append(info);
            sb.Append("\r\n");
            listaPrzelewow = sb.ToString();
        }
    }
}
