using FBKsystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public interface IBiodataRepository
    {
        IEnumerable<Biodata> AllMembers { get; }
        Biodata GetMemberById(string MemberId);
       public void CreateMember(Biodata member);
       Biodata UpdateBio(Biodata member);
    }
}
