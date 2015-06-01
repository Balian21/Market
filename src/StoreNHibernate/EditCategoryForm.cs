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
    public partial class EditCategoryForm : Form
    {
        public Category category;

        public EditCategoryForm(Category category)
        {
            InitializeComponent();

            this.category = category;

            textBoxCategory.Text = category.Name;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            category.Name = textBoxCategory.Text;
            DialogResult = DialogResult.OK;
        }
    }
}