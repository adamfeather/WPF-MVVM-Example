using System.Windows;
using MVVMExample.ViewModels;

namespace MVVMExample.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewModel)
        {
            this.DataContext = viewModel;

            InitializeComponent();
        }
    }
}
