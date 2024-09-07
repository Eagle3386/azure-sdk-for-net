// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Egress endpoints which AKS agent nodes connect to for common purpose. </summary>
    public partial class ContainerServiceOutboundEnvironmentEndpoint
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOutboundEnvironmentEndpoint"/>. </summary>
        internal ContainerServiceOutboundEnvironmentEndpoint()
        {
            Endpoints = new ChangeTrackingList<ContainerServiceEndpointDependency>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceOutboundEnvironmentEndpoint"/>. </summary>
        /// <param name="category"> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </param>
        /// <param name="endpoints"> The endpoints that AKS agent nodes connect to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceOutboundEnvironmentEndpoint(string category, IReadOnlyList<ContainerServiceEndpointDependency> endpoints, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Category = category;
            Endpoints = endpoints;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The category of endpoints accessed by the AKS agent node, e.g. azure-resource-management, apiserver, etc. </summary>
        [WirePath("category")]
        public string Category { get; }
        /// <summary> The endpoints that AKS agent nodes connect to. </summary>
        [WirePath("endpoints")]
        public IReadOnlyList<ContainerServiceEndpointDependency> Endpoints { get; }
    }
}
