using System;
using System.Collections.Generic;
using System.Text;


namespace Quotation
{
    public class Quote
    {
        public string Name { get; set; }
        //public UInt32 Material_Cost { get; set; }
        //public float Setup_Hr { get; set; }
        //public UInt32 Setup_Cost { get; set; }
        //public UInt32 Operation_Cost { get; set; }
        //public float Operation_Hr { get; set; }
        //public float Markup { get; set; }

        //public UInt32 Qty { get; set; }
        
        private float _total;

        private List<Material> _materialList = new List<Material>();

        public void AddMaterial(Material material)
        {
            _materialList.Add(material);
        }

        public Material DeleteMaterial(string name)
        {
            Material material = _materialList.Find(x => string.Equals(x.Name, name));

            _materialList.Remove(material);

            return material;
        }

        public void ModifyMaterial(string name, Material material)
        {
            _materialList[_materialList.FindIndex(x => string.Equals(x.Name, name))] = material;
        }

        public List<Material> GetMaterials()
        {
            return _materialList;
        }

        public float Total
        {
            get { return _total; }
            set
            {
                if (value >= 0)
                {
                    _total = value;
                }
                else
                {

                    throw new Exception("Total can't be less than zero");
                }
            }
        }

        public void setTotal()
        {
            float tempTotal = 0;
            foreach (var mat in _materialList)
            {
                tempTotal += mat.SubTotal;
            }

            Total = tempTotal;
        }


        public Quote()
        {
            Name = "untitled";
            //Qty = 1;
        }
        
        //public override string ToString()
        //{
        //    var sb = new StringBuilder();
        //    sb.AppendLine(Name);
        //    sb.AppendLine("Qty: " + Qty.ToString());
        //    sb.AppendLine("Material Cost: " + Material_Cost.ToString());
        //    sb.AppendLine("Markup: " + Markup.ToString());
        //    sb.AppendLine("Setup $/Hr: " + Setup_Cost.ToString());
        //    sb.AppendLine("Setup Hr: " + Setup_Hr.ToString());
        //    sb.AppendLine("Operation $/Hr: " + Operation_Cost.ToString());
        //    sb.AppendLine("Operation Hr: " + Operation_Hr.ToString());
        //    sb.AppendLine("Total Cost: " + _total.ToString());
        //    return sb.ToString();
        //}

    }
}
