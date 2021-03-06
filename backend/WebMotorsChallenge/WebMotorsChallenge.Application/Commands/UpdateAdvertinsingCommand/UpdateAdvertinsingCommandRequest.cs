using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Commands.UpdateAdvertinsingCommand
{
    public class UpdateAdvertinsingCommandRequest : IRequest<UpdateAdvertinsingCommandResponse>
    {
        public int Id { get; set; }
        public string Mark { get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public int Year { get; set; }

        public int Mileage { get; set; }

        public string Note { get; set; }
    }
}
