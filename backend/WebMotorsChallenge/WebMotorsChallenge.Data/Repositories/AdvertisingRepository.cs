using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Entities;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Data.Repositories
{
    public class AdvertisingRepository : IAdvertisingRepository, IDisposable
    {

        private readonly AdvertisingContext _context;
        private readonly IUnitOfWork _unitOfWork;


        public AdvertisingRepository(AdvertisingContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public IList<Adversiting> All()
        {
            return _context.Adversiting.ToList();
        }

        public Adversiting First(int id)
        {
            return _context.Adversiting.FirstOrDefault(x=> x.Id == id);
        }

        public async Task Save(Adversiting adversiting)
        {
            _context.Adversiting.Add(adversiting);
            await _unitOfWork.Commit();
        }

        public async Task Delete(int id)
        {
            var adversiting = new Adversiting() { Id = id };
            _context.Adversiting.Attach(adversiting);
            _context.Adversiting.Remove(adversiting);
            await _unitOfWork.Commit();
        }

        public async Task<Adversiting> Update(Adversiting adversiting)
        {
            _context.Adversiting.Update(adversiting);
            await _unitOfWork.Commit();
            return adversiting;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
