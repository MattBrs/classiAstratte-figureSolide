using System;
using System.Runtime.CompilerServices;

namespace _016_ClassiAstratte_FigureSolide {
    public class Sfera : Solido{
        private double _raggio;

        public Sfera(double raggio, double pesoSpecifico) {
            _raggio = raggio;
            base.pesoSpecifico = pesoSpecifico;
        }

        public override double Superficie() {
            return Math.Round(4 * Math.PI * Math.Pow(_raggio, 2), 2);
        }

        public override double Volume() {
            return Math.Round(4 / 3 * Math.PI * Math.Pow(_raggio, 3), 2);
        }

        public override string ToString() {
            return string.Format($"Raggio: {_raggio}  Peso Specifico: {pesoSpecifico}  Superficie: {Superficie()}  Volume: {Volume()}  Peso: {Peso()}");
        }
    }
}