using System;

namespace Pesel
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.Button();
            this.Wyswietl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj PESEL";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(41, 79);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(100, 20);
            this.Pesel.TabIndex = 1;
            this.Pesel.TextChanged += new System.EventHandler(this.Pesel_TextChanged);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(565, 333);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(183, 82);
            this.Wynik.TabIndex = 2;
            this.Wynik.Text = "Sprawdź pesel";
            this.Wynik.UseVisualStyleBackColor = true;
            this.Wynik.Click += new System.EventHandler(this.Wynik_Click);
            // 
            // Wyswietl
            // 
            this.Wyswietl.AutoSize = true;
            this.Wyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.Wyswietl.Location = new System.Drawing.Point(111, 205);
            this.Wyswietl.Name = "Wyswietl";
            this.Wyswietl.Size = new System.Drawing.Size(0, 63);
            this.Wyswietl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wyswietl);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.Button Wynik;
        private System.Windows.Forms.Label Wyswietl;
    }
}

