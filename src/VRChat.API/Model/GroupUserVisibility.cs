/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.11.1
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
    /// Defines GroupUserVisibility
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupUserVisibility
    {
        /// <summary>
        /// Enum Visible for value: visible
        /// </summary>
        [EnumMember(Value = "visible")]
        Visible = 1,

        /// <summary>
        /// Enum Hidden for value: hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 2,

        /// <summary>
        /// Enum Friends for value: friends
        /// </summary>
        [EnumMember(Value = "friends")]
        Friends = 3

    }

}