using SimpleCrud.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SimpleCrud.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SimpleCrudController : AbpControllerBase
{
    protected SimpleCrudController()
    {
        LocalizationResource = typeof(SimpleCrudResource);
    }
}
