using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Data.Repositories
{
    public class UnitOfWork :  IUnitOfWork
    {
        private readonly AdvertisingContext _context;


        public UnitOfWork(AdvertisingContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
