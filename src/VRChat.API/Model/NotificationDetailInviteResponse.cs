/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.6
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
    /// NotificationDetailInviteResponse
    /// </summary>
    [DataContract(Name = "NotificationDetailInviteResponse")]
    public partial class NotificationDetailInviteResponse : IEquatable<NotificationDetailInviteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailInviteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationDetailInviteResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailInviteResponse" /> class.
        /// </summary>
        /// <param name="inResponseTo">inResponseTo (required).</param>
        /// <param name="responseMessage">responseMessage (required).</param>
        public NotificationDetailInviteResponse(string inResponseTo = default(string), string responseMessage = default(string))
        {
            // to ensure "inResponseTo" is required (not null)
            if (inResponseTo == null)
            {
                throw new ArgumentNullException("inResponseTo is a required property for NotificationDetailInviteResponse and cannot be null");
            }
            this.InResponseTo = inResponseTo;
            // to ensure "responseMessage" is required (not null)
            if (responseMessage == null)
            {
                throw new ArgumentNullException("responseMessage is a required property for NotificationDetailInviteResponse and cannot be null");
            }
            this.ResponseMessage = responseMessage;
        }

        /// <summary>
        /// Gets or Sets InResponseTo
        /// </summary>
        [DataMember(Name = "inResponseTo", IsRequired = true, EmitDefaultValue = true)]
        public string InResponseTo { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMessage
        /// </summary>
        [DataMember(Name = "responseMessage", IsRequired = true, EmitDefaultValue = true)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailInviteResponse {\n");
            sb.Append("  InResponseTo: ").Append(InResponseTo).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
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
            return this.Equals(input as NotificationDetailInviteResponse);
        }

        /// <summary>
        /// Returns true if NotificationDetailInviteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailInviteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailInviteResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InResponseTo == input.InResponseTo ||
                    (this.InResponseTo != null &&
                    this.InResponseTo.Equals(input.InResponseTo))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
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
                if (this.InResponseTo != null)
                {
                    hashCode = (hashCode * 59) + this.InResponseTo.GetHashCode();
                }
                if (this.ResponseMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMessage.GetHashCode();
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
