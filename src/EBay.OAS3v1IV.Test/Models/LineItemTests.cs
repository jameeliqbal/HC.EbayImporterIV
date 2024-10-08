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
    ///  Class for testing LineItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class LineItemTests
    {
        // TODO uncomment below to declare an instance variable for LineItem
        //private LineItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of LineItem
            //instance = new LineItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LineItem
        /// </summary>
        [Test]
        public void LineItemInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" LineItem
            //Assert.IsInstanceOfType<LineItem> (instance, "variable 'instance' is a LineItem");
        }


        /// <summary>
        /// Test the property 'AppliedPromotions'
        /// </summary>
        [Test]
        public void AppliedPromotionsTest()
        {
            // TODO unit test for the property 'AppliedPromotions'
        }
        /// <summary>
        /// Test the property 'DeliveryCost'
        /// </summary>
        [Test]
        public void DeliveryCostTest()
        {
            // TODO unit test for the property 'DeliveryCost'
        }
        /// <summary>
        /// Test the property 'DiscountedLineItemCost'
        /// </summary>
        [Test]
        public void DiscountedLineItemCostTest()
        {
            // TODO unit test for the property 'DiscountedLineItemCost'
        }
        /// <summary>
        /// Test the property 'EbayCollectAndRemitTaxes'
        /// </summary>
        [Test]
        public void EbayCollectAndRemitTaxesTest()
        {
            // TODO unit test for the property 'EbayCollectAndRemitTaxes'
        }
        /// <summary>
        /// Test the property 'EbayCollectedCharges'
        /// </summary>
        [Test]
        public void EbayCollectedChargesTest()
        {
            // TODO unit test for the property 'EbayCollectedCharges'
        }
        /// <summary>
        /// Test the property 'GiftDetails'
        /// </summary>
        [Test]
        public void GiftDetailsTest()
        {
            // TODO unit test for the property 'GiftDetails'
        }
        /// <summary>
        /// Test the property 'ItemLocation'
        /// </summary>
        [Test]
        public void ItemLocationTest()
        {
            // TODO unit test for the property 'ItemLocation'
        }
        /// <summary>
        /// Test the property 'LegacyItemId'
        /// </summary>
        [Test]
        public void LegacyItemIdTest()
        {
            // TODO unit test for the property 'LegacyItemId'
        }
        /// <summary>
        /// Test the property 'LegacyVariationId'
        /// </summary>
        [Test]
        public void LegacyVariationIdTest()
        {
            // TODO unit test for the property 'LegacyVariationId'
        }
        /// <summary>
        /// Test the property 'LineItemCost'
        /// </summary>
        [Test]
        public void LineItemCostTest()
        {
            // TODO unit test for the property 'LineItemCost'
        }
        /// <summary>
        /// Test the property 'LineItemFulfillmentInstructions'
        /// </summary>
        [Test]
        public void LineItemFulfillmentInstructionsTest()
        {
            // TODO unit test for the property 'LineItemFulfillmentInstructions'
        }
        /// <summary>
        /// Test the property 'LineItemFulfillmentStatus'
        /// </summary>
        [Test]
        public void LineItemFulfillmentStatusTest()
        {
            // TODO unit test for the property 'LineItemFulfillmentStatus'
        }
        /// <summary>
        /// Test the property 'LineItemId'
        /// </summary>
        [Test]
        public void LineItemIdTest()
        {
            // TODO unit test for the property 'LineItemId'
        }
        /// <summary>
        /// Test the property 'LinkedOrderLineItems'
        /// </summary>
        [Test]
        public void LinkedOrderLineItemsTest()
        {
            // TODO unit test for the property 'LinkedOrderLineItems'
        }
        /// <summary>
        /// Test the property 'ListingMarketplaceId'
        /// </summary>
        [Test]
        public void ListingMarketplaceIdTest()
        {
            // TODO unit test for the property 'ListingMarketplaceId'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO unit test for the property 'Properties'
        }
        /// <summary>
        /// Test the property 'PurchaseMarketplaceId'
        /// </summary>
        [Test]
        public void PurchaseMarketplaceIdTest()
        {
            // TODO unit test for the property 'PurchaseMarketplaceId'
        }
        /// <summary>
        /// Test the property 'Quantity'
        /// </summary>
        [Test]
        public void QuantityTest()
        {
            // TODO unit test for the property 'Quantity'
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
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
        }
        /// <summary>
        /// Test the property 'SoldFormat'
        /// </summary>
        [Test]
        public void SoldFormatTest()
        {
            // TODO unit test for the property 'SoldFormat'
        }
        /// <summary>
        /// Test the property 'Taxes'
        /// </summary>
        [Test]
        public void TaxesTest()
        {
            // TODO unit test for the property 'Taxes'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'VariationAspects'
        /// </summary>
        [Test]
        public void VariationAspectsTest()
        {
            // TODO unit test for the property 'VariationAspects'
        }

    }

}
