using System;
using System.IO;
using T3MVVM.Services;
using T3MVVM.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace T3MVVM
{
    public partial class App : Application
    {
        static pagoService _pagoService;

        public static pagoService pagoService
        {
            get
            {
                if (_pagoService == null)
                {
                    _pagoService = new pagoService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Pagos.db3"));
                }
                return _pagoService;
            }

        }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
