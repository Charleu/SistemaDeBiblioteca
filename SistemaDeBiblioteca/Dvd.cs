using System;

namespace SistemaBiblioteca
{
    public class Dvd : ItemBiblioteca
    {
        public Dvd(string titulo, string ano)
            : base(titulo, ano, 5) { }
        public override double CalcularMulta(int diasAtraso)
        {
            return base.CalcularMulta(diasAtraso);
        }
    }
}
