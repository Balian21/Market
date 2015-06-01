using StoreNHibernate.Model;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreNHibernate
{
    public partial class EditSupplierForm : Form
    {
        public Supplier supplier;
        ManageSupplier manageSupplier = new ManageSupplier();
        public EditSupplierForm(Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;

            textBoxSupplierName.Text = supplier.Name;
            textBoxSupplierName.Tag = supplier;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            supplier.Name = textBoxSupplierName.Text;
            manageSupplier.UpdateSupplier(supplier);
            this.Close();
        }
    }
}
