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
using SwaggerDateConverter = EBay.OAS3v1IV.Client.SwaggerDateConverter;
namespace EBay.OAS3v1IV.Models
{
    /// <summary>
    /// This type is used by the base response of the &lt;strong&gt;getPaymentDispute&lt;/strong&gt; method. The &lt;strong&gt;getPaymentDispute&lt;/strong&gt; method retrieves detailed information on a specific payment dispute.
    /// </summary>
    [DataContract]
        public partial class PaymentDispute :  IEquatable<PaymentDispute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDispute" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="availableChoices">The value(s) returned in this array indicate the choices that the seller has when responding to the payment dispute. Once the seller has responded to the payment dispute, this field will no longer be shown, and instead, the &lt;strong&gt;sellerResponse&lt;/strong&gt; field will show the decision that the seller made..</param>
        /// <param name="buyerProvided">buyerProvided.</param>
        /// <param name="buyerUsername">This is the eBay user ID of the buyer that initiated the payment dispute..</param>
        /// <param name="closedDate">The timestamp in this field shows the date/time when the payment dispute was closed, so this field is only returned for payment disputes in the &lt;code&gt;CLOSED&lt;/code&gt; state.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;..</param>
        /// <param name="evidence">This container shows any evidence that has been provided by the seller to contest the payment dispute. Evidence may include shipment tracking information, proof of authentication documentation, image(s) to proof that an item is as described, or financial documentation/invoice.&lt;br&gt;&lt;br&gt;This container is only returned if the seller has provided at least one document used as evidence against the payment dispute..</param>
        /// <param name="evidenceRequests">This container is returned if one or more evidence documents are being requested from the seller..</param>
        /// <param name="lineItems">This array is used to identify one or more order line items associated with the payment dispute. There will always be at least one &lt;b&gt;itemId&lt;/b&gt;/&lt;b&gt;lineItemId&lt;/b&gt; pair returned in this array..</param>
        /// <param name="monetaryTransactions">This array provide details about one or more monetary transactions that occur as part of a payment dispute. This array is only returned once one or more monetary transacations occur with a payment dispute..</param>
        /// <param name="note">This field shows information that the seller provides about the dispute, such as the basis for the dispute, any relevant evidence, tracking numbers, and so forth.&lt;br&gt;&lt;br&gt;This field is limited to 1000 characters..</param>
        /// <param name="openDate">The timestamp in this field shows the date/time when the payment dispute was opened. This field is returned for payment disputes in all states.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;..</param>
        /// <param name="orderId">This is the unique identifier of the order involved in the payment dispute..</param>
        /// <param name="paymentDisputeId">This is the unique identifier of the payment dispute. This is the same identifier that is passed in to the call URI. This identifier is automatically created by eBay once the payment dispute comes into the eBay system..</param>
        /// <param name="paymentDisputeStatus">The enumeration value in this field gives the current status of the payment dispute. The status of a payment dispute partially determines other fields that are returned in the response. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeStateEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="reason">The enumeration value in this field gives the reason why the buyer initiated the payment dispute. See &lt;strong&gt;DisputeReasonEnum&lt;/strong&gt; type for a description of the supported reasons that buyers can give for initiating a payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="resolution">resolution.</param>
        /// <param name="respondByDate">The timestamp in this field shows the date/time when the seller must response to a payment dispute, so this field is only returned for payment disputes in the &lt;code&gt;ACTION_NEEDED&lt;/code&gt; state. For payment disputes that currently require action by the seller, that same seller should look at the &lt;strong&gt;availableChoices&lt;/strong&gt; array to see the available actions.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;..</param>
        /// <param name="returnAddress">returnAddress.</param>
        /// <param name="revision">This integer value indicates the revision number of the payment dispute. Each time an action is taken against a payment dispute, this integer value increases by 1..</param>
        /// <param name="sellerResponse">The enumeration value returned in this field indicates how the seller has responded to the payment dispute. The seller has the option of accepting the payment dispute and agreeing to issue a refund, accepting the payment dispute and agreeing to issue a refund as long as the buyer returns the item, or contesting the payment dispute. This field is returned as soon as the seller makes an initial decision on the payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:SellerResponseEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        public PaymentDispute(SimpleAmount amount = default(SimpleAmount), List<string> availableChoices = default(List<string>), InfoFromBuyer buyerProvided = default(InfoFromBuyer), string buyerUsername = default(string), string closedDate = default(string), List<DisputeEvidence> evidence = default(List<DisputeEvidence>), List<EvidenceRequest> evidenceRequests = default(List<EvidenceRequest>), List<OrderLineItems> lineItems = default(List<OrderLineItems>), List<MonetaryTransaction> monetaryTransactions = default(List<MonetaryTransaction>), string note = default(string), string openDate = default(string), string orderId = default(string), string paymentDisputeId = default(string), string paymentDisputeStatus = default(string), string reason = default(string), PaymentDisputeOutcomeDetail resolution = default(PaymentDisputeOutcomeDetail), string respondByDate = default(string), ReturnAddress returnAddress = default(ReturnAddress), int? revision = default(int?), string sellerResponse = default(string))
        {
            this.Amount = amount;
            this.AvailableChoices = availableChoices;
            this.BuyerProvided = buyerProvided;
            this.BuyerUsername = buyerUsername;
            this.ClosedDate = closedDate;
            this.Evidence = evidence;
            this.EvidenceRequests = evidenceRequests;
            this.LineItems = lineItems;
            this.MonetaryTransactions = monetaryTransactions;
            this.Note = note;
            this.OpenDate = openDate;
            this.OrderId = orderId;
            this.PaymentDisputeId = paymentDisputeId;
            this.PaymentDisputeStatus = paymentDisputeStatus;
            this.Reason = reason;
            this.Resolution = resolution;
            this.RespondByDate = respondByDate;
            this.ReturnAddress = returnAddress;
            this.Revision = revision;
            this.SellerResponse = sellerResponse;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public SimpleAmount Amount { get; set; }

        /// <summary>
        /// The value(s) returned in this array indicate the choices that the seller has when responding to the payment dispute. Once the seller has responded to the payment dispute, this field will no longer be shown, and instead, the &lt;strong&gt;sellerResponse&lt;/strong&gt; field will show the decision that the seller made.
        /// </summary>
        /// <value>The value(s) returned in this array indicate the choices that the seller has when responding to the payment dispute. Once the seller has responded to the payment dispute, this field will no longer be shown, and instead, the &lt;strong&gt;sellerResponse&lt;/strong&gt; field will show the decision that the seller made.</value>
        [DataMember(Name="availableChoices", EmitDefaultValue=false)]
        public List<string> AvailableChoices { get; set; }

        /// <summary>
        /// Gets or Sets BuyerProvided
        /// </summary>
        [DataMember(Name="buyerProvided", EmitDefaultValue=false)]
        public InfoFromBuyer BuyerProvided { get; set; }

        /// <summary>
        /// This is the eBay user ID of the buyer that initiated the payment dispute.
        /// </summary>
        /// <value>This is the eBay user ID of the buyer that initiated the payment dispute.</value>
        [DataMember(Name="buyerUsername", EmitDefaultValue=false)]
        public string BuyerUsername { get; set; }

        /// <summary>
        /// The timestamp in this field shows the date/time when the payment dispute was closed, so this field is only returned for payment disputes in the &lt;code&gt;CLOSED&lt;/code&gt; state.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.
        /// </summary>
        /// <value>The timestamp in this field shows the date/time when the payment dispute was closed, so this field is only returned for payment disputes in the &lt;code&gt;CLOSED&lt;/code&gt; state.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.</value>
        [DataMember(Name="closedDate", EmitDefaultValue=false)]
        public string ClosedDate { get; set; }

        /// <summary>
        /// This container shows any evidence that has been provided by the seller to contest the payment dispute. Evidence may include shipment tracking information, proof of authentication documentation, image(s) to proof that an item is as described, or financial documentation/invoice.&lt;br&gt;&lt;br&gt;This container is only returned if the seller has provided at least one document used as evidence against the payment dispute.
        /// </summary>
        /// <value>This container shows any evidence that has been provided by the seller to contest the payment dispute. Evidence may include shipment tracking information, proof of authentication documentation, image(s) to proof that an item is as described, or financial documentation/invoice.&lt;br&gt;&lt;br&gt;This container is only returned if the seller has provided at least one document used as evidence against the payment dispute.</value>
        [DataMember(Name="evidence", EmitDefaultValue=false)]
        public List<DisputeEvidence> Evidence { get; set; }

        /// <summary>
        /// This container is returned if one or more evidence documents are being requested from the seller.
        /// </summary>
        /// <value>This container is returned if one or more evidence documents are being requested from the seller.</value>
        [DataMember(Name="evidenceRequests", EmitDefaultValue=false)]
        public List<EvidenceRequest> EvidenceRequests { get; set; }

        /// <summary>
        /// This array is used to identify one or more order line items associated with the payment dispute. There will always be at least one &lt;b&gt;itemId&lt;/b&gt;/&lt;b&gt;lineItemId&lt;/b&gt; pair returned in this array.
        /// </summary>
        /// <value>This array is used to identify one or more order line items associated with the payment dispute. There will always be at least one &lt;b&gt;itemId&lt;/b&gt;/&lt;b&gt;lineItemId&lt;/b&gt; pair returned in this array.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<OrderLineItems> LineItems { get; set; }

        /// <summary>
        /// This array provide details about one or more monetary transactions that occur as part of a payment dispute. This array is only returned once one or more monetary transacations occur with a payment dispute.
        /// </summary>
        /// <value>This array provide details about one or more monetary transactions that occur as part of a payment dispute. This array is only returned once one or more monetary transacations occur with a payment dispute.</value>
        [DataMember(Name="monetaryTransactions", EmitDefaultValue=false)]
        public List<MonetaryTransaction> MonetaryTransactions { get; set; }

        /// <summary>
        /// This field shows information that the seller provides about the dispute, such as the basis for the dispute, any relevant evidence, tracking numbers, and so forth.&lt;br&gt;&lt;br&gt;This field is limited to 1000 characters.
        /// </summary>
        /// <value>This field shows information that the seller provides about the dispute, such as the basis for the dispute, any relevant evidence, tracking numbers, and so forth.&lt;br&gt;&lt;br&gt;This field is limited to 1000 characters.</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// The timestamp in this field shows the date/time when the payment dispute was opened. This field is returned for payment disputes in all states.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.
        /// </summary>
        /// <value>The timestamp in this field shows the date/time when the payment dispute was opened. This field is returned for payment disputes in all states.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.</value>
        [DataMember(Name="openDate", EmitDefaultValue=false)]
        public string OpenDate { get; set; }

        /// <summary>
        /// This is the unique identifier of the order involved in the payment dispute.
        /// </summary>
        /// <value>This is the unique identifier of the order involved in the payment dispute.</value>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// This is the unique identifier of the payment dispute. This is the same identifier that is passed in to the call URI. This identifier is automatically created by eBay once the payment dispute comes into the eBay system.
        /// </summary>
        /// <value>This is the unique identifier of the payment dispute. This is the same identifier that is passed in to the call URI. This identifier is automatically created by eBay once the payment dispute comes into the eBay system.</value>
        [DataMember(Name="paymentDisputeId", EmitDefaultValue=false)]
        public string PaymentDisputeId { get; set; }

        /// <summary>
        /// The enumeration value in this field gives the current status of the payment dispute. The status of a payment dispute partially determines other fields that are returned in the response. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeStateEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The enumeration value in this field gives the current status of the payment dispute. The status of a payment dispute partially determines other fields that are returned in the response. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeStateEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="paymentDisputeStatus", EmitDefaultValue=false)]
        public string PaymentDisputeStatus { get; set; }

        /// <summary>
        /// The enumeration value in this field gives the reason why the buyer initiated the payment dispute. See &lt;strong&gt;DisputeReasonEnum&lt;/strong&gt; type for a description of the supported reasons that buyers can give for initiating a payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The enumeration value in this field gives the reason why the buyer initiated the payment dispute. See &lt;strong&gt;DisputeReasonEnum&lt;/strong&gt; type for a description of the supported reasons that buyers can give for initiating a payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:DisputeReasonEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public PaymentDisputeOutcomeDetail Resolution { get; set; }

        /// <summary>
        /// The timestamp in this field shows the date/time when the seller must response to a payment dispute, so this field is only returned for payment disputes in the &lt;code&gt;ACTION_NEEDED&lt;/code&gt; state. For payment disputes that currently require action by the seller, that same seller should look at the &lt;strong&gt;availableChoices&lt;/strong&gt; array to see the available actions.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.
        /// </summary>
        /// <value>The timestamp in this field shows the date/time when the seller must response to a payment dispute, so this field is only returned for payment disputes in the &lt;code&gt;ACTION_NEEDED&lt;/code&gt; state. For payment disputes that currently require action by the seller, that same seller should look at the &lt;strong&gt;availableChoices&lt;/strong&gt; array to see the available actions.&lt;br&gt;&lt;br&gt;The timestamps returned here use the ISO-8601 24-hour date and time format, and the time zone used is Universal Coordinated Time (UTC), also known as Greenwich Mean Time (GMT), or Zulu. The ISO-8601 format looks like this: &lt;em&gt;yyyy-MM-ddThh:mm.ss.sssZ&lt;/em&gt;. An example would be &lt;code&gt;2019-08-04T19:09:02.768Z&lt;/code&gt;.</value>
        [DataMember(Name="respondByDate", EmitDefaultValue=false)]
        public string RespondByDate { get; set; }

        /// <summary>
        /// Gets or Sets ReturnAddress
        /// </summary>
        [DataMember(Name="returnAddress", EmitDefaultValue=false)]
        public ReturnAddress ReturnAddress { get; set; }

        /// <summary>
        /// This integer value indicates the revision number of the payment dispute. Each time an action is taken against a payment dispute, this integer value increases by 1.
        /// </summary>
        /// <value>This integer value indicates the revision number of the payment dispute. Each time an action is taken against a payment dispute, this integer value increases by 1.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// The enumeration value returned in this field indicates how the seller has responded to the payment dispute. The seller has the option of accepting the payment dispute and agreeing to issue a refund, accepting the payment dispute and agreeing to issue a refund as long as the buyer returns the item, or contesting the payment dispute. This field is returned as soon as the seller makes an initial decision on the payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:SellerResponseEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The enumeration value returned in this field indicates how the seller has responded to the payment dispute. The seller has the option of accepting the payment dispute and agreeing to issue a refund, accepting the payment dispute and agreeing to issue a refund as long as the buyer returns the item, or contesting the payment dispute. This field is returned as soon as the seller makes an initial decision on the payment dispute. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/api:SellerResponseEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="sellerResponse", EmitDefaultValue=false)]
        public string SellerResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDispute {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AvailableChoices: ").Append(AvailableChoices).Append("\n");
            sb.Append("  BuyerProvided: ").Append(BuyerProvided).Append("\n");
            sb.Append("  BuyerUsername: ").Append(BuyerUsername).Append("\n");
            sb.Append("  ClosedDate: ").Append(ClosedDate).Append("\n");
            sb.Append("  Evidence: ").Append(Evidence).Append("\n");
            sb.Append("  EvidenceRequests: ").Append(EvidenceRequests).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  MonetaryTransactions: ").Append(MonetaryTransactions).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaymentDisputeId: ").Append(PaymentDisputeId).Append("\n");
            sb.Append("  PaymentDisputeStatus: ").Append(PaymentDisputeStatus).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  RespondByDate: ").Append(RespondByDate).Append("\n");
            sb.Append("  ReturnAddress: ").Append(ReturnAddress).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  SellerResponse: ").Append(SellerResponse).Append("\n");
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
            return this.Equals(input as PaymentDispute);
        }

