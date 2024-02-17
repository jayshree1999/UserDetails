using Microsoft.AspNetCore.Mvc;
using UserDetails.Data;

namespace UserDetails.Controllers
{
    public class UserController : Controller
    {
        public readonly UserContext UserContext;
        public UserController(UserContext userContext)
        {
            UserContext = userContext;
        }
        public IActionResult Index(string search)
        {

            
            
            var userlist= UserContext.user.ToList();

            if (!String.IsNullOrEmpty(search))
            {
                userlist = UserContext.user.Where(x => x.FirstName == search).ToList();



            }
            return View(userlist);

        }
    }
}
