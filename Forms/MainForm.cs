// ********   INVENTORY MGMT SYSTEM   ********
//         by harryse7en, 15-Mar-2022
// This Windows application was created during a college course to meet requirements of a basic IMS using Visual Studio 2022.
// This application represents the final solution to pass the course.


using IMS.Classes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class MainForm : Form
    {

        // ---------- Variables ----------
        private bool doInit = true; // Set this to TRUE if you want to populate with initial data for testing



        // ---------- Form Constructor ----------
        public MainForm()
        {
            doInitData();
            InitializeComponent();
            dgParts.DataSource = Inventory.AllParts;
            dgParts.Columns["PartID"].HeaderText = "Part ID";
            dgParts.Columns["Name"].HeaderText = "Name";
            dgParts.Columns["InStock"].HeaderText = "# In Stock";
            dgParts.Columns["Min"].Visible = false;
            dgParts.Columns["Max"].Visible = false;
            dgParts.Columns["Price"].HeaderText = "Price ea.";
            dgProducts.DataSource = Inventory.Products;
            dgProducts.Columns["ProductID"].HeaderText = "Product ID";
            dgProducts.Columns["Name"].HeaderText = "Name";
            dgProducts.Columns["InStock"].HeaderText = "# In Stock";
            dgProducts.Columns["Min"].Visible = false;
            dgProducts.Columns["Max"].Visible = false;
            dgProducts.Columns["Price"].HeaderText = "Price ea.";
        }



        // ---------- Form Navigation ----------
        private void btnPartAdd_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
        }

        private void btnPartMod_Click(object sender, EventArgs e)
        {
            if (dgParts.CurrentRow.Selected)
            {
                if (dgParts.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
                {
                    Inhouse _part = (Inhouse)dgParts.CurrentRow.DataBoundItem;
                    ModPartForm modPartForm = new ModPartForm(_part);
                    modPartForm.Show();
                }
                else
                {
                    Outsourced _part = (Outsourced)dgParts.CurrentRow.DataBoundItem;
                    ModPartForm modPartForm = new ModPartForm(_part);
                    modPartForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Nothing selected","ERROR");
            }
        }

        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            AddProdForm addProdForm = new AddProdForm();
            addProdForm.Show();
        }

        private void btnProdMod_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow.Selected)
            {
                Product _prod = (Product)dgProducts.CurrentRow.DataBoundItem;
                ModProdForm modProdForm = new ModProdForm(_prod);
                modProdForm.Show();
            }
            else
            {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string msg = "Exit? Unsaved changes will be lost";
            if (MessageBox.Show(msg, "Confirm Exit", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                // Exit Application
                this.Close();
            }
        }



        // ---------- Form Functions ----------
        private void btnPartDel_Click(object sender, EventArgs e)
        {
            if (dgParts.CurrentRow.Selected)
            {
                string msg = "Are you sure you want to delete this part?";
                if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Inventory.removePart((int)dgParts.CurrentRow.Cells["PartID"].Value);
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }

        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            if (textPartSearch.Text.Length < 1)
            { return; }
            foreach (DataGridViewRow row in dgParts.Rows)
            {
                string value1 = row.Cells["PartID"].Value.ToString();
                string value2 = row.Cells["Name"].Value.ToString();
                if (value1.Contains(textPartSearch.Text) || (value2.Contains(textPartSearch.Text)))
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void btnProdDel_Click(object sender, EventArgs e)
        {
            if (dgProducts.CurrentRow.Selected)
            {
                string msg = "Are you sure you want to delete this product?";
                if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Inventory.removeProduct((int)dgProducts.CurrentRow.Cells["ProductID"].Value);
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }

        private void btnProdSearch_Click(object sender, EventArgs e)
        {
            if (textProdSearch.Text.Length < 1)
            { return; }
            foreach (DataGridViewRow row in dgProducts.Rows)
            {
                string value1 = row.Cells["ProductID"].Value.ToString();
                string value2 = row.Cells["Name"].Value.ToString();
                if (value1.Contains(textProdSearch.Text) || (value2.Contains(textProdSearch.Text)))
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }



        // ---------- Form Events ----------
        private void dgParts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgParts.ClearSelection();
        }

        private void dgProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgProducts.ClearSelection();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dgParts.Refresh();
            dgProducts.Refresh();
        }



        // ---------- Functions ----------
        private void doInitData()
        {
            if (doInit)
            {
                // Various Train Parts
                Part part01 = new Inhouse() { PartID = 101, Name = "Steam Engine", InStock = 4, Min = 1, Max = 10, Price = 10123.98M, MachineID = 7889785 };
                Part part02 = new Inhouse() { PartID = 102, Name = "Coal Car", InStock = 4, Min = 1, Max = 10, Price = 3568.12M, MachineID = 2447899 };
                Part part03 = new Inhouse() { PartID = 103, Name = "Caboose", InStock = 1, Min = 0, Max = 1, Price = 4398.09M, MachineID = 1220000 };
                Part part04 = new Inhouse() { PartID = 104, Name = "Wheels", InStock = 97, Min = 16, Max = 300, Price = 129.00M, MachineID = 3699989 };
                Part part05 = new Inhouse() { PartID = 105, Name = "Couplers", InStock = 33, Min = 4, Max = 100, Price = 187.50M, MachineID = 1244744 };
                Part part06 = new Outsourced() { PartID = 901, Name = "Boxcars", InStock = 13, Min = 1, Max = 30, Price = 5150.34M, CompanyName = "Lionel" };
                Part part07 = new Outsourced() { PartID = 902, Name = "Tanker Cars", InStock = 27, Min = 1, Max = 30, Price = 6855.97M, CompanyName = "Lionel" };
                Part part08 = new Outsourced() { PartID = 903, Name = "Passenger Cars", InStock = 8, Min = 1, Max = 30, Price = 8999.90M, CompanyName = "Amtraxx" };
                Part part09 = new Outsourced() { PartID = 904, Name = "Grain Hoppers", InStock = 9, Min = 1, Max = 30, Price = 6723.04M, CompanyName = "Lionel" };
                Inventory.addPart((Inhouse)part01);
                Inventory.addPart((Inhouse)part02);
                Inventory.addPart((Inhouse)part03);
                Inventory.addPart((Inhouse)part04);
                Inventory.addPart((Inhouse)part05);
                Inventory.addPart((Outsourced)part06);
                Inventory.addPart((Outsourced)part07);
                Inventory.addPart((Outsourced)part08);
                Inventory.addPart((Outsourced)part09);

                // Freight Train + Associated Parts
                Product prod01 = new Product() { ProductID = 1, Name = "Freight Train", InStock = 2, Min = 0, Max = 3, Price = 195000.00M };
                Inventory.addProduct(prod01);
                prod01.AssociatedParts.Add(part01); // Steam Engine
                prod01.AssociatedParts.Add(part02); // Coal Car
                prod01.AssociatedParts.Add(part06); // Boxcars
                prod01.AssociatedParts.Add(part09); // Grain Hoppers
                prod01.AssociatedParts.Add(part03); // Caboose
                prod01.AssociatedParts.Add(part04); // Wheels
                prod01.AssociatedParts.Add(part05); // Couplers

                // Passenger Train + Associated Parts
                Product prod02 = new Product() { ProductID = 2, Name = "Passenger Train", InStock = 1, Min = 0, Max = 3, Price = 259000.00M };
                Inventory.addProduct(prod02);
                prod02.AssociatedParts.Add(part01); // Steam Engine
                prod02.AssociatedParts.Add(part02); // Coal Car
                prod02.AssociatedParts.Add(part06); // Passenger Cars
                prod02.AssociatedParts.Add(part04); // Wheels
                prod02.AssociatedParts.Add(part05); // Couplers

                // Freight Train + Associated Parts
                Product prod03 = new Product() { ProductID = 3, Name = "Tanker Train", InStock = 1, Min = 0, Max = 3, Price = 177500.00M };
                Inventory.addProduct(prod03);
                prod03.AssociatedParts.Add(part01); // Steam Engine
                prod03.AssociatedParts.Add(part02); // Coal Car
                prod03.AssociatedParts.Add(part07); // Tanker Cars
                prod03.AssociatedParts.Add(part04); // Wheels
                prod03.AssociatedParts.Add(part05); // Couplers

            }
        }
    }
}
