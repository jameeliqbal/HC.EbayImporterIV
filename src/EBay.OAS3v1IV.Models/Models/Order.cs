/* 
 * Fulfillment API
 *
 * Use the Fulfillment API to complete the process of packaging, addressing, handling, and shipping each order on behalf of the seller, in accordance with the payment method and timing specified at checkout.
 *
 * OpenAPI spec version: v1.20.3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
//using SwaggerDateConverter = EBay.OAS3v1IV.Client.SwaggerDateConverter;
namespace eBay.OAS3v1IV.Models
{
    /// <summary>
    /// This type contains the details of an order, including information about the buyer, order history, shipping fulfillments, line items, costs, payments, and order fulfillment status.
    /// </summary>
    [DataContract]
        public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="buyer">buyer.</param>
        /// <param name="buyerCheckoutNotes">This field contains any comments that the buyer left for the seller about the order during checkout process. This field is only returned if a buyer left comments at checkout time. .</param>
        /// <param name="cancelStatus">cancelStatus.</param>
        /// <param name="creationDate">The date and time that the order was created. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;.</param>
        /// <param name="ebayCollectAndRemitTax">This field is only returned if &lt;code&gt;true&lt;/code&gt;, and indicates that eBay will collect tax (US state-mandated sales tax, Federal and Provincial Sales Tax in Canada, &#x27;Goods and Services&#x27; tax in Canada, Australia, and New Zealand, and VAT collected for UK and EU countries,) for at least one line item in the order, and remit the tax to the taxing authority of the buyer&#x27;s residence. If this field is returned, the seller should search for one or more &lt;strong&gt;ebayCollectAndRemitTaxes&lt;/strong&gt; containers at the line item level to get more information about the type of tax and the amount..</param>
        /// <param name="fulfillmentHrefs">This array contains a list of one or more &lt;strong&gt;getShippingFulfillment&lt;/strong&gt; call URIs that can be used to retrieve shipping fulfillments that have been set up for the order..</param>
        /// <param name="fulfillmentStartInstructions">This container consists of a set of specifications for fulfilling the order, including the type of fulfillment, shipping carrier and service, shipping address, and estimated delivery window. These instructions are derived from the buyer&#x27;s and seller&#x27;s eBay account preferences, the listing parameters, and the buyer&#x27;s checkout selections. The seller can use them as a starting point for packaging, addressing, and shipping the order.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Although this container is presented as an array, it currently returns only one set of fulfillment specifications. Additional array members will be supported in future functionality.&lt;/span&gt;.</param>
        /// <param name="lastModifiedDate">The date and time that the order was last modified. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;.</param>
        /// <param name="legacyOrderId">The unique identifier of the order in legacy format, as traditionally used by the Trading API (and other legacy APIs). Both the &lt;b&gt;orderId&lt;/b&gt; field and this field are always returned..</param>
        /// <param name="lineItems">This array contains the details for all line items that comprise the order..</param>
        /// <param name="orderFulfillmentStatus">The degree to which fulfillment of the order is complete. See the &lt;strong&gt;OrderFulfillmentStatus&lt;/strong&gt; type definition for more information about each possible fulfillment state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderFulfillmentStatus&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="orderId">The unique identifier of the order. Both the &lt;b&gt;legacyOrderId&lt;/b&gt; field (traditionally used by Trading and other legacy APIS) and this field are always returned..</param>
        /// <param name="orderPaymentStatus">The enumeration value returned in this field indicates the current payment status of an order, or in case of a refund request, the current status of the refund. See the &lt;strong&gt;OrderPaymentStatusEnum&lt;/strong&gt; type definition for more information about each possible payment/refund state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderPaymentStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="paymentSummary">paymentSummary.</param>
        /// <param name="pricingSummary">pricingSummary.</param>
        /// <param name="program">program.</param>
        /// <param name="salesRecordReference">An eBay-generated identifier that is used to identify and manage orders through the Selling Manager and Selling Manager Pro tools. This order identifier can also be found on the Orders grid page and in the Sales Record pages in Seller Hub. A &lt;strong&gt;salesRecordReference&lt;/strong&gt; number is only generated and returned at the order level, and not at the order line item level.&lt;br&gt;&lt;br&gt; In cases where the seller does not have a Selling Manager or Selling Manager Pro subscription nor access to Seller Hub, this field may not be returned..</param>
        /// <param name="sellerId">The unique eBay user ID of the seller who sold the order..</param>
        /// <param name="totalFeeBasisAmount">totalFeeBasisAmount.</param>
        /// <param name="totalMarketplaceFee">totalMarketplaceFee.</param>
        public Order(Buyer buyer = default(Buyer), string buyerCheckoutNotes = default(string), CancelStatus cancelStatus = default(CancelStatus), string creationDate = default(string), bool? ebayCollectAndRemitTax = default(bool?), List<string> fulfillmentHrefs = default(List<string>), List<FulfillmentStartInstruction> fulfillmentStartInstructions = default(List<FulfillmentStartInstruction>), string lastModifiedDate = default(string), string legacyOrderId = default(string), List<LineItem> lineItems = default(List<LineItem>), string orderFulfillmentStatus = default(string), string orderId = default(string), string orderPaymentStatus = default(string), PaymentSummary paymentSummary = default(PaymentSummary), PricingSummary pricingSummary = default(PricingSummary), Program program = default(Program), string salesRecordReference = default(string), string sellerId = default(string), Amount totalFeeBasisAmount = default(Amount), Amount totalMarketplaceFee = default(Amount))
        {
            this.Buyer = buyer;
            this.BuyerCheckoutNotes = buyerCheckoutNotes;
            this.CancelStatus = cancelStatus;
            this.CreationDate = creationDate;
            this.EbayCollectAndRemitTax = ebayCollectAndRemitTax;
            this.FulfillmentHrefs = fulfillmentHrefs;
            this.FulfillmentStartInstructions = fulfillmentStartInstructions;
            this.LastModifiedDate = lastModifiedDate;
            this.LegacyOrderId = legacyOrderId;
            this.LineItems = lineItems;
            this.OrderFulfillmentStatus = orderFulfillmentStatus;
            this.OrderId = orderId;
            this.OrderPaymentStatus = orderPaymentStatus;
            this.PaymentSummary = paymentSummary;
            this.PricingSummary = pricingSummary;
            this.Program = program;
            this.SalesRecordReference = salesRecordReference;
            this.SellerId = sellerId;
            this.TotalFeeBasisAmount = totalFeeBasisAmount;
            this.TotalMarketplaceFee = totalMarketplaceFee;
        }
        
        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [DataMember(Name="buyer", EmitDefaultValue=false)]
        public Buyer Buyer { get; set; }

        /// <summary>
        /// This field contains any comments that the buyer left for the seller about the order during checkout process. This field is only returned if a buyer left comments at checkout time. 
        /// </summary>
        /// <value>This field contains any comments that the buyer left for the seller about the order during checkout process. This field is only returned if a buyer left comments at checkout time. </value>
        [DataMember(Name="buyerCheckoutNotes", EmitDefaultValue=false)]
        public string BuyerCheckoutNotes { get; set; }

        /// <summary>
        /// Gets or Sets CancelStatus
        /// </summary>
        [DataMember(Name="cancelStatus", EmitDefaultValue=false)]
        public CancelStatus CancelStatus { get; set; }

        /// <summary>
        /// The date and time that the order was created. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;
        /// </summary>
        /// <value>The date and time that the order was created. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public string CreationDate { get; set; }

        /// <summary>
        /// This field is only returned if &lt;code&gt;true&lt;/code&gt;, and indicates that eBay will collect tax (US state-mandated sales tax, Federal and Provincial Sales Tax in Canada, &#x27;Goods and Services&#x27; tax in Canada, Australia, and New Zealand, and VAT collected for UK and EU countries,) for at least one line item in the order, and remit the tax to the taxing authority of the buyer&#x27;s residence. If this field is returned, the seller should search for one or more &lt;strong&gt;ebayCollectAndRemitTaxes&lt;/strong&gt; containers at the line item level to get more information about the type of tax and the amount.
        /// </summary>
        /// <value>This field is only returned if &lt;code&gt;true&lt;/code&gt;, and indicates that eBay will collect tax (US state-mandated sales tax, Federal and Provincial Sales Tax in Canada, &#x27;Goods and Services&#x27; tax in Canada, Australia, and New Zealand, and VAT collected for UK and EU countries,) for at least one line item in the order, and remit the tax to the taxing authority of the buyer&#x27;s residence. If this field is returned, the seller should search for one or more &lt;strong&gt;ebayCollectAndRemitTaxes&lt;/strong&gt; containers at the line item level to get more information about the type of tax and the amount.</value>
        [DataMember(Name="ebayCollectAndRemitTax", EmitDefaultValue=false)]
        public bool? EbayCollectAndRemitTax { get; set; }

        /// <summary>
        /// This array contains a list of one or more &lt;strong&gt;getShippingFulfillment&lt;/strong&gt; call URIs that can be used to retrieve shipping fulfillments that have been set up for the order.
        /// </summary>
        /// <value>This array contains a list of one or more &lt;strong&gt;getShippingFulfillment&lt;/strong&gt; call URIs that can be used to retrieve shipping fulfillments that have been set up for the order.</value>
        [DataMember(Name="fulfillmentHrefs", EmitDefaultValue=false)]
        public List<string> FulfillmentHrefs { get; set; }

        /// <summary>
        /// This container consists of a set of specifications for fulfilling the order, including the type of fulfillment, shipping carrier and service, shipping address, and estimated delivery window. These instructions are derived from the buyer&#x27;s and seller&#x27;s eBay account preferences, the listing parameters, and the buyer&#x27;s checkout selections. The seller can use them as a starting point for packaging, addressing, and shipping the order.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Although this container is presented as an array, it currently returns only one set of fulfillment specifications. Additional array members will be supported in future functionality.&lt;/span&gt;
        /// </summary>
        /// <value>This container consists of a set of specifications for fulfilling the order, including the type of fulfillment, shipping carrier and service, shipping address, and estimated delivery window. These instructions are derived from the buyer&#x27;s and seller&#x27;s eBay account preferences, the listing parameters, and the buyer&#x27;s checkout selections. The seller can use them as a starting point for packaging, addressing, and shipping the order.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Although this container is presented as an array, it currently returns only one set of fulfillment specifications. Additional array members will be supported in future functionality.&lt;/span&gt;</value>
        [DataMember(Name="fulfillmentStartInstructions", EmitDefaultValue=false)]
        public List<FulfillmentStartInstruction> FulfillmentStartInstructions { get; set; }

        /// <summary>
        /// The date and time that the order was last modified. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;
        /// </summary>
        /// <value>The date and time that the order was last modified. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. &lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;</value>
        [DataMember(Name="lastModifiedDate", EmitDefaultValue=false)]
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// The unique identifier of the order in legacy format, as traditionally used by the Trading API (and other legacy APIs). Both the &lt;b&gt;orderId&lt;/b&gt; field and this field are always returned.
        /// </summary>
        /// <value>The unique identifier of the order in legacy format, as traditionally used by the Trading API (and other legacy APIs). Both the &lt;b&gt;orderId&lt;/b&gt; field and this field are always returned.</value>
        [DataMember(Name="legacyOrderId", EmitDefaultValue=false)]
        public string LegacyOrderId { get; set; }

        /// <summary>
        /// This array contains the details for all line items that comprise the order.
        /// </summary>
        /// <value>This array contains the details for all line items that comprise the order.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// The degree to which fulfillment of the order is complete. See the &lt;strong&gt;OrderFulfillmentStatus&lt;/strong&gt; type definition for more information about each possible fulfillment state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderFulfillmentStatus&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The degree to which fulfillment of the order is complete. See the &lt;strong&gt;OrderFulfillmentStatus&lt;/strong&gt; type definition for more information about each possible fulfillment state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderFulfillmentStatus&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="orderFulfillmentStatus", EmitDefaultValue=false)]
        public string OrderFulfillmentStatus { get; set; }

        /// <summary>
        /// The unique identifier of the order. Both the &lt;b&gt;legacyOrderId&lt;/b&gt; field (traditionally used by Trading and other legacy APIS) and this field are always returned.
        /// </summary>
        /// <value>The unique identifier of the order. Both the &lt;b&gt;legacyOrderId&lt;/b&gt; field (traditionally used by Trading and other legacy APIS) and this field are always returned.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The enumeration value returned in this field indicates the current payment status of an order, or in case of a refund request, the current status of the refund. See the &lt;strong&gt;OrderPaymentStatusEnum&lt;/strong&gt; type definition for more information about each possible payment/refund state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderPaymentStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The enumeration value returned in this field indicates the current payment status of an order, or in case of a refund request, the current status of the refund. See the &lt;strong&gt;OrderPaymentStatusEnum&lt;/strong&gt; type definition for more information about each possible payment/refund state. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:OrderPaymentStatusEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="orderPaymentStatus", EmitDefaultValue=false)]
        public string OrderPaymentStatus { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSummary
        /// </summary>
        [DataMember(Name="paymentSummary", EmitDefaultValue=false)]
        public PaymentSummary PaymentSummary { get; set; }

        /// <summary>
        /// Gets or Sets PricingSummary
        /// </summary>
        [DataMember(Name="pricingSummary", EmitDefaultValue=false)]
        public PricingSummary PricingSummary { get; set; }

        /// <summary>
        /// Gets or Sets Program
        /// </summary>
        [DataMember(Name="program", EmitDefaultValue=false)]
        public Program Program { get; set; }

        /// <summary>
        /// An eBay-generated identifier that is used to identify and manage orders through the Selling Manager and Selling Manager Pro tools. This order identifier can also be found on the Orders grid page and in the Sales Record pages in Seller Hub. A &lt;strong&gt;salesRecordReference&lt;/strong&gt; number is only generated and returned at the order level, and not at the order line item level.&lt;br&gt;&lt;br&gt; In cases where the seller does not have a Selling Manager or Selling Manager Pro subscription nor access to Seller Hub, this field may not be returned.
        /// </summary>
        /// <value>An eBay-generated identifier that is used to identify and manage orders through the Selling Manager and Selling Manager Pro tools. This order identifier can also be found on the Orders grid page and in the Sales Record pages in Seller Hub. A &lt;strong&gt;salesRecordReference&lt;/strong&gt; number is only generated and returned at the order level, and not at the order line item level.&lt;br&gt;&lt;br&gt; In cases where the seller does not have a Selling Manager or Selling Manager Pro subscription nor access to Seller Hub, this field may not be returned.</value>
        [DataMember(Name="salesRecordReference", EmitDefaultValue=false)]
        public string SalesRecordReference { get; set; }

        /// <summary>
        /// The unique eBay user ID of the seller who sold the order.
        /// </summary>
        /// <value>The unique eBay user ID of the seller who sold the order.</value>
        [DataMember(Name="sellerId", EmitDefaultValue=false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Gets or Sets TotalFeeBasisAmount
        /// </summary>
        [DataMember(Name="totalFeeBasisAmount", EmitDefaultValue=false)]
        public Amount TotalFeeBasisAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalMarketplaceFee
        /// </summary>
        [DataMember(Name="totalMarketplaceFee", EmitDefaultValue=false)]
        public Amount TotalMarketplaceFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  BuyerCheckoutNotes: ").Append(BuyerCheckoutNotes).Append("\n");
            sb.Append("  CancelStatus: ").Append(CancelStatus).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  EbayCollectAndRemitTax: ").Append(EbayCollectAndRemitTax).Append("\n");
            sb.Append("  FulfillmentHrefs: ").Append(FulfillmentHrefs).Append("\n");
            sb.Append("  FulfillmentStartInstructions: ").Append(FulfillmentStartInstructions).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  LegacyOrderId: ").Append(LegacyOrderId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  OrderFulfillmentStatus: ").Append(OrderFulfillmentStatus).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderPaymentStatus: ").Append(OrderPaymentStatus).Append("\n");
            sb.Append("  PaymentSummary: ").Append(PaymentSummary).Append("\n");
            sb.Append("  PricingSummary: ").Append(PricingSummary).Append("\n");
            sb.Append("  Program: ").Append(Program).Append("\n");
            sb.Append("  SalesRecordReference: ").Append(SalesRecordReference).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  TotalFeeBasisAmount: ").Append(TotalFeeBasisAmount).Append("\n");
            sb.Append("  TotalMarketplaceFee: ").Append(TotalMarketplaceFee).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="input">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buyer == input.Buyer ||
                    (this.Buyer != null &&
                    this.Buyer.Equals(input.Buyer))
                ) && 
                (
                    this.BuyerCheckoutNotes == input.BuyerCheckoutNotes ||
                    (this.BuyerCheckoutNotes != null &&
                    this.BuyerCheckoutNotes.Equals(input.BuyerCheckoutNotes))
                ) && 
                (
                    this.CancelStatus == input.CancelStatus ||
                    (this.CancelStatus != null &&
                    this.CancelStatus.Equals(input.CancelStatus))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.EbayCollectAndRemitTax == input.EbayCollectAndRemitTax ||
                    (this.EbayCollectAndRemitTax != null &&
                    this.EbayCollectAndRemitTax.Equals(input.EbayCollectAndRemitTax))
                ) && 
                (
                    this.FulfillmentHrefs == input.FulfillmentHrefs ||
                    this.FulfillmentHrefs != null &&
                    input.FulfillmentHrefs != null &&
                    this.FulfillmentHrefs.SequenceEqual(input.FulfillmentHrefs)
                ) && 
                (
                    this.FulfillmentStartInstructions == input.FulfillmentStartInstructions ||
                    this.FulfillmentStartInstructions != null &&
                    input.FulfillmentStartInstructions != null &&
                    this.FulfillmentStartInstructions.SequenceEqual(input.FulfillmentStartInstructions)
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && 
                (
                    this.LegacyOrderId == input.LegacyOrderId ||
                    (this.LegacyOrderId != null &&
                    this.LegacyOrderId.Equals(input.LegacyOrderId))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.OrderFulfillmentStatus == input.OrderFulfillmentStatus ||
                    (this.OrderFulfillmentStatus != null &&
                    this.OrderFulfillmentStatus.Equals(input.OrderFulfillmentStatus))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderPaymentStatus == input.OrderPaymentStatus ||
                    (this.OrderPaymentStatus != null &&
                    this.OrderPaymentStatus.Equals(input.OrderPaymentStatus))
                ) && 
                (
                    this.PaymentSummary == input.PaymentSummary ||
                    (this.PaymentSummary != null &&
                    this.PaymentSummary.Equals(input.PaymentSummary))
                ) && 
                (
                    this.PricingSummary == input.PricingSummary ||
                    (this.PricingSummary != null &&
                    this.PricingSummary.Equals(input.PricingSummary))
                ) && 
                (
                    this.Program == input.Program ||
                    (this.Program != null &&
                    this.Program.Equals(input.Program))
                ) && 
                (
                    this.SalesRecordReference == input.SalesRecordReference ||
                    (this.SalesRecordReference != null &&
                    this.SalesRecordReference.Equals(input.SalesRecordReference))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.TotalFeeBasisAmount == input.TotalFeeBasisAmount ||
                    (this.TotalFeeBasisAmount != null &&
                    this.TotalFeeBasisAmount.Equals(input.TotalFeeBasisAmount))
                ) && 
                (
                    this.TotalMarketplaceFee == input.TotalMarketplaceFee ||
                    (this.TotalMarketplaceFee != null &&
                    this.TotalMarketplaceFee.Equals(input.TotalMarketplaceFee))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Buyer != null)
                    hashCode = hashCode * 59 + this.Buyer.GetHashCode();
                if (this.BuyerCheckoutNotes != null)
                    hashCode = hashCode * 59 + this.BuyerCheckoutNotes.GetHashCode();
                if (this.CancelStatus != null)
                    hashCode = hashCode * 59 + this.CancelStatus.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.EbayCollectAndRemitTax != null)
                    hashCode = hashCode * 59 + this.EbayCollectAndRemitTax.GetHashCode();
                if (this.FulfillmentHrefs != null)
                    hashCode = hashCode * 59 + this.FulfillmentHrefs.GetHashCode();
                if (this.FulfillmentStartInstructions != null)
                    hashCode = hashCode * 59 + this.FulfillmentStartInstructions.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.LegacyOrderId != null)
                    hashCode = hashCode * 59 + this.LegacyOrderId.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.OrderFulfillmentStatus != null)
                    hashCode = hashCode * 59 + this.OrderFulfillmentStatus.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OrderPaymentStatus != null)
                    hashCode = hashCode * 59 + this.OrderPaymentStatus.GetHashCode();
                if (this.PaymentSummary != null)
                    hashCode = hashCode * 59 + this.PaymentSummary.GetHashCode();
                if (this.PricingSummary != null)
                    hashCode = hashCode * 59 + this.PricingSummary.GetHashCode();
                if (this.Program != null)
                    hashCode = hashCode * 59 + this.Program.GetHashCode();
                if (this.SalesRecordReference != null)
                    hashCode = hashCode * 59 + this.SalesRecordReference.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.TotalFeeBasisAmount != null)
                    hashCode = hashCode * 59 + this.TotalFeeBasisAmount.GetHashCode();
                if (this.TotalMarketplaceFee != null)
                    hashCode = hashCode * 59 + this.TotalMarketplaceFee.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
