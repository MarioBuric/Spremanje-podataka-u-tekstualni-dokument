namespace AsistentGUI
{
    partial class KreiranjeTurnira
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
            this.lblKotizacija = new System.Windows.Forms.Label();
            this.lblNazivTima = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNapraviTim = new System.Windows.Forms.Button();
            this.btnUcitajTim = new System.Windows.Forms.Button();
            this.lblListaTimova = new System.Windows.Forms.Label();
            this.lstListaTimova = new System.Windows.Forms.ListBox();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lblNagrada = new System.Windows.Forms.Label();
            this.lstNagrada = new System.Windows.Forms.ListBox();
            this.btnUrediNagradu = new System.Windows.Forms.Button();
            this.btnIzbrisiNagradu = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKotizacija
            // 
            this.lblKotizacija.AutoSize = true;
            this.lblKotizacija.Location = new System.Drawing.Point(29, 27);
            this.lblKotizacija.Name = "lblKotizacija";
            this.lblKotizacija.Size = new System.Drawing.Size(55, 13);
            this.lblKotizacija.TabIndex = 0;
            this.lblKotizacija.Text = "Kotizacija:";
            this.lblKotizacija.Click += new System.EventHandler(this.lblKotizacija_Click);
            // 
            // lblNazivTima
            // 
            this.lblNazivTima.AutoSize = true;
            this.lblNazivTima.Location = new System.Drawing.Point(29, 55);
            this.lblNazivTima.Name = "lblNazivTima";
            this.lblNazivTima.Size = new System.Drawing.Size(27, 13);
            this.lblNazivTima.TabIndex = 1;
            this.lblNazivTima.Text = "Tim:";
            this.lblNazivTima.Click += new System.EventHandler(this.lblNazivTima_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnNapraviTim
            // 
            this.btnNapraviTim.Location = new System.Drawing.Point(81, 128);
            this.btnNapraviTim.Name = "btnNapraviTim";
            this.btnNapraviTim.Size = new System.Drawing.Size(75, 23);
            this.btnNapraviTim.TabIndex = 4;
            this.btnNapraviTim.Text = "Napravi Tim";
            this.btnNapraviTim.UseVisualStyleBackColor = true;
            this.btnNapraviTim.Click += new System.EventHandler(this.btnNapraviTim_Click);
            // 
            // btnUcitajTim
            // 
            this.btnUcitajTim.Location = new System.Drawing.Point(81, 89);
            this.btnUcitajTim.Name = "btnUcitajTim";
            this.btnUcitajTim.Size = new System.Drawing.Size(75, 23);
            this.btnUcitajTim.TabIndex = 5;
            this.btnUcitajTim.Text = "Učitaj Tim";
            this.btnUcitajTim.UseVisualStyleBackColor = true;
            this.btnUcitajTim.Click += new System.EventHandler(this.btnUcitajTim_Click);
            // 
            // lblListaTimova
            // 
            this.lblListaTimova.AutoSize = true;
            this.lblListaTimova.Location = new System.Drawing.Point(29, 191);
            this.lblListaTimova.Name = "lblListaTimova";
            this.lblListaTimova.Size = new System.Drawing.Size(70, 13);
            this.lblListaTimova.TabIndex = 6;
            this.lblListaTimova.Text = "Lista Timova:";
            this.lblListaTimova.Click += new System.EventHandler(this.lblListaTimova_Click);
            // 
            // lstListaTimova
            // 
            this.lstListaTimova.FormattingEnabled = true;
            this.lstListaTimova.Location = new System.Drawing.Point(97, 191);
            this.lstListaTimova.Name = "lstListaTimova";
            this.lstListaTimova.Size = new System.Drawing.Size(120, 95);
            this.lstListaTimova.TabIndex = 7;
            this.lstListaTimova.SelectedIndexChanged += new System.EventHandler(this.lstListaTimova_SelectedIndexChanged);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(254, 209);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 8;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(254, 251);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisi.TabIndex = 9;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // lblNagrada
            // 
            this.lblNagrada.AutoSize = true;
            this.lblNagrada.Location = new System.Drawing.Point(424, 27);
            this.lblNagrada.Name = "lblNagrada";
            this.lblNagrada.Size = new System.Drawing.Size(51, 13);
            this.lblNagrada.TabIndex = 10;
            this.lblNagrada.Text = "Nagrada:";
            this.lblNagrada.Click += new System.EventHandler(this.lblNagrada_Click);
            // 
            // lstNagrada
            // 
            this.lstNagrada.FormattingEnabled = true;
            this.lstNagrada.Location = new System.Drawing.Point(481, 27);
            this.lstNagrada.Name = "lstNagrada";
            this.lstNagrada.Size = new System.Drawing.Size(120, 95);
            this.lstNagrada.TabIndex = 11;
            this.lstNagrada.SelectedIndexChanged += new System.EventHandler(this.lstNagrada_SelectedIndexChanged);
            // 
            // btnUrediNagradu
            // 
            this.btnUrediNagradu.Location = new System.Drawing.Point(635, 45);
            this.btnUrediNagradu.Name = "btnUrediNagradu";
            this.btnUrediNagradu.Size = new System.Drawing.Size(75, 23);
            this.btnUrediNagradu.TabIndex = 12;
            this.btnUrediNagradu.Text = "Uredi";
            this.btnUrediNagradu.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiNagradu
            // 
            this.btnIzbrisiNagradu.Location = new System.Drawing.Point(635, 89);
            this.btnIzbrisiNagradu.Name = "btnIzbrisiNagradu";
            this.btnIzbrisiNagradu.Size = new System.Drawing.Size(75, 23);
            this.btnIzbrisiNagradu.TabIndex = 13;
            this.btnIzbrisiNagradu.Text = "Izbriši";
            this.btnIzbrisiNagradu.UseVisualStyleBackColor = true;
            this.btnIzbrisiNagradu.Click += new System.EventHandler(this.btnIzbrisiNagradu_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(328, 346);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 23);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // KreiranjeTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnIzbrisiNagradu);
            this.Controls.Add(this.btnUrediNagradu);
            this.Controls.Add(this.lstNagrada);
            this.Controls.Add(this.lblNagrada);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.lstListaTimova);
            this.Controls.Add(this.lblListaTimova);
            this.Controls.Add(this.btnUcitajTim);
            this.Controls.Add(this.btnNapraviTim);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNazivTima);
            this.Controls.Add(this.lblKotizacija);
            this.Name = "KreiranjeTurnira";
            this.Text = "KreiranjeTurnira";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKotizacija;
        private System.Windows.Forms.Label lblNazivTima;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNapraviTim;
        private System.Windows.Forms.Button btnUcitajTim;
        private System.Windows.Forms.Label lblListaTimova;
        private System.Windows.Forms.ListBox lstListaTimova;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.Label lblNagrada;
        private System.Windows.Forms.ListBox lstNagrada;
        private System.Windows.Forms.Button btnUrediNagradu;
        private System.Windows.Forms.Button btnIzbrisiNagradu;
        private System.Windows.Forms.Button btnOdustani;
    }
}