using IMS.Classes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class ModPartForm : Form
    {
        // ---------- Variables ----------
        private bool cat = false;



        // ---------- Form Constructor ----------
        public ModPartForm(Inhouse part)
        {
            InitializeComponent();
            radioCat1.Checked = true;
            radioCat2.Checked = false;
            textID.Text = part.PartID.ToString();
            textName.Text = part.Name;
            textInventory.Text = part.InStock.ToString();
            textPrice.Text = part.Price.ToString();
            textMax.Text = part.Max.ToString();
            textMin.Text = part.Min.ToString();
            textCat.Text = part.MachineID.ToString();
            cat = false;
        }

        public ModPartForm(Outsourced part)
        {
            InitializeComponent();
            radioCat1.Checked = false;
            radioCat2.Checked = true;
            textID.Text = part.PartID.ToString();
            textName.Text = part.Name;
            textInventory.Text = part.InStock.ToString();
            textPrice.Text = part.Price.ToString();
            textMax.Text = part.Max.ToString();
            textMin.Text = part.Min.ToString();
            textCat.Text = part.CompanyName;
            cat = true;
        }



        // ---------- Form Functions ----------
        private void btnSave_Click(object sender, EventArgs e)
        {
            int _min, _max, _stock;
            int _machID = -1;
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

            if (radioCat1.Checked)
            {
                try { _machID = Int32.Parse(textCat.Text); }
                catch { MessageBox.Show("'Machine ID' can only be a number", "ERROR"); return; }
            }

            if (string.IsNullOrWhiteSpace(textCat.Text) && radioCat1.Checked)
            {
                MessageBox.Show("'Machine ID' cannot be empty", "ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(textCat.Text) && radioCat2.Checked)
            {
                MessageBox.Show("'Company Name' cannot be empty", "ERROR");
                return;
            }

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

            if (radioCat1.Checked && !cat)
            {
                Part _part = new Inhouse()
                {
                    PartID = Int32.Parse(textID.Text),
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    MachineID = _machID
                };
                Inventory.updatePart(Int32.Parse(textID.Text), (Inhouse)_part);
            }
            else if (radioCat2.Checked && cat)
            {
                Part _part = new Outsourced()
                {
                    PartID = Int32.Parse(textID.Text),
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    CompanyName = textCat.Text
                };
                Inventory.updatePart(Int32.Parse(textID.Text), (Outsourced)_part);
            }
            else if (radioCat1.Checked && cat)
            {
                Part _part = new Inhouse()
                {
                    PartID = Int32.Parse(textID.Text),
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    MachineID = _machID
                };
                Inventory.removePart(Int32.Parse(textID.Text));
                Inventory.addPart((Inhouse)_part);
            }
            else if (radioCat2.Checked && !cat)
            {
                Part _part = new Outsourced()
                {
                    PartID = Int32.Parse(textID.Text),
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    CompanyName = textCat.Text
                };
                Inventory.removePart(Int32.Parse(textID.Text));
                Inventory.addPart((Outsourced)_part);
            }
            else
            {
                MessageBox.Show("An error occured", "ERROR");
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioCat1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCat1.Checked)
            {
                labelCat.Text = "        Machine ID:";
            }
            else
            {
                labelCat.Text = "Company Name:";
            }
        }

        private void radioCat2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCat1.Checked)
            {
                labelCat.Text = "        Machine ID:";
            }
            else
            {
                labelCat.Text = "Company Name:";
            }
        }
    }
}
