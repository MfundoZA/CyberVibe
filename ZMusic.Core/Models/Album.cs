using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZMusic.Core.Models
{
    class Album : INotifyPropertyChanged
    {
        private string title;
        private string artist;
        private int numberOfTracks;
        private int yearRealeased;
        private Genre genre;

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
