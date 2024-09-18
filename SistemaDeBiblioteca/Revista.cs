using System;

namespace SistemaBiblioteca
{
    public class Revista : ItemBiblioteca
    {
        public Revista(string titulo, string ano)
            : base(titulo, ano, 1) { }

        public override double CalcularMulta(int diasAtraso)
        {
            return base.CalcularMulta(diasAtraso);
        }
    }
}
