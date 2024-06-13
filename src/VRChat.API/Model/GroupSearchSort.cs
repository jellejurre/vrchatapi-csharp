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
    /// Defines GroupSearchSort
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupSearchSort
    {
        /// <summary>
        /// Enum Asc for value: joinedAt:asc
        /// </summary>
        [EnumMember(Value = "joinedAt:asc")]
        Asc = 1,

        /// <summary>
        /// Enum Desc for value: joinedAt:desc
        /// </summary>
        [EnumMember(Value = "joinedAt:desc")]
        Desc = 2

    }

}
