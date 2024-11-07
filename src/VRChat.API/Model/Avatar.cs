/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.18.8
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
    /// Avatar
    /// </summary>
    [DataContract(Name = "Avatar")]
    public partial class Avatar : IEquatable<Avatar>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ReleaseStatus
        /// </summary>
        [DataMember(Name = "releaseStatus", IsRequired = true, EmitDefaultValue = true)]
        public ReleaseStatus ReleaseStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Avatar" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Avatar() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Avatar" /> class.
        /// </summary>
        /// <param name="assetUrl">Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;..</param>
        /// <param name="assetUrlObject">Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;. **Deprecation:** &#x60;Object&#x60; has unknown usage/fields, and is always empty. Use normal &#x60;Url&#x60; field instead..</param>
        /// <param name="authorId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="authorName">authorName (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="featured">featured (required) (default to false).</param>
        /// <param name="id">id (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="releaseStatus">releaseStatus (required).</param>
        /// <param name="tags">  (required).</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl (required).</param>
        /// <param name="unityPackageUrl">unityPackageUrl (required).</param>
        /// <param name="unityPackageUrlObject">unityPackageUrlObject (required).</param>
        /// <param name="unityPackages">unityPackages (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="version">version (required) (default to 0).</param>
        public Avatar(string assetUrl = default(string), Object assetUrlObject = default(Object), string authorId = default(string), string authorName = default(string), DateTime createdAt = default(DateTime), string description = default(string), bool featured = false, string id = default(string), string imageUrl = default(string), string name = default(string), ReleaseStatus releaseStatus = default(ReleaseStatus), List<string> tags = default(List<string>), string thumbnailImageUrl = default(string), string unityPackageUrl = default(string), AvatarUnityPackageUrlObject unityPackageUrlObject = default(AvatarUnityPackageUrlObject), List<UnityPackage> unityPackages = default(List<UnityPackage>), DateTime updatedAt = default(DateTime), int version = 0)
        {
            // to ensure "authorId" is required (not null)
            if (authorId == null)
            {
                throw new ArgumentNullException("authorId is a required property for Avatar and cannot be null");
            }
            this.AuthorId = authorId;
            // to ensure "authorName" is required (not null)
            if (authorName == null)
            {
                throw new ArgumentNullException("authorName is a required property for Avatar and cannot be null");
            }
            this.AuthorName = authorName;
            this.CreatedAt = createdAt;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for Avatar and cannot be null");
            }
            this.Description = description;
            this.Featured = featured;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Avatar and cannot be null");
            }
            this.Id = id;
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new ArgumentNullException("imageUrl is a required property for Avatar and cannot be null");
            }
            this.ImageUrl = imageUrl;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Avatar and cannot be null");
            }
            this.Name = name;
            this.ReleaseStatus = releaseStatus;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for Avatar and cannot be null");
            }
            this.Tags = tags;
            // to ensure "thumbnailImageUrl" is required (not null)
            if (thumbnailImageUrl == null)
            {
                throw new ArgumentNullException("thumbnailImageUrl is a required property for Avatar and cannot be null");
            }
            this.ThumbnailImageUrl = thumbnailImageUrl;
            // to ensure "unityPackageUrl" is required (not null)
            if (unityPackageUrl == null)
            {
                throw new ArgumentNullException("unityPackageUrl is a required property for Avatar and cannot be null");
            }
            this.UnityPackageUrl = unityPackageUrl;
            // to ensure "unityPackageUrlObject" is required (not null)
            if (unityPackageUrlObject == null)
            {
                throw new ArgumentNullException("unityPackageUrlObject is a required property for Avatar and cannot be null");
            }
            this.UnityPackageUrlObject = unityPackageUrlObject;
            // to ensure "unityPackages" is required (not null)
            if (unityPackages == null)
            {
                throw new ArgumentNullException("unityPackages is a required property for Avatar and cannot be null");
            }
            this.UnityPackages = unityPackages;
            this.UpdatedAt = updatedAt;
            this._Version = version;
            this.AssetUrl = assetUrl;
            this.AssetUrlObject = assetUrlObject;
        }

        /// <summary>
        /// Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;.
        /// </summary>
        /// <value>Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;.</value>
        [DataMember(Name = "assetUrl", EmitDefaultValue = false)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;. **Deprecation:** &#x60;Object&#x60; has unknown usage/fields, and is always empty. Use normal &#x60;Url&#x60; field instead.
        /// </summary>
        /// <value>Not present from general serach &#x60;/avatars&#x60;, only on specific requests &#x60;/avatars/{avatarId}&#x60;. **Deprecation:** &#x60;Object&#x60; has unknown usage/fields, and is always empty. Use normal &#x60;Url&#x60; field instead.</value>
        [DataMember(Name = "assetUrlObject", EmitDefaultValue = false)]
        public Object AssetUrlObject { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "authorId", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "authorName", IsRequired = true, EmitDefaultValue = true)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Featured
        /// </summary>
        [DataMember(Name = "featured", IsRequired = true, EmitDefaultValue = true)]
        public bool Featured { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackageUrl
        /// </summary>
        [DataMember(Name = "unityPackageUrl", IsRequired = true, EmitDefaultValue = true)]
        public string UnityPackageUrl { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackageUrlObject
        /// </summary>
        [DataMember(Name = "unityPackageUrlObject", IsRequired = true, EmitDefaultValue = true)]
        [Obsolete]
        public AvatarUnityPackageUrlObject UnityPackageUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets UnityPackages
        /// </summary>
        [DataMember(Name = "unityPackages", IsRequired = true, EmitDefaultValue = true)]
        public List<UnityPackage> UnityPackages { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Avatar {\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AssetUrlObject: ").Append(AssetUrlObject).Append("\n");
            sb.Append("  AuthorId: ").Append(AuthorId).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Featured: ").Append(Featured).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReleaseStatus: ").Append(ReleaseStatus).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
            sb.Append("  UnityPackageUrl: ").Append(UnityPackageUrl).Append("\n");
            sb.Append("  UnityPackageUrlObject: ").Append(UnityPackageUrlObject).Append("\n");
            sb.Append("  UnityPackages: ").Append(UnityPackages).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as Avatar);
        }

        /// <summary>
        /// Returns true if Avatar instances are equal
        /// </summary>
        /// <param name="input">Instance of Avatar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Avatar input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AssetUrlObject == input.AssetUrlObject ||
                    (this.AssetUrlObject != null &&
                    this.AssetUrlObject.Equals(input.AssetUrlObject))
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
                    this.Featured == input.Featured ||
                    this.Featured.Equals(input.Featured)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.UnityPackageUrl == input.UnityPackageUrl ||
                    (this.UnityPackageUrl != null &&
                    this.UnityPackageUrl.Equals(input.UnityPackageUrl))
                ) && 
                (
                    this.UnityPackageUrlObject == input.UnityPackageUrlObject ||
                    (this.UnityPackageUrlObject != null &&
                    this.UnityPackageUrlObject.Equals(input.UnityPackageUrlObject))
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
                {
                    hashCode = (hashCode * 59) + this.AssetUrl.GetHashCode();
                }
                if (this.AssetUrlObject != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUrlObject.GetHashCode();
                }
                if (this.AuthorId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorId.GetHashCode();
                }
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Featured.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReleaseStatus.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.ThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImageUrl.GetHashCode();
                }
                if (this.UnityPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UnityPackageUrl.GetHashCode();
                }
                if (this.UnityPackageUrlObject != null)
                {
                    hashCode = (hashCode * 59) + this.UnityPackageUrlObject.GetHashCode();
                }
                if (this.UnityPackages != null)
                {
                    hashCode = (hashCode * 59) + this.UnityPackages.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
            // AssetUrl (string) minLength
            if (this.AssetUrl != null && this.AssetUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetUrl, length must be greater than 1.", new [] { "AssetUrl" });
            }

            // AuthorName (string) minLength
            if (this.AuthorName != null && this.AuthorName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorName, length must be greater than 1.", new [] { "AuthorName" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

            // ImageUrl (string) minLength
            if (this.ImageUrl != null && this.ImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImageUrl, length must be greater than 1.", new [] { "ImageUrl" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // ThumbnailImageUrl (string) minLength
            if (this.ThumbnailImageUrl != null && this.ThumbnailImageUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ThumbnailImageUrl, length must be greater than 1.", new [] { "ThumbnailImageUrl" });
            }

            // _Version (int) minimum
            if (this._Version < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for _Version, must be a value greater than or equal to 0.", new [] { "_Version" });
            }

            yield break;
        }
    }

}
