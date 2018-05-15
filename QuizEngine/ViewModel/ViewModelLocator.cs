using GalaSoft.MvvmLight.Ioc;
using CommonServiceLocator;

namespace QuizEngine.ViewModel
{

        public class ViewModelLocator
        {
            public ViewModelLocator()
            {
                ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

                SimpleIoc.Default.Register<MainViewModel>();
            }

            public MainViewModel MainViewModel
            {
                get
                {
                    return ServiceLocator.Current.GetInstance<MainViewModel>();
                }
            }
        }
}
