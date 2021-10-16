using AutoMapper;
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
                
                #endregion
            
             }
    }
}
