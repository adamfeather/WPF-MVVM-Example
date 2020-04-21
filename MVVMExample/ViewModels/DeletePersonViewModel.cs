using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MVVMExample.Data.Commands;
using MVVMExample.Data.Queries;
using MVVMExample.Messages;
using MVVMExample.Models;

namespace MVVMExample.ViewModels
{
    public class DeletePersonViewModel
    {
        private readonly Messenger _messenger;
        private readonly DeletePerson _deletePerson;

        public ObservableCollection<Person> People { get; private set; }

        public Person SelectedPerson { get; set; }

        public ICommand DeletePersonCommand { get; private set; }

        public DeletePersonViewModel(
            Messenger messenger,
            GetPeople getPeople,
            DeletePerson deletePerson)
        {
            _messenger = messenger;
            _deletePerson = deletePerson;
            People = new ObservableCollection<Person>(getPeople.Execute());

            DeletePersonCommand = new RelayCommand(OnDeletePersonCommand, CanExecuteDeletePersonCommand);
        }

        private void OnDeletePersonCommand()
        {
            _deletePerson.Execute(SelectedPerson);

            People.Remove(SelectedPerson);

            _messenger.Send(new PersonDeletedMessage());
        }

        private bool CanExecuteDeletePersonCommand()
        {
            return SelectedPerson != null;
        }
    }
}
