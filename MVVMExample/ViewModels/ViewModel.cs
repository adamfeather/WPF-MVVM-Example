using GalaSoft.MvvmLight;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

namespace MVVMExample.ViewModels
{
    public class ViewModel : ViewModelBase
    {
        /// <summary>
        /// This gives us the ReSharper option to transform an autoproperty into a property with change notification
        /// </summary>
        [NotifyPropertyChangedInvocator]

        public override void RaisePropertyChanged([CallerMemberName]string property = "")
        {
            base.RaisePropertyChanged(property);
        }
    }
}