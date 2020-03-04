using System;

namespace _016_ClassiAstratte_FigureSolide {
    public class Cubo : Solido {
        private double _lato;

        public Cubo(double lato, double pesoSpecifico) {
            _lato = lato;
            base.pesoSpecifico = pesoSpecifico;
        }

        public override double Superficie() {
            return 6 * Math.Pow(_lato, 2);
        }

        public override double Volume() {
            return Math.Pow(_lato, 3);
        }

        public override string ToString() {
            return string.Format($"Lato: {_lato}  Peso Specifico: {pesoSpecifico}  Superficie: {Superficie()}  Volume: {Volume()}  Peso: {Peso()}");
        }
    }
}