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
    public partial class ListForm : Form
    {
        private MessageManager messageManager = new MessageManager();
        private BindingList<Message> allMessages;

        public ListForm()
        {
            InitializeComponent();

            GetAllMessagesFromDB();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Message msg = new Message() { Created = DateTime.Now };
            using (EditForm editForm = new EditForm(msg))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    messageManager.AddMessage(msg);
                    allMessages.Add(msg);
                }
            };
        }

        public void GetAllMessagesFromDB()
        {
            IList<Message> messages = messageManager.GetMessages();
            allMessages = new BindingList<Message>(messages);
            this.messageBindingSource.DataSource = allMessages;
        }
    }
}