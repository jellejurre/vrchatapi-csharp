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
    /// Status object representing if a queried user by username or userId exists or not. This model is primarily used by the &#x60;/auth/exists&#x60; endpoint, which in turn is used during registration. Please see the documentation on that endpoint for more information on usage.
    /// </summary>
    [DataContract]
    public partial class UserExists :  IEquatable<UserExists>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExists" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserExists() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExists" /> class.
        /// </summary>
        /// <param name="userExists">Status if a user exist with that username or userId. (required) (default to false).</param>
        public UserExists(bool userExists = false)
        {
            // to ensure "userExists" is required (not null)
            if (userExists == null)
            {
                throw new InvalidDataException("userExists is a required property for UserExists and cannot be null");
            }
            else
            {
                this._UserExists = userExists;
            }

        }

        /// <summary>
        /// Status if a user exist with that username or userId.
        /// </summary>
        /// <value>Status if a user exist with that username or userId.</value>
        [DataMember(Name="userExists", EmitDefaultValue=true)]
        public bool _UserExists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserExists {\n");
            sb.Append("  _UserExists: ").Append(_UserExists).Append("\n");
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
            return this.Equals(input as UserExists);
        }

        /// <summary>
        /// Returns true if UserExists instances are equal
        /// </summary>
        /// <param name="input">Instance of UserExists to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserExists input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._UserExists == input._UserExists ||
                    (this._UserExists != null &&
                    this._UserExists.Equals(input._UserExists))
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
                if (this._UserExists != null)
                    hashCode = hashCode * 59 + this._UserExists.GetHashCode();
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
