using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Application.Queries.AdversitingQuery
{
    public class AdversitingQueryHandle : IRequestHandler<AdversitingQueryRequest, AdversitingQueryResponse>
    {

        private readonly IMapper _mapper;
        private readonly IAdvertisingRepository _advertisingRepository;
        public AdversitingQueryHandle(IMapper mapper, IAdvertisingRepository advertisingRepository)
        {
            _mapper = mapper;
            _advertisingRepository = advertisingRepository;
        }

        public async Task<AdversitingQueryResponse> Handle(AdversitingQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {                
                var result = _mapper.Map<AdversitingQueryResponse>(_advertisingRepository.First(request.Id));

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
