using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace QuizEngine.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        
        public ICommand _SaveToFile { get; private set; }
        public ICommand _NextQuestion { get; private set; }

        public MainViewModel()
        {
            this._SaveToFile = new RelayCommand(SaveToFile,true);
            this._NextQuestion=new GalaSoft.MvvmLight.CommandWpf.RelayCommand(NextQuestion);
           /* this.LoadDataCommand = new RelayCommand(() =>
            {
                this.Data = "xDDDD";
            });*/
        }

        private void SaveToFile()
        {
            Debug.WriteLine("testcompletedddd");
        }

        private void NextQuestion()
        {
            Debug.WriteLine("testcompletedddd");
        }
        //public ICommand LoadDataCommand { get; private set; }
/*
        public string Data
        {
            get
            {
                //return this.data;
            }
            set
            {
               // this.data = value;
                this.RaisePropertyChanged("Data");
            }
        }*/
    }
}
