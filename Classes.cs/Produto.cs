namespace Metodo_Construtor.Classes.cs
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public string descricao;
        public int estoque;

        public Produto(){

        }

        public Produto(int codg){
            codigo = codg;
        }
        public Produto(int cod, string name, string desc, int estq){
            codigo = cod;
            nome = name;
            descricao = desc;
            estoque = estq;
        }
    }
}