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
    /// This type contains a string field representing a telephone number.
    /// </summary>
    [DataContract]
        public partial class PhoneNumber :  IEquatable<PhoneNumber>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumber" /> class.
        /// </summary>
        /// <param name="phoneNumber">The primary telephone number for the shipping recipient..</param>
        public PhoneNumber(string phoneNumber = default(string))
        {
            this._PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// The primary telephone number for the shipping recipient.
        /// </summary>
        /// <value>The primary telephone number for the shipping recipient.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string _PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumber {\n");
            sb.Append("  _PhoneNumber: ").Append(_PhoneNumber).Append("\n");
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
            return this.Equals(input as PhoneNumber);
        }

        /// <summary>
        /// Returns true if PhoneNumber instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumber input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._PhoneNumber == input._PhoneNumber ||
                    (this._PhoneNumber != null &&
                    this._PhoneNumber.Equals(input._PhoneNumber))
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
                if (this._PhoneNumber != null)
                    hashCode = hashCode * 59 + this._PhoneNumber.GetHashCode();
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
