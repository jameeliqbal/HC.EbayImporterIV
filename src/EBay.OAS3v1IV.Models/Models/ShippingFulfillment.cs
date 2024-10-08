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
    /// This type contains the complete details of an existing fulfillment for an order.
    /// </summary>
    [DataContract]
        public partial class ShippingFulfillment :  IEquatable<ShippingFulfillment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingFulfillment" /> class.
        /// </summary>
        /// <param name="fulfillmentId">The unique identifier of the fulfillment; for example, &lt;code&gt;9405509699937003457459&lt;/code&gt;. This eBay-generated value is created with a successful &lt;b&gt;createShippingFulfillment&lt;/b&gt; call..</param>
        /// <param name="lineItems">This array contains a list of one or more line items (and purchased quantity) to which the fulfillment applies..</param>
        /// <param name="shipmentTrackingNumber">The tracking number provided by the shipping carrier for the package shipped in this fulfillment. This field is returned if available..</param>
        /// <param name="shippedDate">The date and time that the fulfillment package was shipped. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field should only be returned if the package has been shipped.&lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;.</param>
        /// <param name="shippingCarrierCode">The eBay code identifying the shipping carrier for this fulfillment. This field is returned if available. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;b&gt;ShippingCarrierCodeType&lt;/b&gt; enumeration type contains the most current list of eBay shipping carrier codes and the countries served by each carrier. See &lt;a href&#x3D;\&quot;https://developer.ebay.com/Devzone/XML/docs/Reference/eBay/types/ShippingCarrierCodeType.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ShippingCarrierCodeType&lt;/a&gt;.&lt;/span&gt;.</param>
        public ShippingFulfillment(string fulfillmentId = default(string), List<LineItemReference> lineItems = default(List<LineItemReference>), string shipmentTrackingNumber = default(string), string shippedDate = default(string), string shippingCarrierCode = default(string))
        {
            this.FulfillmentId = fulfillmentId;
            this.LineItems = lineItems;
            this.ShipmentTrackingNumber = shipmentTrackingNumber;
            this.ShippedDate = shippedDate;
            this.ShippingCarrierCode = shippingCarrierCode;
        }
        
        /// <summary>
        /// The unique identifier of the fulfillment; for example, &lt;code&gt;9405509699937003457459&lt;/code&gt;. This eBay-generated value is created with a successful &lt;b&gt;createShippingFulfillment&lt;/b&gt; call.
        /// </summary>
        /// <value>The unique identifier of the fulfillment; for example, &lt;code&gt;9405509699937003457459&lt;/code&gt;. This eBay-generated value is created with a successful &lt;b&gt;createShippingFulfillment&lt;/b&gt; call.</value>
        [DataMember(Name="fulfillmentId", EmitDefaultValue=false)]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// This array contains a list of one or more line items (and purchased quantity) to which the fulfillment applies.
        /// </summary>
        /// <value>This array contains a list of one or more line items (and purchased quantity) to which the fulfillment applies.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<LineItemReference> LineItems { get; set; }

        /// <summary>
        /// The tracking number provided by the shipping carrier for the package shipped in this fulfillment. This field is returned if available.
        /// </summary>
        /// <value>The tracking number provided by the shipping carrier for the package shipped in this fulfillment. This field is returned if available.</value>
        [DataMember(Name="shipmentTrackingNumber", EmitDefaultValue=false)]
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// The date and time that the fulfillment package was shipped. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field should only be returned if the package has been shipped.&lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;
        /// </summary>
        /// <value>The date and time that the fulfillment package was shipped. This timestamp is in ISO 8601 format, which uses the 24-hour Universal Coordinated Time (UTC) clock. This field should only be returned if the package has been shipped.&lt;br&gt;&lt;br&gt;&lt;b&gt;Format:&lt;/b&gt; &lt;code&gt;[YYYY]-[MM]-[DD]T[hh]:[mm]:[ss].[sss]Z&lt;/code&gt; &lt;br&gt;&lt;b&gt;Example:&lt;/b&gt; &lt;code&gt;2015-08-04T19:09:02.768Z&lt;/code&gt;</value>
        [DataMember(Name="shippedDate", EmitDefaultValue=false)]
        public string ShippedDate { get; set; }

        /// <summary>
        /// The eBay code identifying the shipping carrier for this fulfillment. This field is returned if available. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;b&gt;ShippingCarrierCodeType&lt;/b&gt; enumeration type contains the most current list of eBay shipping carrier codes and the countries served by each carrier. See &lt;a href&#x3D;\&quot;https://developer.ebay.com/Devzone/XML/docs/Reference/eBay/types/ShippingCarrierCodeType.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ShippingCarrierCodeType&lt;/a&gt;.&lt;/span&gt;
        /// </summary>
        /// <value>The eBay code identifying the shipping carrier for this fulfillment. This field is returned if available. &lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; The Trading API&#x27;s &lt;b&gt;ShippingCarrierCodeType&lt;/b&gt; enumeration type contains the most current list of eBay shipping carrier codes and the countries served by each carrier. See &lt;a href&#x3D;\&quot;https://developer.ebay.com/Devzone/XML/docs/Reference/eBay/types/ShippingCarrierCodeType.html \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ShippingCarrierCodeType&lt;/a&gt;.&lt;/span&gt;</value>
        [DataMember(Name="shippingCarrierCode", EmitDefaultValue=false)]
        public string ShippingCarrierCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShippingFulfillment {\n");
            sb.Append("  FulfillmentId: ").Append(FulfillmentId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  ShipmentTrackingNumber: ").Append(ShipmentTrackingNumber).Append("\n");
            sb.Append("  ShippedDate: ").Append(ShippedDate).Append("\n");
            sb.Append("  ShippingCarrierCode: ").Append(ShippingCarrierCode).Append("\n");
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
            return this.Equals(input as ShippingFulfillment);
        }

        /// <summary>
        /// Returns true if ShippingFulfillment instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingFulfillment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingFulfillment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FulfillmentId == input.FulfillmentId ||
                    (this.FulfillmentId != null &&
                    this.FulfillmentId.Equals(input.FulfillmentId))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.ShipmentTrackingNumber == input.ShipmentTrackingNumber ||
                    (this.ShipmentTrackingNumber != null &&
                    this.ShipmentTrackingNumber.Equals(input.ShipmentTrackingNumber))
                ) && 
                (
                    this.ShippedDate == input.ShippedDate ||
                    (this.ShippedDate != null &&
                    this.ShippedDate.Equals(input.ShippedDate))
                ) && 
                (
                    this.ShippingCarrierCode == input.ShippingCarrierCode ||
                    (this.ShippingCarrierCode != null &&
                    this.ShippingCarrierCode.Equals(input.ShippingCarrierCode))
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
                if (this.FulfillmentId != null)
                    hashCode = hashCode * 59 + this.FulfillmentId.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                if (this.ShipmentTrackingNumber != null)
                    hashCode = hashCode * 59 + this.ShipmentTrackingNumber.GetHashCode();
                if (this.ShippedDate != null)
                    hashCode = hashCode * 59 + this.ShippedDate.GetHashCode();
                if (this.ShippingCarrierCode != null)
                    hashCode = hashCode * 59 + this.ShippingCarrierCode.GetHashCode();
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
