//-----------------------------------------------------------------------
// <copyright file="WorldDataHelper.cs" company="1UpApplications">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Neil Shaffer</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloSample.Api.Utility
{
    /// <summary>
    /// World data helper
    /// </summary>
    public class WorldDataHelper
    {
        /// <summary>
        /// Gets the hello world.
        /// </summary>
        /// <returns>hello world</returns>
        public static string GetHelloWorld()
        {
            return "Hello World";
        }

        /// <summary>
        /// Gets the worlds.
        /// </summary>
        /// <returns>Array of Worlds</returns>
        public static string[] GetWorlds()
        {
            return new string[] { "Mars", "Earth", "Pluto" };
        }
    }
}