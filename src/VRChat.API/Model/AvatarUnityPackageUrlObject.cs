/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.6
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
    /// **Deprecation:** &#x60;Object&#x60; has unknown usage/fields, and is always empty. Use normal &#x60;Url&#x60; field instead.
    /// </summary>
    [DataContract(Name = "Avatar_unityPackageUrlObject")]
    public partial class AvatarUnityPackageUrlObject : IEquatable<AvatarUnityPackageUrlObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarUnityPackageUrlObject" /> class.
        /// </summary>
        /// <param name="unityPackageUrl">unityPackageUrl.</param>
        public AvatarUnityPackageUrlObject(string unityPackageUrl = default(string))
        {
            this.UnityPackageUrl = unityPackageUrl;
        }

        /// <summary>
        /// Gets or Sets UnityPackageUrl
        /// </summary>
        [DataMember(Name = "unityPackageUrl", EmitDefaultValue = false)]
        public string UnityPackageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AvatarUnityPackageUrlObject {\n");
            sb.Append("  UnityPackageUrl: ").Append(UnityPackageUrl).Append("\n");
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
            return this.Equals(input as AvatarUnityPackageUrlObject);
        }

        /// <summary>
        /// Returns true if AvatarUnityPackageUrlObject instances are equal
        /// </summary>
        /// <param name="input">Instance of AvatarUnityPackageUrlObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvatarUnityPackageUrlObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UnityPackageUrl == input.UnityPackageUrl ||
                    (this.UnityPackageUrl != null &&
                    this.UnityPackageUrl.Equals(input.UnityPackageUrl))
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
                if (this.UnityPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UnityPackageUrl.GetHashCode();
                }
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
