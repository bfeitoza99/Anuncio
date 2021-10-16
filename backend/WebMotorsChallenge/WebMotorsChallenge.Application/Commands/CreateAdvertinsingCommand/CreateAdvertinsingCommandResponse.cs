using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Commands.CreateAdvertisingCommand
{
    public class CreateAdvertinsingCommandResponse
    {
        public CreateAdvertinsingCommandResponse(bool isSucess)
        {
            IsSucess = isSucess;
        }

        public bool IsSucess { get; set; }
    }
}
