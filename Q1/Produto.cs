namespace Q1
{
    public class Produto
    {
        protected string nome;
        protected double valor;
        protected int quantidade;

        public Produto(string nome, int quantidade, double valor){
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public virtual double calcularValorFinal(){
            return (valor * quantidade * 1.10);
        }
    }
}