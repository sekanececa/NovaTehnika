namespace NovaTehnika
{
    partial class Proizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.comboBoxDobavljac = new System.Windows.Forms.ComboBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.groupBoxObradaProizvoda = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSifraProizvoda = new System.Windows.Forms.TextBox();
            this.buttonNadji = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonUkloni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxObradaProizvoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategorija";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dobavljac";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(106, 230);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(279, 20);
            this.textBoxNaziv.TabIndex = 5;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(106, 256);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 6;
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(106, 288);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(157, 21);
            this.comboBoxKategorija.TabIndex = 7;
            // 
            // comboBoxDobavljac
            // 
            this.comboBoxDobavljac.FormattingEnabled = true;
            this.comboBoxDobavljac.Location = new System.Drawing.Point(106, 315);
            this.comboBoxDobavljac.Name = "comboBoxDobavljac";
            this.comboBoxDobavljac.Size = new System.Drawing.Size(157, 21);
            this.comboBoxDobavljac.TabIndex = 8;
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(288, 288);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 9;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(288, 313);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 10;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            // 
            // groupBoxObradaProizvoda
            // 
            this.groupBoxObradaProizvoda.Controls.Add(this.buttonUkloni);
            this.groupBoxObradaProizvoda.Controls.Add(this.buttonIzmeni);
            this.groupBoxObradaProizvoda.Controls.Add(this.buttonNadji);
            this.groupBoxObradaProizvoda.Controls.Add(this.textBoxSifraProizvoda);
            this.groupBoxObradaProizvoda.Controls.Add(this.label5);
            this.groupBoxObradaProizvoda.Location = new System.Drawing.Point(12, 346);
            this.groupBoxObradaProizvoda.Name = "groupBoxObradaProizvoda";
            this.groupBoxObradaProizvoda.Size = new System.Drawing.Size(381, 86);
            this.groupBoxObradaProizvoda.TabIndex = 11;
            this.groupBoxObradaProizvoda.TabStop = false;
            this.groupBoxObradaProizvoda.Text = "Obrada proizvoda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sifra proizvoda";
            // 
            // textBoxSifraProizvoda
            // 
            this.textBoxSifraProizvoda.Location = new System.Drawing.Point(162, 42);
            this.textBoxSifraProizvoda.Name = "textBoxSifraProizvoda";
            this.textBoxSifraProizvoda.Size = new System.Drawing.Size(52, 20);
            this.textBoxSifraProizvoda.TabIndex = 1;
            // 
            // buttonNadji
            // 
            this.buttonNadji.Location = new System.Drawing.Point(220, 19);
            this.buttonNadji.Name = "buttonNadji";
            this.buttonNadji.Size = new System.Drawing.Size(75, 23);
            this.buttonNadji.TabIndex = 2;
            this.buttonNadji.Text = "Nadji";
            this.buttonNadji.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(301, 19);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 3;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.Location = new System.Drawing.Point(257, 52);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(75, 23);
            this.buttonUkloni.TabIndex = 4;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            // 
            // Proizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 444);
            this.Controls.Add(this.groupBoxObradaProizvoda);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.comboBoxDobavljac);
            this.Controls.Add(this.comboBoxKategorija);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Proizvodi";
            this.Text = "Proizvodi";
            this.Load += new System.EventHandler(this.Proizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxObradaProizvoda.ResumeLayout(false);
            this.groupBoxObradaProizvoda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.ComboBox comboBoxDobavljac;
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.GroupBox groupBoxObradaProizvoda;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonNadji;
        private System.Windows.Forms.TextBox textBoxSifraProizvoda;
        private System.Windows.Forms.Label label5;
    }
}