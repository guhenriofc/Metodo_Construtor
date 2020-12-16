namespace Metodo_Construtor.Classes.cs
{
    public class Produto
    {
        public int codigo{ get; set; }
        public string nome{ get; set; }
        public string descricao{ get; set; }
        public int estoque{ get; set;}

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