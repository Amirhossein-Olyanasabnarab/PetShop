using PetShop.Application.Interfaces.Contexts;
using PetShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Queries.GetUsers
{
    public class GetrUserService : IGetUserService
    {
        private readonly IDatabaseContext _context;
        public GetrUserService(IDatabaseContext context)
        {
            _context = context;
        }

        public ResultGetDto Execute(GetRequestDto request)
        {
            var users = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request.SearchKey))
            {
                users = users.Where(p => p.FullName.Contains(request.SearchKey) && p.Email.Contains(request.SearchKey));
            }

            int rowsCount = 0;
            var userList = users.ToPaged(request.Page, 20, out rowsCount).Select(p => new GetUserDto
            {
                Email = p.Email,
                FullName = p.FullName,
                Id = p.Id,
            }).ToList();

            return new ResultGetDto
            {
                Rows = rowsCount,
                Users = userList
            };
        }
    }
}
