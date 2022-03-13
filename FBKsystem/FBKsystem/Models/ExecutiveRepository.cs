using FBKsystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FBKsystem.Models
{
    public class ExecutiveRepository : IExecutiveRepository
    {
        private readonly FBKsystemContext _appDbContext;
        public ExecutiveRepository(FBKsystemContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Executive> AllExecutives
        {
            get
            {
                return _appDbContext.Executives;
            }
        }

        public void CreateExecutive(Executive executive)
        {
            string RegDate = DateTime.Now.ToString();
            executive.RegDate = RegDate;
            _appDbContext.Executives.Add(executive);
            _appDbContext.SaveChanges();
            
        }

        public Executive GetExecutiveByLevel(string level)
        {
            return _appDbContext.Executives.FirstOrDefault(p => p.Level == level);
        }
        public Executive GetExecutiveByPosition(string Position)
        {
            return _appDbContext.Executives.FirstOrDefault(p => p.Position == Position);
        }
    }
}
