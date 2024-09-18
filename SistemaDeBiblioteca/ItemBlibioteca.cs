using System;

namespace SistemaBiblioteca
{
    public class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Ano { get; set; }
        public double MultaDiaria { get; set; }
        public bool Emprestado { get; private set; }

        public ItemBiblioteca(string titulo, string ano, double multaDiaria)
        {
            Titulo = titulo;
            Ano = ano;
            MultaDiaria = multaDiaria;
            Emprestado = false;
        }

        public virtual void Alugar()
        {
            if (!Emprestado)
            {
                Emprestado = true;
                Console.WriteLine($"{Titulo} alugado com sucesso!");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está alugado! Escolha outro");
            }
        }

        public void Devolver(int diasAtraso)
        {
            if (Emprestado)
            {
                Emprestado = false;
                double multa = CalcularMulta(diasAtraso);
                Console.WriteLine($"{Titulo} devolvido!\nMulta por atraso: {multa.ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Esse{Titulo} não foi alugado.");
            }
        }

        public virtual double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * MultaDiaria;
        }
    }
}
