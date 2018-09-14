using AR.LinesManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AR.LinesManagementSystem.Controllers
{
    public class ApplicationController : Controller
    {


        //public UserRepository userRepo;
        // this is the main user information of the application
        // we use ApplicationUser because it is convient to trouble shoot
        // user issues
        public string ApplicationUserAlias { get; set; }

        // these user properties are admin users
        // the value can be NULL if the user is not administrator
        //public User ApplicationUser { get; set; }
        //public DirectoryAccount ApplicationUserDirectoryAccount { get; set; }

        public ApplicationController(IUnitOfWork IUow, ILogger log)
        {

        }

    }
}
