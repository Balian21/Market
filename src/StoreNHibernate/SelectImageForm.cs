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
    public partial class SelectImageForm : Form
    {
        public Product product;
        private ImageConverter converter = new ImageConverter();

        public SelectImageForm(Product product)
        {
            InitializeComponent();

            this.product = product;
        }

        private void SelectImageForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Выбор изображения";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";

            pictureBox1.Image = (Image)converter.ConvertFrom(product.ImageData);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                pictureBox1.Load(textBox1.Text);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
            byte[] temp = memoryStream.GetBuffer();
            product.ImageData = temp;

            if (pictureBox1.Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                product.ImageMimeType = "image/jpeg";
            }
            else if (pictureBox1.Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                product.ImageMimeType = "image/png";
            }
            else if (pictureBox1.Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
            {
                product.ImageMimeType = "image/gif";
            }

            DialogResult = DialogResult.OK;
        }
    }
}