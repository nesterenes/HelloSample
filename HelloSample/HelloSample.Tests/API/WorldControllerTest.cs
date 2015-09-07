//-----------------------------------------------------------------------
// <copyright file="WorldControllerTest.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Tests.Controllers
{
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Hosting;
    using HelloSample.Api.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;

    /// <summary>
    /// World Controller Tests
    /// </summary>
    [TestClass]
    public class WorldControllerTest
    {
        /// <summary>
        /// Get method test
        /// </summary>
        [TestMethod]
        public void Get_Test()
        {
            // Arrange
            WorldController controller = this.CreateController<WorldController>();

            // Act
            HttpResponseMessage result = controller.Get();
            var output = JsonConvert.DeserializeObject<string[]>(result.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, output.Count());
            Assert.AreEqual("Mars", output[0]);
        }

        /// <summary>
        /// Gets the by id_ ok.
        /// </summary>
        [TestMethod]
        public void GetById_OK_Test()
        {
            // Arrange
            WorldController controller = this.CreateController<WorldController>();

            // Act
            HttpResponseMessage result = controller.Get(1);
            var output = JsonConvert.DeserializeObject<string>(result.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual("Mars", output);
        }

        /// <summary>
        /// Gets the by id_ bad request.
        /// </summary>
        [TestMethod]
        public void GetById_BadRequest_Test()
        {
            // Arrange
            WorldController controller = this.CreateController<WorldController>();

            // Act
            HttpResponseMessage result = controller.Get(100);
            var output = JsonConvert.DeserializeObject<string>(result.Content.ReadAsStringAsync().Result);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
        }

        /// <summary>
        /// Creates the controller.
        /// </summary>
        /// <typeparam name="T">Controller type</typeparam>
        /// <returns>The controller</returns>
        protected T CreateController<T>() where T : ApiController, new()
        {
            var rtn = new T();
            rtn.Request = new HttpRequestMessage();
            rtn.Request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            return rtn;
        }
    }
}