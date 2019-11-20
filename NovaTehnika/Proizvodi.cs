using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NovaTehnika
{
    public partial class Proizvodi : Form
    {
        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public Proizvodi()
        {
            InitializeComponent();
            KonekcioniString = ConfigurationManager.ConnectionStrings["NovaTehnikaConnectionString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);
        }
        private void OsveziEkran()
        {
            using (Konekcija=new SqlConnection(KonekcioniString))
            {
                string KomandaTabele = "SELECT Proizvod.SifraProizvoda as [ID], Proizvod.NazivProizvoda as [Naziv proizvoda], Proizvod.Cena as [Cena], Kategorija.NazivKategorije as [Kategorija], Dobavljaci.NazivKompanije as [Dobavljac] from Proizvod INNER JOIN Kategorija ON Proizvod.SifraKategorije = Kategorija.SifraKategorije INNER JOIN Dobavljaci on Proizvod.SifraDobavljaca = Dobavljaci.SifraDobavljaca";
                Komanda = new SqlCommand(KomandaTabele, Konekcija);
                Konekcija.Open();
                SqlDataReader Reader = Komanda.ExecuteReader();
                if (Reader.HasRows)
                {
                    DataTable Tabela = new DataTable();
                    Tabela.Load(Reader);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.DataSource = Tabela;

                }
            }
        }
        private void Proizvodi_Load(object sender, EventArgs e)
        {
            OsveziEkran();
        }
    }
}
