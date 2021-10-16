using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Commands.CreateAdvertisingCommand
{
    public class CreateAdvertisingCommandResponse
    {
        public CreateAdvertisingCommandResponse(bool isSucess)
        {
            IsSucess = isSucess;
        }

        public bool IsSucess { get; set; }
    }
}
