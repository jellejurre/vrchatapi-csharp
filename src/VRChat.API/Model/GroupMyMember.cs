/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.9.1
 * Contact: me@ariesclark.com
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
    /// GroupMyMember
    /// </summary>
    [DataContract(Name = "GroupMyMember")]
    public partial class GroupMyMember : IEquatable<GroupMyMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMyMember" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="userId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="roleIds">roleIds.</param>
        /// <param name="managerNotes">managerNotes.</param>
        /// <param name="membershipStatus">membershipStatus.</param>
        /// <param name="isSubscribedToAnnouncements">isSubscribedToAnnouncements (default to true).</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="isRepresenting">isRepresenting (default to false).</param>
        /// <param name="joinedAt">joinedAt.</param>
        /// <param name="bannedAt">bannedAt.</param>
        /// <param name="has2FA">has2FA (default to false).</param>
        /// <param name="permissions">permissions.</param>
        public GroupMyMember(string id = default(string), string groupId = default(string), string userId = default(string), List<string> roleIds = default(List<string>), string managerNotes = default(string), string membershipStatus = default(string), bool isSubscribedToAnnouncements = true, string visibility = default(string), bool isRepresenting = false, DateTime joinedAt = default(DateTime), string bannedAt = default(string), bool has2FA = false, List<string> permissions = default(List<string>))
        {
            this.Id = id;
            this.GroupId = groupId;
            this.UserId = userId;
            this.RoleIds = roleIds;
            this.ManagerNotes = managerNotes;
            this.MembershipStatus = membershipStatus;
            this.IsSubscribedToAnnouncements = isSubscribedToAnnouncements;
            this.Visibility = visibility;
            this.IsRepresenting = isRepresenting;
            this.JoinedAt = joinedAt;
            this.BannedAt = bannedAt;
            this.Has2FA = has2FA;
            this.Permissions = permissions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets RoleIds
        /// </summary>
        [DataMember(Name = "roleIds", EmitDefaultValue = false)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// Gets or Sets ManagerNotes
        /// </summary>
        [DataMember(Name = "managerNotes", EmitDefaultValue = false)]
        public string ManagerNotes { get; set; }

        /// <summary>
        /// Gets or Sets MembershipStatus
        /// </summary>
        [DataMember(Name = "membershipStatus", EmitDefaultValue = false)]
        public string MembershipStatus { get; set; }

        /// <summary>
        /// Gets or Sets IsSubscribedToAnnouncements
        /// </summary>
        [DataMember(Name = "isSubscribedToAnnouncements", EmitDefaultValue = true)]
        public bool IsSubscribedToAnnouncements { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or Sets IsRepresenting
        /// </summary>
        [DataMember(Name = "isRepresenting", EmitDefaultValue = true)]
        public bool IsRepresenting { get; set; }

        /// <summary>
        /// Gets or Sets JoinedAt
        /// </summary>
        [DataMember(Name = "joinedAt", EmitDefaultValue = false)]
        public DateTime JoinedAt { get; set; }

        /// <summary>
        /// Gets or Sets BannedAt
        /// </summary>
        [DataMember(Name = "bannedAt", EmitDefaultValue = true)]
        public string BannedAt { get; set; }

        /// <summary>
        /// Gets or Sets Has2FA
        /// </summary>
        [DataMember(Name = "has2FA", EmitDefaultValue = true)]
        public bool Has2FA { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupMyMember {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
            sb.Append("  ManagerNotes: ").Append(ManagerNotes).Append("\n");
            sb.Append("  MembershipStatus: ").Append(MembershipStatus).Append("\n");
            sb.Append("  IsSubscribedToAnnouncements: ").Append(IsSubscribedToAnnouncements).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  IsRepresenting: ").Append(IsRepresenting).Append("\n");
            sb.Append("  JoinedAt: ").Append(JoinedAt).Append("\n");
            sb.Append("  BannedAt: ").Append(BannedAt).Append("\n");
            sb.Append("  Has2FA: ").Append(Has2FA).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as GroupMyMember);
        }

        /// <summary>
        /// Returns true if GroupMyMember instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupMyMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupMyMember input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.RoleIds == input.RoleIds ||
                    this.RoleIds != null &&
                    input.RoleIds != null &&
                    this.RoleIds.SequenceEqual(input.RoleIds)
                ) && 
                (
                    this.ManagerNotes == input.ManagerNotes ||
                    (this.ManagerNotes != null &&
                    this.ManagerNotes.Equals(input.ManagerNotes))
                ) && 
                (
                    this.MembershipStatus == input.MembershipStatus ||
                    (this.MembershipStatus != null &&
                    this.MembershipStatus.Equals(input.MembershipStatus))
                ) && 
                (
                    this.IsSubscribedToAnnouncements == input.IsSubscribedToAnnouncements ||
                    this.IsSubscribedToAnnouncements.Equals(input.IsSubscribedToAnnouncements)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.IsRepresenting == input.IsRepresenting ||
                    this.IsRepresenting.Equals(input.IsRepresenting)
                ) && 
                (
                    this.JoinedAt == input.JoinedAt ||
                    (this.JoinedAt != null &&
                    this.JoinedAt.Equals(input.JoinedAt))
                ) && 
                (
                    this.BannedAt == input.BannedAt ||
                    (this.BannedAt != null &&
                    this.BannedAt.Equals(input.BannedAt))
                ) && 
                (
                    this.Has2FA == input.Has2FA ||
                    this.Has2FA.Equals(input.Has2FA)
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.RoleIds != null)
                {
                    hashCode = (hashCode * 59) + this.RoleIds.GetHashCode();
                }
                if (this.ManagerNotes != null)
                {
                    hashCode = (hashCode * 59) + this.ManagerNotes.GetHashCode();
                }
                if (this.MembershipStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSubscribedToAnnouncements.GetHashCode();
                if (this.Visibility != null)
                {
                    hashCode = (hashCode * 59) + this.Visibility.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsRepresenting.GetHashCode();
                if (this.JoinedAt != null)
                {
                    hashCode = (hashCode * 59) + this.JoinedAt.GetHashCode();
                }
                if (this.BannedAt != null)
                {
                    hashCode = (hashCode * 59) + this.BannedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Has2FA.GetHashCode();
                if (this.Permissions != null)
                {
                    hashCode = (hashCode * 59) + this.Permissions.GetHashCode();
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
            // Id (string) pattern
            Regex regexId = new Regex(@"gmem_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // GroupId (string) pattern
            Regex regexGroupId = new Regex(@"grp_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
            if (false == regexGroupId.Match(this.GroupId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupId, must match a pattern of " + regexGroupId, new [] { "GroupId" });
            }

            yield break;
        }
    }

}
