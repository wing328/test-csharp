/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\ 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing FakeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FakeApiTests
    {
        private FakeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FakeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FakeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOf' FakeApi
            Assert.IsInstanceOf(typeof(FakeApi), instance);
        }

        
        /// <summary>
        /// Test TestEndpointParameters
        /// </summary>
        [Test]
        public void TestEndpointParametersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? number = null;
            //double? _double = null;
            //string _string = null;
            //byte[] _byte = null;
            //int? integer = null;
            //int? int32 = null;
            //long? int64 = null;
            //float? _float = null;
            //byte[] binary = null;
            //DateTime? date = null;
            //DateTime? dateTime = null;
            //string password = null;
            //instance.TestEndpointParameters(number, _double, _string, _byte, integer, int32, int64, _float, binary, date, dateTime, password);
            
        }
        
    }

}
