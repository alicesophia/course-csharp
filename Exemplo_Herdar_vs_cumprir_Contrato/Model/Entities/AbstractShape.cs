using Exemplo_Herdar_vs_cumprir_Contrato.Model.Enums;

namespace Exemplo_Herdar_vs_cumprir_Contrato.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();

    }
}
