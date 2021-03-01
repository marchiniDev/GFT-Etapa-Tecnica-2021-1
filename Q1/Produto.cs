namespace Q1
{
    public class Produto
    {
        public string nome;
        public double valor;
        public int quantidade;

        public virtual double calcularValorFinal(){
            retunr (valor * quantidade * 1.10);
        }
    }
}