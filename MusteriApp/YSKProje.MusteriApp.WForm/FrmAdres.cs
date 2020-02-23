using System;
using System.Windows.Forms;
using YSKProje.MusteriApp.WForm.Islemler;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm
{
    public partial class FrmAdres : Form
    {
        Musteri gelenMusteri;
        Adres adres;
        AdresIslem adresIslem;
        public FrmAdres(Musteri musteri)
        {
            adresIslem = new AdresIslem();
            adres = null;
            gelenMusteri = musteri;
            InitializeComponent();
            grpAdres.Text = $"{musteri.Isim} adlı müşterinin adresleri";
            ListBoxDoldur();
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            FrmAdresIslem frmAdresIslem = new FrmAdresIslem(new Adres()
            {
                Id = Guid.Empty,
                MusteriId = gelenMusteri.Id,
                Tanim = null
            });
            frmAdresIslem.ShowDialog();
            ListBoxDoldur();

        }

        private void btnGuncelle_Click(object sender, System.EventArgs e)
        {
            if (adres != null)
            {
                FrmAdresIslem frmAdresIslem = new FrmAdresIslem(adres);
                frmAdresIslem.ShowDialog();
                ListBoxDoldur();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir adres seçiniz");
            }
        }

        private void btnSil_Click(object sender, System.EventArgs e)
        {
            if (adres != null)
            {
                DialogResult result= MessageBox.Show("Uyarı","Silmek istediğinizden emin misiniz?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    adresIslem.AdresSil(adres.Id);
                    ListBoxDoldur();
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir adres seçiniz");
            }
        }

        public void ListBoxDoldur()
        {
            lstAdres.DataSource = adresIslem.AdresleriGetir(gelenMusteri.Id);
        }

        private void lstAdres_Click(object sender, System.EventArgs e)
        {
            ListBox yakalanan = (ListBox)sender;
            Adres yakanlanAdres = (Adres)yakalanan.SelectedItem;
            if (yakanlanAdres != null)
            {
                adres = yakanlanAdres;
            }
        }
    }
}
