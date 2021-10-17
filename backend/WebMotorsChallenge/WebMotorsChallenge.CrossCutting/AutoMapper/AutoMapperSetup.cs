using AutoMapper;
using WebMotorsChallenge.Application.Commands.CreateAdvertisingCommand;
using WebMotorsChallenge.Application.Commands.UpdateAdvertinsingCommand;
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
                CreateMap<CreateAdvertinsingCommandRequest, Adversiting>();
                CreateMap<UpdateAdvertinsingCommandRequest, Adversiting>();
                #endregion

                #region EnityToCommand
                CreateMap<Adversiting, UpdateAdvertinsingCommandResponse>();
                #endregion

                #region EnityToQuery
                CreateMap<Adversiting, AdvertisementsItems>();
                CreateMap<Adversiting, AdversitingQueryResponse>();
                #endregion

        }
    }
}
