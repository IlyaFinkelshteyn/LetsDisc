﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using LetsDisc.Controllers;

namespace LetsDisc.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : LetsDiscControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
