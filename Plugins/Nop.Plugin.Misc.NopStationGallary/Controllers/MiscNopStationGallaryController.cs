using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Misc.NopStationGallary.Models;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Misc.NopStationGallary.Controllers;

[AuthorizeAdmin]
[Area(AreaNames.ADMIN)]
[AutoValidateAntiforgeryToken]
public class MiscNopStationGallaryController : BasePluginController
{
    public async Task<IActionResult> Configure()
    {

        var model = new ConfigureModel();
        return View("~/Plugins/Misc.NopStationGallary/Views/Configure.cshtml", model);
    }
}
