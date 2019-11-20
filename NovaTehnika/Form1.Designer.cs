namespace NovaTehnika
{
    partial class Form1
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
            this.buttonKategorijaProizvoda = new System.Windows.Forms.Button();
            this.buttonDostavljaci = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxProcedure = new System.Windows.Forms.GroupBox();
            this.buttonProizvod = new System.Windows.Forms.Button();
            this.buttonStanjePorudzbine = new System.Windows.Forms.Button();
            this.groupBoxOkidaci = new System.Windows.Forms.GroupBox();
            this.buttonPorudzbine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxProcedure.SuspendLayout();
            this.groupBoxOkidaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Tehnika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lanac snabdevanja";
            // 
            // buttonKategorijaProizvoda
            // 
            this.buttonKategorijaProizvoda.Location = new System.Drawing.Point(6, 39);
            this.buttonKategorijaProizvoda.Name = "buttonKategorijaProizvoda";
            this.buttonKategorijaProizvoda.Size = new System.Drawing.Size(105, 34);
            this.buttonKategorijaProizvoda.TabIndex = 3;
            this.buttonKategorijaProizvoda.Text = "Kategorija proizvoda";
            this.buttonKategorijaProizvoda.UseVisualStyleBackColor = true;
            this.buttonKategorijaProizvoda.Click += new System.EventHandler(this.buttonKategorijaProizvoda_Click);
            // 
            // buttonDostavljaci
            // 
            this.buttonDostavljaci.Location = new System.Drawing.Point(140, 39);
            this.buttonDostavljaci.Name = "buttonDostavljaci";
            this.buttonDostavljaci.Size = new System.Drawing.Size(102, 34);
            this.buttonDostavljaci.TabIndex = 4;
            this.buttonDostavljaci.Text = "Dostavljaci";
            this.buttonDostavljaci.UseVisualStyleBackColor = true;
            this.buttonDostavljaci.Click += new System.EventHandler(this.buttonDostavljaci_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonKategorijaProizvoda);
            this.groupBox1.Controls.Add(this.buttonDostavljaci);
            this.groupBox1.Location = new System.Drawing.Point(66, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 105);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diskonektovana arhitektura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxProcedure);
            this.groupBox2.Controls.Add(this.groupBoxOkidaci);
            this.groupBox2.Location = new System.Drawing.Point(30, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 118);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Konektovana arhitektura";
            // 
            // groupBoxProcedure
            // 
            this.groupBoxProcedure.Controls.Add(this.buttonProizvod);
            this.groupBoxProcedure.Controls.Add(this.buttonStanjePorudzbine);
            this.groupBoxProcedure.Location = new System.Drawing.Point(140, 20);
            this.groupBoxProcedure.Name = "groupBoxProcedure";
            this.groupBoxProcedure.Size = new System.Drawing.Size(182, 81);
            this.groupBoxProcedure.TabIndex = 1;
            this.groupBoxProcedure.TabStop = false;
            this.groupBoxProcedure.Text = "Procedure";
            // 
            // buttonProizvod
            // 
            this.buttonProizvod.Location = new System.Drawing.Point(101, 23);
            this.buttonProizvod.Name = "buttonProizvod";
            this.buttonProizvod.Size = new System.Drawing.Size(75, 42);
            this.buttonProizvod.TabIndex = 1;
            this.buttonProizvod.Text = "Proizvodi";
            this.buttonProizvod.UseVisualStyleBackColor = true;
            this.buttonProizvod.Click += new System.EventHandler(this.buttonProizvod_Click);
            // 
            // buttonStanjePorudzbine
            // 
            this.buttonStanjePorudzbine.Location = new System.Drawing.Point(6, 23);
            this.buttonStanjePorudzbine.Name = "buttonStanjePorudzbine";
            this.buttonStanjePorudzbine.Size = new System.Drawing.Size(75, 42);
            this.buttonStanjePorudzbine.TabIndex = 0;
            this.buttonStanjePorudzbine.Text = "Stanje porudzbine";
            this.buttonStanjePorudzbine.UseVisualStyleBackColor = true;
            this.buttonStanjePorudzbine.Click += new System.EventHandler(this.buttonStanjePorudzbine_Click);
            // 
            // groupBoxOkidaci
            // 
            this.groupBoxOkidaci.Controls.Add(this.buttonPorudzbine);
            this.groupBoxOkidaci.Location = new System.Drawing.Point(7, 20);
            this.groupBoxOkidaci.Name = "groupBoxOkidaci";
            this.groupBoxOkidaci.Size = new System.Drawing.Size(126, 81);
            this.groupBoxOkidaci.TabIndex = 0;
            this.groupBoxOkidaci.TabStop = false;
            this.groupBoxOkidaci.Text = "Okidaci";
            // 
            // buttonPorudzbine
            // 
            this.buttonPorudzbine.Location = new System.Drawing.Point(21, 23);
            this.buttonPorudzbine.Name = "buttonPorudzbine";
            this.buttonPorudzbine.Size = new System.Drawing.Size(83, 42);
            this.buttonPorudzbine.TabIndex = 0;
            this.buttonPorudzbine.Text = "Porudzbine";
            this.buttonPorudzbine.UseVisualStyleBackColor = true;
            this.buttonPorudzbine.Click += new System.EventHandler(this.buttonPorudzbine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nova Tehnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBoxProcedure.ResumeLayout(false);
            this.groupBoxOkidaci.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKategorijaProizvoda;
        private System.Windows.Forms.Button buttonDostavljaci;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxProcedure;
        private System.Windows.Forms.Button buttonProizvod;
        private System.Windows.Forms.Button buttonStanjePorudzbine;
        private System.Windows.Forms.GroupBox groupBoxOkidaci;
        private System.Windows.Forms.Button buttonPorudzbine;
    }
}

