using FBKsystem.Data;
using FBKsystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public class BiodataRepository : IBiodataRepository
    {
       
        private readonly FBKsystemContext _appDbContext;
        public BiodataRepository(FBKsystemContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Biodata> AllMembers
        {
            get
            {
                return _appDbContext.Members;
            }

        }
        public void CreateMember(Biodata member)
        {
            try
            {
                member.RegDate = DateTime.Now.ToString();
                _appDbContext.Members.Add(member);
                _appDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public Biodata GetMemberById(string memberId)
        {
            return _appDbContext.Members.FirstOrDefault(p => p.MemberId == memberId);
        }

        public Biodata UpdateBio(Biodata member)
        {
            var Upmember = _appDbContext.Members.Attach(member);
            Upmember.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _appDbContext.SaveChanges();
            return member;
        }
    }
}
