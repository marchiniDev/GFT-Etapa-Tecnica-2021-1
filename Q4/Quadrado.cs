using System;

namespace Q4
{
    public class Quadrado: AreaCalculavel
    {
        private float lado;

        public  Quadrado (float lado){
            this.lado = lado;
        }

        public void calcArea(){
            Console.WriteLine($"A área do quadrado é {lado * lado}.");
        }
    }
}