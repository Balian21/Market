using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiber_Diary
{
    public class Message : INotifyPropertyChanged
    {
        private int id;
        private string title;
        private string description;
        private DateTime? planned;
        private MessageStatus status;

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual int Id { get; set; }

        public virtual string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.NotifyPropertyChanged("Title");
            }
        }

        public virtual string Description
        {
            get { return description; }
            set
            {
                description = value;
                this.NotifyPropertyChanged("Description");
            }
        }

        public virtual DateTime? Planned
        {
            get { return planned; }
            set
            {
                planned = value;
                this.NotifyPropertyChanged("Planned");
            }
        }

        public virtual MessageStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                this.NotifyPropertyChanged("Status");
            }
        }

        public virtual DateTime? Created { get; set; }

        public virtual void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}