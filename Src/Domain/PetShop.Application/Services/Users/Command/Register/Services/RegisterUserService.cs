using PetShop.Application.Interfaces.Contexts;
using PetShop.Application.Services.Users.Command.Register.Dtos;
using PetShop.Application.Services.Users.Command.Register.Interfaces;
using PetShop.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Command.Register.Services
{
    public class RegisterUserService : IRegisterUserService
    {
        private readonly IDatabaseContext _context;
        public RegisterUserService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultDto<ResultRegisterUserDto> Executer(RequestRegisterUserDto request)
        {
            throw new NotImplementedException();
        }
    }
}
