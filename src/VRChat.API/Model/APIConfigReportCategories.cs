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
    /// Categories available for reporting objectionable content
    /// </summary>
    [DataContract(Name = "APIConfig_reportCategories")]
    public partial class APIConfigReportCategories : IEquatable<APIConfigReportCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigReportCategories" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected APIConfigReportCategories() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigReportCategories" /> class.
        /// </summary>
        /// <param name="avatar">avatar (required).</param>
        /// <param name="behavior">behavior (required).</param>
        /// <param name="chat">chat (required).</param>
        /// <param name="environment">environment (required).</param>
        /// <param name="groupstore">groupstore (required).</param>
        /// <param name="image">image (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="warnings">warnings (required).</param>
        /// <param name="worldimage">worldimage (required).</param>
        /// <param name="worldstore">worldstore (required).</param>
        public APIConfigReportCategories(ReportCategory avatar = default(ReportCategory), ReportCategory behavior = default(ReportCategory), ReportCategory chat = default(ReportCategory), ReportCategory environment = default(ReportCategory), ReportCategory groupstore = default(ReportCategory), ReportCategory image = default(ReportCategory), ReportCategory text = default(ReportCategory), ReportCategory warnings = default(ReportCategory), ReportCategory worldimage = default(ReportCategory), ReportCategory worldstore = default(ReportCategory))
        {
            // to ensure "avatar" is required (not null)
            if (avatar == null)
            {
                throw new ArgumentNullException("avatar is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Avatar = avatar;
            // to ensure "behavior" is required (not null)
            if (behavior == null)
            {
                throw new ArgumentNullException("behavior is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Behavior = behavior;
            // to ensure "chat" is required (not null)
            if (chat == null)
            {
                throw new ArgumentNullException("chat is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Chat = chat;
            // to ensure "environment" is required (not null)
            if (environment == null)
            {
                throw new ArgumentNullException("environment is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Environment = environment;
            // to ensure "groupstore" is required (not null)
            if (groupstore == null)
            {
                throw new ArgumentNullException("groupstore is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Groupstore = groupstore;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Image = image;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Text = text;
            // to ensure "warnings" is required (not null)
            if (warnings == null)
            {
                throw new ArgumentNullException("warnings is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Warnings = warnings;
            // to ensure "worldimage" is required (not null)
            if (worldimage == null)
            {
                throw new ArgumentNullException("worldimage is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Worldimage = worldimage;
            // to ensure "worldstore" is required (not null)
            if (worldstore == null)
            {
                throw new ArgumentNullException("worldstore is a required property for APIConfigReportCategories and cannot be null");
            }
            this.Worldstore = worldstore;
        }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name = "avatar", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Avatar { get; set; }

        /// <summary>
        /// Gets or Sets Behavior
        /// </summary>
        [DataMember(Name = "behavior", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Behavior { get; set; }

        /// <summary>
        /// Gets or Sets Chat
        /// </summary>
        [DataMember(Name = "chat", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Chat { get; set; }

        /// <summary>
        /// Gets or Sets Environment
        /// </summary>
        [DataMember(Name = "environment", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Environment { get; set; }

        /// <summary>
        /// Gets or Sets Groupstore
        /// </summary>
        [DataMember(Name = "groupstore", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Groupstore { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Image { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Text { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Warnings { get; set; }

        /// <summary>
        /// Gets or Sets Worldimage
        /// </summary>
        [DataMember(Name = "worldimage", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Worldimage { get; set; }

        /// <summary>
        /// Gets or Sets Worldstore
        /// </summary>
        [DataMember(Name = "worldstore", IsRequired = true, EmitDefaultValue = true)]
        public ReportCategory Worldstore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigReportCategories {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Behavior: ").Append(Behavior).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Environment: ").Append(Environment).Append("\n");
            sb.Append("  Groupstore: ").Append(Groupstore).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Worldimage: ").Append(Worldimage).Append("\n");
            sb.Append("  Worldstore: ").Append(Worldstore).Append("\n");
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
            return this.Equals(input as APIConfigReportCategories);
        }

        /// <summary>
        /// Returns true if APIConfigReportCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigReportCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigReportCategories input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.Behavior == input.Behavior ||
                    (this.Behavior != null &&
                    this.Behavior.Equals(input.Behavior))
                ) && 
                (
                    this.Chat == input.Chat ||
                    (this.Chat != null &&
                    this.Chat.Equals(input.Chat))
                ) && 
                (
                    this.Environment == input.Environment ||
                    (this.Environment != null &&
                    this.Environment.Equals(input.Environment))
                ) && 
                (
                    this.Groupstore == input.Groupstore ||
                    (this.Groupstore != null &&
                    this.Groupstore.Equals(input.Groupstore))
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    (this.Warnings != null &&
                    this.Warnings.Equals(input.Warnings))
                ) && 
                (
                    this.Worldimage == input.Worldimage ||
                    (this.Worldimage != null &&
                    this.Worldimage.Equals(input.Worldimage))
                ) && 
                (
                    this.Worldstore == input.Worldstore ||
                    (this.Worldstore != null &&
                    this.Worldstore.Equals(input.Worldstore))
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
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.Behavior != null)
                {
                    hashCode = (hashCode * 59) + this.Behavior.GetHashCode();
                }
                if (this.Chat != null)
                {
                    hashCode = (hashCode * 59) + this.Chat.GetHashCode();
                }
                if (this.Environment != null)
                {
                    hashCode = (hashCode * 59) + this.Environment.GetHashCode();
                }
                if (this.Groupstore != null)
                {
                    hashCode = (hashCode * 59) + this.Groupstore.GetHashCode();
                }
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                if (this.Worldimage != null)
                {
                    hashCode = (hashCode * 59) + this.Worldimage.GetHashCode();
                }
                if (this.Worldstore != null)
                {
                    hashCode = (hashCode * 59) + this.Worldstore.GetHashCode();
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
