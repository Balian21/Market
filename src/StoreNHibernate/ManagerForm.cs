using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
using StoreNHibernate.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreNHibernate
{
    public partial class ManagerForm : Form
    {
        public ManageProduct managerProduct = new ManageProduct();
        public ManageCategory manageCategory = new ManageCategory();
        private Category currentChangedCategory;

        public ManagerForm()
        {
            InitializeComponent();
            GetCategories();
        }

        public void GetCategories()
        {
            treeViewCategories.Nodes.Clear();

            using (var session = NHibernateHelper.OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                var roots = session.QueryOver<Category>().Where(p => p.Parent == null).List();

                foreach (var root in roots)
                {
                    CreateCategoryNode(root, treeViewCategories.Nodes);
                }

                transaction.Commit();
            }
        }

        private void CreateCategoryNode(Category category, TreeNodeCollection nodes)
        {
            var node = new TreeNode(category.Name)
            {
                Tag = category
            };

            foreach (var child in category.Children)
            {
                CreateCategoryNode(child, node.Nodes);
            }

            nodes.Add(node);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewCategories.SelectedNode != null)
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    Category parent = treeViewCategories.SelectedNode.Tag as Model.Category;
                    Category dbCategory = session.Get<Category>(parent.Id);

                    Category child = new Category()
                    {
                        Name = "Новая категория",
                        Parent = dbCategory
                    };
                    session.Save(child);
                    dbCategory.Children.Add(child);

                    transaction.Commit();
                }                
            }
            else
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                {
                    Category root = new Category()
                    {
                        Name = "Новая категория"
                    };

                    treeViewCategories.Nodes.Add(root.Name);

                    session.Save(root);
                    transaction.Commit();
                }                
            }
            GetCategories();
        }

        public void AddRow(Product product)
        {
            DataGridViewRow row = dataGridViewProducts.Rows[dataGridViewProducts.Rows.Add()];
            row.Cells["Product"].Value = product.Name;
            row.Cells["Supplier"].Value = product.Supplier.Name;
            row.Cells["Category"].Value = product.Category.Name;
            row.Tag = product;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (AddProductForm addProductForm = new AddProductForm())
            {
                if (addProductForm.ShowDialog() == DialogResult.OK)
                {
                    GetProductsForCurrentCategory(currentChangedCategory);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Product product = dataGridViewProducts.CurrentRow.Tag as Product;

            DialogResult dialogresult = MessageBox.Show("Удалить \"" + product.Name + "\"?", "Удаление продукта", MessageBoxButtons.OKCancel);
            if (dialogresult == DialogResult.OK)
            {
                currentChangedCategory = product.Category;
                managerProduct.DeleteProduct(product);

                GetProductsForCurrentCategory(currentChangedCategory);
            }
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridViewProducts.Rows.Clear();
            using (ISession session = NHibernateHelper.OpenSession())
            {
                currentChangedCategory = treeViewCategories.SelectedNode.Tag as Category;

                var products = session.QueryOver<Product>()
                                        .Where(p => p.Category == currentChangedCategory)
                                        .List();

                dataGridViewProducts.Rows.Clear();

                foreach (Product product in products)
                {
                    AddRow(product);
                }
            }
        }

        public void GetProductsForCurrentCategory(Category currentCategory)
        {
            dataGridViewProducts.Rows.Clear();

            IList<Product> prds = new List<Product>();
            using (ISession session_2 = NHibernateHelper.OpenSession())
            {
                var products = session_2.QueryOver<Product>()
                                        .Where(p => p.Category == currentCategory)
                                        .List();
                dataGridViewProducts.Rows.Clear();

                foreach (Product pr in products)
                {
                    AddRow(pr);
                }
            }
        }

        private void treeViewCategories_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Category currentCategory = treeViewCategories.SelectedNode.Tag as Category;
            using (EditCategoryForm editCategoryForm = new EditCategoryForm(currentCategory))
            {
                if (editCategoryForm.ShowDialog() == DialogResult.OK)
                {
                    manageCategory.UpdateCategory(currentCategory);
                    treeViewCategories.Nodes.Clear();
                    GetCategories();
                }
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                Product currentProduct = dataGridViewProducts.CurrentRow.Tag as Product;
                Category tempCategory = currentProduct.Category; // tempCategory - запоминаем первоначальную категорию продукта до изменений
                using (EditProductForm editProductForm = new EditProductForm(currentProduct))
                {
                    editProductForm.ShowDialog();
                    dataGridViewProducts.Rows.Clear();
                    GetProductsForCurrentCategory(tempCategory);
                }
            }
        }

        private void SuppliersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SuppliersListForm supplierListForm = new SuppliersListForm())
            {
                supplierListForm.ShowDialog();
            }
        }

        private void RemoveCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewCategories.SelectedNode != null)
            {
                Category category = treeViewCategories.SelectedNode.Tag as Model.Category;
                DialogResult dialogresult = MessageBox.Show("Удалить категорию \"" + category.Name + "\"?", "Удаление категории", MessageBoxButtons.OKCancel);
                if (dialogresult == DialogResult.OK)
                {
                    manageCategory.DeleteCategory(category);
                    GetCategories();
                    dataGridViewProducts.Rows.Clear();
                }
            }
        }
    }
}