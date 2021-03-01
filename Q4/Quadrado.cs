using System;

namespace Q2
{
    public class Quadrado: AreaCalculavel
    {
        public float lado, area;

        public  Quadrado (float lado){
            this.lado = lado;
        }

        public void calcArea(){
            area = lado * lado;
            Console.WriteLine($"A área do quadrado é {area}.");
        }
    }
}