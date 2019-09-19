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
        static Random rnd = new Random();
        public List<Lama> lamak;

        public FrmMain()
        {
            InitializeComponent();

            tbNev.TextChanged += TbkTextChanged;
            tbEv.TextChanged += TbkTextChanged;
            tbIz.TextChanged += TbkTextChanged;

            this.BackColor = Color.FromArgb(
                rnd.Next(256),
                rnd.Next(256),
                rnd.Next(256));

            lamak = new List<Lama>();
            ListaFeltolt();
            CbFeltolt();


        }

        private void TbkTextChanged(object sender, EventArgs e)
        {
            btnUjLama.Enabled =
                tbNev.Text.Length != 0 &&
                tbEv.Text.Length != 0 &&
                tbIz.Text.Length != 0;
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

        private void CbNevek_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSzulEv.ForeColor = 
                (lamak[cbNevek.SelectedIndex].Iz == "édes")
                ? Color.Pink : Color.LightBlue;
            /*
            if (lamak[cbNevek.SelectedIndex].Iz == "édes")
                lblSzulEv.ForeColor = Color.Pink;
            else lblSzulEv.ForeColor = Color.LightBlue;
            */

            lblSzulEv.Text = lamak[cbNevek.SelectedIndex].SzulEv + "";
        }

        private void BtnUjLama_Click(object sender, EventArgs e)
        {
            if (cbNevek.Items.Contains(tbNev.Text))
                MessageBox.Show("Nár van ilyen név!");
            else if (!int.TryParse(tbEv.Text, out int ev))
                MessageBox.Show("nem szám");
            else if (tbIz.Text != "édes" && tbIz.Text != "sós")
                MessageBox.Show("nem jó íz");
            else
            {
                var sw = new StreamWriter(@"lama.txt", true, Encoding.UTF8);
                sw.WriteLine($"{tbNev.Text};{tbEv.Text};{tbIz.Text}");
                MessageBox.Show("rögzítve!");
                sw.Close();
                Application.Restart();
            }
        }
    }
}
