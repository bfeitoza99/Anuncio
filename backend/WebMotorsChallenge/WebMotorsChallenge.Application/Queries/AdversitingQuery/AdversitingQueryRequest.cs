using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Queries.AdversitingQuery
{
    public class AdversitingQueryRequest : IRequest<AdversitingQueryResponse>
    {
        public AdversitingQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
