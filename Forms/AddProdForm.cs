using IMS.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace IMS
{
    public partial class AddProdForm : Form
    {
        // ---------- Variables ----------
        private int _prodIdx;
        private BindingList<Part> assocParts = new BindingList<Part>();



        // ---------- Form Constructor ----------
        public AddProdForm()
        {
            InitializeComponent();
            _prodIdx = Inventory.ProductIdx + 1;
            textID.Text = _prodIdx.ToString();
            dgPartsAvail.DataSource = Inventory.AllParts;
            dgPartsAvail.Columns["PartID"].HeaderText = "Part ID";
            dgPartsAvail.Columns["Name"].HeaderText = "Name";
            dgPartsAvail.Columns["InStock"].HeaderText = "# In Stock";
            dgPartsAvail.Columns["Min"].Visible = false;
            dgPartsAvail.Columns["Max"].Visible = false;
            dgPartsAvail.Columns["Price"].HeaderText = "Price ea.";
            dgPartsAssoc.DataSource = assocParts;
            dgPartsAssoc.Columns["PartID"].HeaderText = "Part ID";
            dgPartsAssoc.Columns["Name"].HeaderText = "Name";
            dgPartsAssoc.Columns["InStock"].HeaderText = "# In Stock";
            dgPartsAssoc.Columns["Min"].Visible = false;
            dgPartsAssoc.Columns["Max"].Visible = false;
            dgPartsAssoc.Columns["Price"].HeaderText = "Price ea.";
        }



        // ---------- Form Functions ----------
        private void btnSave_Click(object sender, EventArgs e)
        {
            int _min, _max, _stock;
            decimal _price;

            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("'Name' cannot be empty", "ERROR");
                return;
            }

            try { _stock = Int32.Parse(textInventory.Text); }
            catch { MessageBox.Show("'Inventory' can only be a whole number", "ERROR"); return; }

            try { _price = Decimal.Parse(textPrice.Text); }
            catch { MessageBox.Show("'Price' can only be a number", "ERROR"); return; }

            try { _max = Int32.Parse(textMax.Text); }
            catch { MessageBox.Show("'Max' can only be a whole number", "ERROR"); return; }

            try { _min = Int32.Parse(textMin.Text); }
            catch { MessageBox.Show("'Min' can only be a whole number", "ERROR"); return; }

            if (_min > _max)
            {
                MessageBox.Show("'Min' cannot be greater than 'Max'", "ERROR");
                return;
            }

            if (_stock < _min || _stock > _max)
            {
                MessageBox.Show("'Inventory' cannot be outside of the Min/Max values", "ERROR");
                return;
            }

            /*if (assocParts.Count < 1)
            {
                MessageBox.Show("'Associated Parts' cannot be empty", "ERROR");
                return;
            }*/

            Product _prod = new Product()
            {
                Name = textName.Text,
                InStock = _stock,
                Min = _min,
                Max = _max,
                Price = _price,
                AssociatedParts = assocParts
            };
            _prod.ProductID = Inventory.ProductIdx + 1;
            Inventory.addProduct(_prod);

            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textSearch.Text.Length < 1)
            { return; }
            foreach (DataGridViewRow row in dgPartsAvail.Rows)
            {
                string value1 = row.Cells["PartID"].Value.ToString();
                string value2 = row.Cells["Name"].Value.ToString();
                if (value1.Contains(textSearch.Text) || (value2.Contains(textSearch.Text)))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgPartsAvail.CurrentRow.Selected)
            {
                if (dgPartsAvail.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
                {
                    Inhouse _part = (Inhouse)dgPartsAvail.CurrentRow.DataBoundItem;
                    assocParts.Add(_part); // Add Inhouse part
                }
                else
                {
                    Outsourced _part = (Outsourced)dgPartsAvail.CurrentRow.DataBoundItem;
                    assocParts.Add(_part); // Add Outsourced part
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgPartsAssoc.CurrentRow.Selected)
            {
                string msg = "Are you sure you want to delete this part?";
                if (MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (dgPartsAssoc.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
                    {
                        Inhouse _part = (Inhouse)dgPartsAssoc.CurrentRow.DataBoundItem;
                        assocParts.Remove(_part); // Delete Inhouse part
                    }
                    else
                    {
                        Outsourced _part = (Outsourced)dgPartsAssoc.CurrentRow.DataBoundItem;
                        assocParts.Remove(_part); // Delete Outsourced part
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing selected", "ERROR");
            }
        }
    }
}
