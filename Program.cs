using System;
using Metodo_Construtor.Classes.cs;

namespace Metodo_Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto();
            Console.WriteLine($"Nome-> {produto1.nome ?? "Sem nome"} \nCodigo-> {produto1.codigo} \nDescricao-> {produto1.descricao ?? "Sem descricao"} \nValor em estoque-> {produto1.estoque}");
            
            Produto produto2 = new Produto(2565);
            Console.WriteLine($"Nome-> {produto2.nome ?? "Sem nome"} \nCodigo-> {produto2.codigo} \nDescricao-> {produto2.descricao ?? "Sem descricao"} \nValor em estoque-> {produto2.estoque}");

            Produto produto3 = new Produto(0336,"Feijao","Feijao Camil",100);
            Console.WriteLine($"Nome-> {produto3.nome ?? "Sem nome"} \nCodigo-> {produto3.codigo} \nDescricao-> {produto3.descricao ?? "Sem descricao"} \nValor em estoque-> {produto3.estoque}");
        }
    }
}
