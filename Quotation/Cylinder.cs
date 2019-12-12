using System;
using System.Collections.Generic;
using System.Text;

namespace Quotation
{
    public class Cylinder: RawMaterial
    {

        public double Diameter { get; set; }
        public double Length { get; set; }

        public override void ComputePricePerPiece()
        {
            if (Diameter >= 0 && Length >= 0)
            {
                Price_Per_Piece = Math.PI * Math.Pow(Diameter/2, 2) * Length * Density * Price_Per_Kilo;
            }
            else
            {
                throw new Exception("Diameter and Length should be positive");
            }
        }

        public override void ComputeTotalPrice()
        {
            Total = Qty * Price_Per_Piece;
        }

        public Cylinder(string name, double diameter, double length, float density, double price_per_kilo, float qty)
        {
            Name = name;
            Diameter = diameter;
            Length = length;
            Density = density;
            Price_Per_Kilo = price_per_kilo;
            Qty = qty;
        }

        public Cylinder()
        {

        }
    }
}
