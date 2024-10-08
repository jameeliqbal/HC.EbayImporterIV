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
    /// This type is used by the payment dispute methods, and is relevant if the buyer will be returning the item to the seller.
    /// </summary>
    [DataContract]
        public partial class ReturnAddress :  IEquatable<ReturnAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">The first line of the street address..</param>
        /// <param name="addressLine2">The second line of the street address. This line is not always necessarily, but is often used for apartment number or suite number, or other relevant information that can not fit on the first line..</param>
        /// <param name="city">The city of the return address..</param>
        /// <param name="country">The country&#x27;s two-digit, ISO 3166-1 country code. See the enumeration type for a country&#x27;s value. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;.</param>
        /// <param name="county">The county of the return address. Counties are not applicable to all countries..</param>
        /// <param name="fullName">The full name of return address owner..</param>
        /// <param name="postalCode">The postal code of the return address..</param>
        /// <param name="primaryPhone">primaryPhone.</param>
        /// <param name="stateOrProvince">The state or province of the return address..</param>
        public ReturnAddress(string addressLine1 = default(string), string addressLine2 = default(string), string city = default(string), string country = default(string), string county = default(string), string fullName = default(string), string postalCode = default(string), Phone primaryPhone = default(Phone), string stateOrProvince = default(string))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.Country = country;
            this.County = county;
            this.FullName = fullName;
            this.PostalCode = postalCode;
            this.PrimaryPhone = primaryPhone;
            this.StateOrProvince = stateOrProvince;
        }
        
        /// <summary>
        /// The first line of the street address.
        /// </summary>
        /// <value>The first line of the street address.</value>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the street address. This line is not always necessarily, but is often used for apartment number or suite number, or other relevant information that can not fit on the first line.
        /// </summary>
        /// <value>The second line of the street address. This line is not always necessarily, but is often used for apartment number or suite number, or other relevant information that can not fit on the first line.</value>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The city of the return address.
        /// </summary>
        /// <value>The city of the return address.</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The country&#x27;s two-digit, ISO 3166-1 country code. See the enumeration type for a country&#x27;s value. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;
        /// </summary>
        /// <value>The country&#x27;s two-digit, ISO 3166-1 country code. See the enumeration type for a country&#x27;s value. For implementation help, refer to &lt;a href&#x3D;&#x27;https://developer.ebay.com/api-docs/sell/fulfillment/types/ba:CountryCodeEnum&#x27;&gt;eBay API documentation&lt;/a&gt;</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The county of the return address. Counties are not applicable to all countries.
        /// </summary>
        /// <value>The county of the return address. Counties are not applicable to all countries.</value>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// The full name of return address owner.
        /// </summary>
        /// <value>The full name of return address owner.</value>
        [DataMember(Name="fullName", EmitDefaultValue=false)]
        public string FullName { get; set; }

        /// <summary>
        /// The postal code of the return address.
        /// </summary>
        /// <value>The postal code of the return address.</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryPhone
        /// </summary>
        [DataMember(Name="primaryPhone", EmitDefaultValue=false)]
        public Phone PrimaryPhone { get; set; }

        /// <summary>
        /// The state or province of the return address.
        /// </summary>
        /// <value>The state or province of the return address.</value>
        [DataMember(Name="stateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReturnAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PrimaryPhone: ").Append(PrimaryPhone).Append("\n");
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
            return this.Equals(input as ReturnAddress);
        }

        /// <summary>
        /// Returns true if ReturnAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ReturnAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReturnAddress input)
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
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PrimaryPhone == input.PrimaryPhone ||
                    (this.PrimaryPhone != null &&
                    this.PrimaryPhone.Equals(input.PrimaryPhone))
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
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PrimaryPhone != null)
                    hashCode = hashCode * 59 + this.PrimaryPhone.GetHashCode();
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
