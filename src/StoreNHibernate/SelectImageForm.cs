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
    public partial class SelectImageForm : Form
    {
        public SelectImageForm()
        {
            InitializeComponent();
        }

        private void SelectImageForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выбор изображения";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.Load(textBox1.Text);
            }
        }
    }
}