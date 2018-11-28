using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibraryApp.Controllers
{
    public abstract class LibraryAppControllerBase: AbpController
    {
        protected LibraryAppControllerBase()
        {
            LocalizationSourceName = LibraryAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
