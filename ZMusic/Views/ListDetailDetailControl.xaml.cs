using System;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using ZMusic.Core.Models;

namespace ZMusic.Views
{
    public sealed partial class ListDetailDetailControl : UserControl
    {
        public SampleOrder ListMenuItem
        {
            get { return GetValue(ListMenuItemProperty) as SampleOrder; }
            set { SetValue(ListMenuItemProperty, value); }
        }

        public static readonly DependencyProperty ListMenuItemProperty = DependencyProperty.Register("ListMenuItem", typeof(SampleOrder), typeof(ListDetailDetailControl), new PropertyMetadata(null, OnListMenuItemPropertyChanged));

        public ListDetailDetailControl()
        {
            InitializeComponent();
        }

        private static void OnListMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as ListDetailDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
