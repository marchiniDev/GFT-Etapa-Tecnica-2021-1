using System;

namespace Q4
{
    public class Circulo: AreaCalculavel
    {
        private float raio;

        public  Circulo (float raio){
            this.raio = raio;
        }

        public void calcArea(){
            Console.WriteLine($"A área do quadrado é {Math.PI * Math.Pow(raio, 2)}.");
        }
    }
}