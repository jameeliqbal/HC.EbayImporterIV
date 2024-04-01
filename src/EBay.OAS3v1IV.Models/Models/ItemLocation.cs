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
    /// This type describes the physical location of an order.
    /// </summary>
    [DataContract]
        public partial class ItemLocation :  IEquatable<ItemLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLocation" /> class.
        /// </summary>
        /// <param name="countryCode">The two-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-3166-country-codes.html \&quot; title&#x3D;\&quot;https://www.iso.org \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ISO 3166&lt;/a&gt; code representing the country of the address. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="location">Indicates the geographical location of the item (along with the value in the &lt;strong&gt;countryCode&lt;/strong&gt; field). This field provides city, province, state, or similar information..</param>
        /// <param name="postalCode">The postal code of the address..</param>
        public ItemLocation(string countryCode = default(string), string location = default(string), string postalCode = default(string))
        {
            this.CountryCode = countryCode;
            this.Location = location;
            this.PostalCode = postalCode;
        }
        
        /// <summary>
        /// The two-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-3166-country-codes.html \&quot; title&#x3D;\&quot;https://www.iso.org \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ISO 3166&lt;/a&gt; code representing the country of the address. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The two-letter &lt;a href&#x3D;\&quot;https://www.iso.org/iso-3166-country-codes.html \&quot; title&#x3D;\&quot;https://www.iso.org \&quot; target&#x3D;\&quot;_blank\&quot;&gt;ISO 3166&lt;/a&gt; code representing the country of the address. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Indicates the geographical location of the item (along with the value in the &lt;strong&gt;countryCode&lt;/strong&gt; field). This field provides city, province, state, or similar information.
        /// </summary>
        /// <value>Indicates the geographical location of the item (along with the value in the &lt;strong&gt;countryCode&lt;/strong&gt; field). This field provides city, province, state, or similar information.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        /// <value>The postal code of the address.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemLocation {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(input as ItemLocation);
        }

        /// <summary>
        /// Returns true if ItemLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemLocation input)
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
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
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
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
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
