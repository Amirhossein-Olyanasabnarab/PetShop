using Microsoft.AspNetCore.Mvc;
using PetShop.Application.Services.Users.Queries.GetUsers;

namespace EndPoint.Site.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly IGetUserService _userService;
        public UsersController(IGetUserService getUserService)
        {
            _userService = getUserService;
        }
        public IActionResult Index(string searchKey, int page = 1)
        {
            return View(_userService.Execute(new GetRequestDto
            {
                SearchKey = searchKey,
                Page = page
            }));
        }
    }
}
