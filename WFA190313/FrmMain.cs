using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA190313
{
    public partial class FrmMain : Form
    {
        public List<Lama> lamak;

        public FrmMain()
        {
            InitializeComponent();
            lamak = new List<Lama>();
            ListaFeltolt();
            CbFeltolt();


        }

        private void CbFeltolt()
        {
            foreach (var l in lamak)
            {
                cbNevek.Items.Add(l.Nev);
            }
        }

        private void ListaFeltolt()
        {
            var sr = new StreamReader(@"lama.txt", Encoding.UTF8);

            while (!sr.EndOfStream)
            {
                lamak.Add(new Lama(sr.ReadLine()));
            }
            sr.Close();
        }
    }
}
