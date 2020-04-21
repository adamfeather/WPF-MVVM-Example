using MVVMExample.Data.Queries;
using MVVMExample.Models;
using System.Collections.Generic;

namespace MVVMExample.ViewModels
{
    public class EditablePersonViewModel : ViewModel
    {
        private Person _person;

        public Person Person
        {
            get => _person;
            set
            {
                if (Equals(value, _person)) return;
                _person = value;
                RaisePropertyChanged();
            }
        }

        public IEnumerable<Cheese> Cheeses { get; set; }

        public bool IdVisible { get; set; }

        public EditablePersonViewModel(GetCheeses getCheeses)
        {
            Cheeses = getCheeses.Execute();

            Person = new Person();
        }
    }
}
