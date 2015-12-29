using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Collections;
using System.Web.Mvc;
using DotNetNuke.Security;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;

namespace Dnn.Modules.DnnMvcModule.Controllers
{
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.Edit)]
    [DnnHandleError]
    public class SettingsController : DnnController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Settings()
        {
            var settings = new Models.Settings();
            settings.Setting1 = ModuleContext.Configuration.ModuleSettings.GetValueOrDefault("DnnMvcModule_Setting1", false);
            settings.Setting2 = ModuleContext.Configuration.ModuleSettings.GetValueOrDefault("DnnMvcModule_Setting2", System.DateTime.Now);

            return View(settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supportsTokens"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        [DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken]
        public ActionResult Settings(Models.Settings settings)
        {
            ModuleContext.Configuration.ModuleSettings["DnnMvcModule_Setting1"] = settings.Setting1.ToString();
            ModuleContext.Configuration.ModuleSettings["DnnMvcModule_Setting2"] = settings.Setting2.ToUniversalTime().ToString("u");

            return RedirectToDefaultRoute();
        }
    }
}