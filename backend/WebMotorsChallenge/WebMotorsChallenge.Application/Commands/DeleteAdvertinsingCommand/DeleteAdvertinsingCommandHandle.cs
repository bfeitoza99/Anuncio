using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebMotorsChallenge.Domain.Interfaces.Repositories;

namespace WebMotorsChallenge.Application.Commands.DeleteAdvertinsingCommand
{
    public class DeleteAdvertinsingCommandHandle : IRequestHandler<DeleteAdvertinsingCommandRequest, DeleteAdvertinsingCommandResponse>
    {

        private readonly IMapper _mapper;
        private readonly IAdvertisingRepository _advertisingRepository;
        public DeleteAdvertinsingCommandHandle(IMapper mapper, IAdvertisingRepository advertisingRepository)
        {
            _mapper = mapper;
            _advertisingRepository = advertisingRepository;
        }

        public async Task<DeleteAdvertinsingCommandResponse> Handle(DeleteAdvertinsingCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new DeleteAdvertinsingCommandResponse(true);
            try
            {
                await _advertisingRepository.Delete(request.Id);
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
