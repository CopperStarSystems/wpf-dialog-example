using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalDialogExample.Models
{
    internal class Mold
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        public Mold Clone()
        {
            return (Mold)this.MemberwiseClone();
        }
    }
}
