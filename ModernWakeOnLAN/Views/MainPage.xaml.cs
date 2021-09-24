using System;

using ModernWakeOnLAN.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ModernWakeOnLAN.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
