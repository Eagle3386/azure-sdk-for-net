// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Definition of Prometheus metrics forwarding configuration. </summary>
    public partial class PrometheusForwarderDataSource
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

        /// <summary> Initializes a new instance of <see cref="PrometheusForwarderDataSource"/>. </summary>
        public PrometheusForwarderDataSource()
        {
            Streams = new ChangeTrackingList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream>();
            LabelIncludeFilter = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="PrometheusForwarderDataSource"/>. </summary>
        /// <param name="streams"> List of streams that this data source will be sent to. </param>
        /// <param name="labelIncludeFilter">
        /// The list of label inclusion filters in the form of label "name-value" pairs.
        /// Currently only one label is supported: 'microsoft_metrics_include_label'.
        /// Label values are matched case-insensitively.
        /// </param>
        /// <param name="name">
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrometheusForwarderDataSource(IList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> streams, IDictionary<string, string> labelIncludeFilter, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Streams = streams;
            LabelIncludeFilter = labelIncludeFilter;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of streams that this data source will be sent to. </summary>
        public IList<DataCollectionRuleKnownPrometheusForwarderDataSourceStream> Streams { get; }
        /// <summary>
        /// The list of label inclusion filters in the form of label "name-value" pairs.
        /// Currently only one label is supported: 'microsoft_metrics_include_label'.
        /// Label values are matched case-insensitively.
        /// </summary>
        public IDictionary<string, string> LabelIncludeFilter { get; }
        /// <summary>
        /// A friendly name for the data source.
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
