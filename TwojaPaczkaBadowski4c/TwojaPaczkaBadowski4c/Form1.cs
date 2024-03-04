using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwojaPaczkaBadowski4c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pocztowka.Checked)
            {
                obrazek.BackgroundImage = Properties.Resources.pocztowka;
                cena.Text = "Cena: 1 zł";
            }
            if(list.Checked)
            {
                obrazek.BackgroundImage = Properties.Resources.list;
                cena.Text = "Cena: 1,5 zł";
            }
            if(paczka.Checked)
            {
                obrazek.BackgroundImage = Properties.Resources.paczka;
                cena.Text = "Cena: 10 zł";
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            int value;
            if(!int.TryParse(kodP.Text, out value))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr.");
                return;
            } else if(kodP.Text.Length > 5 || kodP.Text.Length < 5)
            {
                MessageBox.Show("Nieprawidłowa ilość cyfr w kodzie pocztowym.");
            } else
            {
                MessageBox.Show("Dane przesyłki zostały wprowadzone.");
            }
        }
    }
}
