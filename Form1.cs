using System;
using System.Windows.Forms;

namespace Formser {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();

            varosok.Items.Add("Debrecen");
            varosok.Items.Add("Budapest");
            varosok.Items.Add("Győr");

            nyelvek.Items.Add("Angol");
            nyelvek.Items.Add("Német");
            nyelvek.Items.Add("Francia");
            nyelvek.Items.Add("Olasz");
        }

        private void checkButton_Click(object sender, EventArgs e) {
            if (nev.Text.Trim().Length == 0) {
                hibas.SetError(nev, "Nincs név megadva");
                return;
            }

            if (nyelvek.Text.Length == 0) {
                hibas.SetError(nyelvek, "Nincs nyelv megadva");
                return;
            }

            if (varosok.Text.Length == 0) {
                hibas.SetError(varosok, "Nincs város megadva");
                return;
            }

            MessageBox.Show("Sikeres adatbevitel", "Adat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
