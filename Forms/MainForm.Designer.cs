
namespace IMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.textPartSearch = new System.Windows.Forms.TextBox();
            this.btnPartAdd = new System.Windows.Forms.Button();
            this.btnPartDel = new System.Windows.Forms.Button();
            this.btnPartMod = new System.Windows.Forms.Button();
            this.btnProdMod = new System.Windows.Forms.Button();
            this.btnProdDel = new System.Windows.Forms.Button();
            this.btnProdAdd = new System.Windows.Forms.Button();
            this.textProdSearch = new System.Windows.Forms.TextBox();
            this.btnProdSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgParts
            // 
            this.dgParts.AllowUserToAddRows = false;
            this.dgParts.AllowUserToDeleteRows = false;
            this.dgParts.AllowUserToOrderColumns = true;
            this.dgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgParts.Location = new System.Drawing.Point(18, 75);
            this.dgParts.MultiSelect = false;
            this.dgParts.Name = "dgParts";
            this.dgParts.ReadOnly = true;
            this.dgParts.RowHeadersVisible = false;
            this.dgParts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgParts.Size = new System.Drawing.Size(409, 242);
            this.dgParts.TabIndex = 3;
            this.dgParts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgParts_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventory Management System";
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPartSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartSearch.Location = new System.Drawing.Point(216, 46);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(54, 23);
            this.btnPartSearch.TabIndex = 1;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = false;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // textPartSearch
            // 
            this.textPartSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartSearch.Location = new System.Drawing.Point(276, 49);
            this.textPartSearch.Name = "textPartSearch";
            this.textPartSearch.Size = new System.Drawing.Size(151, 22);
            this.textPartSearch.TabIndex = 2;
            // 
            // btnPartAdd
            // 
            this.btnPartAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPartAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartAdd.Location = new System.Drawing.Point(244, 324);
            this.btnPartAdd.Name = "btnPartAdd";
            this.btnPartAdd.Size = new System.Drawing.Size(54, 23);
            this.btnPartAdd.TabIndex = 4;
            this.btnPartAdd.Text = "Add";
            this.btnPartAdd.UseVisualStyleBackColor = false;
            this.btnPartAdd.Click += new System.EventHandler(this.btnPartAdd_Click);
            // 
            // btnPartDel
            // 
            this.btnPartDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPartDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartDel.Location = new System.Drawing.Point(364, 324);
            this.btnPartDel.Name = "btnPartDel";
            this.btnPartDel.Size = new System.Drawing.Size(54, 23);
            this.btnPartDel.TabIndex = 6;
            this.btnPartDel.Text = "Delete";
            this.btnPartDel.UseVisualStyleBackColor = false;
            this.btnPartDel.Click += new System.EventHandler(this.btnPartDel_Click);
            // 
            // btnPartMod
            // 
            this.btnPartMod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPartMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPartMod.Location = new System.Drawing.Point(304, 324);
            this.btnPartMod.Name = "btnPartMod";
            this.btnPartMod.Size = new System.Drawing.Size(54, 23);
            this.btnPartMod.TabIndex = 5;
            this.btnPartMod.Text = "Modify";
            this.btnPartMod.UseVisualStyleBackColor = false;
            this.btnPartMod.Click += new System.EventHandler(this.btnPartMod_Click);
            // 
            // btnProdMod
            // 
            this.btnProdMod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdMod.Location = new System.Drawing.Point(725, 324);
            this.btnProdMod.Name = "btnProdMod";
            this.btnProdMod.Size = new System.Drawing.Size(54, 23);
            this.btnProdMod.TabIndex = 11;
            this.btnProdMod.Text = "Modify";
            this.btnProdMod.UseVisualStyleBackColor = false;
            this.btnProdMod.Click += new System.EventHandler(this.btnProdMod_Click);
            // 
            // btnProdDel
            // 
            this.btnProdDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdDel.Location = new System.Drawing.Point(785, 324);
            this.btnProdDel.Name = "btnProdDel";
            this.btnProdDel.Size = new System.Drawing.Size(54, 23);
            this.btnProdDel.TabIndex = 12;
            this.btnProdDel.Text = "Delete";
            this.btnProdDel.UseVisualStyleBackColor = false;
            this.btnProdDel.Click += new System.EventHandler(this.btnProdDel_Click);
            // 
            // btnProdAdd
            // 
            this.btnProdAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdAdd.Location = new System.Drawing.Point(665, 324);
            this.btnProdAdd.Name = "btnProdAdd";
            this.btnProdAdd.Size = new System.Drawing.Size(54, 23);
            this.btnProdAdd.TabIndex = 10;
            this.btnProdAdd.Text = "Add";
            this.btnProdAdd.UseVisualStyleBackColor = false;
            this.btnProdAdd.Click += new System.EventHandler(this.btnProdAdd_Click);
            // 
            // textProdSearch
            // 
            this.textProdSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProdSearch.Location = new System.Drawing.Point(697, 49);
            this.textProdSearch.Name = "textProdSearch";
            this.textProdSearch.Size = new System.Drawing.Size(151, 22);
            this.textProdSearch.TabIndex = 8;
            // 
            // btnProdSearch
            // 
            this.btnProdSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProdSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdSearch.Location = new System.Drawing.Point(637, 46);
            this.btnProdSearch.Name = "btnProdSearch";
            this.btnProdSearch.Size = new System.Drawing.Size(54, 23);
            this.btnProdSearch.TabIndex = 7;
            this.btnProdSearch.Text = "Search";
            this.btnProdSearch.UseVisualStyleBackColor = false;
            this.btnProdSearch.Click += new System.EventHandler(this.btnProdSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(456, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products";
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToOrderColumns = true;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgProducts.Location = new System.Drawing.Point(439, 75);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.RowHeadersVisible = false;
            this.dgProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(409, 242);
            this.dgProducts.TabIndex = 9;
            this.dgProducts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProducts_DataBindingComplete);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(785, 358);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(IMS.Classes.Part);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(866, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProdMod);
            this.Controls.Add(this.btnProdDel);
            this.Controls.Add(this.btnProdAdd);
            this.Controls.Add(this.textProdSearch);
            this.Controls.Add(this.btnProdSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.btnPartMod);
            this.Controls.Add(this.btnPartDel);
            this.Controls.Add(this.btnPartAdd);
            this.Controls.Add(this.textPartSearch);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgParts);
            this.Name = "MainForm";
            this.Text = "IMS_HarryStafford";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.TextBox textPartSearch;
        private System.Windows.Forms.Button btnPartAdd;
        private System.Windows.Forms.Button btnPartDel;
        private System.Windows.Forms.Button btnPartMod;
        private System.Windows.Forms.Button btnProdMod;
        private System.Windows.Forms.Button btnProdDel;
        private System.Windows.Forms.Button btnProdAdd;
        private System.Windows.Forms.TextBox textProdSearch;
        private System.Windows.Forms.Button btnProdSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource partBindingSource;
    }
}

