﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ModalDialogExample.ViewModels.Commands
{
    internal class CancelCommand : CommandBase, ICancelCommand
    {
        protected override bool CanExecuteInternal(object? parameter)
        {
            return true;
        }

        protected override void ExecuteInternal(object? parameter)
        {
            MessageBox.Show("Cancelling");
        }
    }
}
