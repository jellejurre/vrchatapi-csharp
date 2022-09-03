/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.7.3
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
    /// World
    /// </summary>
    [DataContract(Name = "World")]
    public partial class World : IEquatable<World>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name = "releaseStatus", IsRequired = true, EmitDefaultValue = false)]
        public ReleaseStatus ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected World() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="World" /> class.
        /// </summary>
        /// <param name="assetUrl">Empty if unauthenticated. (required).</param>
        /// <param name="authorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="authorName">authorName (required).</param>
        /// <param name="capacity">capacity (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="favorites">favorites (default to 0).</param>
        /// <param name="featured">featured (required) (default to false).</param>
        /// <param name="heat">heat (required) (default to 0).</param>
        /// <param name="id">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user. (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="instances">instances.</param>
        /// <param name="labsPublicationDate">labsPublicationDate (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="_namespace">_namespace (required).</param>
        /// <param name="occupants">occupants (default to 0).</param>
        /// <param name="organization">organization (required) (default to &quot;vrchat&quot;).</param>
        /// <param name="popularity">popularity (required) (default to 0).</param>
        /// <param name="previewYoutubeId">previewYoutubeId.</param>
        /// <param name="privateOccupants">privateOccupants (default to 0).</param>
        /// <param name="publicOccupants">publicOccupants (default to 0).</param>
        /// <param name="publicationDate">publicationDate (required).</param>
        /// <param name="releaseStatus">releaseStatus (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl (required).</param>
        /// <param name="unityPackages">Empty if unauthenticated. (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="version">version (required) (default to 0).</param>
        /// <param name="visits">visits (required) (default to 0).</param>
        public World(string assetUrl = default(string), string authorId = default(string), string authorName = default(string), int capacity = default(int), DateTime createdAt = default(DateTime), string description = default(string), int favorites = 0, bool featured = false, int heat = 0, string id = default(string), string imageUrl = default(string), List<List<Object>> instances = default(List<List<Object>>), string labsPublicationDate = default(string), string name = default(string), string _namespace = default(string), int occupants = 0, string organization = "vrchat", int popularity = 0, string previewYoutubeId = default(string), int privateOccupants = 0, int publicOccupants = 0, string publicationDate = default(string), ReleaseStatus releaseStatus = default(ReleaseStatus), List<string> tags = default(List<string>), string thumbnailImageUrl = default(string), List<UnityPackage> unityPackages = default(List<UnityPackage>), DateTime updatedAt = default(DateTime), int version = 0, int visits = 0)
        {
            // to ensure "assetUrl" is required (not null)
            if (assetUrl == null) {
                throw new ArgumentNullException("assetUrl is a required property for World and cannot be null");
            }
            this.AssetUrl = assetUrl;
            // to ensure "authorId" is required (not null)
            if (authorId == null) {
                throw new ArgumentNullException("authorId is a required property for World and cannot be null");
            }
            this.AuthorId = authorId;
            // to ensure "authorName" is required (not null)
            if (authorName == null) {
                throw new ArgumentNullException("authorName is a required property for World and cannot be null");
            }
            this.AuthorName = authorName;
            this.Capacity = capacity;
            this.CreatedAt = createdAt;
            // to ensure "description" is required (not null)
            if (description == null) {
                throw new ArgumentNullException("description is a required property for World and cannot be null");
            }
            this.Description = description;
            this.Featured = featured;
            this.Heat = heat;
            // to ensure "id" is required (not null)
            if (id == null) {
                throw new ArgumentNullException("id is a required property for World and cannot be null");
            }
            this.Id = id;
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null) {
                throw new ArgumentNullException("imageUrl is a required property for World and cannot be null");
            }
            this.ImageUrl = imageUrl;
            // to ensure "labsPublicationDate" is required (not null)
            if (labsPublicationDate == null) {
                throw new ArgumentNullException("labsPublicationDate is a required property for World and cannot be null");
            }
            this.LabsPublicationDate = labsPublicationDate;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for World and cannot be null");
            }
            this.Name = name;
            // to ensure "_namespace" is required (not null)
            if (_namespace == null) {
                throw new ArgumentNullException("_namespace is a required property for World and cannot be null");
            }
            this.Namespace = _namespace;
            // to ensure "organization" is required (not null)
            if (organization == null) {
                throw new ArgumentNullException("organization is a required property for World and cannot be null");
            }
            this.Organization = organization;
            this.Popularity = popularity;
            // to ensure "publicationDate" is required (not null)
            if (publicationDate == null) {
                throw new ArgumentNullException("publicationDate is a required property for World and cannot be null");
            }
            this.PublicationDate = publicationDate;
            this.ReleaseStatus = releaseStatus;
            // to ensure "tags" is required (not null)
            if (tags == null) {
                throw new ArgumentNullException("tags is a required property for World and cannot be null");
            }
            this.Tags = tags;
            // to ensure "thumbnailImageUrl" is required (not null)
            if (thumbnailImageUrl == null) {
                throw new ArgumentNullException("thumbnailImageUrl is a required property for World and cannot be null");
            }
            this.ThumbnailImageUrl = thumbnailImageUrl;
            // to ensure "unityPackages" is required (not null)
            if (unityPackages == null) {
                throw new ArgumentNullException("unityPackages is a required property for World and cannot be null");
            }
            this.UnityPackages = unityPackages;
            this.UpdatedAt = updatedAt;
            this._Version = version;
            this.Visits = visits;
            this.Favorites = favorites;
            this.Instances = instances;
            this.Occupants = occupants;
            this.PreviewYoutubeId = previewYoutubeId;
            this.PrivateOccupants = privateOccupants;
            this.PublicOccupants = publicOccupants;
        }

        /// <summary>
        /// Empty if unauthenticated.
        /// </summary>
        /// <value>Empty if unauthenticated.</value>
        [DataMember(Name = "assetUrl", IsRequired = true, EmitDefaultValue = false)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "authorId", IsRequired = true, EmitDefaultValue = false)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "authorName", IsRequired = true, EmitDefaultValue = false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name = "capacity", IsRequired = true, EmitDefaultValue = false)]
        public int Capacity { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Favorites
        /// </summary>
        [DataMember(Name = "favorites", EmitDefaultValue = false)]
        public int Favorites { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name = "featured", IsRequired = true, EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets Heat
        /// </summary>
        [DataMember(Name = "heat", IsRequired = true, EmitDefaultValue = false)]
        public int Heat { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Instances
        /// </summary>
        [DataMember(Name = "instances", EmitDefaultValue = false)]
        public List<List<Object>> Instances { get; set; }

        /// <summary>
        /// Gets or Sets LabsPublicationDate
        /// </summary>
        [DataMember(Name = "labsPublicationDate", IsRequired = true, EmitDefaultValue = false)]
        public string LabsPublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Namespace
        /// </summary>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets Occupants
        /// </summary>
        [DataMember(Name = "occupants", EmitDefaultValue = false)]
        public int Occupants { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name = "organization", IsRequired = true, EmitDefaultValue = false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name = "popularity", IsRequired = true, EmitDefaultValue = false)]
        public int Popularity { get; set; }

        /// <summary>
        /// Gets or Sets PreviewYoutubeId
        /// </summary>
        [DataMember(Name = "previewYoutubeId", EmitDefaultValue = true)]
        public string PreviewYoutubeId { get; set; }

        /// <summary>
        /// Gets or Sets PrivateOccupants
        /// </summary>
        [DataMember(Name = "privateOccupants", EmitDefaultValue = false)]
        public int PrivateOccupants { get; set; }

        /// <summary>
        /// Gets or Sets PublicOccupants
        /// </summary>
        [DataMember(Name = "publicOccupants", EmitDefaultValue = false)]
        public int PublicOccupants { get; set; }

        /// <summary>
        /// Gets or Sets PublicationDate
        /// </summary>
        [DataMember(Name = "publicationDate", IsRequired = true, EmitDefaultValue = false)]
        public string PublicationDate { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Empty if unauthenticated.
        /// </summary>
        /// <value>Empty if unauthenticated.</value>
        [DataMember(Name = "unityPackages", IsRequired = true, EmitDefaultValue = false)]
        public List<UnityPackage> UnityPackages { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Gets or Sets Visits
        /// </summary>
        [DataMember(Name = "visits", IsRequired = true, EmitDefaultValue = false)]
        public int Visits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class World {\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Favorites: ").Append(Favorites).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Heat: ").Append(Heat).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Instances: ").Append(Instances).Append("\n");
            sb.Append("  LabsPublicationDate: ").Append(LabsPublicationDate).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Occupants: ").Append(Occupants).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  PreviewYoutubeId: ").Append(PreviewYoutubeId).Append("\n");
            sb.Append("  PrivateOccupants: ").Append(PrivateOccupants).Append("\n");
            sb.Append("  PublicOccupants: ").Append(PublicOccupants).Append("\n");
            sb.Append("  PublicationDate: ").Append(PublicationDate).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
            sb.Append("  UnityPackages: ").Append(UnityPackages).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Visits: ").Append(Visits).Append("\n");
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
            return this.Equals(input as World);
        }

        /// <summary>
        /// Returns true if World instances are equal
        /// </summary>
        /// <param name="input">Instance of World to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(World input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AuthorId == input.AuthorId ||
                    (this.AuthorId != null &&
                    this.AuthorId.Equals(input.AuthorId))
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    this.Capacity.Equals(input.Capacity)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Favorites == input.Favorites ||
                    this.Favorites.Equals(input.Favorites)
                ) && 
                (
                    this.Featured == input.Featured ||
                    this.Featured.Equals(input.Featured)
                ) && 
                (
                    this.Heat == input.Heat ||
                    this.Heat.Equals(input.Heat)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.Instances == input.Instances ||
                    this.Instances != null &&
                    input.Instances != null &&
                    this.Instances.SequenceEqual(input.Instances)
                ) && 
                (
                    this.LabsPublicationDate == input.LabsPublicationDate ||
                    (this.LabsPublicationDate != null &&
                    this.LabsPublicationDate.Equals(input.LabsPublicationDate))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Occupants == input.Occupants ||
                    this.Occupants.Equals(input.Occupants)
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Popularity == input.Popularity ||
                    this.Popularity.Equals(input.Popularity)
                ) && 
                (
                    this.PreviewYoutubeId == input.PreviewYoutubeId ||
                    (this.PreviewYoutubeId != null &&
                    this.PreviewYoutubeId.Equals(input.PreviewYoutubeId))
                ) && 
                (
                    this.PrivateOccupants == input.PrivateOccupants ||
                    this.PrivateOccupants.Equals(input.PrivateOccupants)
                ) && 
                (
                    this.PublicOccupants == input.PublicOccupants ||
                    this.PublicOccupants.Equals(input.PublicOccupants)
                ) && 
                (
                    this.PublicationDate == input.PublicationDate ||
                    (this.PublicationDate != null &&
                    this.PublicationDate.Equals(input.PublicationDate))
                ) && 
                (
                    this.ReleaseStatus == input.ReleaseStatus ||
                    this.ReleaseStatus.Equals(input.ReleaseStatus)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
                ) && 
                (
                    this.UnityPackages == input.UnityPackages ||
                    this.UnityPackages != null &&
                    input.UnityPackages != null &&
                    this.UnityPackages.SequenceEqual(input.UnityPackages)
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Visits == input.Visits ||
                    this.Visits.Equals(input.Visits)
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
                if (this.AssetUrl != null)
                    hashCode = hashCode * 59 + this.AssetUrl.GetHashCode();
                if (this.AuthorId != null)
                    hashCode = hashCode * 59 + this.AuthorId.GetHashCode();
                if (this.AuthorName != null)
                    hashCode = hashCode * 59 + this.AuthorName.GetHashCode();
                hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Favorites.GetHashCode();
                hashCode = hashCode * 59 + this.Featured.GetHashCode();
                hashCode = hashCode * 59 + this.Heat.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.Instances != null)
                    hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.LabsPublicationDate != null)
                    hashCode = hashCode * 59 + this.LabsPublicationDate.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                hashCode = hashCode * 59 + this.Occupants.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                hashCode = hashCode * 59 + this.Popularity.GetHashCode();
                if (this.PreviewYoutubeId != null)
                    hashCode = hashCode * 59 + this.PreviewYoutubeId.GetHashCode();
                hashCode = hashCode * 59 + this.PrivateOccupants.GetHashCode();
                hashCode = hashCode * 59 + this.PublicOccupants.GetHashCode();
                if (this.PublicationDate != null)
                    hashCode = hashCode * 59 + this.PublicationDate.GetHashCode();
                hashCode = hashCode * 59 + this.ReleaseStatus.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ThumbnailImageUrl != null)
                    hashCode = hashCode * 59 + this.ThumbnailImageUrl.GetHashCode();
                if (this.UnityPackages != null)
                    hashCode = hashCode * 59 + this.UnityPackages.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this._Version.GetHashCode();
                hashCode = hashCode * 59 + this.Visits.GetHashCode();
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
            // AuthorName (string) minLength
            if(this.AuthorName != null && this.AuthorName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorName, length must be greater than 1.", new [] { "AuthorName" });
            }

            // Capacity (int) maximum
            if(this.Capacity > (int)40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value less than or equal to 40.", new [] { "Capacity" });
            }

            // Capacity (int) minimum
            if(this.Capacity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Capacity, must be a value greater than or equal to 0.", new [] { "Capacity" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // Favorites (int) minimum
            if(this.Favorites < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Favorites, must be a value greater than or equal to 0.", new [] { "Favorites" });
            }

            // Heat (int) minimum
            if(this.Heat < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Heat, must be a value greater than or equal to 0.", new [] { "Heat" });
            }

            // Id (string) pattern
            Regex regexId = new Regex(@"(^$|offline|(wrld|wld)_[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12})", RegexOptions.CultureInvariant);
            if (false == regexId.Match(this.Id).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
            }

            // ImageUrl (string) minLength
            if(this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }

            // LabsPublicationDate (string) minLength
            if(this.LabsPublicationDate != null && this.LabsPublicationDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LabsPublicationDate, length must be greater than 1.", new [] { "LabsPublicationDate" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Occupants (int) minimum
            if(this.Occupants < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Occupants, must be a value greater than or equal to 0.", new [] { "Occupants" });
            }

            // Organization (string) minLength
            if(this.Organization != null && this.Organization.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Organization, length must be greater than 1.", new [] { "Organization" });
            }

            // Popularity (int) minimum
            if(this.Popularity < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Popularity, must be a value greater than or equal to 0.", new [] { "Popularity" });
            }

            // PrivateOccupants (int) minimum
            if(this.PrivateOccupants < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivateOccupants, must be a value greater than or equal to 0.", new [] { "PrivateOccupants" });
            }

            // PublicOccupants (int) minimum
            if(this.PublicOccupants < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicOccupants, must be a value greater than or equal to 0.", new [] { "PublicOccupants" });
            }

            // PublicationDate (string) minLength
            if(this.PublicationDate != null && this.PublicationDate.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PublicationDate, length must be greater than 1.", new [] { "PublicationDate" });
            }

            // ThumbnailImageUrl (string) minLength
            if(this.ThumbnailImageUrl != null && this.ThumbnailImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThumbnailImageUrl, length must be greater than 1.", new [] { "ThumbnailImageUrl" });
            }

            // _Version (int) minimum
            if(this._Version < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, must be a value greater than or equal to 0.", new [] { "_Version" });
            }

            // Visits (int) minimum
            if(this.Visits < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Visits, must be a value greater than or equal to 0.", new [] { "Visits" });
            }

            yield break;
        }
    }

}
