using System;
using System.Collections.Generic;
using System.Text;
using SimpleCrud.Localization;
using Volo.Abp.Application.Services;

namespace SimpleCrud;

/* Inherit your application services from this class.
 */
public abstract class SimpleCrudAppService : ApplicationService
{
    protected SimpleCrudAppService()
    {
        LocalizationResource = typeof(SimpleCrudResource);
    }
}
