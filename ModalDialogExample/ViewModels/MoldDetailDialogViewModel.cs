using ModalDialogExample.Models;
using ModalDialogExample.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalDialogExample.ViewModels
{
    internal class MoldDetailDialogViewModel : ViewModelBase
    {
        private Mold selectedMold;
        private Mold originalMold;

        public MoldDetailDialogViewModel(Mold mold, ISaveMoldCommand saveMoldCommand, ICancelCommand cancelCommand)
        {
            selectedMold = mold;
            originalMold = mold.Clone();

            SaveCommand = saveMoldCommand;
            CancelCommand = cancelCommand;
            CancelCommand.Cancel += CancelEdit;
        }

        

        public Mold SelectedMold
		{
			get { return selectedMold; }
			set { 
				selectedMold = value; 
				OnPropertyChanged();
			}
		}

        public string DialogTitle { get
            {
                return string.Format("Mold Details: {0}", SelectedMold.Name);
            }
        }

        public ICommand SaveCommand { get; }

        public ICancelCommand CancelCommand { get; }

        private void CancelEdit(object? sender, EventArgs e)
        {
            ResetModelValues();
        }

        private void ResetModelValues()
        {
            selectedMold.Name = originalMold!.Name;
            selectedMold.Description = originalMold!.Description;
        }
    }
}
