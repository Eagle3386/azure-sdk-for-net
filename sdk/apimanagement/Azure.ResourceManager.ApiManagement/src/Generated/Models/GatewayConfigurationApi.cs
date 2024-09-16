// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Information regarding the Configuration API of the API Management gateway. This is only applicable for API gateway with Standard SKU. </summary>
    internal partial class GatewayConfigurationApi
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GatewayConfigurationApi"/>. </summary>
        public GatewayConfigurationApi()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GatewayConfigurationApi"/>. </summary>
        /// <param name="hostname"> Hostname to which the agent connects to propagate configuration to the cloud. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GatewayConfigurationApi(string hostname, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hostname = hostname;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hostname to which the agent connects to propagate configuration to the cloud. </summary>
        [WirePath("hostname")]
        public string Hostname { get; }
    }
}
