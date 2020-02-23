using System;
using System.Windows.Forms;
using YSKProje.MusteriApp.WForm.Islemler;

namespace YSKProje.MusteriApp.WForm
{
    public partial class Form1 : Form
    {
        AdminIslem adminIslem;
        public Form1()
        {
            adminIslem = new AdminIslem();
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAd.Text) && !string.IsNullOrEmpty(txtSifre.Text))
            {

                int sartiSaglayanKayitSayisi = adminIslem.KullaniciGiris(txtKullaniciAd.Text, txtSifre.Text);


                if (sartiSaglayanKayitSayisi > 0)
                {
                    FrmMusteri frmMusteri = new FrmMusteri();
                    frmMusteri.Show();
                    this.Hide();
                }
                else
                {
                    lblDurum.Visible = true;
                    lblDurum.Text = "Kullanıcı adı veya şifre hatalı";
                }

            }
            else
            {
                lblDurum.Visible = true;
                lblDurum.Text = "Kullanıcı adı veya şifre alanı boş geçilemez";
            }
        }
    }
}
