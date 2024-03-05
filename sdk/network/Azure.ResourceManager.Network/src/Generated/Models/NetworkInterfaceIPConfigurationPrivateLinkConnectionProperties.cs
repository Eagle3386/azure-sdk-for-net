// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> PrivateLinkConnection properties for the network interface. </summary>
    public partial class NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties
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

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties"/>. </summary>
        internal NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties()
        {
            Fqdns = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties"/>. </summary>
        /// <param name="groupId"> The group ID for current private link connection. </param>
        /// <param name="requiredMemberName"> The required member name for current private link connection. </param>
        /// <param name="fqdns"> List of FQDNs for current private link connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(string groupId, string requiredMemberName, IReadOnlyList<string> fqdns, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupId = groupId;
            RequiredMemberName = requiredMemberName;
            Fqdns = fqdns;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The group ID for current private link connection. </summary>
        public string GroupId { get; }
        /// <summary> The required member name for current private link connection. </summary>
        public string RequiredMemberName { get; }
        /// <summary> List of FQDNs for current private link connection. </summary>
        public IReadOnlyList<string> Fqdns { get; }
    }
}
