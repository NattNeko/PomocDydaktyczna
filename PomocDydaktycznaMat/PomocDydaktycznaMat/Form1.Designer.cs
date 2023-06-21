
namespace PomocDydaktycznaMat
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Prosty kalkulator",
            "Geometria",
            "Trygonometria"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(411, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz liczbę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wpisz drugą liczbę";
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(263, 239);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(105, 23);
            this.dodawanie.TabIndex = 5;
            this.dodawanie.Text = "Dodawanie";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(263, 292);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(105, 23);
            this.odejmowanie.TabIndex = 6;
            this.odejmowanie.Text = "Odejmowanie";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(419, 239);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(92, 23);
            this.mnozenie.TabIndex = 7;
            this.mnozenie.Text = "Mnożenie";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.mnozenie_Click);

            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(419, 292);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(92, 23);
            this.dzielenie.TabIndex = 8;
            this.dzielenie.Text = "Dzielenie";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(411, 353);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 22);
            this.wynik.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label label3;
    }
}

