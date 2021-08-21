using System;

using System.Threading.Tasks;
using Xamarin.Forms;
using T3MVVM.Models;
using System.Collections.ObjectModel;

using T3MVVM.Views;

namespace T3MVVM.ViewModels
{
    public class pagoViewModel : BasePagosViewModel
    {
        public Command LoadPagoCommand { get; }

        public ObservableCollection<Pagos> PagoInfo { get; }

        public Command AddPagoCommand { get; }

        public Command PagoTappedEdit { get; }
        public Command PagoTappedDelete{ get; }

        public pagoViewModel(INavigation _navigation)
        {
            LoadPagoCommand = new Command(async () => await ExecuteLoadPagoCommand());
            PagoInfo = new ObservableCollection<Pagos>();
            AddPagoCommand = new Command(OnAddPago);
            PagoTappedEdit = new Command<Pagos>(OnEditPago);
            PagoTappedDelete = new Command<Pagos>(OnDeletePago);
            Navigation = _navigation;
        }


        public void OnAppearing()
        {
            IsBusy = true;
  
        }

        async Task ExecuteLoadPagoCommand()
        {
            IsBusy = true;

            try
            {
                PagoInfo.Clear();
                var prodList = await App.pagoService.GetPagosAsync();
                
                foreach (var prod in prodList)
                {
                    PagoInfo.Add(prod);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }


        }


        async Task ExecuteLoadPagoCommand2()
         {
            IsBusy = true;

            try
            {
            
  
            }
            catch (Exception)
            {
             
            }
            finally
            {
                IsBusy = true;
            }


        }
        private async void OnAddPago(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddPagoPage));
        }
        private async void OnEditPago(Pagos pagos)
        {
            await Navigation.PushAsync(new AddPagoPage(pagos));
        }
        private async void OnDeletePago(Pagos pagos)
        {
   
            await ExecuteLoadPagoCommand2();
            await App.pagoService.DeletePagoAsync(pagos.Id_empleados);
           

            
        }
    }
}
