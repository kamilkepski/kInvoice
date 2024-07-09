using System;
using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Windowing;
using Windows.ApplicationModel;

namespace kInvoice
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.AppWindow.Title = "kInvoice - darmowy program do wystawiania faktur";
            MainNavigationView.SelectionChanged += MainNavigationView_SelectionChanged;
        }

        private void MainNavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem selectedItem = args.SelectedItem as NavigationViewItem;
            if (selectedItem != null)
            {
                switch (selectedItem.Name)
                {
                    case "ClientPage":
                        ContentFrame.Navigate(typeof(Views.ClientPage));
                        break;
                    case "RecipientPage":
                        ContentFrame.Navigate(typeof(Views.RecipientPage));
                        break;
                }
            }
        }

    }
}
