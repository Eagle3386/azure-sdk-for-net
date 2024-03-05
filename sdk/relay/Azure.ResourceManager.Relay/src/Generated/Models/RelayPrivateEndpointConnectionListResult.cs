// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Relay;

namespace Azure.ResourceManager.Relay.Models
{
    /// <summary> Result of the list of all private endpoint connections operation. </summary>
    internal partial class RelayPrivateEndpointConnectionListResult
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

        /// <summary> Initializes a new instance of <see cref="RelayPrivateEndpointConnectionListResult"/>. </summary>
        internal RelayPrivateEndpointConnectionListResult()
        {
            Value = new ChangeTrackingList<RelayPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of <see cref="RelayPrivateEndpointConnectionListResult"/>. </summary>
        /// <param name="value"> A collection of private endpoint connection resources. </param>
        /// <param name="nextLink"> A link for the next page of private endpoint connection resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RelayPrivateEndpointConnectionListResult(IReadOnlyList<RelayPrivateEndpointConnectionData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A collection of private endpoint connection resources. </summary>
        public IReadOnlyList<RelayPrivateEndpointConnectionData> Value { get; }
        /// <summary> A link for the next page of private endpoint connection resources. </summary>
        public string NextLink { get; }
    }
}
