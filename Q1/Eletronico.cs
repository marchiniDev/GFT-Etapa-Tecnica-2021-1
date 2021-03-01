namespace Q1
{
    public class Eletronico: Produto
    {
        public Eletronico(string nome, int quantidade, double valor): base(nome, quantidade, valor){}
        public override double calcularValorFinal(){
            return (valor * quantidade * 1.15);
        }
    }
}