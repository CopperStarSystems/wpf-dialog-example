using ModalDialogExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalDialogExample.ViewModels
{
    internal class MoldDetailDialogViewModel : ViewModelBase
    {
        public MoldDetailDialogViewModel(Mold mold)
        {
            selectedMold = mold;
        }

        private Mold selectedMold;

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
    }
}
