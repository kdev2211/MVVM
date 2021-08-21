using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using T3MVVM.Models;
using T3MVVM.ViewModels;

namespace T3MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddPagoPage : ContentPage
    {
        public Pagos Pagos { get; set; }
        public AddPagoPage()
        {
            InitializeComponent();
            BindingContext = new AddPagoViewModel();
        }
        public AddPagoPage(Pagos pagos)
        {
            InitializeComponent();
            BindingContext = new AddPagoViewModel();

            if (pagos != null)
            {
                ((AddPagoViewModel)BindingContext).Pagos = pagos;
            }
        }
    }
}