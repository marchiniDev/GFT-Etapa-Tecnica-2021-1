using System;

namespace Q2
{
    public class Circulo: AreaCalculavel
    {
        public double area;
        public float raio;

        public  Circulo (float raio){
            this.raio = raio;
        }

        public void calcArea(){
            area = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do quadrado é {area}.");
        }
    }
}