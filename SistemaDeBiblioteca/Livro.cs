using System;

namespace SistemaBiblioteca
{
    public class Livro : ItemBiblioteca
    {
        public Livro(string titulo, string ano)
            : base(titulo, ano, 2) { }
        public override double CalcularMulta(int diasAtraso)
        {
            return base.CalcularMulta(diasAtraso);
        }
    }
}
