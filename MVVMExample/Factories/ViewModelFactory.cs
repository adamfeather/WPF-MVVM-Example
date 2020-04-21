using System;
using MVVMExample.ViewModels;

namespace MVVMExample.Factories
{
    public class ViewModelFactory
    {
        private readonly Func<FindPersonViewModel> _findPersonViewModel;
        private readonly Func<AddPersonViewModel> _addPersonViewModel;
        private readonly Func<DeletePersonViewModel> _deletePersonViewModel;
        private readonly Func<EditablePersonViewModel> _editablePersonViewModel;

        public ViewModelFactory(
            Func<FindPersonViewModel> findPersonViewModel,
            Func<AddPersonViewModel> addPersonViewModel,
            Func<DeletePersonViewModel> deletePersonViewModel,
            Func<EditablePersonViewModel> editablePersonViewModel)
        {
            _findPersonViewModel = findPersonViewModel;
            _addPersonViewModel = addPersonViewModel;
            _deletePersonViewModel = deletePersonViewModel;
            _editablePersonViewModel = editablePersonViewModel;
        }

        public FindPersonViewModel CreateFindPersonViewModel()
        {
            return _findPersonViewModel();
        }

        public AddPersonViewModel CreateAddPersonViewModel()
        {
            return _addPersonViewModel();
        }

        public DeletePersonViewModel CreateDeletePersonViewModel()
        {
            return _deletePersonViewModel();
        }

        public EditablePersonViewModel CreateEditablePersonViewModel()
        {
            return _editablePersonViewModel();
        }
    }
}
