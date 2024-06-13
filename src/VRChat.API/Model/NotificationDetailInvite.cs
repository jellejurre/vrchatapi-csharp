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
    /// NotificationDetailInvite
    /// </summary>
    [DataContract(Name = "NotificationDetailInvite")]
    public partial class NotificationDetailInvite : IEquatable<NotificationDetailInvite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailInvite" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NotificationDetailInvite() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetailInvite" /> class.
        /// </summary>
        /// <param name="inviteMessage">inviteMessage.</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="worldName">worldName (required).</param>
        public NotificationDetailInvite(string inviteMessage = default(string), string worldId = default(string), string worldName = default(string))
        {
            // to ensure "worldId" is required (not null)
            if (worldId == null)
            {
                throw new ArgumentNullException("worldId is a required property for NotificationDetailInvite and cannot be null");
            }
            this.WorldId = worldId;
            // to ensure "worldName" is required (not null)
            if (worldName == null)
            {
                throw new ArgumentNullException("worldName is a required property for NotificationDetailInvite and cannot be null");
            }
            this.WorldName = worldName;
            this.InviteMessage = inviteMessage;
        }

        /// <summary>
        /// Gets or Sets InviteMessage
        /// </summary>
        [DataMember(Name = "inviteMessage", EmitDefaultValue = false)]
        public string InviteMessage { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", IsRequired = true, EmitDefaultValue = true)]
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or Sets WorldName
        /// </summary>
        [DataMember(Name = "worldName", IsRequired = true, EmitDefaultValue = true)]
        public string WorldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetailInvite {\n");
            sb.Append("  InviteMessage: ").Append(InviteMessage).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  WorldName: ").Append(WorldName).Append("\n");
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
            return this.Equals(input as NotificationDetailInvite);
        }

        /// <summary>
        /// Returns true if NotificationDetailInvite instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetailInvite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetailInvite input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InviteMessage == input.InviteMessage ||
                    (this.InviteMessage != null &&
                    this.InviteMessage.Equals(input.InviteMessage))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.WorldName == input.WorldName ||
                    (this.WorldName != null &&
                    this.WorldName.Equals(input.WorldName))
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
                if (this.InviteMessage != null)
                {
                    hashCode = (hashCode * 59) + this.InviteMessage.GetHashCode();
                }
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
                }
                if (this.WorldName != null)
                {
                    hashCode = (hashCode * 59) + this.WorldName.GetHashCode();
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