        /// <summary>
        /// Returns true if PaymentDispute instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDispute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDispute input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AvailableChoices == input.AvailableChoices ||
                    this.AvailableChoices != null &&
                    input.AvailableChoices != null &&
                    this.AvailableChoices.SequenceEqual(input.AvailableChoices)
                ) && 
                (
                    this.BuyerProvided == input.BuyerProvided ||
                    (this.BuyerProvided != null &&
                    this.BuyerProvided.Equals(input.BuyerProvided))
                ) && 
                (
                    this.BuyerUsername == input.BuyerUsername ||
                    (this.BuyerUsername != null &&
                    this.BuyerUsername.Equals(input.BuyerUsername))
                ) && 
                (
                    this.ClosedDate == input.ClosedDate ||
                    (this.ClosedDate != null &&
                    this.ClosedDate.Equals(input.ClosedDate))
                ) && 
                (
                    this.Evidence == input.Evidence ||
                    this.Evidence != null &&
                    input.Evidence != null &&
                    this.Evidence.SequenceEqual(input.Evidence)
                ) && 
                (
                    this.EvidenceRequests == input.EvidenceRequests ||
                    this.EvidenceRequests != null &&
                    input.EvidenceRequests != null &&
                    this.EvidenceRequests.SequenceEqual(input.EvidenceRequests)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.MonetaryTransactions == input.MonetaryTransactions ||
                    this.MonetaryTransactions != null &&
                    input.MonetaryTransactions != null &&
                    this.MonetaryTransactions.SequenceEqual(input.MonetaryTransactions)
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.OpenDate == input.OpenDate ||
                    (this.OpenDate != null &&
                    this.OpenDate.Equals(input.OpenDate))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaymentDisputeId == input.PaymentDisputeId ||
                    (this.PaymentDisputeId != null &&
                    this.PaymentDisputeId.Equals(input.PaymentDisputeId))
                ) && 
                (
                    this.PaymentDisputeStatus == input.PaymentDisputeStatus ||
                    (this.PaymentDisputeStatus != null &&
                    this.PaymentDisputeStatus.Equals(input.PaymentDisputeStatus))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.RespondByDate == input.RespondByDate ||
                    (this.RespondByDate != null &&
                    this.RespondByDate.Equals(input.RespondByDate))
                ) && 
                (
                    this.ReturnAddress == input.ReturnAddress ||
                    (this.ReturnAddress != null &&
                    this.ReturnAddress.Equals(input.ReturnAddress))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.SellerResponse == input.SellerResponse ||
                    (this.SellerResponse != null &&
                    this.SellerResponse.Equals(input.SellerResponse))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AvailableChoices != null)
                    hashCode = hashCode * 59 + this.AvailableChoices.GetHashCode();
                if (this.BuyerProvided != null)
                    hashCode = hashCode * 59 + this.BuyerProvided.GetHashCode();
                if (this.BuyerUsername != null)
                    hashCode = hashCode * 59 + this.BuyerUsername.GetHashCode();
                if (this.ClosedDate != null)
                    hashCode = hashCode * 59 + this.ClosedDate.GetHashCode();
                if (this.Evidence != null)
                    hashCode = hashCode * 59 + this.Evidence.GetHashCode();
                if (this.EvidenceRequests != null)
                    hashCode = hashCode * 59 + this.EvidenceRequests.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.MonetaryTransactions != null)
                    hashCode = hashCode * 59 + this.MonetaryTransactions.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.OpenDate != null)
                    hashCode = hashCode * 59 + this.OpenDate.GetHashCode();
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.PaymentDisputeId != null)
                    hashCode = hashCode * 59 + this.PaymentDisputeId.GetHashCode();
                if (this.PaymentDisputeStatus != null)
                    hashCode = hashCode * 59 + this.PaymentDisputeStatus.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.RespondByDate != null)
                    hashCode = hashCode * 59 + this.RespondByDate.GetHashCode();
                if (this.ReturnAddress != null)
                    hashCode = hashCode * 59 + this.ReturnAddress.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.SellerResponse != null)
                    hashCode = hashCode * 59 + this.SellerResponse.GetHashCode();
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
