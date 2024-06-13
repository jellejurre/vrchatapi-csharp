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
    /// PaginatedGroupAuditLogEntryList
    /// </summary>
    [DataContract(Name = "PaginatedGroupAuditLogEntryList")]
    public partial class PaginatedGroupAuditLogEntryList : IEquatable<PaginatedGroupAuditLogEntryList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedGroupAuditLogEntryList" /> class.
        /// </summary>
        /// <param name="results"> .</param>
        /// <param name="totalCount">The total number of results that the query would return if there were no pagination..</param>
        /// <param name="hasNext">Whether there are more results after this page..</param>
        public PaginatedGroupAuditLogEntryList(List<GroupAuditLogEntry> results = default(List<GroupAuditLogEntry>), int totalCount = default(int), bool hasNext = default(bool))
        {
            this.Results = results;
            this.TotalCount = totalCount;
            this.HasNext = hasNext;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <value> </value>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<GroupAuditLogEntry> Results { get; set; }

        /// <summary>
        /// The total number of results that the query would return if there were no pagination.
        /// </summary>
        /// <value>The total number of results that the query would return if there were no pagination.</value>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Whether there are more results after this page.
        /// </summary>
        /// <value>Whether there are more results after this page.</value>
        [DataMember(Name = "hasNext", EmitDefaultValue = true)]
        public bool HasNext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginatedGroupAuditLogEntryList {\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  HasNext: ").Append(HasNext).Append("\n");
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
            return this.Equals(input as PaginatedGroupAuditLogEntryList);
        }

        /// <summary>
        /// Returns true if PaginatedGroupAuditLogEntryList instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginatedGroupAuditLogEntryList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedGroupAuditLogEntryList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.HasNext == input.HasNext ||
                    this.HasNext.Equals(input.HasNext)
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
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                hashCode = (hashCode * 59) + this.HasNext.GetHashCode();
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
