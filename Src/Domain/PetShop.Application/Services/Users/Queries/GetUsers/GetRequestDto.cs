using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Queries.GetUsers
{
    public class GetRequestDto
    {
        public string SearchKey { get; set; }
        public int Page { get; set; }
    }
}
