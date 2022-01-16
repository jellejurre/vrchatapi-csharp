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
    /// * &#x60;hidden&#x60; field is only present if InstanceType is &#x60;hidden&#x60; aka \&quot;Friends+\&quot;, and is instance creator. * &#x60;friends&#x60; field is only present if InstanceType is &#x60;friends&#x60; aka \&quot;Friends\&quot;, and is instance creator. * &#x60;private&#x60; field is only present if InstanceType is &#x60;private&#x60; aka \&quot;Invite\&quot; or \&quot;Invite+\&quot;, and is instance creator.
    /// </summary>
    [DataContract(Name = "Instance")]
    public partial class Instance : IEquatable<Instance>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets PhotonRegion
        /// </summary>
        [DataMember(Name = "photonRegion", IsRequired = true, EmitDefaultValue = false)]
        public Region PhotonRegion { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = false)]
        public Region Region { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public InstanceType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Instance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Instance" /> class.
        /// </summary>
        /// <param name="active">active (required) (default to true).</param>
        /// <param name="canRequestInvite">canRequestInvite (required) (default to true).</param>
        /// <param name="capacity">capacity (required).</param>
        /// <param name="clientNumber">Always returns \&quot;unknown\&quot;. (required).</param>
        /// <param name="full">full (required) (default to false).</param>
        /// <param name="id">InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="instanceId">instanceId (required).</param>
        /// <param name="location">InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="nUsers">nUsers (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="ownerId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="permanent">permanent (required) (default to false).</param>
        /// <param name="photonRegion">photonRegion (required).</param>
        /// <param name="platforms">platforms (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="shortName">shortName (required).</param>
        /// <param name="tags">The tags array on Instances usually contain the language tags of the people in the instance.  (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="hidden">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="friends">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="_private">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        public Instance(bool active = true, bool canRequestInvite = true, int capacity = default(int), string clientNumber = default(string), bool full = false, string id = default(string), string instanceId = default(string), string location = default(string), int nUsers = default(int), string name = default(string), string ownerId = default(string), bool permanent = false, Region photonRegion = default(Region), InstancePlatforms platforms = default(InstancePlatforms), Region region = default(Region), string shortName = default(string), List<string> tags = default(List<string>), InstanceType type = default(InstanceType), string worldId = default(string), string hidden = default(string), string friends = default(string), string _private = default(string))
        {
            this.Active = active;
            this.CanRequestInvite = canRequestInvite;
            this.Capacity = capacity;
            // to ensure "clientNumber" is required (not null)
            if (clientNumber == null) {
                throw new ArgumentNullException("clientNumber is a required property for Instance and cannot be null");
            }
            this.ClientNumber = clientNumber;
            this.Full = full;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for Instance and cannot be null");
            }
            this.Id = id;
            // to ensure "instanceId" is required (not null)
            if (instanceId == null) {
                throw new ArgumentNullException("instanceId is a required property for Instance and cannot be null");
            }
            this.InstanceId = instanceId;
            // to ensure "location" is required (not null)
            if (location == null) {
                throw new ArgumentNullException("location is a required property for Instance and cannot be null");
            }
            this.Location = location;
            this.NUsers = nUsers;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for Instance and cannot be null");
            }
            this.Name = name;
            this.Permanent = permanent;
            this.PhotonRegion = photonRegion;
            // to ensure "platforms" is required (not null)
            if (platforms == null) {
                throw new ArgumentNullException("platforms is a required property for Instance and cannot be null");
            }
            this.Platforms = platforms;
            this.Region = region;
            // to ensure "shortName" is required (not null)
            if (shortName == null) {
                throw new ArgumentNullException("shortName is a required property for Instance and cannot be null");
            }
            this.ShortName = shortName;
            // to ensure "tags" is required (not null)
            if (tags == null) {
                throw new ArgumentNullException("tags is a required property for Instance and cannot be null");
            }
            this.Tags = tags;
            this.Type = type;
            // to ensure "worldId" is required (not null)
            if (worldId == null) {
                throw new ArgumentNullException("worldId is a required property for Instance and cannot be null");
            }
            this.WorldId = worldId;
            this.OwnerId = ownerId;
            this.Hidden = hidden;
            this.Friends = friends;
            this.Private = _private;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", IsRequired = true, EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets CanRequestInvite
        /// </summary>
        [DataMember(Name = "canRequestInvite", IsRequired = true, EmitDefaultValue = true)]
        public bool CanRequestInvite { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", IsRequired = true, EmitDefaultValue = false)]
        public int Capacity { get; set; }

        /// <summary>
        /// Always returns \&quot;unknown\&quot;.
        /// </summary>
        /// <value>Always returns \&quot;unknown\&quot;.</value>
        [DataMember(Name = "clientNumber", IsRequired = true, EmitDefaultValue = false)]
        [Obsolete]
        public string ClientNumber { get; set; }

        /// <summary>
        /// Gets or Sets Full
        /// </summary>
        [DataMember(Name = "full", IsRequired = true, EmitDefaultValue = true)]
        public bool Full { get; set; }

        /// <summary>
        /// InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name = "instanceId", IsRequired = true, EmitDefaultValue = false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>InstanceID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "location", IsRequired = true, EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets NUsers
        /// </summary>
        [DataMember(Name = "n_users", IsRequired = true, EmitDefaultValue = false)]
        public int NUsers { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Permanent
        /// </summary>
        [DataMember(Name = "permanent", IsRequired = true, EmitDefaultValue = true)]
        public bool Permanent { get; set; }

        /// <summary>
        /// Gets or Sets Platforms
        /// </summary>
        [DataMember(Name = "platforms", IsRequired = true, EmitDefaultValue = false)]
        public InstancePlatforms Platforms { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", IsRequired = true, EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// The tags array on Instances usually contain the language tags of the people in the instance. 
        /// </summary>
        /// <value>The tags array on Instances usually contain the language tags of the people in the instance. </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", IsRequired = true, EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "hidden", EmitDefaultValue = false)]
        public string Hidden { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "friends", EmitDefaultValue = false)]
        public string Friends { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "private", EmitDefaultValue = false)]
        public string Private { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Instance {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CanRequestInvite: ").Append(CanRequestInvite).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  ClientNumber: ").Append(ClientNumber).Append("\n");
            sb.Append("  Full: ").Append(Full).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  NUsers: ").Append(NUsers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Permanent: ").Append(Permanent).Append("\n");
            sb.Append("  PhotonRegion: ").Append(PhotonRegion).Append("\n");
            sb.Append("  Platforms: ").Append(Platforms).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  Hidden: ").Append(Hidden).Append("\n");
            sb.Append("  Friends: ").Append(Friends).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
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
            return this.Equals(input as Instance);
        }

        /// <summary>
        /// Returns true if Instance instances are equal
        /// </summary>
        /// <param name="input">Instance of Instance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Instance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.CanRequestInvite == input.CanRequestInvite ||
                    this.CanRequestInvite.Equals(input.CanRequestInvite)
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
                ) && 
                (
                    this.ClientNumber == input.ClientNumber ||
                    (this.ClientNumber != null &&
                    this.ClientNumber.Equals(input.ClientNumber))
                ) && 
                (
                    this.Full == input.Full ||
                    this.Full.Equals(input.Full)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.NUsers == input.NUsers ||
                    this.NUsers.Equals(input.NUsers)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.Permanent == input.Permanent ||
                    this.Permanent.Equals(input.Permanent)
                ) && 
                (
                    this.PhotonRegion == input.PhotonRegion ||
                    this.PhotonRegion.Equals(input.PhotonRegion)
                ) && 
                (
                    this.Platforms == input.Platforms ||
                    (this.Platforms != null &&
                    this.Platforms.Equals(input.Platforms))
                ) && 
                (
                    this.Region == input.Region ||
                    this.Region.Equals(input.Region)
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.Hidden == input.Hidden ||
                    (this.Hidden != null &&
                    this.Hidden.Equals(input.Hidden))
                ) && 
                (
                    this.Friends == input.Friends ||
                    (this.Friends != null &&
                    this.Friends.Equals(input.Friends))
                ) && 
                (
                    this.Private == input.Private ||
                    (this.Private != null &&
                    this.Private.Equals(input.Private))
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                hashCode = hashCode * 59 + this.CanRequestInvite.GetHashCode();
                hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.ClientNumber != null)
                    hashCode = hashCode * 59 + this.ClientNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Full.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.NUsers.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                hashCode = hashCode * 59 + this.Permanent.GetHashCode();
                hashCode = hashCode * 59 + this.PhotonRegion.GetHashCode();
                if (this.Platforms != null)
                    hashCode = hashCode * 59 + this.Platforms.GetHashCode();
                hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ShortName != null)
                    hashCode = hashCode * 59 + this.ShortName.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.WorldId != null)
                    hashCode = hashCode * 59 + this.WorldId.GetHashCode();
                if (this.Hidden != null)
                    hashCode = hashCode * 59 + this.Hidden.GetHashCode();
                if (this.Friends != null)
                    hashCode = hashCode * 59 + this.Friends.GetHashCode();
                if (this.Private != null)
                    hashCode = hashCode * 59 + this.Private.GetHashCode();
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
            // Capacity (int) minimum
            if(this.Capacity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 0.", new [] { "Capacity" });
            }

            // ClientNumber (string) minLength
            if(this.ClientNumber != null && this.ClientNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClientNumber, length must be greater than 1.", new [] { "ClientNumber" });
            }

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 41)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 41.", new [] { "Id" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"(offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}:(\\d+)(~region\\(([\\w]+)\\))?(~([\\w]+)\\(usr_([\\w-]+)\\)((\\~canRequestInvite)?)(~region\\(([\\w].+)\\))?~nonce\\((.+)\\))?)", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // InstanceId (string) minLength
            if(this.InstanceId != null && this.InstanceId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InstanceId, length must be greater than 1.", new [] { "InstanceId" });
            }

            // Location (string) minLength
            if(this.Location != null && this.Location.Length < 41)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, length must be greater than 41.", new [] { "Location" });
            }

            // Location (string) pattern
            Regex regexLocation = new Regex(@"(offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}:(\\d+)(~region\\(([\\w]+)\\))?(~([\\w]+)\\(usr_([\\w-]+)\\)((\\~canRequestInvite)?)(~region\\(([\\w].+)\\))?~nonce\\((.+)\\))?)", RegexOptions.CultureInvariant);
            if (false == regexLocation.Match(this.Location).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Location, must match a pattern of " + regexLocation, new [] { "Location" });
            }

            // NUsers (int) minimum
            if(this.NUsers < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NUsers, must be a value greater than or equal to 0.", new [] { "NUsers" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // ShortName (string) minLength
            if(this.ShortName != null && this.ShortName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be greater than 1.", new [] { "ShortName" });
            }

            // WorldId (string) pattern
            Regex regexWorldId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexWorldId.Match(this.WorldId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WorldId, must match a pattern of " + regexWorldId, new [] { "WorldId" });
            }

            yield break;
        }
    }

}
