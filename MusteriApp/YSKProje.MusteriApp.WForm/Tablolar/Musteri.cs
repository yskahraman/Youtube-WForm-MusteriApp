using System;

namespace YSKProje.MusteriApp.WForm.Tablolar
{
    public class Musteri
    {
        public Guid Id { get; set; }
        public string Isim { get; set; }

        public override string ToString()
        {
            return Isim;
        }
    }
}
