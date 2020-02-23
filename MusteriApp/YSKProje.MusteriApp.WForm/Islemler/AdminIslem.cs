using System.Data;
using System.Data.SqlClient;

namespace YSKProje.MusteriApp.WForm.Islemler
{   
    public class AdminIslem
    {
        Db db;
        public AdminIslem()
        {
            db = new Db();
        }

        public int KullaniciGiris(string kullaniciAd, string sifre)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.Text;
                cmd.Connection = db.BaglantiyiGetir();
                cmd.CommandText = "select count(*) from Admin where KullaniciAd=@kullaniciAd and Sifre=@sifre";

                cmd.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                db.BaglantiyiAc();

                int sartiSaglayanKayitSayisi = (int)cmd.ExecuteScalar();

                cmd.Parameters.Clear();

                db.BaglantiyiKapa();
                return sartiSaglayanKayitSayisi;
            }
                      
        }
    }
}
