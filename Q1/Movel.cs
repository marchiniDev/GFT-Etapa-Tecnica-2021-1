namespace Q1
{
    public class Movel: Produto
    {
        public override double calcularValorFinal(){
            if (quantidade >= 10)
            {
                retunr (valor * quantidade * 1.05);
            }
            else
            {
                retunr (valor * quantidade * 1.11);
            }
            
        }
    }
}