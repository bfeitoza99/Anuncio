using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Queries.AdvertisementsQuery
{
    public class AdvertisementsQueryHandle : IRequestHandler<AdvertisementsQueryRequest, AdvertisementsQueryResponse>
    {
        public AdvertisementsQueryHandle()
        {

        }

        public async Task<AdvertisementsQueryResponse> Handle(AdvertisementsQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
