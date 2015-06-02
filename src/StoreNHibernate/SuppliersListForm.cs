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
    public partial class SuppliersListForm : Form
    {
        private ManageSupplier manageSupplier = new ManageSupplier();

        public SuppliersListForm()
        {
            InitializeComponent();
            GetSuppliers();
        }

        public void GetSuppliers()
        {
            dataGridViewSuppliers.Rows.Clear();

            IList<Supplier> sprs = new List<Supplier>();
            using (ISession session = NHibernateHelper.OpenSession())
            {
                var suppliers = session.QueryOver<Supplier>().List();

                dataGridViewSuppliers.Rows.Clear();

                foreach (Supplier sp in suppliers)
                {
                    AddRow(sp);
                }
            }
        }

        public void AddRow(Supplier supplier)
        {
            DataGridViewRow row = dataGridViewSuppliers.Rows[dataGridViewSuppliers.Rows.Add()];
            row.Cells["SupplierName"].Value = supplier.Name;

            row.Tag = supplier;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddSupplierForm addSupplierForm = new AddSupplierForm())
            {
                if (addSupplierForm.ShowDialog() == DialogResult.OK)
                {
                    GetSuppliers();
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = dataGridViewSuppliers.CurrentRow.Tag as Supplier;

            DialogResult dialogresult = MessageBox.Show("Удалить поставщика " + supplier.Name + "?", "Удаление поставщика", MessageBoxButtons.OKCancel);
            if (dialogresult == DialogResult.OK)
            {
                manageSupplier.DeleteSupplier(supplier);
                GetSuppliers();
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            Supplier supplier = dataGridViewSuppliers.CurrentRow.Tag as Supplier;
            using (EditSupplierForm editSupplierForm = new EditSupplierForm(supplier))
            {
                editSupplierForm.ShowDialog();
                dataGridViewSuppliers.Rows.Clear();
                GetSuppliers();
            }
        }
    }
}