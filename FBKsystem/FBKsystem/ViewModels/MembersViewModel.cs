using FBKsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.ViewModels
{
    public class MembersViewModel
    {
        public IEnumerable<Biodata>Biodata { get; set;  }
        public IEnumerable<Executive> Executives { get; set; }
    }
}
