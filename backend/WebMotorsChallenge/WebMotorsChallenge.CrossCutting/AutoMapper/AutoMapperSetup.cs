using AutoMapper;
using WebMotorsChallenge.Application.Queries.AdversitingQuery;
using WebMotorsChallenge.Application.Queries.AdvertisementsQuery;
using WebMotorsChallenge.Domain.Entities;

namespace WebMotorsChallenge.CrossCutting.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
            public AutoMapperSetup()
            {
                #region CommandToEntity 
                
                #endregion

                #region EnityToQuery
                CreateMap<Adversiting, AdvertisementsItems>();
                CreateMap<Adversiting, AdversitingQueryResponse>();

            #endregion

        }
    }
}
