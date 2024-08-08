using ModalDialogExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ModalDialogExample.ViewModels.Commands
{
    internal class CancelCommand : CommandBase, ICancelCommand
    {
        private readonly Window dialogView;

        public CancelCommand(Window dialogView)
        {
            this.dialogView = dialogView;
        }

        public event EventHandler? Cancel;

        protected override bool CanExecuteInternal(object? parameter)
        {
            return true;
        }

        protected override void ExecuteInternal(object? parameter)
        {
            RaiseCancelEvent();
            dialogView.Close();
        }

        void RaiseCancelEvent()
        {
            Cancel?.Invoke(this, EventArgs.Empty);
        }
    }
}
