using System;
using System.Collections.Generic;
using System.Text;

namespace Quotation
{
    public class Material
    {
        public UInt32 Qty { get; set; }
        public string Name { get; set; }
        public float Material_Cost { get; set; }
        public float Setup_Hr { get; set; }
        public UInt32 Setup_Cost { get; set; }
        public UInt32 Operation_Cost { get; set; }
        public float Operation_Hr { get; set; }
        public float Markup { get; set; }
        

        public float Price_Per_Piece { get; set; }

        public void SetPricePerPiece()
        {
            Price_Per_Piece = SubTotal / Qty;
        }

        public float SubTotal { get; set; }

        public void SetSubTotal()
        { 
        SubTotal = Qty* ((1 + Markup) * (Material_Cost + (Setup_Hr* Setup_Cost / Qty) + (Operation_Hr * Operation_Cost)));
        }

        public Material()
        {
            Name = "untitled";
            Qty = 1;
        }

    }
}
