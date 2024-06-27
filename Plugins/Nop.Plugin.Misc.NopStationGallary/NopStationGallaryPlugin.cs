using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.FileProviders;
using Nop.Core;
using Nop.Plugin.Misc.NopStationGallary.Components;
using Nop.Services.Cms;
using Nop.Services.Common;
using Nop.Services.Plugins;

namespace Nop.Plugin.Misc.NopStationGallary
{
    public class NopStationGallaryPlugin : BasePlugin, IMiscPlugin
    {
        private readonly IWebHelper _webHelper;

        public bool HideInWidgetList => throw new NotImplementedException();

        public NopStationGallaryPlugin(IWebHelper webHelper)
        {
            _webHelper = webHelper;
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task InstallAsync()
        {
            await base.InstallAsync();
        }

        /// <summary>
        /// Uninstall plugin
        /// </summary>
        /// <returns>A task that represents the asynchronous operation</returns>
        public override async Task UninstallAsync()
        {
            await base.UninstallAsync();
        }

        public override string GetConfigurationPageUrl()
        {
            return _webHelper.GetStoreLocation() + "Admin/MiscNopStationGallary/Configure";
        }
    }
}
