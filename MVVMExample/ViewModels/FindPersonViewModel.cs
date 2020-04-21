using GalaSoft.MvvmLight.Messaging;
using MVVMExample.Data.Queries;
using MVVMExample.Messages;
using MVVMExample.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVVMExample.ViewModels
{
    public class FindPersonViewModel : ViewModel
    {
        private readonly GetPeople _getPeople;
        private IEnumerable<Person> _people;
        private Person _selectedPerson;

        public IEnumerable<Person> People
        {
            get => _people;
            set
            {
                _people = value;
                RaisePropertyChanged();
            }
        }

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                RaisePropertyChanged();
            }
        }

        public FindPersonViewModel(
            Messenger messenger,
            GetPeople getPeople)
        {
            _getPeople = getPeople;

            People = getPeople.Execute();

            SelectedPerson = _people.First();

            messenger.Register<PersonAddedMessage>(this, m => LoadPeople());
            messenger.Register<PersonDeletedMessage>(this, m => LoadPeople());
        }

        private void LoadPeople()
        {
            People = _getPeople.Execute();
        }
    }
}
