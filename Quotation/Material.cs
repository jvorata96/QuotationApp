using System;
using System.Collections.Generic;
using System.Text;

namespace Quotation
{
    public class Material
    {
        public string Name { get; set; }
        public UInt32 Material_Cost { get; set; }
        public float Setup_Hr { get; set; }
        public UInt32 Setup_Cost { get; set; }
        public UInt32 Operation_Cost { get; set; }
        public float Operation_Hr { get; set; }
        public float Markup { get; set; }
        public UInt32 Qty { get; set; }

        
        public Material()
        {
            Name = "untitled";
            Qty = 1;
        }

    }
}
