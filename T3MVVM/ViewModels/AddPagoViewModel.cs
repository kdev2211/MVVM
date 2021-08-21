using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using T3MVVM.Models;
namespace T3MVVM.ViewModels
{
   public class AddPagoViewModel:BasePagosViewModel
    {
        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        public AddPagoViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);

            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
            Pagos = new Pagos();
        }

        private async void OnSave()
        {
          
     
            var pago = Pagos;
            
            await App.pagoService.AddPagoAsync(pago);

            await Shell.Current.GoToAsync("..");
        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }


    }
}
