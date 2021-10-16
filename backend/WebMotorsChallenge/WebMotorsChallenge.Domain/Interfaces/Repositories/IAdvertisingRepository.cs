using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Entities;

namespace WebMotorsChallenge.Domain.Interfaces.Repositories
{
    public interface IAdvertisingRepository
    {
        IList<Adversiting> All();
        Adversiting First(int id);
        Task Save(Adversiting adversiting);
        Task Delete(Adversiting adversiting);
        Task<Adversiting> Update(Adversiting adversiting);
    }
}
