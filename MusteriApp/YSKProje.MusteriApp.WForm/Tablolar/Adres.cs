using System;

namespace YSKProje.MusteriApp.WForm.Tablolar
{
    public class Adres
    {
        public Guid Id { get; set; }
        public string Tanim { get; set; }
        public Guid MusteriId { get; set; }

        public override string ToString()
        {
            return Tanim;
        }
    }
}
