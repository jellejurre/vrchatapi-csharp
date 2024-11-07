/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.8
 * Contact: vrchatapi.lpv0t@aries.fyi
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
    /// Info about the performance limits on a platform
    /// </summary>
    [DataContract(Name = "PerformanceLimiterInfo")]
    public partial class PerformanceLimiterInfo : IEquatable<PerformanceLimiterInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceLimiterInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerformanceLimiterInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceLimiterInfo" /> class.
        /// </summary>
        /// <param name="allowed">allowed (required).</param>
        /// <param name="maxSeats">Maximum amount of seats. -1 means no limit. (required).</param>
        public PerformanceLimiterInfo(bool allowed = default(bool), int maxSeats = default(int))
        {
            this.Allowed = allowed;
            this.MaxSeats = maxSeats;
        }

        /// <summary>
        /// Gets or Sets Allowed
        /// </summary>
        [DataMember(Name = "allowed", IsRequired = true, EmitDefaultValue = true)]
        public bool Allowed { get; set; }

        /// <summary>
        /// Maximum amount of seats. -1 means no limit.
        /// </summary>
        /// <value>Maximum amount of seats. -1 means no limit.</value>
        [DataMember(Name = "maxSeats", IsRequired = true, EmitDefaultValue = true)]
        public int MaxSeats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PerformanceLimiterInfo {\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  MaxSeats: ").Append(MaxSeats).Append("\n");
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
            return this.Equals(input as PerformanceLimiterInfo);
        }

        /// <summary>
        /// Returns true if PerformanceLimiterInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceLimiterInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceLimiterInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Allowed == input.Allowed ||
                    this.Allowed.Equals(input.Allowed)
                ) && 
                (
                    this.MaxSeats == input.MaxSeats ||
                    this.MaxSeats.Equals(input.MaxSeats)
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
                hashCode = (hashCode * 59) + this.Allowed.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxSeats.GetHashCode();
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
