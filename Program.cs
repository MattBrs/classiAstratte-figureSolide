using System;

namespace _016_ClassiAstratte_FigureSolide {
    class Program {
        static void Main(string[] args) {
            Solido s1 = new Sfera(10, 5);
            Solido c1 = new Cubo(15, 9);

            Console.WriteLine(s1);
            Console.WriteLine(c1);
        }
    }
}