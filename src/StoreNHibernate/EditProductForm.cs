using Model;
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
    public partial class EditProductForm : Form
    {
        public Product product;
        public Category category;
        public SelectCategoryForm selectCategoryForm;
        public ManageProduct manageProduct = new ManageProduct();

        public EditProductForm(Product product)
        {
            InitializeComponent();

            this.product = product;
            textBoxProductName.Text = product.Name;

            textBoxCategoryName.Text = product.Category.Name;
            textBoxCategoryName.Tag = product.Category;

            textBoxSupplierName.Text = product.Supplier.Name;

            category = product.Category; // запомнить категорию продукта на случай измениний
        }

        private void buttonSelectingCategory_Click(object sender, EventArgs e)
        {
            using (this.selectCategoryForm = new SelectCategoryForm())
            {
                selectCategoryForm.ShowDialog();

                if (selectCategoryForm.category != null)
                {
                    textBoxCategoryName.Tag = selectCategoryForm.category;
                    textBoxCategoryName.Text = selectCategoryForm.category.Name;
                }
            }
        }

        private void buttonSelectingSupplier_Click(object sender, EventArgs e)
        {
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //проверяем изменялсь ли категория продукта, чтобы обновить в продукте только изменившиеся поля

            if (textBoxCategoryName.Text == category.Name && textBoxCategoryName.Tag == category) // если категория не менялась, то условие true
            {
                this.product.Name = textBoxProductName.Text;

                manageProduct.UpdateProduct(this.product);
            }
            else
            {
                this.product.Name = textBoxProductName.Text;
                this.product.Category = textBoxCategoryName.Tag as Category;
                manageProduct.UpdateProduct(this.product);
            }

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            SelectImageForm selectImageForm = new SelectImageForm();
            selectImageForm.ShowDialog();
        }
    }
}