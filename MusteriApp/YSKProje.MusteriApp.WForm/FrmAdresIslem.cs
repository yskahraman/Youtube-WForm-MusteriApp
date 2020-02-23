using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSKProje.MusteriApp.WForm.Islemler;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm
{
    public partial class FrmAdresIslem : Form
    {
        Adres gelenAdres;
        AdresIslem adresIslem;
        public FrmAdresIslem(Adres adres)
        {
            adresIslem = new AdresIslem();
            gelenAdres = adres;
            InitializeComponent();

        }

        private void FrmAdresIslem_Load(object sender, EventArgs e)
        {
            if (gelenAdres.Id != Guid.Empty)
            {
                lblDurum.Text = "Güncelleme işlemi";
                txtAdres.Text = gelenAdres.Tanim;
            }
            else
            {
                lblDurum.Text = "Ekleme işlemi";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (gelenAdres.Id != Guid.Empty)
            {
                gelenAdres.Tanim = txtAdres.Text;
                adresIslem.AdresGuncelle(gelenAdres);
            }
            else
            {
                adresIslem.AdresEkle(new Adres()
                {
                    Id = Guid.NewGuid(),
                    Tanim = txtAdres.Text,
                    MusteriId = gelenAdres.MusteriId
                });
            }

            this.Close();
        }
    }
}
