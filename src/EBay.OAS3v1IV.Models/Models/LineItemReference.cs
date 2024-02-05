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
    /// This type identifies the line item and quantity of that line item that comprises one fulfillment, such as a shipping package.
    /// </summary>
    [DataContract]
        public partial class LineItemReference :  IEquatable<LineItemReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemReference" /> class.
        /// </summary>
        /// <param name="lineItemId">This is the unique identifier of the eBay order line item that is part of the shipping fulfillment.&lt;br&gt;&lt;br&gt;Line item Ids can be found in the lineItems.&lt;b&gt;lineItemId&lt;/b&gt; field of the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank\&quot;&gt;getOrders&lt;/a&gt; response..</param>
        /// <param name="quantity">This is the number of lineItems associated with the &lt;a href&#x3D;\&quot;#request.trackingNumber\&quot;&gt;trackingNumber&lt;/a&gt; specified by the seller. This must be a whole number greater than zero (0)..</param>
        public LineItemReference(string lineItemId = default(string), int? quantity = default(int?))
        {
            this.LineItemId = lineItemId;
            this.Quantity = quantity;
        }
        
        /// <summary>
        /// This is the unique identifier of the eBay order line item that is part of the shipping fulfillment.&lt;br&gt;&lt;br&gt;Line item Ids can be found in the lineItems.&lt;b&gt;lineItemId&lt;/b&gt; field of the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank\&quot;&gt;getOrders&lt;/a&gt; response.
        /// </summary>
        /// <value>This is the unique identifier of the eBay order line item that is part of the shipping fulfillment.&lt;br&gt;&lt;br&gt;Line item Ids can be found in the lineItems.&lt;b&gt;lineItemId&lt;/b&gt; field of the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/order/methods/getOrders\&quot; target&#x3D;\&quot;_blank\&quot;&gt;getOrders&lt;/a&gt; response.</value>
        [DataMember(Name="lineItemId", EmitDefaultValue=false)]
        public string LineItemId { get; set; }

        /// <summary>
        /// This is the number of lineItems associated with the &lt;a href&#x3D;\&quot;#request.trackingNumber\&quot;&gt;trackingNumber&lt;/a&gt; specified by the seller. This must be a whole number greater than zero (0).
        /// </summary>
        /// <value>This is the number of lineItems associated with the &lt;a href&#x3D;\&quot;#request.trackingNumber\&quot;&gt;trackingNumber&lt;/a&gt; specified by the seller. This must be a whole number greater than zero (0).</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemReference {\n");
            sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as LineItemReference);
        }

        /// <summary>
        /// Returns true if LineItemReference instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LineItemId == input.LineItemId ||
                    (this.LineItemId != null &&
                    this.LineItemId.Equals(input.LineItemId))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
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
                if (this.LineItemId != null)
                    hashCode = hashCode * 59 + this.LineItemId.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
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
