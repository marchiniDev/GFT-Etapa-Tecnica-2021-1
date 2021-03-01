namespace Q1
{
    public class Eletronico: Produto
    {
        public override double calcularValorFinal(){
            retunr (valor * quantidade * 1.15);
        }
    }
}