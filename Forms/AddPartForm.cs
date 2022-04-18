using IMS.Classes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class AddPartForm : Form
    {
        // ---------- Variables ----------
        private int _partIdx;



        // ---------- Form Constructor ----------
        public AddPartForm()
        {
            InitializeComponent();
            _partIdx = Inventory.InhousePartIdx + 101;
            textID.Text = _partIdx.ToString();
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

            if (radioCat1.Checked)
            {
                Part _part = new Inhouse()
                {
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    MachineID = _machID
                };
                _part.PartID = Inventory.InhousePartIdx + 101;
                Inventory.addPart((Inhouse)_part);
            }
            else
            {
                Part _part = new Outsourced()
                {
                    Name = textName.Text,
                    InStock = _stock,
                    Min = _min,
                    Max = _max,
                    Price = _price,
                    CompanyName = textCat.Text
                };
                _part.PartID = Inventory.OutsourcedPartIdx + 901;
                Inventory.addPart((Outsourced)_part);
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
                _partIdx = Inventory.InhousePartIdx + 101;
            }
            else
            {
                labelCat.Text = "Company Name:";
                _partIdx = Inventory.OutsourcedPartIdx + 901;
            }
            textID.Text = _partIdx.ToString();
        }

        private void radioCat2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCat1.Checked)
            {
                labelCat.Text = "        Machine ID:";
                _partIdx = Inventory.InhousePartIdx + 101;
            }
            else
            {
                labelCat.Text = "Company Name:";
                _partIdx = Inventory.OutsourcedPartIdx + 901;
            }
            textID.Text = _partIdx.ToString();
        }
    }
}
