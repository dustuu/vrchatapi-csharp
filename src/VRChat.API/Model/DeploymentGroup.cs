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
    /// Used to identify which API deployment cluster is currently responding.  &#x60;blue&#x60; and &#x60;green&#x60; are used by Production. &#x60;grape&#x60;and &#x60;cherry&#x60; are used during Development.  [Blue Green Deployment by Martin Fowler](https://martinfowler.com/bliki/BlueGreenDeployment.html)
    /// </summary>
    /// <value>Used to identify which API deployment cluster is currently responding.  &#x60;blue&#x60; and &#x60;green&#x60; are used by Production. &#x60;grape&#x60;and &#x60;cherry&#x60; are used during Development.  [Blue Green Deployment by Martin Fowler](https://martinfowler.com/bliki/BlueGreenDeployment.html)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentGroup
    {
        /// <summary>
        /// Enum Blue for value: blue
        /// </summary>
        [EnumMember(Value = "blue")]
        Blue = 1,

        /// <summary>
        /// Enum Green for value: green
        /// </summary>
        [EnumMember(Value = "green")]
        Green = 2,

        /// <summary>
        /// Enum Grape for value: grape
        /// </summary>
        [EnumMember(Value = "grape")]
        Grape = 3,

        /// <summary>
        /// Enum Cherry for value: cherry
        /// </summary>
        [EnumMember(Value = "cherry")]
        Cherry = 4

    }

}
