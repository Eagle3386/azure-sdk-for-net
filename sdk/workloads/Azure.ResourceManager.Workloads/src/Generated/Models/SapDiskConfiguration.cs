// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The SAP Disk Configuration contains 'recommended disk' details and list of supported disks detail for a volume type. </summary>
    public partial class SapDiskConfiguration
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

        /// <summary> Initializes a new instance of <see cref="SapDiskConfiguration"/>. </summary>
        internal SapDiskConfiguration()
        {
            SupportedConfigurations = new ChangeTrackingList<SupportedConfigurationsDiskDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SapDiskConfiguration"/>. </summary>
        /// <param name="recommendedConfiguration"> The recommended disk details for a given VM Sku. </param>
        /// <param name="supportedConfigurations"> The list of supported disks for a given VM Sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapDiskConfiguration(DiskVolumeConfiguration recommendedConfiguration, IReadOnlyList<SupportedConfigurationsDiskDetails> supportedConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RecommendedConfiguration = recommendedConfiguration;
            SupportedConfigurations = supportedConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The recommended disk details for a given VM Sku. </summary>
        public DiskVolumeConfiguration RecommendedConfiguration { get; }
        /// <summary> The list of supported disks for a given VM Sku. </summary>
        public IReadOnlyList<SupportedConfigurationsDiskDetails> SupportedConfigurations { get; }
    }
}
