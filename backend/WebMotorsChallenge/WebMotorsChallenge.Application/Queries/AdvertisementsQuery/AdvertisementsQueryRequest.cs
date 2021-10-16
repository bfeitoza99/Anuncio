using MediatR;

namespace WebMotorsChallenge.Application.Queries.AdvertisementsQuery
{
    public class AdvertisementsQueryRequest : IRequest<AdvertisementsQueryResponse>
    {
        public AdvertisementsQueryRequest()
        {

        }
    }
}
