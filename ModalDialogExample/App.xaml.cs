using ModalDialogExample.ViewModels;
using System.Configuration;
using System.Data;
using System.Windows;

namespace ModalDialogExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var view = new MainWindow();
            var viewModel = new MainViewModel();
            view.DataContext = viewModel;
            view.Show();
        }
    }

}
