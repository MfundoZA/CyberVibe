using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ZMusic.Core.Models
{
    class Album : INotifyPropertyChanged
    {

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
