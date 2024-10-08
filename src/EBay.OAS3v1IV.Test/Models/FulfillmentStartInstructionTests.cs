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
    ///  Class for testing FulfillmentStartInstruction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class FulfillmentStartInstructionTests
    {
        // TODO uncomment below to declare an instance variable for FulfillmentStartInstruction
        //private FulfillmentStartInstruction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of FulfillmentStartInstruction
            //instance = new FulfillmentStartInstruction();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentStartInstruction
        /// </summary>
        [Test]
        public void FulfillmentStartInstructionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" FulfillmentStartInstruction
            //Assert.IsInstanceOfType<FulfillmentStartInstruction> (instance, "variable 'instance' is a FulfillmentStartInstruction");
        }


        /// <summary>
        /// Test the property 'EbaySupportedFulfillment'
        /// </summary>
        [Test]
        public void EbaySupportedFulfillmentTest()
        {
            // TODO unit test for the property 'EbaySupportedFulfillment'
        }
        /// <summary>
        /// Test the property 'FinalDestinationAddress'
        /// </summary>
        [Test]
        public void FinalDestinationAddressTest()
        {
            // TODO unit test for the property 'FinalDestinationAddress'
        }
        /// <summary>
        /// Test the property 'FulfillmentInstructionsType'
        /// </summary>
        [Test]
        public void FulfillmentInstructionsTypeTest()
        {
            // TODO unit test for the property 'FulfillmentInstructionsType'
        }
        /// <summary>
        /// Test the property 'MaxEstimatedDeliveryDate'
        /// </summary>
        [Test]
        public void MaxEstimatedDeliveryDateTest()
        {
            // TODO unit test for the property 'MaxEstimatedDeliveryDate'
        }
        /// <summary>
        /// Test the property 'MinEstimatedDeliveryDate'
        /// </summary>
        [Test]
        public void MinEstimatedDeliveryDateTest()
        {
            // TODO unit test for the property 'MinEstimatedDeliveryDate'
        }
        /// <summary>
        /// Test the property 'PickupStep'
        /// </summary>
        [Test]
        public void PickupStepTest()
        {
            // TODO unit test for the property 'PickupStep'
        }
        /// <summary>
        /// Test the property 'ShippingStep'
        /// </summary>
        [Test]
        public void ShippingStepTest()
        {
            // TODO unit test for the property 'ShippingStep'
        }

    }

}
