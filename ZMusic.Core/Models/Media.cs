using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZMusic.Core.Models
{
    class Media : INotifyPropertyChanged
    {
        private string title;
        private string artist;
        int yearRealeased;
        object duration;
        string album;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            { 
                artist = value;
                OnPropertyChanged("Artist");
            }
        }
        public int YearRealeased
        {
            get
            {
                return yearRealeased;
            }
            set
            {
                yearRealeased = value;
                OnPropertyChanged("YearRealeased");
            }
        }

        public object Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public string Album
        {
            get
            {
                return album;
            }
            set
            {
                album = value;
                OnPropertyChanged("Album");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
