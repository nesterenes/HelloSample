//-----------------------------------------------------------------------
// <copyright file="DataAccessHelperTest.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Tests.Controllers
{
    using HelloSample.Api.Utility;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// World Controller Tests
    /// </summary>
    [TestClass]
    public class DataAccessHelperTest
    {
        /// <summary>
        /// Get method test
        /// </summary>
        [TestMethod]
        public void GetConnectionString_Test()
        {
            // Act
            var result = DataAccessHelper.GetConnectionString();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}