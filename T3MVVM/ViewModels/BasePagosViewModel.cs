using System;
using System.Collections.Generic;
using System.Text;
using T3MVVM.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace T3MVVM.ViewModels
{
   public class BasePagosViewModel:INotifyPropertyChanged
    {
        private Pagos _pagosInfo;

        public INavigation Navigation { get; set; }

        public Pagos Pagos
        {
            get { return _pagosInfo; }
            set { _pagosInfo = value;onPropertyChanged(); }
        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                SetProperty(ref isBusy, value);
            }
        }

        protected bool SetProperty<T>(ref T backingPago, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingPago, value))
                return false;
            backingPago = value;
            onChanged?.Invoke();
            onPropertyChanged(propertyName);
            return true;
        }    

            public event PropertyChangedEventHandler PropertyChanged;


        protected void onPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));

        } 

        }
    }

