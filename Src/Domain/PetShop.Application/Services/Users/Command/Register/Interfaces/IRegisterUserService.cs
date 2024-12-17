using PetShop.Application.Services.Users.Command.Register.Dtos;
using PetShop.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Command.Register.Interfaces
{
    public interface IRegisterUserService
    {
        ResultDto<ResultRegisterUserDto> Executer(RequestRegisterUserDto request);
    }
}
