using System.Data.SqlClient;

namespace YSKProje.MusteriApp.WForm.Islemler
{
    public class Db
    {
        private SqlConnection con;

        public Db()
        {
            con= new SqlConnection(@"data source=.\SQLExpress; initial catalog=MusteriApp; user id=sa; password=1;");
        }

        public void BaglantiyiAc()
        {
            con.Open();
        }

        public void BaglantiyiKapa()
        {
            con.Close();
        }

        public SqlConnection BaglantiyiGetir()
        {
            return con;
        }
    }

}
