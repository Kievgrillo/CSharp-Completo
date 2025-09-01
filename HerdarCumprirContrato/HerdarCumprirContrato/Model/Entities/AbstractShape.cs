using HerdarCumprirContrato.Model.Enums;

namespace HerdarCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
