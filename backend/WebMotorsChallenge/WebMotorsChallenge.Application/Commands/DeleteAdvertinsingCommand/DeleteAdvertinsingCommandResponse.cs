using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMotorsChallenge.Application.Commands.DeleteAdvertinsingCommand
{
    public class DeleteAdvertinsingCommandResponse
    {
        public DeleteAdvertinsingCommandResponse(bool isSucess)
        {
            IsSucess = isSucess;
        }

        public bool IsSucess { get; set; }
    }
}
