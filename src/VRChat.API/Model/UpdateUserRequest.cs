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
    /// UpdateUserRequest
    /// </summary>
    [DataContract(Name = "UpdateUserRequest")]
    public partial class UpdateUserRequest : IEquatable<UpdateUserRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public UserStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserRequest" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="birthday">birthday.</param>
        /// <param name="acceptedTOSVersion">acceptedTOSVersion.</param>
        /// <param name="tags"> .</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="bio">bio.</param>
        /// <param name="bioLinks">bioLinks.</param>
        /// <param name="pronouns">pronouns.</param>
        /// <param name="isBoopingEnabled">isBoopingEnabled.</param>
        /// <param name="userIcon">MUST be a valid VRChat /file/ url..</param>
        public UpdateUserRequest(string email = default(string), DateTime birthday = default(DateTime), int acceptedTOSVersion = default(int), List<string> tags = default(List<string>), UserStatus? status = default(UserStatus?), string statusDescription = default(string), string bio = default(string), List<string> bioLinks = default(List<string>), string pronouns = default(string), bool isBoopingEnabled = default(bool), string userIcon = default(string))
        {
            this.Email = email;
            this.Birthday = birthday;
            this.AcceptedTOSVersion = acceptedTOSVersion;
            this.Tags = tags;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.Bio = bio;
            this.BioLinks = bioLinks;
            this.Pronouns = pronouns;
            this.IsBoopingEnabled = isBoopingEnabled;
            this.UserIcon = userIcon;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Birthday
        /// </summary>
        [DataMember(Name = "birthday", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// Gets or Sets AcceptedTOSVersion
        /// </summary>
        [DataMember(Name = "acceptedTOSVersion", EmitDefaultValue = false)]
        public int AcceptedTOSVersion { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = false)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name = "bioLinks", EmitDefaultValue = false)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets Pronouns
        /// </summary>
        [DataMember(Name = "pronouns", EmitDefaultValue = false)]
        public string Pronouns { get; set; }

        /// <summary>
        /// Gets or Sets IsBoopingEnabled
        /// </summary>
        [DataMember(Name = "isBoopingEnabled", EmitDefaultValue = true)]
        public bool IsBoopingEnabled { get; set; }

        /// <summary>
        /// MUST be a valid VRChat /file/ url.
        /// </summary>
        /// <value>MUST be a valid VRChat /file/ url.</value>
        [DataMember(Name = "userIcon", EmitDefaultValue = false)]
        public string UserIcon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateUserRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  AcceptedTOSVersion: ").Append(AcceptedTOSVersion).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  Pronouns: ").Append(Pronouns).Append("\n");
            sb.Append("  IsBoopingEnabled: ").Append(IsBoopingEnabled).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
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
            return this.Equals(input as UpdateUserRequest);
        }

        /// <summary>
        /// Returns true if UpdateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateUserRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Birthday == input.Birthday ||
                    (this.Birthday != null &&
                    this.Birthday.Equals(input.Birthday))
                ) && 
                (
                    this.AcceptedTOSVersion == input.AcceptedTOSVersion ||
                    this.AcceptedTOSVersion.Equals(input.AcceptedTOSVersion)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.Pronouns == input.Pronouns ||
                    (this.Pronouns != null &&
                    this.Pronouns.Equals(input.Pronouns))
                ) && 
                (
                    this.IsBoopingEnabled == input.IsBoopingEnabled ||
                    this.IsBoopingEnabled.Equals(input.IsBoopingEnabled)
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Birthday != null)
                {
                    hashCode = (hashCode * 59) + this.Birthday.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AcceptedTOSVersion.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.BioLinks != null)
                {
                    hashCode = (hashCode * 59) + this.BioLinks.GetHashCode();
                }
                if (this.Pronouns != null)
                {
                    hashCode = (hashCode * 59) + this.Pronouns.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsBoopingEnabled.GetHashCode();
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
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
            // Bio (string) minLength
            if (this.Bio != null && this.Bio.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bio, length must be greater than 0.", new [] { "Bio" });
            }

            // Pronouns (string) maxLength
            if (this.Pronouns != null && this.Pronouns.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pronouns, length must be less than 32.", new [] { "Pronouns" });
            }

            // Pronouns (string) minLength
            if (this.Pronouns != null && this.Pronouns.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pronouns, length must be greater than 0.", new [] { "Pronouns" });
            }

            // UserIcon (string) minLength
            if (this.UserIcon != null && this.UserIcon.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserIcon, length must be greater than 0.", new [] { "UserIcon" });
            }

            yield break;
        }
    }

}
