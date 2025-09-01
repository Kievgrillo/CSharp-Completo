using System.Globalization;

namespace HerdarCumprirContrato.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return width * Height;
        }

        public override string ToString()
        {
            return "Rectangle color = "
                + Color + ", " +
                "width = "
                + width.ToString("F2", CultureInfo.InvariantCulture) +
                ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture) +
                ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
