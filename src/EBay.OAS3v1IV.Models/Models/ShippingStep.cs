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
    /// This type contains shipping information for a fulfillment, including the shipping carrier, the shipping service option, the shipment destination, and the Global Shipping Program reference ID.
    /// </summary>
    [DataContract]
        public partial class ShippingStep :  IEquatable<ShippingStep>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingStep" /> class.
        /// </summary>
        /// <param name="shippingCarrierCode">The unique identifier of the shipping carrier being used to ship the line item. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;a href&#x3D;\&quot;https://developer.ebay.com/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call can be used to retrieve the latest shipping carrier and shipping service option enumeration values.&lt;/span&gt;.</param>
        /// <param name="shippingServiceCode">The unique identifier of the shipping service option being used to ship the line item.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Use the Trading API&#x27;s &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call to retrieve the latest shipping carrier and shipping service option enumeration values. When making the &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call, include the &lt;strong&gt;DetailName&lt;/strong&gt; field in the request payload and set its value to &lt;code&gt;ShippingServiceDetails&lt;/code&gt;. Each valid shipping service option (returned in &lt;strong&gt;ShippingServiceDetails.ShippingService&lt;/strong&gt; field) and corresponding shipping carrier (returned in &lt;strong&gt;ShippingServiceDetails.ShippingCarrier&lt;/strong&gt; field) is returned in response payload.&lt;/span&gt;.</param>
        /// <param name="shipTo">shipTo.</param>
        /// <param name="shipToReferenceId">This is the unique identifer of the Global Shipping Program (GSP) shipment. This field is only returned if the line item is being shipped via GSP (the value of the &lt;b&gt;fulfillmentStartInstructions.ebaySupportedFulfillment&lt;/b&gt; field will be &lt;code&gt;true&lt;/code&gt;. The international shipping provider uses the &lt;b&gt;shipToReferenceId&lt;/b&gt; value as the primary reference number to retrieve the relevant details about the buyer, the order, and the fulfillment, so the shipment can be completed. &lt;br&gt;&lt;br&gt;Sellers must include this value on the shipping label immediately above the street address of the international shipping provider. &lt;br&gt;&lt;br&gt;Example: \&quot;Reference #1234567890123456\&quot; &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This value is the same as the &lt;b&gt;ShipToAddress.ReferenceID&lt;/b&gt; value returned by the Trading API&#x27;s GetOrders call.&lt;/span&gt;.</param>
        public ShippingStep(string shippingCarrierCode = default(string), string shippingServiceCode = default(string), ExtendedContact shipTo = default(ExtendedContact), string shipToReferenceId = default(string))
        {
            this.ShippingCarrierCode = shippingCarrierCode;
            this.ShippingServiceCode = shippingServiceCode;
            this.ShipTo = shipTo;
            this.ShipToReferenceId = shipToReferenceId;
        }
        
        /// <summary>
        /// The unique identifier of the shipping carrier being used to ship the line item. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;a href&#x3D;\&quot;https://developer.ebay.com/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call can be used to retrieve the latest shipping carrier and shipping service option enumeration values.&lt;/span&gt;
        /// </summary>
        /// <value>The unique identifier of the shipping carrier being used to ship the line item. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;a href&#x3D;\&quot;https://developer.ebay.com/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call can be used to retrieve the latest shipping carrier and shipping service option enumeration values.&lt;/span&gt;</value>
        [DataMember(Name="shippingCarrierCode", EmitDefaultValue=false)]
        public string ShippingCarrierCode { get; set; }

        /// <summary>
        /// The unique identifier of the shipping service option being used to ship the line item.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Use the Trading API&#x27;s &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call to retrieve the latest shipping carrier and shipping service option enumeration values. When making the &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call, include the &lt;strong&gt;DetailName&lt;/strong&gt; field in the request payload and set its value to &lt;code&gt;ShippingServiceDetails&lt;/code&gt;. Each valid shipping service option (returned in &lt;strong&gt;ShippingServiceDetails.ShippingService&lt;/strong&gt; field) and corresponding shipping carrier (returned in &lt;strong&gt;ShippingServiceDetails.ShippingCarrier&lt;/strong&gt; field) is returned in response payload.&lt;/span&gt;
        /// </summary>
        /// <value>The unique identifier of the shipping service option being used to ship the line item.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; Use the Trading API&#x27;s &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call to retrieve the latest shipping carrier and shipping service option enumeration values. When making the &lt;a href&#x3D;\&quot;/devzone/XML/docs/Reference/eBay/GeteBayDetails.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;GeteBayDetails&lt;/a&gt; call, include the &lt;strong&gt;DetailName&lt;/strong&gt; field in the request payload and set its value to &lt;code&gt;ShippingServiceDetails&lt;/code&gt;. Each valid shipping service option (returned in &lt;strong&gt;ShippingServiceDetails.ShippingService&lt;/strong&gt; field) and corresponding shipping carrier (returned in &lt;strong&gt;ShippingServiceDetails.ShippingCarrier&lt;/strong&gt; field) is returned in response payload.&lt;/span&gt;</value>
        [DataMember(Name="shippingServiceCode", EmitDefaultValue=false)]
        public string ShippingServiceCode { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public ExtendedContact ShipTo { get; set; }

        /// <summary>
        /// This is the unique identifer of the Global Shipping Program (GSP) shipment. This field is only returned if the line item is being shipped via GSP (the value of the &lt;b&gt;fulfillmentStartInstructions.ebaySupportedFulfillment&lt;/b&gt; field will be &lt;code&gt;true&lt;/code&gt;. The international shipping provider uses the &lt;b&gt;shipToReferenceId&lt;/b&gt; value as the primary reference number to retrieve the relevant details about the buyer, the order, and the fulfillment, so the shipment can be completed. &lt;br&gt;&lt;br&gt;Sellers must include this value on the shipping label immediately above the street address of the international shipping provider. &lt;br&gt;&lt;br&gt;Example: \&quot;Reference #1234567890123456\&quot; &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This value is the same as the &lt;b&gt;ShipToAddress.ReferenceID&lt;/b&gt; value returned by the Trading API&#x27;s GetOrders call.&lt;/span&gt;
        /// </summary>
        /// <value>This is the unique identifer of the Global Shipping Program (GSP) shipment. This field is only returned if the line item is being shipped via GSP (the value of the &lt;b&gt;fulfillmentStartInstructions.ebaySupportedFulfillment&lt;/b&gt; field will be &lt;code&gt;true&lt;/code&gt;. The international shipping provider uses the &lt;b&gt;shipToReferenceId&lt;/b&gt; value as the primary reference number to retrieve the relevant details about the buyer, the order, and the fulfillment, so the shipment can be completed. &lt;br&gt;&lt;br&gt;Sellers must include this value on the shipping label immediately above the street address of the international shipping provider. &lt;br&gt;&lt;br&gt;Example: \&quot;Reference #1234567890123456\&quot; &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; This value is the same as the &lt;b&gt;ShipToAddress.ReferenceID&lt;/b&gt; value returned by the Trading API&#x27;s GetOrders call.&lt;/span&gt;</value>
        [DataMember(Name="shipToReferenceId", EmitDefaultValue=false)]
        public string ShipToReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingStep {\n");
            sb.Append("  ShippingCarrierCode: ").Append(ShippingCarrierCode).Append("\n");
            sb.Append("  ShippingServiceCode: ").Append(ShippingServiceCode).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  ShipToReferenceId: ").Append(ShipToReferenceId).Append("\n");
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
            return this.Equals(input as ShippingStep);
        }

        /// <summary>
        /// Returns true if ShippingStep instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingStep to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingStep input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ShippingCarrierCode == input.ShippingCarrierCode ||
                    (this.ShippingCarrierCode != null &&
                    this.ShippingCarrierCode.Equals(input.ShippingCarrierCode))
                ) && 
                (
                    this.ShippingServiceCode == input.ShippingServiceCode ||
                    (this.ShippingServiceCode != null &&
                    this.ShippingServiceCode.Equals(input.ShippingServiceCode))
                ) && 
                (
                    this.ShipTo == input.ShipTo ||
                    (this.ShipTo != null &&
                    this.ShipTo.Equals(input.ShipTo))
                ) && 
                (
                    this.ShipToReferenceId == input.ShipToReferenceId ||
                    (this.ShipToReferenceId != null &&
                    this.ShipToReferenceId.Equals(input.ShipToReferenceId))
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
                if (this.ShippingCarrierCode != null)
                    hashCode = hashCode * 59 + this.ShippingCarrierCode.GetHashCode();
                if (this.ShippingServiceCode != null)
                    hashCode = hashCode * 59 + this.ShippingServiceCode.GetHashCode();
                if (this.ShipTo != null)
                    hashCode = hashCode * 59 + this.ShipTo.GetHashCode();
                if (this.ShipToReferenceId != null)
                    hashCode = hashCode * 59 + this.ShipToReferenceId.GetHashCode();
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
