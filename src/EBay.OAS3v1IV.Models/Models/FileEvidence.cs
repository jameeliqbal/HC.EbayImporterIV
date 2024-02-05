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
    /// This type is used to store the unique identifier of an evidence file. Evidence files are used by seller to contest a payment dispute.
    /// </summary>
    [DataContract]
        public partial class FileEvidence :  IEquatable<FileEvidence>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEvidence" /> class.
        /// </summary>
        /// <param name="fileId">This field is used to identify the evidence file to be uploaded to the evidence set.&lt;br&gt;&lt;br&gt; This file is created with the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/uploadEvidenceFile\&quot; target&#x3D;\&quot;_blank \&quot;&gt;uploadEvidenceFile&lt;/a&gt; method and can be retrieved using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/getPaymentDisputes\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getPaymentDisputes&lt;/a&gt; method..</param>
        public FileEvidence(string fileId = default(string))
        {
            this.FileId = fileId;
        }
        
        /// <summary>
        /// This field is used to identify the evidence file to be uploaded to the evidence set.&lt;br&gt;&lt;br&gt; This file is created with the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/uploadEvidenceFile\&quot; target&#x3D;\&quot;_blank \&quot;&gt;uploadEvidenceFile&lt;/a&gt; method and can be retrieved using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/getPaymentDisputes\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getPaymentDisputes&lt;/a&gt; method.
        /// </summary>
        /// <value>This field is used to identify the evidence file to be uploaded to the evidence set.&lt;br&gt;&lt;br&gt; This file is created with the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/uploadEvidenceFile\&quot; target&#x3D;\&quot;_blank \&quot;&gt;uploadEvidenceFile&lt;/a&gt; method and can be retrieved using the &lt;a href&#x3D;\&quot;/api-docs/sell/fulfillment/resources/payment_dispute/methods/getPaymentDisputes\&quot; target&#x3D;\&quot;_blank \&quot;&gt;getPaymentDisputes&lt;/a&gt; method.</value>
        [DataMember(Name="fileId", EmitDefaultValue=false)]
        public string FileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEvidence {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
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
            return this.Equals(input as FileEvidence);
        }

        /// <summary>
        /// Returns true if FileEvidence instances are equal
        /// </summary>
        /// <param name="input">Instance of FileEvidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileEvidence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
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
