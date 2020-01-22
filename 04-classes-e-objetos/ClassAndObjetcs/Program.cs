using System;
using ClassAndObjetcs.Heranca;

namespace ClassAndObjetcs
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(0,1);
            Ponto p2 = new Ponto(10,20);

            Ponto3D p3 = new Ponto3D(0,1,2);
            
            Console.WriteLine(p1.Printar());
            Console.WriteLine(p2.Printar());
        }
    }
}
