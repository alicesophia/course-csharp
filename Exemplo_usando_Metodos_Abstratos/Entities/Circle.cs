using System;
using Exemplo_usando_Metodos_Abstratos.Entities.Enums;

namespace Exemplo_usando_Metodos_Abstratos.Entities {
    class Circle : Shape {

        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Radius * Radius;
        }
    }
}
