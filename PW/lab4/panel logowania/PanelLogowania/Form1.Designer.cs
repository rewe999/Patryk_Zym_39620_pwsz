namespace PanelLogowania
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
            this.login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.haslo = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(73, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj Login";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(78, 123);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(142, 20);
            this.login.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(73, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podaj Hasło";
            // 
            // haslo
            // 
            this.haslo.Location = new System.Drawing.Point(78, 253);
            this.haslo.Name = "haslo";
            this.haslo.PasswordChar = '*';
            this.haslo.Size = new System.Drawing.Size(142, 20);
            this.haslo.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.submit.Location = new System.Drawing.Point(463, 306);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(256, 92);
            this.submit.TabIndex = 2;
            this.submit.Text = "Zaloguj";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(371, 140);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(348, 44);
            this.error.TabIndex = 3;
            this.error.Text = "Niepoprawne dane!";
            this.error.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.haslo);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox haslo;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label error;
    }
}

