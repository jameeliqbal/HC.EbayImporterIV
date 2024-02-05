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
    /// This type is used if the seller is issuing a refund for one or more individual order line items in a multiple line item order. Otherwise, the seller just uses the &lt;b&gt;orderLevelRefundAmount&lt;/b&gt; container to specify the amount of the refund for the entire order.
    /// </summary>
    [DataContract]
        public partial class RefundItem :  IEquatable<RefundItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundItem" /> class.
        /// </summary>
        /// <param name="refundAmount">refundAmount.</param>
        /// <param name="lineItemId">The unique identifier of an order line item. This identifier is created once a buyer purchases a &#x27;Buy It Now&#x27; item or if an auction listing ends with a winning bidder.&lt;br&gt;&lt;br&gt;Either this field or the &lt;b&gt;legacyReference&lt;/b&gt; container is needed to identify an individual order line item that will receive a refund.&lt;br&gt;&lt;br&gt; This value is returned using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method..</param>
        /// <param name="legacyReference">legacyReference.</param>
        public RefundItem(SimpleAmount refundAmount = default(SimpleAmount), string lineItemId = default(string), LegacyReference legacyReference = default(LegacyReference))
        {
            this.RefundAmount = refundAmount;
            this.LineItemId = lineItemId;
            this.LegacyReference = legacyReference;
        }
        
        /// <summary>
        /// Gets or Sets RefundAmount
        /// </summary>
        [DataMember(Name="refundAmount", EmitDefaultValue=false)]
        public SimpleAmount RefundAmount { get; set; }

        /// <summary>
        /// The unique identifier of an order line item. This identifier is created once a buyer purchases a &#x27;Buy It Now&#x27; item or if an auction listing ends with a winning bidder.&lt;br&gt;&lt;br&gt;Either this field or the &lt;b&gt;legacyReference&lt;/b&gt; container is needed to identify an individual order line item that will receive a refund.&lt;br&gt;&lt;br&gt; This value is returned using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method.
        /// </summary>
        /// <value>The unique identifier of an order line item. This identifier is created once a buyer purchases a &#x27;Buy It Now&#x27; item or if an auction listing ends with a winning bidder.&lt;br&gt;&lt;br&gt;Either this field or the &lt;b&gt;legacyReference&lt;/b&gt; container is needed to identify an individual order line item that will receive a refund.&lt;br&gt;&lt;br&gt; This value is returned using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getOrders&lt;/a&gt; method.</value>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// Gets or Sets LegacyReference
        /// </summary>
        [DataMember(Name="legacyReference", EmitDefaultValue=false)]
        public LegacyReference LegacyReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefundItem {\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  LegacyReference: ").Append(LegacyReference).Append("\n");
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
            return this.Equals(input as RefundItem);
        }

        /// <summary>
        /// Returns true if RefundItem instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.LegacyReference == input.LegacyReference ||
                    (this.LegacyReference != null &&
                    this.LegacyReference.Equals(input.LegacyReference))
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
                if (this.RefundAmount != null)
                    hashCode = hashCode * 59 + this.RefundAmount.GetHashCode();
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.LegacyReference != null)
                    hashCode = hashCode * 59 + this.LegacyReference.GetHashCode();
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
