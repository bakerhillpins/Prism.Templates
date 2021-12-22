using Prism.Mvvm;

namespace FullApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty( ref _title, value ); }
        }

        public MainPageViewModel()
        {

        }
    }
}
