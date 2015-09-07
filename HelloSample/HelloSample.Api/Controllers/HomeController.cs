//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Api.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Landing page
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Landing page view.
        /// </summary>
        /// <returns>homepage</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}