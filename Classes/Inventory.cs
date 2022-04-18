using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Classes
{
    static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static int ProductIdx = 0;
        public static int InhousePartIdx = 0;
        public static int OutsourcedPartIdx = 0;

        public static void addProduct(Product prod)
        {
            Products.Add(prod); // Add product
            ProductIdx++;
        }

        public static bool removeProduct(int prodID)
        {
            foreach (Product _prod in Products) // Search all products to find a match
            {
                if (prodID == _prod.ProductID)
                {
                    if (_prod.AssociatedParts.Count == 0)
                    {
                        Products.Remove(_prod); // Delete product
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete the product when it has associated parts.  Delete all of the associated parts and try again", "ERROR");
                        return false;
                    }
                }
            }
            MessageBox.Show("Failed to delete the product!", "ERROR");
            return false;
        }

        public static Product lookupProduct(int prodID)
        {
            foreach (Product _prod in Products) // Search all products to find a match
            {
                if (prodID == _prod.ProductID)
                {
                    return _prod; // Return the matched product
                }
            }
            return new Product(); // Return a new, blank product if lookup didn't find a match
        }

        public static void updateProduct(int prodID, Product prod)
        {
            foreach (Product _prod in Products) // Search all products to find a match
            {
                if (prodID == _prod.ProductID)
                {
                    _prod.Name = prod.Name;
                    _prod.InStock = prod.InStock;
                    _prod.Min = prod.Min;
                    _prod.Max = prod.Max;
                    _prod.Price = prod.Price;
                    _prod.AssociatedParts = prod.AssociatedParts;
                    return;
                }
            }
            MessageBox.Show("Failed to update the product!", "ERROR");
            return;
        }

        public static void addPart(Inhouse part) // Overloaded function special for Inhouse parts
        {
            AllParts.Add(part); // Add part
            InhousePartIdx++;
        }

        public static void addPart(Outsourced part) // Overloaded function special for Outsourced parts
        {
            AllParts.Add(part); // Add part
            OutsourcedPartIdx++;
        }

        public static bool removePart(int partID)
        {
            foreach (Part _part in AllParts) // Search all parts to find a match
            {
                if (partID == _part.PartID)
                {
                    AllParts.Remove(_part); // Delete part
                    return true;
                }
            }
            MessageBox.Show("Failed to delete the part!", "ERROR");
            return false;
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part _part in AllParts) // Search all parts to find a match
            {
                if (partID == _part.PartID)
                {
                    return _part; // Return the matched part
                }
            }
            return new Inhouse(); // Return a new, blank Inhouse part if lookup didn't find a match
        }

        public static void updatePart(int partID, Inhouse part) // Overloaded function special for Inhouse parts
        {
            foreach (Inhouse _part in AllParts) // Search all parts to find a match
            {
                if (partID == _part.PartID)
                {
                    _part.Name = part.Name;
                    _part.InStock = part.InStock;
                    _part.Min = part.Min;
                    _part.Max = part.Max;
                    _part.Price = part.Price;
                    _part.MachineID = part.MachineID;
                    return;
                }
            }
            MessageBox.Show("Failed to update the part!", "ERROR");
            return;
        }

        public static void updatePart(int partID, Outsourced part) // Overloaded function special for Outsourced parts
        {
            foreach (Outsourced _part in AllParts) // Search all parts to find a match
            {
                if (partID == _part.PartID)
                {
                    _part.Name = part.Name;
                    _part.InStock = part.InStock;
                    _part.Min = part.Min;
                    _part.Max = part.Max;
                    _part.Price = part.Price;
                    _part.CompanyName = part.CompanyName;
                    return;
                }
            }
            MessageBox.Show("Failed to update the part!", "ERROR");
            return;
        }
    }
}
