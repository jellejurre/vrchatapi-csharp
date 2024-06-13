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
    /// * \&quot;online\&quot; User is online in VRChat * \&quot;active\&quot; User is online, but not in VRChat * \&quot;offline\&quot; User is offline  Always offline when returned through &#x60;getCurrentUser&#x60; (/auth/user).
    /// </summary>
    /// <value>* \&quot;online\&quot; User is online in VRChat * \&quot;active\&quot; User is online, but not in VRChat * \&quot;offline\&quot; User is offline  Always offline when returned through &#x60;getCurrentUser&#x60; (/auth/user).</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserState
    {
        /// <summary>
        /// Enum Offline for value: offline
        /// </summary>
        [EnumMember(Value = "offline")]
        Offline = 1,

        /// <summary>
        /// Enum Active for value: active
        /// </summary>
        [EnumMember(Value = "active")]
        Active = 2,

        /// <summary>
        /// Enum Online for value: online
        /// </summary>
        [EnumMember(Value = "online")]
        Online = 3

    }

}
