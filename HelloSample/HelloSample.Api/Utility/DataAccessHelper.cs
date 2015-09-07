//-----------------------------------------------------------------------
// <copyright file="DataAccessHelper.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Api.Utility
{
    using System.Configuration;

    public class DataAccessHelper
    {
        /// <summary>
        /// Gets the connection string.
        /// Note: Exposing the connection string through a public method is a security risk.
        /// It is demonstrated here only for testing purposes.
        /// </summary>
        /// <returns>connection string</returns>
        public static string GetConnectionString()
        {
            // TODO - Encrypt and store data access properties in external file.
            return string.Format(ConfigurationManager.ConnectionStrings["FutureDbConnection"].ToString(), 
                "DataSource", "InitialCatalog", "UserId", "Password");
        }
    }
}