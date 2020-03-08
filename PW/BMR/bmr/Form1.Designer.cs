namespace bmr
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Oblicz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Masa = new System.Windows.Forms.TextBox();
            this.Wzrost = new System.Windows.Forms.TextBox();
            this.Wiek = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MezczyznaPlec = new System.Windows.Forms.RadioButton();
            this.KobietaPlec = new System.Windows.Forms.RadioButton();
            this.Wynik = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(589, 344);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(147, 72);
            this.Oblicz.TabIndex = 0;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Masa [kg]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wzrost [cm]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wiek";
            // 
            // Masa
            // 
            this.Masa.Location = new System.Drawing.Point(67, 98);
            this.Masa.Name = "Masa";
            this.Masa.Size = new System.Drawing.Size(100, 20);
            this.Masa.TabIndex = 2;
            // 
            // Wzrost
            // 
            this.Wzrost.Location = new System.Drawing.Point(67, 168);
            this.Wzrost.Name = "Wzrost";
            this.Wzrost.Size = new System.Drawing.Size(100, 20);
            this.Wzrost.TabIndex = 2;
            // 
            // Wiek
            // 
            this.Wiek.Location = new System.Drawing.Point(67, 243);
            this.Wiek.Name = "Wiek";
            this.Wiek.Size = new System.Drawing.Size(100, 20);
            this.Wiek.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wybierz Płeć";
            // 
            // MezczyznaPlec
            // 
            this.MezczyznaPlec.AutoSize = true;
            this.MezczyznaPlec.Location = new System.Drawing.Point(264, 151);
            this.MezczyznaPlec.Name = "MezczyznaPlec";
            this.MezczyznaPlec.Size = new System.Drawing.Size(78, 17);
            this.MezczyznaPlec.TabIndex = 3;
            this.MezczyznaPlec.TabStop = true;
            this.MezczyznaPlec.Text = "Mężczyzna";
            this.MezczyznaPlec.UseVisualStyleBackColor = true;
            // 
            // KobietaPlec
            // 
            this.KobietaPlec.AutoSize = true;
            this.KobietaPlec.Location = new System.Drawing.Point(264, 193);
            this.KobietaPlec.Name = "KobietaPlec";
            this.KobietaPlec.Size = new System.Drawing.Size(61, 17);
            this.KobietaPlec.TabIndex = 3;
            this.KobietaPlec.TabStop = true;
            this.KobietaPlec.Text = "Kobieta";
            this.KobietaPlec.UseVisualStyleBackColor = true;
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.Wynik.Location = new System.Drawing.Point(458, 243);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(0, 29);
            this.Wynik.TabIndex = 1;
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(43, 344);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(153, 72);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.KobietaPlec);
            this.Controls.Add(this.MezczyznaPlec);
            this.Controls.Add(this.Wiek);
            this.Controls.Add(this.Wzrost);
            this.Controls.Add(this.Masa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Oblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Masa;
        private System.Windows.Forms.TextBox Wzrost;
        private System.Windows.Forms.TextBox Wiek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton MezczyznaPlec;
        private System.Windows.Forms.RadioButton KobietaPlec;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.Button Reset;
    }
}

