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
        Mold[] exampleMolds =
        {
            new Mold(),
            new Mold(),
            new Mold()
        };

        public MainViewModel()
        {
            // Normally AvailableMolds would be dynamically populated, but this 
            // is just example code so we use the hardcoded examples above
            AvailableMolds = new ObservableCollection<Mold>(exampleMolds);
            ShowDialogCommand = new ShowDialogCommand();
        }



        public ObservableCollection<Mold> AvailableMolds { get; }


        public ICommand ShowDialogCommand { get; }
    }
}
