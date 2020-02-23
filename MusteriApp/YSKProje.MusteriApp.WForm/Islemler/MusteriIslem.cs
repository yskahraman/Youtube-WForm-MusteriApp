using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm.Islemler
{

    public class MusteriIslem 
    {
        Db db;
        public MusteriIslem()
        {
            db = new Db();
        }

        public List<Musteri> TumMusterileriGetir()
        {
            using (SqlCommand command = new SqlCommand())
            {
                List<Musteri> musteriListesi = new List<Musteri>();

                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "select * from Musteri";

                db.BaglantiyiAc();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    Musteri musteri = new Musteri();
                    musteri.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    musteri.Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);

                    musteriListesi.Add(musteri);
                }
                reader.Close();
                db.BaglantiyiKapa();

                return musteriListesi;
            }
        }

        public int MusteriEkle(Musteri musteri)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "insert into Musteri values(@id,@isim)";

                command.Parameters.AddWithValue("@id", musteri.Id);
                command.Parameters.AddWithValue("@isim", musteri.Isim);

                db.BaglantiyiAc();
                int etkilenenSatirSayisi= command.ExecuteNonQuery();
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }


        public int MusteriSil(Guid musteriId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "delete from Musteri where Id=@id";

                command.Parameters.AddWithValue("@id", musteriId);
               

                db.BaglantiyiAc();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }


        public int MusteriGuncelle(Musteri musteri)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "update Musteri set Isim=@isim where Id=@id";

                command.Parameters.AddWithValue("@id", musteri.Id);
                command.Parameters.AddWithValue("@isim", musteri.Isim);

                db.BaglantiyiAc();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }

        public Musteri MusteriGetir(Guid id)
        {
            using (SqlCommand command = new SqlCommand())
            {
                Musteri musteri = new Musteri();
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "select * from Musteri where Id=@id";

                command.Parameters.AddWithValue("@id", id);
              

                db.BaglantiyiAc();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
                    musteri.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    musteri.Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);

                   
                }
                reader.Close();
                command.Parameters.Clear();
                db.BaglantiyiKapa();
               

                return musteri;
            }
        }
    }
}
