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
    /// WorldPublishStatus
    /// </summary>
    [DataContract(Name = "WorldPublishStatus")]
    public partial class WorldPublishStatus : IEquatable<WorldPublishStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldPublishStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorldPublishStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorldPublishStatus" /> class.
        /// </summary>
        /// <param name="canPubilsh">canPubilsh (required) (default to true).</param>
        public WorldPublishStatus(bool canPubilsh = true)
        {
            this.CanPubilsh = canPubilsh;
        }

        /// <summary>
        /// Gets or Sets CanPubilsh
        /// </summary>
        [DataMember(Name = "canPubilsh", IsRequired = true, EmitDefaultValue = true)]
        public bool CanPubilsh { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorldPublishStatus {\n");
            sb.Append("  CanPubilsh: ").Append(CanPubilsh).Append("\n");
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
            return this.Equals(input as WorldPublishStatus);
        }

        /// <summary>
        /// Returns true if WorldPublishStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of WorldPublishStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorldPublishStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanPubilsh == input.CanPubilsh ||
                    this.CanPubilsh.Equals(input.CanPubilsh)
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
                hashCode = hashCode * 59 + this.CanPubilsh.GetHashCode();
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
            yield break;
        }
    }

}
