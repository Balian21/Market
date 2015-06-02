using Model;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Linq;
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
    public partial class SelectCategoryForm : Form
    {
        public Category category;

        public SelectCategoryForm()
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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (treeViewCategories.SelectedNode != null)
            {
                category = treeViewCategories.SelectedNode.Tag as Category;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ничего не выбрано!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}