
using System.Windows.Input;

namespace ModalDialogExample.ViewModels.Commands
{
    internal interface ICancelCommand : ICommand
    {
        event EventHandler? Cancel;
    }
}