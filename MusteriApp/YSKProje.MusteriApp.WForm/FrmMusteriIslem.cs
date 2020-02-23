using System;
using System.Windows.Forms;
using YSKProje.MusteriApp.WForm.Enumlar;
using YSKProje.MusteriApp.WForm.Islemler;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm
{
    public partial class FrmMusteriIslem : Form
    {
        IslemTip gelenTip;
        Guid musteriId;
        MusteriIslem musteriIslem;
        public FrmMusteriIslem(Guid id, IslemTip tip)
        {
            musteriIslem = new MusteriIslem();
            gelenTip = tip;
            musteriId = id;
            InitializeComponent();

        }

        private void FrmMusteriIslem_Load(object sender, System.EventArgs e)
        {
            if (gelenTip == IslemTip.EklemeIslemi)
            {
                lblDurum.Text = "Müşteri ekleme";
            }
            else
            {
                lblDurum.Text = "Müşteri düzenleme";
                txtMusteriAd.Text = musteriIslem.MusteriGetir(musteriId).Isim;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gelenTip == IslemTip.EklemeIslemi)
            {
                musteriIslem.MusteriEkle(new Musteri()
                {
                    Id = Guid.NewGuid(),
                    Isim = txtMusteriAd.Text
                });

                this.Close();
            }
            else
            {
                var gelenMusteri = musteriIslem.MusteriGetir(musteriId);
                gelenMusteri.Isim = txtMusteriAd.Text;
                musteriIslem.MusteriGuncelle(gelenMusteri);
                this.Close();
            }
        }
    }
}
