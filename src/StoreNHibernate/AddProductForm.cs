using NHibernate;
using StoreNHibernate.Model;
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
    public partial class AddProductForm : Form
    {
        public Product product = new Product();
        public ManageProduct managerProduct = new ManageProduct();
        public SelectCategoryForm selectCategoryForm;
        private List<Category> categoriesList = new List<Category>();
        private List<Supplier> suppliersList = new List<Supplier>();

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                IList<Supplier> suppliers = session.CreateCriteria<Supplier>().List<Supplier>();

                suppliersComboBox.DataSource = suppliers;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            product.Name = productTextBox.Text;

            product.Category = textBoxCategory.Tag as Category;
            product.Supplier = suppliersComboBox.SelectedItem as Supplier;

            DialogResult = DialogResult.OK;

            managerProduct.AddProduct(product);

            this.Close();
        }

        private void buttonSelectingCategory_Click(object sender, EventArgs e)
        {
            using (this.selectCategoryForm = new SelectCategoryForm())
            {
                selectCategoryForm.ShowDialog();

                if (selectCategoryForm.category != null)
                {
                    textBoxCategory.Tag = selectCategoryForm.category;
                    textBoxCategory.Text = selectCategoryForm.category.Name;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}