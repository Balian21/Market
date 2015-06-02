using Model;
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
    public partial class AddSupplierForm : Form
    {
        private Supplier supplier = new Supplier();
        private ManageSupplier manageSupplier = new ManageSupplier();

        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            supplier.Name = textBoxSupplierName.Text;

            DialogResult = DialogResult.OK;

            manageSupplier.AddSupplier(supplier);

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}