using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public interface IExecutiveRepository
    {
        void CreateExecutive(Executive executive);
        public IEnumerable<Executive> AllExecutives { get; }
        public Executive GetExecutiveByPosition(string Position);
        public Executive GetExecutiveByLevel(string Level);

    }
}

