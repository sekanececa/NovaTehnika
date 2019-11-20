using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
namespace NovaTehnika
{
    public partial class FormPorudzbine : Form
    {

        string KonekcioniString;
        SqlConnection Konekcija;
        SqlCommand Komanda;

        public FormPorudzbine()
        {
            InitializeComponent();
            KonekcioniString = ConfigurationManager.ConnectionStrings["NovaTehnikaConnectionString"].ConnectionString;
            Konekcija = new SqlConnection(KonekcioniString);

        }
        

        private void OsveziEkran()
        {

            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                string KomandaTabele = "SELECT Porudzbina.SifraPorudzbine AS [ID],Klijent.NazivKompanije AS [Klijent], Porudzbina.DatumPorudzbine AS [Datum porudzbine], Porudzbina.RokIsporuke AS [Rok isporuke], StanjePorudzbine.NazivStanja AS [Stanje], Dostavljac.NazivKompanije AS [Dostavljac], Zaposleni.NazivZaposlenog AS [Zapsoleni] FROM Porudzbina INNER JOIN Zaposleni ON Zaposleni.SifraZaposlenog=Porudzbina.SifraZaposlenog INNER JOIN Klijent ON Klijent.SifraKlijenta=Porudzbina.SifraKlijenta INNER JOIN Dostavljac ON Dostavljac.SifraDostavljaca=Porudzbina.SifraDostavljaca INNER JOIN StanjePorudzbine ON StanjePorudzbine.SifraStanja=Porudzbina.SifraStanja ";

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
        public void UcitajZaposlene()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraZaposlenog, NazivZaposlenog FROM Zaposleni";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query,Konekcija);
                    DataSet setZaposleni = new DataSet();
                    Adapter.Fill(setZaposleni, "Zaposleni");
                    comboBoxZaposleni.DisplayMember = "NazivZaposlenog";
                    comboBoxZaposleni.ValueMember = "SifraZaposlenog";
                    comboBoxZaposleni.DataSource = setZaposleni.Tables["Zaposleni"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UcitajKlijente()
        {
            using (Konekcija=new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SIfraKlijenta, NazivKompanije FROM Klijent";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setKlijent = new DataSet();
                    Adapter.Fill(setKlijent, "Klijent");
                    comboBoxKlijen.DisplayMember = "NazivKompanije";
                    comboBoxKlijen.ValueMember = "SifraKlijenta";
                    comboBoxKlijen.DataSource = setKlijent.Tables["Klijent"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void UcitajDostavljaca()
        {
            using (Konekcija=new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraDostavljaca, NazivKompanije FROM Dostavljac";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query, Konekcija);
                    DataSet setDostavljac = new DataSet();
                    Adapter.Fill(setDostavljac, "Dostavljac");
                    comboBoxDostavljac.DisplayMember = "NazivKompanije";
                    comboBoxDostavljac.ValueMember = "SifraDostavljaca";
                    comboBoxDostavljac.DataSource = setDostavljac.Tables["Dostavljac"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UcitajStanja()
        {
            using (Konekcija = new SqlConnection(KonekcioniString))
            {
                try
                {
                    string Query = "SELECT SifraStanja, NazivStanja FROM StanjePorudzbine";
                    SqlDataAdapter Adapter = new SqlDataAdapter(Query,Konekcija);
                    DataSet setStanje = new DataSet();
                    Adapter.Fill(setStanje,"Stanje");
                    comboBoxStanje.DisplayMember = "NazivStanja";
                    comboBoxStanje.ValueMember = "SifraStanja";
                    comboBoxStanje.DataSource = setStanje.Tables["Stanje"];
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void FormPorudzbine_Load(object sender, EventArgs e)
        {
            OsveziEkran();
            UcitajZaposlene();
            UcitajKlijente();
            UcitajDostavljaca();
            UcitajStanja();
        }

       

        private void buttonDetaljiPorudzbine_Click(object sender, EventArgs e)
        {
            if (textBoxSifraPorudzbine.Text=="")
            {
                MessageBox.Show("Polje 'Sifra porudzbine' je prazno - unesite sifru porudzbine.");
            }
            else
            {
                FormDetaljiPorudzbine formDetaljiPorudzbine = new FormDetaljiPorudzbine();
                formDetaljiPorudzbine.ShowDialog();
            }
           
        }

        private void buttonUnos_Click(object sender, EventArgs e)
        {
            using (Konekcija=new SqlConnection(KonekcioniString))
            {
                SqlCommand Komanda = new SqlCommand("insert into Porudzbina(DatumPorudzbine, RokIsporuke, SifraKlijenta, SifraStanja, SifraZaposlenog, SifraDostavljaca, NazivKlijenta, StanjePorudzbine) values('" + dateTimePickerDatumPorudzbine.Text + "', '" + dateTimePickerRokIsporuke.Text + "', '" + comboBoxKlijen.SelectedValue + "', '" + comboBoxStanje.SelectedValue + "', '" + comboBoxZaposleni.SelectedValue + "', '" + comboBoxDostavljac.SelectedValue + "', '" + comboBoxKlijen.Text + "', '" + comboBoxStanje.Text + "');", Konekcija);

                Konekcija.Open();
                try
                {
                    Komanda.ExecuteNonQuery();
                    MessageBox.Show("Porudzbina je uspesno uneta.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Nastala je greska - " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OsveziEkran();
                    Konekcija.Close();
                }
            }
        }

        private void Osvezi_Click(object sender, EventArgs e)
        {
            comboBoxDostavljac.SelectedItem = 0;
            comboBoxKlijen.SelectedItem = 0;
            comboBoxStanje.SelectedItem = 0;
            comboBoxZaposleni.SelectedItem = 0;
            dateTimePickerDatumPorudzbine.Text = DateTime.Now.ToString();
            dateTimePickerRokIsporuke.Text = DateTime.Now.ToString();
            textBoxSifraPorudzbine.Text = "";
            OsveziEkran();
        }

        private void buttonNadji_Click(object sender, EventArgs e)
        {
            if (textBoxSifraPorudzbine.Text=="")
            {
                MessageBox.Show("Polje 'Sifra porudzbine' je prazno - unesite sifru porudzbine.");
            }
            else
            {
                using (Konekcija= new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(textBoxSifraPorudzbine.Text), Konekcija);

                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();
                        if (Reader.Read())
                        {
                            dateTimePickerDatumPorudzbine.Text = Reader[1].ToString();
                            dateTimePickerRokIsporuke.Text = Reader[2].ToString();
                            comboBoxKlijen.SelectedValue = Reader[3];
                            comboBoxStanje.SelectedValue = Reader[4];
                            comboBoxZaposleni.SelectedValue = Reader[5];
                            comboBoxDostavljac.SelectedValue = Reader[6];
                        }
                        else
                        {
                            MessageBox.Show("Porudzbina sa zadatom sifrom nije pronadjena.");
                        }
                        Reader.Close();
                        textBoxSifraPorudzbine.Focus();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Dogodila se greska - " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                        OsveziEkran();
                    }
                }
            }
        }

        private void buttonUkloni_Click(object sender, EventArgs e)
        {
          
            if (textBoxSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'Sifra porudzbine' je prazno - unesite sifru porudzbine.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(textBoxSifraPorudzbine.Text),Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Reader = Komanda.ExecuteReader();
                        if (Reader.Read())
                        {


                            Reader.Close();
                            var PotvrdiUklanjanje = MessageBox.Show("Potvrdite uklanjanje porudzbine " + textBoxSifraPorudzbine.Text + ".", "Potvrdite uklanjanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            if (PotvrdiUklanjanje == DialogResult.OK)
                            {
                                SqlCommand KomandaStavke = new SqlCommand("DELETE FROM StavkaPorudzbine WHERE SifraPorudzbine = " + int.Parse(textBoxSifraPorudzbine.Text), Konekcija);
                                Komanda = new SqlCommand("DELETE FROM Porudzbina WHERE SifraPorudzbine =" + int.Parse(textBoxSifraPorudzbine.Text), Konekcija);
                                try
                                {
                                    KomandaStavke.ExecuteNonQuery();
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Porudzbina je uspesno uklonjena.", "Uklanjanje porudzbine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Doslo je do greske - " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Porudzbina sa zadatom sifrom nije pronadjena.");
                            textBoxSifraPorudzbine.Text = "";
                            textBoxSifraPorudzbine.Focus();

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Doslo je do greske - " + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                        OsveziEkran();

                    }
                }
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (textBoxSifraPorudzbine.Text == "")
            {
                MessageBox.Show("Polje 'Sifra porudzbine' je prazno - unesite sifru porudzbine.");
            }
            else
            {
                using (Konekcija = new SqlConnection(KonekcioniString))
                {
                    SqlCommand Komanda = new SqlCommand("SELECT * FROM Porudzbina WHERE SifraPorudzbine = " + int.Parse(textBoxSifraPorudzbine.Text), Konekcija);
                    Konekcija.Open();
                    try
                    {
                        SqlDataReader Readre = Komanda.ExecuteReader();
                        if (Readre.Read())
                        {
                            Readre.Close();
                            var PotvrdiIzmenu = MessageBox.Show("Potvrdite izmenu porudzbine " + textBoxSifraPorudzbine.Text + ".", "Potvrdite izmenu", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                            if (PotvrdiIzmenu == DialogResult.OK)
                            {
                                Komanda = new SqlCommand("UPDATE Porudzbina SET DatumPorudzbine ='" + dateTimePickerDatumPorudzbine.Text + "', RokIsporuke = '" + dateTimePickerRokIsporuke.Text + "', SifraKlijenta ='" + comboBoxKlijen.SelectedValue + "', SifraStanja ='" + comboBoxStanje.SelectedValue + "', SifraZaposlenog ='" + comboBoxZaposleni.SelectedValue + "', SifraDostavljaca ='" + comboBoxDostavljac.SelectedValue + "', NazivKlijenta ='" + comboBoxKlijen.Text + "', StanjePorudzbine ='" + comboBoxStanje.Text + "'WHERE SifraPorudzbine ='" + int.Parse(textBoxSifraPorudzbine.Text) + ";", Konekcija);
                                // UPDATE Porudzbina SET  SifraKlijenta = 1, SifraStanja = 2, SifraZaposlenog = 1, SifraDostavljaca = 1, NazivKlijenta ='Nemanja Kojic', StanjePorudzbine ='Otkazano' WHERE SifraPorudzbine =7;



                                try
                                {
                                    Komanda.ExecuteNonQuery();
                                    MessageBox.Show("Porudzbina je uspesno izmenjena.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Dogodila se greska -" + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Porudzbina sa zadatom sifrom nije pronadjena.");
                            textBoxSifraPorudzbine.Text = "";
                            textBoxSifraPorudzbine.Focus();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Dogodila se greska -" + ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Konekcija.Close();
                        OsveziEkran();
                    }
                }
            }

        }
    }
 }

