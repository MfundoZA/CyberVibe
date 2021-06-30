using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ZMusic.Core.Models
{
    class Artist : INotifyPropertyChanged
    {
        private string name;
        private ObservableCollection<Media> singles;
        private ObservableCollection<Album> albums;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public ObservableCollection<Media> Singles
        {
            get
            {
                return singles;
            }
            set
            {
                singles = value;
                OnPropertyChanged("Singles");
            }
        }

        public ObservableCollection<Album> Albums
        {
            get
            {
                return albums;
            }
            set
            {
                albums = value;
                OnPropertyChanged("Albums");
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
