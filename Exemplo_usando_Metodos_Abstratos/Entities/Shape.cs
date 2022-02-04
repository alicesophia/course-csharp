using Exemplo_usando_Metodos_Abstratos.Entities.Enums;

namespace Exemplo_usando_Metodos_Abstratos.Entities {
    abstract class Shape {

        public Color Color { get; set; }

        protected Shape(Color color) {
            Color = color;
        }

        public abstract double Area();

    }
}
