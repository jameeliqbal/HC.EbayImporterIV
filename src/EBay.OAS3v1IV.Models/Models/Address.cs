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
    /// This type contains the details of a geographical address.
    /// </summary>
    [DataContract]
        public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="addressLine1">The first line of the street address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine1&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;.</param>
        /// <param name="addressLine2">The second line of the street address. This field can be used for additional address information, such as a suite or apartment number. This field will be returned if defined for the shipping address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine2&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;b&gt;Note:&lt;/b&gt; As of January 31, 2022, &lt;b&gt;addressLine2&lt;/b&gt; no longer returns EU VAT tax information. To determine line-item level VAT tax information, refer to &lt;a href&#x3D;\&quot;#response.orders.lineItems.ebayCollectAndRemitTaxes.ebayReference\&quot;&gt;eBayReference&lt;/a&gt;.&lt;/span&gt;.</param>
        /// <param name="city">The city of the shipping destination..</param>
        /// <param name="countryCode">The country of the shipping destination, represented as a two-letter ISO 3166-1 alpha-2 country code. For example, &lt;code&gt;US&lt;/code&gt; represents the United States, and &lt;code&gt;DE&lt;/code&gt; represents Germany. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="county">The county of the shipping destination. Counties typically, but not always, contain multiple cities or towns. This field is returned if known/available..</param>
        /// <param name="postalCode">The postal code of the shipping destination. Usually referred to as Zip codes in the US. Most countries have postal codes, but not all. The postal code will be returned if applicable..</param>
        /// <param name="stateOrProvince">The state or province of the shipping destination. Most countries have states or provinces, but not all. The state or province will be returned if applicable..</param>
        public Address(string addressLine1 = default(string), string addressLine2 = default(string), string city = default(string), string countryCode = default(string), string county = default(string), string postalCode = default(string), string stateOrProvince = default(string))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.CountryCode = countryCode;
            this.County = county;
            this.PostalCode = postalCode;
            this.StateOrProvince = stateOrProvince;
        }
        
        /// <summary>
        /// The first line of the street address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine1&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;
        /// </summary>
        /// <value>The first line of the street address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine1&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;</value>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the street address. This field can be used for additional address information, such as a suite or apartment number. This field will be returned if defined for the shipping address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine2&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;b&gt;Note:&lt;/b&gt; As of January 31, 2022, &lt;b&gt;addressLine2&lt;/b&gt; no longer returns EU VAT tax information. To determine line-item level VAT tax information, refer to &lt;a href&#x3D;\&quot;#response.orders.lineItems.ebayCollectAndRemitTaxes.ebayReference\&quot;&gt;eBayReference&lt;/a&gt;.&lt;/span&gt;
        /// </summary>
        /// <value>The second line of the street address. This field can be used for additional address information, such as a suite or apartment number. This field will be returned if defined for the shipping address.&lt;br&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;strong&gt;Note:&lt;/strong&gt; &lt;b&gt;addressLine2&lt;/b&gt; will not be returned for any order that is more than 90 days old.&lt;/span&gt;&lt;br&gt;&lt;span class&#x3D;\&quot;tablenote\&quot;&gt;&lt;b&gt;Note:&lt;/b&gt; As of January 31, 2022, &lt;b&gt;addressLine2&lt;/b&gt; no longer returns EU VAT tax information. To determine line-item level VAT tax information, refer to &lt;a href&#x3D;\&quot;#response.orders.lineItems.ebayCollectAndRemitTaxes.ebayReference\&quot;&gt;eBayReference&lt;/a&gt;.&lt;/span&gt;</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The city of the shipping destination.
        /// </summary>
        /// <value>The city of the shipping destination.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The country of the shipping destination, represented as a two-letter ISO 3166-1 alpha-2 country code. For example, &lt;code&gt;US&lt;/code&gt; represents the United States, and &lt;code&gt;DE&lt;/code&gt; represents Germany. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The country of the shipping destination, represented as a two-letter ISO 3166-1 alpha-2 country code. For example, &lt;code&gt;US&lt;/code&gt; represents the United States, and &lt;code&gt;DE&lt;/code&gt; represents Germany. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The county of the shipping destination. Counties typically, but not always, contain multiple cities or towns. This field is returned if known/available.
        /// </summary>
        /// <value>The county of the shipping destination. Counties typically, but not always, contain multiple cities or towns. This field is returned if known/available.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// The postal code of the shipping destination. Usually referred to as Zip codes in the US. Most countries have postal codes, but not all. The postal code will be returned if applicable.
        /// </summary>
        /// <value>The postal code of the shipping destination. Usually referred to as Zip codes in the US. Most countries have postal codes, but not all. The postal code will be returned if applicable.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The state or province of the shipping destination. Most countries have states or provinces, but not all. The state or province will be returned if applicable.
        /// </summary>
        /// <value>The state or province of the shipping destination. Most countries have states or provinces, but not all. The state or province will be returned if applicable.</value>
        [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
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
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.StateOrProvince != null)
                    hashCode = hashCode * 59 + this.StateOrProvince.GetHashCode();
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
