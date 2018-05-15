using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Collections;
using System.Collections.ObjectModel;
using QuizEngine.Model;
using QuizEngine.View;

namespace QuizEngine.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        
        public ICommand _saveToFile { get; private set; }
        public ICommand _nextQuestion { get; private set; }

        private readonly ModelDataInput Model;

        private string _question;
        private string _error;
        private ObservableCollection<string> _answers;
        private ObservableCollection<bool> _boolAnswers;
      

        public MainViewModel()
        {
            Model=new ModelDataInput();
            _answers=new ObservableCollection<string>();
            _boolAnswers = new ObservableCollection<bool>();

            InitTextFill();
            this._saveToFile = new RelayCommand(SaveToFile,true);
            this._nextQuestion=new RelayCommand(NextQuestion);
        }
#region Text Fillers
        private void InitTextFill()
        {
            Question = "Type Question here!";
            for (int i = 0; i < 4; i++)
            {
                Answers.Add("Type Answer here!");
                BoolAnswers.Add(false);
            }
        }

        private void AfterTextFill()
        {
            Question = "Type Question here!";
            for (int i = 0; i < 4; i++)
            {
                Answers[i]="Type Answer here!";
                BoolAnswers[i]=false;
            }
        }
#endregion
        private void SaveToFile()
        {
            Model.SaveJson();
        }

        private void NextQuestion()
        {
            Dictionary<string,bool> temporary=new Dictionary<string, bool>();

            Error = "";
            for (int i = 0; i < 4; i++)
            {
                if (!temporary.ContainsKey(_answers[i]))
                {
                    temporary.Add(_answers[i], _boolAnswers[i]);
                }
                else
                {
                    Error = "Answers must be diffrent!";
                    return;
                }
                   
            }
            Model.AddPage(temporary,_question);
            AfterTextFill();
        }
#region property to Binding

        public string Error
        {
            get
            {
                return _error;
            }
            set
            {
                _error = value;
                RaisePropertyChanged("Error");
            }
        }

        public string Question
        {
            get
            {
              return _question;
            }
            set
            {
              _question = value;
              RaisePropertyChanged("Question");
            }
        }

        public ObservableCollection<string> Answers
        {
            get
            {
                return _answers;
            }
            set
            {
                _answers = value;
                RaisePropertyChanged("Answers");
                
            }
        }

        public ObservableCollection<bool> BoolAnswers
        {
            get
            {
                return _boolAnswers;
            }
            set
            {
                _boolAnswers = value;
                RaisePropertyChanged("BoolAnswers");
            }
        }
#endregion
    }
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
