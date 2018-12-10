using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using samplebrowser.Helpers;
using Microsoft.AspNetCore.Hosting;

namespace samplebrowser.Controllers
{
    public class SourceCodeTabController : Controller
    {
        private IHostingEnvironment _appEnv;
        public SourceCodeTabController(IHostingEnvironment appEnv)
        {
            _appEnv = appEnv;
        }
        public ActionResult Index(string file)
        {
            return Content(new SourceTabActionResult(file, "false", _appEnv).getContent(_appEnv));
        }

    }
}
