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
    /// JamStateChangeDates
    /// </summary>
    [DataContract(Name = "Jam_stateChangeDates")]
    public partial class JamStateChangeDates : IEquatable<JamStateChangeDates>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JamStateChangeDates" /> class.
        /// </summary>
        /// <param name="closed">closed.</param>
        /// <param name="submissionsClosed">submissionsClosed.</param>
        /// <param name="submissionsOpened">submissionsOpened.</param>
        /// <param name="winnersSelected">winnersSelected.</param>
        public JamStateChangeDates(DateTime? closed = default(DateTime?), DateTime? submissionsClosed = default(DateTime?), DateTime? submissionsOpened = default(DateTime?), DateTime? winnersSelected = default(DateTime?))
        {
            this.Closed = closed;
            this.SubmissionsClosed = submissionsClosed;
            this.SubmissionsOpened = submissionsOpened;
            this.WinnersSelected = winnersSelected;
        }

        /// <summary>
        /// Gets or Sets Closed
        /// </summary>
        [DataMember(Name = "closed", EmitDefaultValue = true)]
        public DateTime? Closed { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionsClosed
        /// </summary>
        [DataMember(Name = "submissionsClosed", EmitDefaultValue = true)]
        public DateTime? SubmissionsClosed { get; set; }

        /// <summary>
        /// Gets or Sets SubmissionsOpened
        /// </summary>
        [DataMember(Name = "submissionsOpened", EmitDefaultValue = true)]
        public DateTime? SubmissionsOpened { get; set; }

        /// <summary>
        /// Gets or Sets WinnersSelected
        /// </summary>
        [DataMember(Name = "winnersSelected", EmitDefaultValue = true)]
        public DateTime? WinnersSelected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JamStateChangeDates {\n");
            sb.Append("  Closed: ").Append(Closed).Append("\n");
            sb.Append("  SubmissionsClosed: ").Append(SubmissionsClosed).Append("\n");
            sb.Append("  SubmissionsOpened: ").Append(SubmissionsOpened).Append("\n");
            sb.Append("  WinnersSelected: ").Append(WinnersSelected).Append("\n");
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
            return this.Equals(input as JamStateChangeDates);
        }

        /// <summary>
        /// Returns true if JamStateChangeDates instances are equal
        /// </summary>
        /// <param name="input">Instance of JamStateChangeDates to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JamStateChangeDates input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Closed == input.Closed ||
                    (this.Closed != null &&
                    this.Closed.Equals(input.Closed))
                ) && 
                (
                    this.SubmissionsClosed == input.SubmissionsClosed ||
                    (this.SubmissionsClosed != null &&
                    this.SubmissionsClosed.Equals(input.SubmissionsClosed))
                ) && 
                (
                    this.SubmissionsOpened == input.SubmissionsOpened ||
                    (this.SubmissionsOpened != null &&
                    this.SubmissionsOpened.Equals(input.SubmissionsOpened))
                ) && 
                (
                    this.WinnersSelected == input.WinnersSelected ||
                    (this.WinnersSelected != null &&
                    this.WinnersSelected.Equals(input.WinnersSelected))
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
                if (this.Closed != null)
                {
                    hashCode = (hashCode * 59) + this.Closed.GetHashCode();
                }
                if (this.SubmissionsClosed != null)
                {
                    hashCode = (hashCode * 59) + this.SubmissionsClosed.GetHashCode();
                }
                if (this.SubmissionsOpened != null)
                {
                    hashCode = (hashCode * 59) + this.SubmissionsOpened.GetHashCode();
                }
                if (this.WinnersSelected != null)
                {
                    hashCode = (hashCode * 59) + this.WinnersSelected.GetHashCode();
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
