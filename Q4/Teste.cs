using System;

namespace Q4
{
    class Teste
    {
        static void Main(string[] args)
        {
            Quadrado sqr = new Quadrado(3);
            Retangulo rec = new Retangulo(5, 8);
            Circulo circ = new Circulo (13);

            sqr.calcArea();
            rec.calcArea();
            circ.calcArea();
        }
    }
}
