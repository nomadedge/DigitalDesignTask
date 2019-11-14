﻿using DigitalDesignTask.UWP.ViewModels;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DigitalDesignTask.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
            set { DataContext = value; }
        }

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();
        }
    }
}