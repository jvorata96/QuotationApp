using System;
using System.Collections.Generic;
using System.Text;


namespace Quotation
{
    public abstract class RawMaterial
    {
        public string Name { get; set; }
        public float Density { get; set; }
        public double Qty { get; set; }
        public double Price_Per_Kilo { get; set; }
        public double Price_Per_Piece { get; set; }
        public double Total { get; set; }
        public abstract void ComputePricePerPiece();
        public abstract void ComputeTotalPrice();

        

    }
}
