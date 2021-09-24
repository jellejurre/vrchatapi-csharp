/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.3.3
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// InstancePlatforms
    /// </summary>
    [DataContract]
    public partial class InstancePlatforms :  IEquatable<InstancePlatforms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancePlatforms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InstancePlatforms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InstancePlatforms" /> class.
        /// </summary>
        /// <param name="android">android (required).</param>
        /// <param name="standalonewindows">standalonewindows (required).</param>
        public InstancePlatforms(decimal android = default(decimal), decimal standalonewindows = default(decimal))
        {
            // to ensure "android" is required (not null)
            if (android == null)
            {
                throw new InvalidDataException("android is a required property for InstancePlatforms and cannot be null");
            }
            else
            {
                this.Android = android;
            }

            // to ensure "standalonewindows" is required (not null)
            if (standalonewindows == null)
            {
                throw new InvalidDataException("standalonewindows is a required property for InstancePlatforms and cannot be null");
            }
            else
            {
                this.Standalonewindows = standalonewindows;
            }

        }

        /// <summary>
        /// Gets or Sets Android
        /// </summary>
        [DataMember(Name="android", EmitDefaultValue=true)]
        public decimal Android { get; set; }

        /// <summary>
        /// Gets or Sets Standalonewindows
        /// </summary>
        [DataMember(Name="standalonewindows", EmitDefaultValue=true)]
        public decimal Standalonewindows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstancePlatforms {\n");
            sb.Append("  Android: ").Append(Android).Append("\n");
            sb.Append("  Standalonewindows: ").Append(Standalonewindows).Append("\n");
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
            return this.Equals(input as InstancePlatforms);
        }

        /// <summary>
        /// Returns true if InstancePlatforms instances are equal
        /// </summary>
        /// <param name="input">Instance of InstancePlatforms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstancePlatforms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Android == input.Android ||
                    (this.Android != null &&
                    this.Android.Equals(input.Android))
                ) && 
                (
                    this.Standalonewindows == input.Standalonewindows ||
                    (this.Standalonewindows != null &&
                    this.Standalonewindows.Equals(input.Standalonewindows))
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
                if (this.Android != null)
                    hashCode = hashCode * 59 + this.Android.GetHashCode();
                if (this.Standalonewindows != null)
                    hashCode = hashCode * 59 + this.Standalonewindows.GetHashCode();
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
