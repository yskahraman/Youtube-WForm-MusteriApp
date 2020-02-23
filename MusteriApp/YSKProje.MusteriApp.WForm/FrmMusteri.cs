using System;
using System.Windows.Forms;
using YSKProje.MusteriApp.WForm.Enumlar;
using YSKProje.MusteriApp.WForm.Islemler;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm
{
    public partial class FrmMusteri : Form
    {
        MusteriIslem musteriIslem;
      
        Guid musteriId;
        public FrmMusteri()
        {
           
            musteriId = Guid.Empty;
            musteriIslem = new MusteriIslem();
            InitializeComponent();
            //Musteri dummy = new Musteri();

            ListBoxDoldur();
            //lstMusteri.DisplayMember = nameof(dummy.Isim);
        }
        public void ListBoxDoldur()
        {
            lstMusteri.DataSource = musteriIslem.TumMusterileriGetir();
        }

        private void FrmMusteri_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEkle_Click(object sender, System.EventArgs e)
        {
            FrmMusteriIslem frmMusteriIslem = new FrmMusteriIslem(Guid.Empty, IslemTip.EklemeIslemi);
            frmMusteriIslem.ShowDialog();
            ListBoxDoldur();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (musteriId != Guid.Empty)
            {
                FrmMusteriIslem frmMusteriIslem = new FrmMusteriIslem(musteriId, IslemTip.GuncellemeIslemi);
                frmMusteriIslem.ShowDialog();
                ListBoxDoldur();
            }
            else
            {
                MessageBox.Show("Listeden bir müşteri seçiniz");
            }
           
        }

        private void lstMusteri_Click(object sender, EventArgs e)
        {
            ListBox yakalanListBox = (ListBox)sender;
             Musteri secilenMusteri= (Musteri)yakalanListBox.SelectedItem;

            if (secilenMusteri != null)
            {
                musteriId = secilenMusteri.Id;
                
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (musteriId != Guid.Empty)
            {
              DialogResult result=  MessageBox.Show("Uyarı","Silmek istediğinizden emin misiniz?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
              

                if (result == DialogResult.Yes)
                {
                    musteriIslem.MusteriSil(musteriId);
                    ListBoxDoldur();
                }
                else
                {

                }
               
            }
            else
            {
                MessageBox.Show("Listeden bir müşteri seçiniz");
            }
        }

        private void btnAdres_Click(object sender, EventArgs e)
        {
            if (musteriId != Guid.Empty)
            {
                FrmAdres frmAdres = new FrmAdres(musteriIslem.MusteriGetir(musteriId));
                frmAdres.ShowDialog();
            }
            else
            {
                MessageBox.Show("Listeden bir müşteri seçiniz");
            }
        }
    }
}
