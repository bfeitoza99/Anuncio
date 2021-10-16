using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Application.Queries.AdvertisementsQuery
{
    public class AdvertisementsQueryHandle : IRequestHandler<AdvertisementsQueryRequest, AdvertisementsQueryResponse>
    {

        private readonly IMapper _mapper;
        private readonly IAdvertisingRepository _advertisingRepository;
        public AdvertisementsQueryHandle(IMapper mapper, IAdvertisingRepository advertisingRepository)
        {
            _mapper = mapper;
            _advertisingRepository = advertisingRepository;
        }

        public async Task<AdvertisementsQueryResponse> Handle(AdvertisementsQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {

                var result = new AdvertisementsQueryResponse();
                result.Items = _mapper.Map<List<AdvertisementsItems>>(_advertisingRepository.All());

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
