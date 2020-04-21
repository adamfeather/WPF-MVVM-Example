using GalaSoft.MvvmLight.CommandWpf;
using MVVMExample.Data.Commands;
using MVVMExample.Data.Queries;
using MVVMExample.Factories;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using MVVMExample.Messages;
using MVVMExample.Models;

namespace MVVMExample.ViewModels
{
    public class AddPersonViewModel
    {
        private readonly Messenger _messenger;
        private readonly AddPerson _addPerson;

        public ICommand AddPersonCommand { get; private set; }

        public EditablePersonViewModel EditablePersonViewModel { get; private set; }

        public AddPersonViewModel(
            Messenger messenger,
            AddPerson addPerson,
            ViewModelFactory viewModelFactory)
        {
            _messenger = messenger;
            _addPerson = addPerson;

            AddPersonCommand = new RelayCommand(OnAddPersonCommand, CanExecuteAddPersonCommand);

            EditablePersonViewModel = viewModelFactory.CreateEditablePersonViewModel();
            EditablePersonViewModel.IdVisible = false;
        }

        private bool CanExecuteAddPersonCommand()
        {
            return EditablePersonViewModel.Person.IsValid;
        }

        private void OnAddPersonCommand()
        {
            _addPerson.Execute(EditablePersonViewModel.Person);

            EditablePersonViewModel.Person = new Person();

            _messenger.Send(new PersonAddedMessage());
        }
    }
}
