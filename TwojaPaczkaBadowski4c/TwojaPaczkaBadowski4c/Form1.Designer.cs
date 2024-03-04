
namespace TwojaPaczkaBadowski4c
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rodzaj = new System.Windows.Forms.GroupBox();
            this.pocztowka = new System.Windows.Forms.RadioButton();
            this.paczka = new System.Windows.Forms.RadioButton();
            this.list = new System.Windows.Forms.RadioButton();
            this.dane = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.miasto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.kodP = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.cena = new System.Windows.Forms.Label();
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.rodzaj.SuspendLayout();
            this.dane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // rodzaj
            // 
            this.rodzaj.Controls.Add(this.pocztowka);
            this.rodzaj.Controls.Add(this.paczka);
            this.rodzaj.Controls.Add(this.list);
            this.rodzaj.Location = new System.Drawing.Point(12, 12);
            this.rodzaj.Name = "rodzaj";
            this.rodzaj.Size = new System.Drawing.Size(207, 118);
            this.rodzaj.TabIndex = 0;
            this.rodzaj.TabStop = false;
            this.rodzaj.Text = "Rodzaj przesyłki";
            // 
            // pocztowka
            // 
            this.pocztowka.AutoSize = true;
            this.pocztowka.Checked = true;
            this.pocztowka.Location = new System.Drawing.Point(20, 33);
            this.pocztowka.Name = "pocztowka";
            this.pocztowka.Size = new System.Drawing.Size(82, 19);
            this.pocztowka.TabIndex = 0;
            this.pocztowka.TabStop = true;
            this.pocztowka.Text = "Pocztówka";
            this.pocztowka.UseVisualStyleBackColor = true;
            // 
            // paczka
            // 
            this.paczka.AutoSize = true;
            this.paczka.Location = new System.Drawing.Point(20, 83);
            this.paczka.Name = "paczka";
            this.paczka.Size = new System.Drawing.Size(61, 19);
            this.paczka.TabIndex = 2;
            this.paczka.TabStop = true;
            this.paczka.Text = "Paczka";
            this.paczka.UseVisualStyleBackColor = true;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(20, 58);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(43, 19);
            this.list.TabIndex = 1;
            this.list.TabStop = true;
            this.list.Text = "List";
            this.list.UseVisualStyleBackColor = true;
            // 
            // dane
            // 
            this.dane.Controls.Add(this.label4);
            this.dane.Controls.Add(this.label3);
            this.dane.Controls.Add(this.miasto);
            this.dane.Controls.Add(this.label2);
            this.dane.Controls.Add(this.textBox2);
            this.dane.Controls.Add(this.kodP);
            this.dane.Location = new System.Drawing.Point(294, 12);
            this.dane.Name = "dane";
            this.dane.Size = new System.Drawing.Size(230, 188);
            this.dane.TabIndex = 0;
            this.dane.TabStop = false;
            this.dane.Text = "Dane adresowe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Miasto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kod pocztowy";
            // 
            // miasto
            // 
            this.miasto.Location = new System.Drawing.Point(18, 150);
            this.miasto.Name = "miasto";
            this.miasto.Size = new System.Drawing.Size(195, 23);
            this.miasto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ulica z numerem";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 23);
            this.textBox2.TabIndex = 4;
            // 
            // kodP
            // 
            this.kodP.Location = new System.Drawing.Point(18, 99);
            this.kodP.Name = "kodP";
            this.kodP.Size = new System.Drawing.Size(100, 23);
            this.kodP.TabIndex = 6;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(12, 283);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(512, 23);
            this.confirm.TabIndex = 7;
            this.confirm.Text = "Zatwierdź";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 136);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(207, 23);
            this.check.TabIndex = 8;
            this.check.Text = "Sprawdź cenę";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button2_Click);
            // 
            // cena
            // 
            this.cena.AutoSize = true;
            this.cena.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cena.Location = new System.Drawing.Point(150, 219);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(69, 28);
            this.cena.TabIndex = 9;
            this.cena.Text = "Cena: ";
            // 
            // obrazek
            // 
            this.obrazek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obrazek.BackgroundImage")));
            this.obrazek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obrazek.Location = new System.Drawing.Point(12, 177);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(126, 84);
            this.obrazek.TabIndex = 10;
            this.obrazek.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 408);
            this.Controls.Add(this.dane);
            this.Controls.Add(this.check);
            this.Controls.Add(this.cena);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.rodzaj);
            this.Controls.Add(this.confirm);
            this.Name = "Form1";
            this.Text = "Nadaj przesyłkę";
            this.rodzaj.ResumeLayout(false);
            this.rodzaj.PerformLayout();
            this.dane.ResumeLayout(false);
            this.dane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox rodzaj;
        private System.Windows.Forms.RadioButton pocztowka;
        private System.Windows.Forms.RadioButton paczka;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.GroupBox dane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miasto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox kodP;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Label cena;
        private System.Windows.Forms.PictureBox obrazek;
    }
}

