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
    /// This type is used by the &lt;strong&gt;returnAddress&lt;/strong field that is used by the payment dispute methods. If a buyer is returning the item (under payment dispute) to the seller, a primary phone number for the seller must be provided.
    /// </summary>
    [DataContract]
        public partial class Phone :  IEquatable<Phone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Phone" /> class.
        /// </summary>
        /// <param name="countryCode">The seller&#x27;s country calling code. This field is needed if the buyer is located in a different country than the seller. It is also OK to provide if the buyer and seller are both located in the same country. For a full list of calling codes for all countries, see the &lt;a href&#x3D;\&quot;https://countrycode.org/ \&quot; target&#x3D;\&quot;_blank\&quot;&gt;countrycode.org&lt;/a&gt; site..</param>
        /// <param name="number">The seller&#x27;s primary phone number associated with the return address. When this number is provided in a &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; or &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; method, it is provided as one continuous numeric string, including the area code. So, if the phone number&#x27;s area code was &#x27;408&#x27;, a number in this field may look something like this: &lt;br&gt;&lt;br&gt;&lt;code&gt;\&quot;number\&quot; : \&quot;4088084356\&quot;&lt;/code&gt;&lt;br&gt;&lt;br&gt;If the buyer is located in a different country than the seller, the seller&#x27;s country calling code will need to be specified in the &lt;strong&gt;countryCode&lt;/strong&gt; field..</param>
        public Phone(string countryCode = default(string), string number = default(string))
        {
            this.CountryCode = countryCode;
            this.Number = number;
        }
        
        /// <summary>
        /// The seller&#x27;s country calling code. This field is needed if the buyer is located in a different country than the seller. It is also OK to provide if the buyer and seller are both located in the same country. For a full list of calling codes for all countries, see the &lt;a href&#x3D;\&quot;https://countrycode.org/ \&quot; target&#x3D;\&quot;_blank\&quot;&gt;countrycode.org&lt;/a&gt; site.
        /// </summary>
        /// <value>The seller&#x27;s country calling code. This field is needed if the buyer is located in a different country than the seller. It is also OK to provide if the buyer and seller are both located in the same country. For a full list of calling codes for all countries, see the &lt;a href&#x3D;\&quot;https://countrycode.org/ \&quot; target&#x3D;\&quot;_blank\&quot;&gt;countrycode.org&lt;/a&gt; site.</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The seller&#x27;s primary phone number associated with the return address. When this number is provided in a &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; or &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; method, it is provided as one continuous numeric string, including the area code. So, if the phone number&#x27;s area code was &#x27;408&#x27;, a number in this field may look something like this: &lt;br&gt;&lt;br&gt;&lt;code&gt;\&quot;number\&quot; : \&quot;4088084356\&quot;&lt;/code&gt;&lt;br&gt;&lt;br&gt;If the buyer is located in a different country than the seller, the seller&#x27;s country calling code will need to be specified in the &lt;strong&gt;countryCode&lt;/strong&gt; field.
        /// </summary>
        /// <value>The seller&#x27;s primary phone number associated with the return address. When this number is provided in a &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; or &lt;strong&gt;contestPaymentDispute&lt;/strong&gt; method, it is provided as one continuous numeric string, including the area code. So, if the phone number&#x27;s area code was &#x27;408&#x27;, a number in this field may look something like this: &lt;br&gt;&lt;br&gt;&lt;code&gt;\&quot;number\&quot; : \&quot;4088084356\&quot;&lt;/code&gt;&lt;br&gt;&lt;br&gt;If the buyer is located in a different country than the seller, the seller&#x27;s country calling code will need to be specified in the &lt;strong&gt;countryCode&lt;/strong&gt; field.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Phone {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as Phone);
        }

        /// <summary>
        /// Returns true if Phone instances are equal
        /// </summary>
        /// <param name="input">Instance of Phone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Phone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
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
