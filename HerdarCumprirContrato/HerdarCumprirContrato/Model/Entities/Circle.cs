using System.Globalization;

namespace HerdarCumprirContrato.Model.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", areaa = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
