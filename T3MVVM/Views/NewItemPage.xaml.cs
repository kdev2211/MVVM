using System;
using System.Collections.Generic;
using System.ComponentModel;
using T3MVVM.Models;
using T3MVVM.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T3MVVM.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}