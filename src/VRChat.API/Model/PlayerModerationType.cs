/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.7.1
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
    /// Defines PlayerModerationType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlayerModerationType
    {
        /// <summary>
        /// Enum Mute for value: mute
        /// </summary>
        [EnumMember(Value = "mute")]
        Mute = 1,

        /// <summary>
        /// Enum Unmute for value: unmute
        /// </summary>
        [EnumMember(Value = "unmute")]
        Unmute = 2,

        /// <summary>
        /// Enum Block for value: block
        /// </summary>
        [EnumMember(Value = "block")]
        Block = 3,

        /// <summary>
        /// Enum Unblock for value: unblock
        /// </summary>
        [EnumMember(Value = "unblock")]
        Unblock = 4,

        /// <summary>
        /// Enum HideAvatar for value: hideAvatar
        /// </summary>
        [EnumMember(Value = "hideAvatar")]
        HideAvatar = 5,

        /// <summary>
        /// Enum ShowAvatar for value: showAvatar
        /// </summary>
        [EnumMember(Value = "showAvatar")]
        ShowAvatar = 6,

        /// <summary>
        /// Enum InteractOn for value: interactOn
        /// </summary>
        [EnumMember(Value = "interactOn")]
        InteractOn = 7,

        /// <summary>
        /// Enum InteractOff for value: interactOff
        /// </summary>
        [EnumMember(Value = "interactOff")]
        InteractOff = 8

    }

}
