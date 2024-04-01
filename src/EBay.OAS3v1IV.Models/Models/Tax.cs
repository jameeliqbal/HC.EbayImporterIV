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
    /// This type contains information about any sales tax applied to a line item.
    /// </summary>
    [DataContract]
        public partial class Tax :  IEquatable<Tax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tax" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="taxType">Tax type. This field is only available when &lt;strong&gt;fieldGroups&lt;/strong&gt; is set to &lt;code&gt;TAX_BREAKDOWN&lt;/code&gt;. If the order has fees, a breakdown of the fees is also provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:TaxTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        public Tax(Amount amount = default(Amount), string taxType = default(string))
        {
            this.Amount = amount;
            this.TaxType = taxType;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// Tax type. This field is only available when &lt;strong&gt;fieldGroups&lt;/strong&gt; is set to &lt;code&gt;TAX_BREAKDOWN&lt;/code&gt;. If the order has fees, a breakdown of the fees is also provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:TaxTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>Tax type. This field is only available when &lt;strong&gt;fieldGroups&lt;/strong&gt; is set to &lt;code&gt;TAX_BREAKDOWN&lt;/code&gt;. If the order has fees, a breakdown of the fees is also provided. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/sel:TaxTypeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="taxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Tax {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as Tax);
        }

        /// <summary>
        /// Returns true if Tax instances are equal
        /// </summary>
        /// <param name="input">Instance of Tax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Tax input)
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
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
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
