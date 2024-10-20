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
    /// InviteRequest
    /// </summary>
    [DataContract(Name = "InviteRequest")]
    public partial class InviteRequest : IEquatable<InviteRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteRequest" /> class.
        /// </summary>
        /// <param name="instanceId">InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance. (required).</param>
        /// <param name="messageSlot">messageSlot.</param>
        public InviteRequest(string instanceId = default(string), int messageSlot = default(int))
        {
            // to ensure "instanceId" is required (not null)
            if (instanceId == null)
            {
                throw new ArgumentNullException("instanceId is a required property for InviteRequest and cannot be null");
            }
            this.InstanceId = instanceId;
            this.MessageSlot = messageSlot;
        }

        /// <summary>
        /// InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.
        /// </summary>
        /// <value>InstanceID can be \&quot;offline\&quot; on User profiles if you are not friends with that user and \&quot;private\&quot; if you are friends and user is in private instance.</value>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Gets or Sets MessageSlot
        /// </summary>
        [DataMember(Name = "messageSlot", EmitDefaultValue = false)]
        public int MessageSlot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InviteRequest {\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  MessageSlot: ").Append(MessageSlot).Append("\n");
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
            return this.Equals(input as InviteRequest);
        }

        /// <summary>
        /// Returns true if InviteRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.MessageSlot == input.MessageSlot ||
                    this.MessageSlot.Equals(input.MessageSlot)
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
                if (this.InstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MessageSlot.GetHashCode();
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
            // MessageSlot (int) maximum
            if (this.MessageSlot > (int)11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MessageSlot, must be a value less than or equal to 11.", new [] { "MessageSlot" });
            }

            // MessageSlot (int) minimum
            if (this.MessageSlot < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MessageSlot, must be a value greater than or equal to 0.", new [] { "MessageSlot" });
            }

            yield break;
        }
    }

}
