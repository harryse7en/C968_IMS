using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Classes
{
    public class Product
    {
        public int ProductID { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public void addAssociatedPart(Part part)
        {

        }

        public bool removeAssociatedPart(int productID)
        {
            return true;
        }

        public Part lookupAssociatedPart(int productID)
        {
            Part part = new Inhouse();
            //Part part = new Outsourced();
            return part;
        }

    }
}
