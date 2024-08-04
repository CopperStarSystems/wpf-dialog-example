using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalDialogExample.ViewModels.Commands
{
    internal abstract class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return CanExecuteInternal(parameter);
        }

        public void Execute(object? parameter)
        {
            ExecuteInternal(parameter);
        }

        protected abstract bool CanExecuteInternal(object? parameter);  

        protected abstract void ExecuteInternal(object? parameter);

        protected void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
