//-----------------------------------------------------------------------
// <copyright file="WorldController.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Api.Controllers
{
    using HelloSample.Api.Utility;
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    /// <summary>
    /// World Data access.
    /// </summary>
    public class WorldController : ApiController
    {
        /// <summary>
        /// Gets worlds.
        /// </summary>
        /// <returns>An Http response with all worlds listed.</returns>
        [HttpGet]
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = null;

            var data = WorldDataHelper.GetWorlds();

            response = this.Request.CreateResponse(HttpStatusCode.OK, data, "application/json");

            return response;
        }

        /// <summary>
        /// Gets a specific world.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>a world</returns>
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            HttpResponseMessage response = null;

            var data = WorldDataHelper.GetWorlds();

            try
            {
                var rtn = data[id - 1];
                response = this.Request.CreateResponse(HttpStatusCode.OK, rtn, "application/json");
            }
            catch (Exception)
            {
                response = this.Request.CreateResponse(HttpStatusCode.BadRequest, "Request id did not match a world", "application/json");
            }

            return response;
        }

        /// <summary>
        /// Posts the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        public void Post([FromBody]string value)
        {
            // TODO Add more worlds later.
        }

        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="value">The value.</param>
        public void Put(int id, [FromBody]string value)
        {
            // TODO Update worlds later.
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            // TODO Build a Death Star later.
        }
    }
}