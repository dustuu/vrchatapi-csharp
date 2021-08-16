/*
 * VRChat API Documentation
 *
 * ![VRChat API Banner](https://vrchatapi.github.io/assets/img/api_banner_1500x400.png)  # VRChat API Documentation This project is an [OPEN Open Source Project](https://openopensource.org)  Individuals making significant and valuable contributions are given commit-access to the project to contribute as they see fit. This project is more like an open wiki than a standard guarded open source project.  ## Disclaimer  This is the official response of the VRChat Team (from Tupper more specifically) on the usage of the VRChat API.  > **Use of the API using applications other than the approved methods (website, VRChat application) are not officially supported. You may use the API for your own application, but keep these guidelines in mind:** > * We do not provide documentation or support for the API. > * Do not make queries to the API more than once per 60 seconds. > * Abuse of the API may result in account termination. > * Access to API endpoints may break at any given time, with no warning.  As stated, this documentation was not created with the help of the official VRChat team. Therefore this documentation is not an official documentation of the VRChat API and may not be always up to date with the latest versions. If you find that a page or endpoint is not longer valid please create an issue and tell us so we can fix it.  ## Get in touch with us!  [https://discord.gg/qjZE9C9fkB#vrchat-api](https://discord.gg/qjZE9C9fkB)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
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