using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiber_Diary
{
    public partial class EditForm : Form
    {
        public Message msg;

        public EditForm(Message msg)
        {
            InitializeComponent();

            this.msg = msg;
            comboBox1.Items.AddRange(Enum.GetNames(typeof(MessageStatus)));
            comboBox1.Text = MessageStatus.Created.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            msg.Title = textBoxTitle.Text;
            msg.Description = textBoxDescription.Text;
            msg.Status = (MessageStatus)Enum.Parse(typeof(MessageStatus), comboBox1.Text);
            msg.Planned = (DateTime)dateTimePickerPlanned.Value;
            msg.Created = DateTime.Now;

            this.Close();
            MessageBox.Show("Message Added.");
        }
    }
}