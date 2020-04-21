using System.Windows;

namespace MVVMExample
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var compositionRoot = new CompositionRoot();

            compositionRoot.StartApp();
        }
    }
}
