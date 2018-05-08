using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace QuizEngine.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        
        public MainViewModel()
        {
            this.LoadDataCommand = new RelayCommand(() =>
            {
                this.Data = "xDDDD";
            });
        }

        public ICommand LoadDataCommand { get; private set; }

        public string Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
                this.RaisePropertyChanged("Data");
            }
        }
    }
}
