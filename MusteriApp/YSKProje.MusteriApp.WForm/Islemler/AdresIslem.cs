using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using YSKProje.MusteriApp.WForm.Tablolar;

namespace YSKProje.MusteriApp.WForm.Islemler
{
    public class AdresIslem
    {
        Db db;
        public AdresIslem()
        {
            db = new Db();
        }

        public List<Adres> AdresleriGetir(Guid musteriId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                List<Adres> adresler = new List<Adres>();

                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "select * from Adres where MusteriId=@musteriId";

                command.Parameters.AddWithValue("@musteriId", musteriId);

                db.BaglantiyiAc();
                SqlDataReader reader= command.ExecuteReader();
                while (reader.Read())
                {
                    Adres adres = new Adres();
                    adres.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    adres.Tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    adres.MusteriId = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2);

                    adresler.Add(adres);
                }

                reader.Close();
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return adresler;
            }
        }

        public int AdresEkle(Adres adres)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "insert into Adres values(@id,@tanim,@musteriId)";

                command.Parameters.AddWithValue("@musteriId", adres.MusteriId);
                command.Parameters.AddWithValue("@id", adres.Id);
                command.Parameters.AddWithValue("@tanim", adres.Tanim);
               

                db.BaglantiyiAc();
               int etkilenenSatirSayisi= command.ExecuteNonQuery();
               

                
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }

        public int AdresSil(Guid adresId)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "delete from Adres where Id=@id";

              
                command.Parameters.AddWithValue("@id", adresId);


                db.BaglantiyiAc();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();



                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }


        public int AdresGuncelle(Adres adres)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "update  Adres set Tanim=@tanim where Id=@id";


                command.Parameters.AddWithValue("@tanim", adres.Tanim);
                command.Parameters.AddWithValue("@id", adres.Id);


                db.BaglantiyiAc();
                int etkilenenSatirSayisi = command.ExecuteNonQuery();



                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return etkilenenSatirSayisi;
            }
        }

        public Adres BirAdresGetir(Guid adresId)
        {
            using (SqlCommand command = new SqlCommand())
            {
         
                Adres adres = new Adres();
                command.CommandType = CommandType.Text;
                command.Connection = db.BaglantiyiGetir();
                command.CommandText = "select * from Adres where Id=@id";

                command.Parameters.AddWithValue("@id", adresId);

                db.BaglantiyiAc();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    adres.Id = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0);
                    adres.Tanim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                    adres.MusteriId = reader.IsDBNull(2) ? Guid.Empty : reader.GetGuid(2);

                   
                }

                reader.Close();
                command.Parameters.Clear();
                db.BaglantiyiKapa();

                return adres;
            }
        }
    }
}
