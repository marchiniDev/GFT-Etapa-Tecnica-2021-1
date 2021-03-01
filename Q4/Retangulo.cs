using System;

namespace Q2
{
    public class Retangulo: AreaCalculavel
    {
        public float largura, altura, area;

        public  Retangulo(float largura, float altura){
            this.largura = largura;
            this.altura =  altura;
        }

        public void calcArea(){
            area = largura * altura;
            Console.WriteLine($"A área do retangulo é {area}.");
        }
    }
}