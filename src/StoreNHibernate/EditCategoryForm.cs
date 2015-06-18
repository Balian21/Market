using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Drawing;

using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreNHibernate
{
    public partial class EditCategoryForm : Form
    {
        public Category category;
        private ImageConverter converter = new ImageConverter();
        private ManageCategory managerCategory = new ManageCategory();

        public EditCategoryForm(Category category)
        {
            InitializeComponent();

            this.category = category;

            textBoxCategory.Text = category.Name;

            if (category.ImageData != null)
            {
                pictureBox1.Image = (Image)converter.ConvertFrom(category.ImageData);
            }
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            using (SelectImageForm selectImageForm = new SelectImageForm(category))
            {
                if (selectImageForm.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = (Image)converter.ConvertFrom(category.ImageData);
                    managerCategory.UpdateCategory(category);
                }
            }
        }
    }
}