using ModalDialogExample.Models;
using ModalDialogExample.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModalDialogExample.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        readonly Mold[] exampleMolds =
        [
            new() {
                Id = 1,
                Name = "Mold 1"
            },
            new()
            {
                Id = 2,
                Name = "Mold 2"
            },
            new()
            {
                Id= 3,
                Name = "Mold 3"
            }
        ];

        public MainViewModel()
        {
            // Normally AvailableMolds would be dynamically populated, but this 
            // is just example code so we use the hardcoded examples above
            AvailableMolds = new ObservableCollection<Mold>(exampleMolds);
            ShowDialogCommand = new ShowDialogCommand();
        }



        public ObservableCollection<Mold> AvailableMolds { get; }

        private Mold selectedMold;

        public Mold SelectedMold
        {
            get { return selectedMold; }
            set { 
                selectedMold = value;
                OnPropertyChanged();
            }
        }


        public ICommand ShowDialogCommand { get; }
    }
}
