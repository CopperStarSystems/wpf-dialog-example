using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ModalDialogExample.Models;

namespace ModalDialogExample.ViewModels.Commands
{
    internal class ShowDialogCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return parameter != null;
        }

        public void Execute(object? parameter)
        {
            var mold = (Mold)parameter!;
            MessageBox.Show(mold.Name);
        }
    }
}