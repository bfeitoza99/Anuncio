using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Interfaces.Repositories;
using WebMotorsChallenge.Domain.Entities;

namespace WebMotorsChallenge.Application.Commands.UpdateAdvertinsingCommand
{
    public class UpdateAdvertinsingCommandHandle : IRequestHandler<UpdateAdvertinsingCommandRequest, UpdateAdvertinsingCommandResponse>
    {

        private readonly IMapper _mapper;
        private readonly IAdvertisingRepository _advertisingRepository;
        public UpdateAdvertinsingCommandHandle(IMapper mapper, IAdvertisingRepository advertisingRepository)
        {
            _mapper = mapper;
            _advertisingRepository = advertisingRepository;
        }

        public async Task<UpdateAdvertinsingCommandResponse> Handle(UpdateAdvertinsingCommandRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _advertisingRepository.Update(_mapper.Map<Adversiting>(request));

                return _mapper.Map<UpdateAdvertinsingCommandResponse>(response);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
