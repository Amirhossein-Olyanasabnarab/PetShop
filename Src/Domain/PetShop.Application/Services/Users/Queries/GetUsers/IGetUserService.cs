﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Application.Services.Users.Queries.GetUsers
{
    public interface IGetUserService
    {
        ResultGetDto Execute(GetRequestDto request);
    }
}
