using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using MVVMExample.Data;
using MVVMExample.Data.Commands;
using MVVMExample.Data.Queries;
using MVVMExample.Factories;
using MVVMExample.ViewModels;
using MVVMExample.Views;

namespace MVVMExample
{
    public class CompositionRoot
    {
        public CompositionRoot()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<Messenger>();

            SimpleIoc.Default.Register<InMemoryData>();

            SimpleIoc.Default.Register<MainWindow>();

            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<FindPersonViewModel>();
            SimpleIoc.Default.Register<AddPersonViewModel>();
            SimpleIoc.Default.Register<DeletePersonViewModel>();
            SimpleIoc.Default.Register<EditablePersonViewModel>();

            SimpleIoc.Default.Register<GetPeople>();
            SimpleIoc.Default.Register<AddPerson>();
            SimpleIoc.Default.Register<DeletePerson>();
            SimpleIoc.Default.Register<GetCheeses>();

            SimpleIoc.Default.Register<ViewModelFactory>(() =>
            {
                return new ViewModelFactory(
                    () => SimpleIoc.Default.GetInstance<FindPersonViewModel>(),
                    () => SimpleIoc.Default.GetInstance<AddPersonViewModel>(),
                    () => SimpleIoc.Default.GetInstance<DeletePersonViewModel>(),
                    () => SimpleIoc.Default.GetInstance<EditablePersonViewModel>());
            });
        }

        public void StartApp()
        {
            var mainWindow = SimpleIoc.Default.GetInstance<MainWindow>();

            mainWindow.Show();
        }
    }
}