using GalaSoft.MvvmLight;
using MVVMExample.Factories;

namespace MVVMExample.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public FindPersonViewModel FindPersonViewModel { get; set; }

        public AddPersonViewModel AddPersonViewModel { get; set; }

        public DeletePersonViewModel DeletePersonViewModel { get; set; }

        public MainViewModel(ViewModelFactory viewModelFactory)
        {
            FindPersonViewModel = viewModelFactory.CreateFindPersonViewModel();

            AddPersonViewModel = viewModelFactory.CreateAddPersonViewModel();

            DeletePersonViewModel = viewModelFactory.CreateDeletePersonViewModel();
        }
    }
}
