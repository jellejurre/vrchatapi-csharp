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
    /// Population brackets based on instance population
    /// </summary>
    [DataContract(Name = "APIConfigConstants_INSTANCE_POPULATION_BRACKETS")]
    public partial class APIConfigConstantsINSTANCEPOPULATIONBRACKETS : IEquatable<APIConfigConstantsINSTANCEPOPULATIONBRACKETS>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIConfigConstantsINSTANCEPOPULATIONBRACKETS" /> class.
        /// </summary>
        /// <param name="cROWDED">cROWDED.</param>
        /// <param name="fEW">fEW.</param>
        /// <param name="mANY">mANY.</param>
        public APIConfigConstantsINSTANCEPOPULATIONBRACKETS(APIConfigConstantsINSTANCEPOPULATIONBRACKETSCROWDED cROWDED = default(APIConfigConstantsINSTANCEPOPULATIONBRACKETSCROWDED), APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW fEW = default(APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW), APIConfigConstantsINSTANCEPOPULATIONBRACKETSMANY mANY = default(APIConfigConstantsINSTANCEPOPULATIONBRACKETSMANY))
        {
            this.CROWDED = cROWDED;
            this.FEW = fEW;
            this.MANY = mANY;
        }

        /// <summary>
        /// Gets or Sets CROWDED
        /// </summary>
        [DataMember(Name = "CROWDED", EmitDefaultValue = false)]
        public APIConfigConstantsINSTANCEPOPULATIONBRACKETSCROWDED CROWDED { get; set; }

        /// <summary>
        /// Gets or Sets FEW
        /// </summary>
        [DataMember(Name = "FEW", EmitDefaultValue = false)]
        public APIConfigConstantsINSTANCEPOPULATIONBRACKETSFEW FEW { get; set; }

        /// <summary>
        /// Gets or Sets MANY
        /// </summary>
        [DataMember(Name = "MANY", EmitDefaultValue = false)]
        public APIConfigConstantsINSTANCEPOPULATIONBRACKETSMANY MANY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class APIConfigConstantsINSTANCEPOPULATIONBRACKETS {\n");
            sb.Append("  CROWDED: ").Append(CROWDED).Append("\n");
            sb.Append("  FEW: ").Append(FEW).Append("\n");
            sb.Append("  MANY: ").Append(MANY).Append("\n");
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
            return this.Equals(input as APIConfigConstantsINSTANCEPOPULATIONBRACKETS);
        }

        /// <summary>
        /// Returns true if APIConfigConstantsINSTANCEPOPULATIONBRACKETS instances are equal
        /// </summary>
        /// <param name="input">Instance of APIConfigConstantsINSTANCEPOPULATIONBRACKETS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIConfigConstantsINSTANCEPOPULATIONBRACKETS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CROWDED == input.CROWDED ||
                    (this.CROWDED != null &&
                    this.CROWDED.Equals(input.CROWDED))
                ) && 
                (
                    this.FEW == input.FEW ||
                    (this.FEW != null &&
                    this.FEW.Equals(input.FEW))
                ) && 
                (
                    this.MANY == input.MANY ||
                    (this.MANY != null &&
                    this.MANY.Equals(input.MANY))
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
                if (this.CROWDED != null)
                {
                    hashCode = (hashCode * 59) + this.CROWDED.GetHashCode();
                }
                if (this.FEW != null)
                {
                    hashCode = (hashCode * 59) + this.FEW.GetHashCode();
                }
                if (this.MANY != null)
                {
                    hashCode = (hashCode * 59) + this.MANY.GetHashCode();
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
