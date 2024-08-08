using ModalDialogExample.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ModalDialogExample.ViewModels
{
    internal interface IMainViewModel
    {
        ObservableCollection<Mold> AvailableMolds { get; }
        Mold? SelectedMold { get; set; }
        ICommand ShowDialogCommand { get; }
    }
}