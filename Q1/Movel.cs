namespace Q1
{
    public class Movel: Produto
    {
        public Movel(string nome, int quantidade, double valor): base(nome, quantidade, valor){}
        public override double calcularValorFinal(){
            if (quantidade >= 10)
            {
                return (valor * quantidade * 1.05);
            }
            else
            {
                return (valor * quantidade * 1.11);
            }
            
        }
    }
}