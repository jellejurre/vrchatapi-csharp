/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.7
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
    /// Group
    /// </summary>
    [DataContract(Name = "Group")]
    public partial class Group : IEquatable<Group>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public GroupPrivacy? Privacy { get; set; }

        /// <summary>
        /// Gets or Sets JoinState
        /// </summary>
        [DataMember(Name = "joinState", EmitDefaultValue = false)]
        public GroupJoinState? JoinState { get; set; }

        /// <summary>
        /// Gets or Sets MembershipStatus
        /// </summary>
        [DataMember(Name = "membershipStatus", EmitDefaultValue = false)]
        public GroupMemberStatus? MembershipStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="badges">badges.</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="shortCode">shortCode.</param>
        /// <param name="discriminator">discriminator.</param>
        /// <param name="description">description.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="bannerUrl">bannerUrl.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="ownerId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="rules">rules.</param>
        /// <param name="links">links.</param>
        /// <param name="languages">languages.</param>
        /// <param name="iconId">iconId.</param>
        /// <param name="bannerId">bannerId.</param>
        /// <param name="memberCount">memberCount.</param>
        /// <param name="memberCountSyncedAt">memberCountSyncedAt.</param>
        /// <param name="isVerified">isVerified (default to false).</param>
        /// <param name="joinState">joinState.</param>
        /// <param name="tags">tags.</param>
        /// <param name="transferTargetId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="galleries">galleries.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="lastPostCreatedAt">lastPostCreatedAt.</param>
        /// <param name="onlineMemberCount">onlineMemberCount.</param>
        /// <param name="membershipStatus">membershipStatus.</param>
        /// <param name="myMember">myMember.</param>
        /// <param name="roles">Only returned if ?includeRoles&#x3D;true is specified..</param>
        public Group(List<string> badges = default(List<string>), string id = default(string), string name = default(string), string shortCode = default(string), string discriminator = default(string), string description = default(string), string iconUrl = default(string), string bannerUrl = default(string), GroupPrivacy? privacy = default(GroupPrivacy?), string ownerId = default(string), string rules = default(string), List<string> links = default(List<string>), List<string> languages = default(List<string>), string iconId = default(string), string bannerId = default(string), int memberCount = default(int), DateTime memberCountSyncedAt = default(DateTime), bool isVerified = false, GroupJoinState? joinState = default(GroupJoinState?), List<string> tags = default(List<string>), string transferTargetId = default(string), List<GroupGallery> galleries = default(List<GroupGallery>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), DateTime? lastPostCreatedAt = default(DateTime?), int onlineMemberCount = default(int), GroupMemberStatus? membershipStatus = default(GroupMemberStatus?), GroupMyMember myMember = default(GroupMyMember), List<GroupRole> roles = default(List<GroupRole>))
        {
            this.Badges = badges;
            this.Id = id;
            this.Name = name;
            this.ShortCode = shortCode;
            this.Discriminator = discriminator;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.BannerUrl = bannerUrl;
            this.Privacy = privacy;
            this.OwnerId = ownerId;
            this.Rules = rules;
            this.Links = links;
            this.Languages = languages;
            this.IconId = iconId;
            this.BannerId = bannerId;
            this.MemberCount = memberCount;
            this.MemberCountSyncedAt = memberCountSyncedAt;
            this.IsVerified = isVerified;
            this.JoinState = joinState;
            this.Tags = tags;
            this.TransferTargetId = transferTargetId;
            this.Galleries = galleries;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.LastPostCreatedAt = lastPostCreatedAt;
            this.OnlineMemberCount = onlineMemberCount;
            this.MembershipStatus = membershipStatus;
            this.MyMember = myMember;
            this.Roles = roles;
        }

        /// <summary>
        /// Gets or Sets Badges
        /// </summary>
        [DataMember(Name = "badges", EmitDefaultValue = false)]
        public List<string> Badges { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortCode
        /// </summary>
        [DataMember(Name = "shortCode", EmitDefaultValue = false)]
        public string ShortCode { get; set; }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", EmitDefaultValue = false)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", EmitDefaultValue = true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// Gets or Sets BannerUrl
        /// </summary>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = true)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "rules", EmitDefaultValue = true)]
        public string Rules { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<string> Links { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "iconId", EmitDefaultValue = true)]
        public string IconId { get; set; }

        /// <summary>
        /// Gets or Sets BannerId
        /// </summary>
        [DataMember(Name = "bannerId", EmitDefaultValue = true)]
        public string BannerId { get; set; }

        /// <summary>
        /// Gets or Sets MemberCount
        /// </summary>
        [DataMember(Name = "memberCount", EmitDefaultValue = false)]
        public int MemberCount { get; set; }

        /// <summary>
        /// Gets or Sets MemberCountSyncedAt
        /// </summary>
        [DataMember(Name = "memberCountSyncedAt", EmitDefaultValue = false)]
        public DateTime MemberCountSyncedAt { get; set; }

        /// <summary>
        /// Gets or Sets IsVerified
        /// </summary>
        [DataMember(Name = "isVerified", EmitDefaultValue = true)]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "transferTargetId", EmitDefaultValue = false)]
        public string TransferTargetId { get; set; }

        /// <summary>
        /// Gets or Sets Galleries
        /// </summary>
        [DataMember(Name = "galleries", EmitDefaultValue = false)]
        public List<GroupGallery> Galleries { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastPostCreatedAt
        /// </summary>
        [DataMember(Name = "lastPostCreatedAt", EmitDefaultValue = true)]
        public DateTime? LastPostCreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets OnlineMemberCount
        /// </summary>
        [DataMember(Name = "onlineMemberCount", EmitDefaultValue = false)]
        public int OnlineMemberCount { get; set; }

        /// <summary>
        /// Gets or Sets MyMember
        /// </summary>
        [DataMember(Name = "myMember", EmitDefaultValue = false)]
        public GroupMyMember MyMember { get; set; }

        /// <summary>
        /// Only returned if ?includeRoles&#x3D;true is specified.
        /// </summary>
        /// <value>Only returned if ?includeRoles&#x3D;true is specified.</value>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<GroupRole> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  Badges: ").Append(Badges).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortCode: ").Append(ShortCode).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  BannerId: ").Append(BannerId).Append("\n");
            sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
            sb.Append("  MemberCountSyncedAt: ").Append(MemberCountSyncedAt).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
            sb.Append("  JoinState: ").Append(JoinState).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TransferTargetId: ").Append(TransferTargetId).Append("\n");
            sb.Append("  Galleries: ").Append(Galleries).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LastPostCreatedAt: ").Append(LastPostCreatedAt).Append("\n");
            sb.Append("  OnlineMemberCount: ").Append(OnlineMemberCount).Append("\n");
            sb.Append("  MembershipStatus: ").Append(MembershipStatus).Append("\n");
            sb.Append("  MyMember: ").Append(MyMember).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Badges == input.Badges ||
                    this.Badges != null &&
                    input.Badges != null &&
                    this.Badges.SequenceEqual(input.Badges)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortCode == input.ShortCode ||
                    (this.ShortCode != null &&
                    this.ShortCode.Equals(input.ShortCode))
                ) && 
                (
                    this.Discriminator == input.Discriminator ||
                    (this.Discriminator != null &&
                    this.Discriminator.Equals(input.Discriminator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Rules == input.Rules ||
                    (this.Rules != null &&
                    this.Rules.Equals(input.Rules))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.BannerId == input.BannerId ||
                    (this.BannerId != null &&
                    this.BannerId.Equals(input.BannerId))
                ) && 
                (
                    this.MemberCount == input.MemberCount ||
                    this.MemberCount.Equals(input.MemberCount)
                ) && 
                (
                    this.MemberCountSyncedAt == input.MemberCountSyncedAt ||
                    (this.MemberCountSyncedAt != null &&
                    this.MemberCountSyncedAt.Equals(input.MemberCountSyncedAt))
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    this.IsVerified.Equals(input.IsVerified)
                ) && 
                (
                    this.JoinState == input.JoinState ||
                    this.JoinState.Equals(input.JoinState)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TransferTargetId == input.TransferTargetId ||
                    (this.TransferTargetId != null &&
                    this.TransferTargetId.Equals(input.TransferTargetId))
                ) && 
                (
                    this.Galleries == input.Galleries ||
                    this.Galleries != null &&
                    input.Galleries != null &&
                    this.Galleries.SequenceEqual(input.Galleries)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.LastPostCreatedAt == input.LastPostCreatedAt ||
                    (this.LastPostCreatedAt != null &&
                    this.LastPostCreatedAt.Equals(input.LastPostCreatedAt))
                ) && 
                (
                    this.OnlineMemberCount == input.OnlineMemberCount ||
                    this.OnlineMemberCount.Equals(input.OnlineMemberCount)
                ) && 
                (
                    this.MembershipStatus == input.MembershipStatus ||
                    this.MembershipStatus.Equals(input.MembershipStatus)
                ) && 
                (
                    this.MyMember == input.MyMember ||
                    (this.MyMember != null &&
                    this.MyMember.Equals(input.MyMember))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.Badges != null)
                {
                    hashCode = (hashCode * 59) + this.Badges.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ShortCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShortCode.GetHashCode();
                }
                if (this.Discriminator != null)
                {
                    hashCode = (hashCode * 59) + this.Discriminator.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Privacy.GetHashCode();
                if (this.OwnerId != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerId.GetHashCode();
                }
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.BannerId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MemberCount.GetHashCode();
                if (this.MemberCountSyncedAt != null)
                {
                    hashCode = (hashCode * 59) + this.MemberCountSyncedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsVerified.GetHashCode();
                hashCode = (hashCode * 59) + this.JoinState.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.TransferTargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TransferTargetId.GetHashCode();
                }
                if (this.Galleries != null)
                {
                    hashCode = (hashCode * 59) + this.Galleries.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.LastPostCreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastPostCreatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OnlineMemberCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MembershipStatus.GetHashCode();
                if (this.MyMember != null)
                {
                    hashCode = (hashCode * 59) + this.MyMember.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
