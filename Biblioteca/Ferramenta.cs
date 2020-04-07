using System;

namespace Biblioteca
{
    public class Ferramenta
    {
        Random random;
        public Ferramenta(string descricao, string tipo, string marca, decimal preco)
        {
            random = new Random();
            Id = random.Next(1, 1000);
            Descricao = descricao;
            Tipo = tipo;
            Marca = marca;
            Preco = preco;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public override string ToString()
        {
            return "Id: " + this.Id +
                 "\nDescrição: " + this.Descricao +
                 "\nTipo: " + this.Tipo +
                 "\nMarca: " + this.Marca +
                 "\nPreço: R$ " + this.Preco.ToString(".00");
        }
    }
}