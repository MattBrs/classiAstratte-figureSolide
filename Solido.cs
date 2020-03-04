using System.Reflection.PortableExecutable;

namespace _016_ClassiAstratte_FigureSolide {
    public abstract class Solido {
        public double pesoSpecifico;

        public double Peso() {
            return pesoSpecifico * Volume();
        }

        public abstract double Volume();
        public abstract double Superficie();
    }
}