namespace WindowsFormsApp3
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.nazwa = new System.Windows.Forms.TextBox();
            this.silnik = new System.Windows.Forms.TextBox();
            this.kolor = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podaj Marke";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Podaj Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Podaj Pojemność Silnika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Podaj Kolor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(12, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Podaj Cene";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(17, 65);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 1;
            // 
            // nazwa
            // 
            this.nazwa.Location = new System.Drawing.Point(17, 164);
            this.nazwa.Name = "nazwa";
            this.nazwa.Size = new System.Drawing.Size(100, 20);
            this.nazwa.TabIndex = 1;
            // 
            // silnik
            // 
            this.silnik.Location = new System.Drawing.Point(17, 265);
            this.silnik.Name = "silnik";
            this.silnik.Size = new System.Drawing.Size(100, 20);
            this.silnik.TabIndex = 1;
            // 
            // kolor
            // 
            this.kolor.Location = new System.Drawing.Point(17, 359);
            this.kolor.Name = "kolor";
            this.kolor.Size = new System.Drawing.Size(100, 20);
            this.kolor.TabIndex = 1;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(17, 446);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(238, 461);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(111, 46);
            this.submit.TabIndex = 2;
            this.submit.Text = "Zatwierdź";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 523);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.kolor);
            this.Controls.Add(this.silnik);
            this.Controls.Add(this.nazwa);
            this.Controls.Add(this.model);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox nazwa;
        private System.Windows.Forms.TextBox silnik;
        private System.Windows.Forms.TextBox kolor;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Button submit;
    }
}