using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WzajemneWykluczanie
{
    public partial class Form1 : Form
    {
        Konto oKonto;
        List<Thread> watki = new List<Thread>();

        public Form1()
        {
            InitializeComponent();          
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bStart.Enabled = false;

            watki.Clear();

            oKonto = new Konto(1000);

            for (int i = 1; i <= numIleWatkow.Value; i++)
            {
                Thread oThread1 = new Thread(new ThreadStart(() => oKonto.Przelewy()));
                oThread1.Name = string.Format("Klient {0}", i);
                watki.Add(oThread1);
            }

            foreach(var t in watki)
            {
                t.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (oKonto != null)
            {
                txtWyniki.Text = oKonto.ListaPrzelewow;
                txtStan.Text = oKonto.Stan.ToString();
            }

            int ileDziala = 0;

            foreach (var w in watki)
            {
                if (w.IsAlive)
                    ileDziala++;
            }

            int ileWynikow = txtWyniki.Text.Split('\r').Count() - 1;

            txtPracuje.Text = ileDziala.ToString();

            bStart.Enabled = (ileDziala == 0);

            this.Refresh();
        }
    }


  

}
