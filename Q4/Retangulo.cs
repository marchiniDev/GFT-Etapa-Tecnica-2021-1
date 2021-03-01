using System;

namespace Q4
{
    public class Retangulo: AreaCalculavel
    {
        private float largura, altura;

        public  Retangulo(float largura, float altura){
            this.largura = largura;
            this.altura =  altura;
        }

        public void calcArea(){
            Console.WriteLine($"A área do retangulo é {largura * altura}.");
        }
    }
}