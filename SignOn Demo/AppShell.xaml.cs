using SignOn_Demo.ViewModels;
using SignOn_Demo.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SignOn_Demo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
