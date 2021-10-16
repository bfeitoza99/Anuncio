using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Commands.DeleteAdvertinsingCommand
{
    public class DeleteAdvertinsingCommandRequest : IRequest<DeleteAdvertinsingCommandResponse>
    {
        public DeleteAdvertinsingCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
