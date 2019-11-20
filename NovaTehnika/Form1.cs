using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaTehnika
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKategorijaProizvoda_Click(object sender, EventArgs e)
        {

        }

        private void buttonDostavljaci_Click(object sender, EventArgs e)
        {

        }

        private void buttonPorudzbine_Click(object sender, EventArgs e)
        {
            FormPorudzbine formPorudzbine = new FormPorudzbine();
            formPorudzbine.ShowDialog();
        }

        private void buttonStanjePorudzbine_Click(object sender, EventArgs e)
        {

        }

        private void buttonProizvod_Click(object sender, EventArgs e)
        {
            Proizvodi formProizvod = new Proizvodi();
            formProizvod.ShowDialog();
        }
    }
}
