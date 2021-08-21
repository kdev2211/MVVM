using System.ComponentModel;
using T3MVVM.ViewModels;
using Xamarin.Forms;

namespace T3MVVM.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}