using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Queries.GetUsers
{
    public class ResultGetDto
    {
        public List<GetUserDto> Users { get; set; }
        public int Rows { get; set; }
    }
}
