﻿using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Entities;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Application.Commands.CreateAdvertisingCommand
{
    public class CreateAdvertisingCommandHandle : IRequestHandler<CreateAdvertisingCommandRequest, CreateAdvertisingCommandResponse>
    {

        private readonly IMapper _mapper;
        private readonly IAdvertisingRepository _advertisingRepository;
        public CreateAdvertisingCommandHandle(IMapper mapper, IAdvertisingRepository advertisingRepository)
        {
            _mapper = mapper;
            _advertisingRepository = advertisingRepository;
        }

        public async  Task<CreateAdvertisingCommandResponse> Handle(CreateAdvertisingCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new CreateAdvertisingCommandResponse(true);
            try
            {               
                await _advertisingRepository.Save(_mapper.Map<Adversiting>(request));

                return response;
            }
            catch (Exception ex)
            {
                response.IsSucess = false;
                throw ex;
            }
        }
    }
}
