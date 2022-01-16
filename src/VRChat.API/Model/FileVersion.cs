/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.6
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
    /// FileVersion
    /// </summary>
    [DataContract(Name = "FileVersion")]
    public partial class FileVersion : IEquatable<FileVersion>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = false)]
        public FileStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileVersion" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="deleted">Usually only present if &#x60;true&#x60; (default to true).</param>
        /// <param name="delta">delta.</param>
        /// <param name="file">file.</param>
        /// <param name="signature">signature.</param>
        /// <param name="status">status (required).</param>
        /// <param name="version">Incremental version counter, can only be increased. (required) (default to 0).</param>
        public FileVersion(DateTime createdAt = default(DateTime), bool deleted = true, FileData delta = default(FileData), FileData file = default(FileData), FileData signature = default(FileData), FileStatus status = default(FileStatus), int version = 0)
        {
            this.CreatedAt = createdAt;
            this.Status = status;
            this._Version = version;
            this.Deleted = deleted;
            this.Delta = delta;
            this.File = file;
            this.Signature = signature;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Usually only present if &#x60;true&#x60;
        /// </summary>
        /// <value>Usually only present if &#x60;true&#x60;</value>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Delta
        /// </summary>
        [DataMember(Name = "delta", EmitDefaultValue = false)]
        public FileData Delta { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileData File { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public FileData Signature { get; set; }

        /// <summary>
        /// Incremental version counter, can only be increased.
        /// </summary>
        /// <value>Incremental version counter, can only be increased.</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileVersion {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as FileVersion);
        }

        /// <summary>
        /// Returns true if FileVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of FileVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this._Version.GetHashCode();
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
            // _Version (int) minimum
            if(this._Version < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, must be a value greater than or equal to 0.", new [] { "_Version" });
            }

            yield break;
        }
    }

}
