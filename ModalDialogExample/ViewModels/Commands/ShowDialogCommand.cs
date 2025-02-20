﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ModalDialogExample.Models;
using ModalDialogExample.Views;

namespace ModalDialogExample.ViewModels.Commands
{
    internal class ShowDialogCommand : CommandBase
    {
        protected override bool CanExecuteInternal(object? parameter)
        {
            return parameter != null;
        }

        protected override void ExecuteInternal(object? parameter)
        {
            var mold = (Mold)parameter!;
            var view = new MoldDetailDialog();
            var saveCommand = new SaveMoldCommand(view);
            var cancelCommand = new CancelCommand(view);
            var viewModel = new MoldDetailDialogViewModel(mold, saveCommand, cancelCommand);
            view.DataContext = viewModel;

            view.ShowDialog();
        }
    }
}