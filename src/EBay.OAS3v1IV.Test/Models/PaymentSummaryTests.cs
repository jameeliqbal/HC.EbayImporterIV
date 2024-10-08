/* 
 * Fulfillment API
 *
 * Use the Fulfillment API to complete the process of packaging, addressing, handling, and shipping each order on behalf of the seller, in accordance with the payment method and timing specified at checkout.
 *
 * OpenAPI spec version: v1.20.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using EBay.OAS3v1IV.Apis;
using EBay.OAS3v1IV.Models;
using EBay.OAS3v1IV.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace EBay.OAS3v1IV.Test
{
    /// <summary>
    ///  Class for testing PaymentSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class PaymentSummaryTests
    {
        // TODO uncomment below to declare an instance variable for PaymentSummary
        //private PaymentSummary instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of PaymentSummary
            //instance = new PaymentSummary();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PaymentSummary
        /// </summary>
        [Test]
        public void PaymentSummaryInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PaymentSummary
            //Assert.IsInstanceOfType<PaymentSummary> (instance, "variable 'instance' is a PaymentSummary");
        }


        /// <summary>
        /// Test the property 'Payments'
        /// </summary>
        [Test]
        public void PaymentsTest()
        {
            // TODO unit test for the property 'Payments'
        }
        /// <summary>
        /// Test the property 'Refunds'
        /// </summary>
        [Test]
        public void RefundsTest()
        {
            // TODO unit test for the property 'Refunds'
        }
        /// <summary>
        /// Test the property 'TotalDueSeller'
        /// </summary>
        [Test]
        public void TotalDueSellerTest()
        {
            // TODO unit test for the property 'TotalDueSeller'
        }

    }

}
