/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// CreateFileRequest
    /// </summary>
    [DataContract(Name = "CreateFileRequest")]
    public partial class CreateFileRequest : IEquatable<CreateFileRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name = "mimeType", IsRequired = true, EmitDefaultValue = false)]
        public MIMEType MimeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFileRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="mimeType">mimeType (required).</param>
        /// <param name="extension">extension (required).</param>
        /// <param name="tags">tags.</param>
        public CreateFileRequest(string name = default(string), MIMEType mimeType = default(MIMEType), string extension = default(string), List<string> tags = default(List<string>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CreateFileRequest and cannot be null");
            }
            this.Name = name;
            this.MimeType = mimeType;
            // to ensure "extension" is required (not null)
            if (extension == null) {
                throw new ArgumentNullException("extension is a required property for CreateFileRequest and cannot be null");
            }
            this.Extension = extension;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", IsRequired = true, EmitDefaultValue = false)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFileRequest);
        }

        /// <summary>
        /// Returns true if CreateFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFileRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    this.MimeType.Equals(input.MimeType)
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Extension (string) minLength
            if(this.Extension != null && this.Extension.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Extension, length must be greater than 1.", new [] { "Extension" });
            }

            yield break;
        }
    }

}