namespace NovaTehnika
{
    partial class FormPorudzbine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxZaposleni = new System.Windows.Forms.ComboBox();
            this.comboBoxKlijen = new System.Windows.Forms.ComboBox();
            this.comboBoxDostavljac = new System.Windows.Forms.ComboBox();
            this.comboBoxStanje = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDatumPorudzbine = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRokIsporuke = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUkloni = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonNadji = new System.Windows.Forms.Button();
            this.textBoxSifraPorudzbine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNovoStanje = new System.Windows.Forms.Button();
            this.buttonNoviKlijent = new System.Windows.Forms.Button();
            this.buttonUkoniStanje = new System.Windows.Forms.Button();
            this.buttonUkloniKlijenta = new System.Windows.Forms.Button();
            this.buttonIzmeniStanje = new System.Windows.Forms.Button();
            this.buttonIzmeniklijenta = new System.Windows.Forms.Button();
            this.buttonDetaljiPorudzbine = new System.Windows.Forms.Button();
            this.buttonUnos = new System.Windows.Forms.Button();
            this.Osvezi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposleni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klijent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dostavljac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stanje";
            // 
            // comboBoxZaposleni
            // 
            this.comboBoxZaposleni.FormattingEnabled = true;
            this.comboBoxZaposleni.Location = new System.Drawing.Point(124, 303);
            this.comboBoxZaposleni.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxZaposleni.Name = "comboBoxZaposleni";
            this.comboBoxZaposleni.Size = new System.Drawing.Size(241, 24);
            this.comboBoxZaposleni.TabIndex = 4;
            // 
            // comboBoxKlijen
            // 
            this.comboBoxKlijen.FormattingEnabled = true;
            this.comboBoxKlijen.Location = new System.Drawing.Point(124, 337);
            this.comboBoxKlijen.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxKlijen.Name = "comboBoxKlijen";
            this.comboBoxKlijen.Size = new System.Drawing.Size(241, 24);
            this.comboBoxKlijen.TabIndex = 5;
            // 
            // comboBoxDostavljac
            // 
            this.comboBoxDostavljac.FormattingEnabled = true;
            this.comboBoxDostavljac.Location = new System.Drawing.Point(124, 372);
            this.comboBoxDostavljac.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDostavljac.Name = "comboBoxDostavljac";
            this.comboBoxDostavljac.Size = new System.Drawing.Size(241, 24);
            this.comboBoxDostavljac.TabIndex = 6;
            // 
            // comboBoxStanje
            // 
            this.comboBoxStanje.FormattingEnabled = true;
            this.comboBoxStanje.Location = new System.Drawing.Point(124, 405);
            this.comboBoxStanje.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStanje.Name = "comboBoxStanje";
            this.comboBoxStanje.Size = new System.Drawing.Size(241, 24);
            this.comboBoxStanje.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum porudzbine";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rok isporuke";
            // 
            // dateTimePickerDatumPorudzbine
            // 
            this.dateTimePickerDatumPorudzbine.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDatumPorudzbine.Location = new System.Drawing.Point(587, 303);
            this.dateTimePickerDatumPorudzbine.Name = "dateTimePickerDatumPorudzbine";
            this.dateTimePickerDatumPorudzbine.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatumPorudzbine.TabIndex = 10;
            // 
            // dateTimePickerRokIsporuke
            // 
            this.dateTimePickerRokIsporuke.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRokIsporuke.Location = new System.Drawing.Point(587, 347);
            this.dateTimePickerRokIsporuke.Name = "dateTimePickerRokIsporuke";
            this.dateTimePickerRokIsporuke.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRokIsporuke.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUkloni);
            this.groupBox1.Controls.Add(this.buttonIzmeni);
            this.groupBox1.Controls.Add(this.buttonNadji);
            this.groupBox1.Controls.Add(this.textBoxSifraPorudzbine);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(430, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obrada porudzbine";
            // 
            // buttonUkloni
            // 
            this.buttonUkloni.Location = new System.Drawing.Point(398, 25);
            this.buttonUkloni.Name = "buttonUkloni";
            this.buttonUkloni.Size = new System.Drawing.Size(75, 23);
            this.buttonUkloni.TabIndex = 4;
            this.buttonUkloni.Text = "Ukloni";
            this.buttonUkloni.UseVisualStyleBackColor = true;
            this.buttonUkloni.Click += new System.EventHandler(this.buttonUkloni_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(317, 24);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 3;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonNadji
            // 
            this.buttonNadji.Location = new System.Drawing.Point(236, 24);
            this.buttonNadji.Name = "buttonNadji";
            this.buttonNadji.Size = new System.Drawing.Size(75, 23);
            this.buttonNadji.TabIndex = 2;
            this.buttonNadji.Text = "Nadji";
            this.buttonNadji.UseVisualStyleBackColor = true;
            this.buttonNadji.Click += new System.EventHandler(this.buttonNadji_Click);
            // 
            // textBoxSifraPorudzbine
            // 
            this.textBoxSifraPorudzbine.Location = new System.Drawing.Point(157, 26);
            this.textBoxSifraPorudzbine.Name = "textBoxSifraPorudzbine";
            this.textBoxSifraPorudzbine.Size = new System.Drawing.Size(59, 22);
            this.textBoxSifraPorudzbine.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sifra porudzbine";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNovoStanje);
            this.groupBox2.Controls.Add(this.buttonNoviKlijent);
            this.groupBox2.Controls.Add(this.buttonUkoniStanje);
            this.groupBox2.Controls.Add(this.buttonUkloniKlijenta);
            this.groupBox2.Controls.Add(this.buttonIzmeniStanje);
            this.groupBox2.Controls.Add(this.buttonIzmeniklijenta);
            this.groupBox2.Location = new System.Drawing.Point(21, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testiranje okidaca";
            // 
            // buttonNovoStanje
            // 
            this.buttonNovoStanje.Location = new System.Drawing.Point(518, 38);
            this.buttonNovoStanje.Name = "buttonNovoStanje";
            this.buttonNovoStanje.Size = new System.Drawing.Size(75, 46);
            this.buttonNovoStanje.TabIndex = 5;
            this.buttonNovoStanje.Text = "Novo stanje";
            this.buttonNovoStanje.UseVisualStyleBackColor = true;
            // 
            // buttonNoviKlijent
            // 
            this.buttonNoviKlijent.Location = new System.Drawing.Point(428, 38);
            this.buttonNoviKlijent.Name = "buttonNoviKlijent";
            this.buttonNoviKlijent.Size = new System.Drawing.Size(75, 46);
            this.buttonNoviKlijent.TabIndex = 4;
            this.buttonNoviKlijent.Text = "Novi klijent";
            this.buttonNoviKlijent.UseVisualStyleBackColor = true;
            // 
            // buttonUkoniStanje
            // 
            this.buttonUkoniStanje.Location = new System.Drawing.Point(305, 38);
            this.buttonUkoniStanje.Name = "buttonUkoniStanje";
            this.buttonUkoniStanje.Size = new System.Drawing.Size(75, 46);
            this.buttonUkoniStanje.TabIndex = 3;
            this.buttonUkoniStanje.Text = "Ukoni stanje";
            this.buttonUkoniStanje.UseVisualStyleBackColor = true;
            // 
            // buttonUkloniKlijenta
            // 
            this.buttonUkloniKlijenta.Location = new System.Drawing.Point(200, 38);
            this.buttonUkloniKlijenta.Name = "buttonUkloniKlijenta";
            this.buttonUkloniKlijenta.Size = new System.Drawing.Size(75, 46);
            this.buttonUkloniKlijenta.TabIndex = 2;
            this.buttonUkloniKlijenta.Text = "Ukloni klijenta";
            this.buttonUkloniKlijenta.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeniStanje
            // 
            this.buttonIzmeniStanje.Location = new System.Drawing.Point(103, 38);
            this.buttonIzmeniStanje.Name = "buttonIzmeniStanje";
            this.buttonIzmeniStanje.Size = new System.Drawing.Size(75, 46);
            this.buttonIzmeniStanje.TabIndex = 1;
            this.buttonIzmeniStanje.Text = "Izmeni stanje";
            this.buttonIzmeniStanje.UseVisualStyleBackColor = true;
            // 
            // buttonIzmeniklijenta
            // 
            this.buttonIzmeniklijenta.Location = new System.Drawing.Point(6, 38);
            this.buttonIzmeniklijenta.Name = "buttonIzmeniklijenta";
            this.buttonIzmeniklijenta.Size = new System.Drawing.Size(75, 46);
            this.buttonIzmeniklijenta.TabIndex = 0;
            this.buttonIzmeniklijenta.Text = "Izmeni klijenta";
            this.buttonIzmeniklijenta.UseVisualStyleBackColor = true;
            // 
            // buttonDetaljiPorudzbine
            // 
            this.buttonDetaljiPorudzbine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetaljiPorudzbine.Location = new System.Drawing.Point(678, 477);
            this.buttonDetaljiPorudzbine.Name = "buttonDetaljiPorudzbine";
            this.buttonDetaljiPorudzbine.Size = new System.Drawing.Size(239, 36);
            this.buttonDetaljiPorudzbine.TabIndex = 14;
            this.buttonDetaljiPorudzbine.Text = "Detalji porudzbine";
            this.buttonDetaljiPorudzbine.UseVisualStyleBackColor = true;
            this.buttonDetaljiPorudzbine.Click += new System.EventHandler(this.buttonDetaljiPorudzbine_Click);
            // 
            // buttonUnos
            // 
            this.buttonUnos.Location = new System.Drawing.Point(678, 524);
            this.buttonUnos.Name = "buttonUnos";
            this.buttonUnos.Size = new System.Drawing.Size(109, 40);
            this.buttonUnos.TabIndex = 15;
            this.buttonUnos.Text = "Unos";
            this.buttonUnos.UseVisualStyleBackColor = true;
            this.buttonUnos.Click += new System.EventHandler(this.buttonUnos_Click);
            // 
            // Osvezi
            // 
            this.Osvezi.Location = new System.Drawing.Point(802, 525);
            this.Osvezi.Name = "Osvezi";
            this.Osvezi.Size = new System.Drawing.Size(101, 39);
            this.Osvezi.TabIndex = 16;
            this.Osvezi.Text = "Osvezi";
            this.Osvezi.UseVisualStyleBackColor = true;
            this.Osvezi.Click += new System.EventHandler(this.Osvezi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(913, 272);
            this.dataGridView1.TabIndex = 17;
            // 
            // FormPorudzbine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Osvezi);
            this.Controls.Add(this.buttonUnos);
            this.Controls.Add(this.buttonDetaljiPorudzbine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerRokIsporuke);
            this.Controls.Add(this.dateTimePickerDatumPorudzbine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxStanje);
            this.Controls.Add(this.comboBoxDostavljac);
            this.Controls.Add(this.comboBoxKlijen);
            this.Controls.Add(this.comboBoxZaposleni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPorudzbine";
            this.Text = "Porudzbine";
            this.Load += new System.EventHandler(this.FormPorudzbine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxZaposleni;
        private System.Windows.Forms.ComboBox comboBoxKlijen;
        private System.Windows.Forms.ComboBox comboBoxDostavljac;
        private System.Windows.Forms.ComboBox comboBoxStanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumPorudzbine;
        private System.Windows.Forms.DateTimePicker dateTimePickerRokIsporuke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUkloni;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonNadji;
        private System.Windows.Forms.TextBox textBoxSifraPorudzbine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonNovoStanje;
        private System.Windows.Forms.Button buttonNoviKlijent;
        private System.Windows.Forms.Button buttonUkoniStanje;
        private System.Windows.Forms.Button buttonUkloniKlijenta;
        private System.Windows.Forms.Button buttonIzmeniStanje;
        private System.Windows.Forms.Button buttonIzmeniklijenta;
        private System.Windows.Forms.Button buttonDetaljiPorudzbine;
        private System.Windows.Forms.Button buttonUnos;
        private System.Windows.Forms.Button Osvezi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}