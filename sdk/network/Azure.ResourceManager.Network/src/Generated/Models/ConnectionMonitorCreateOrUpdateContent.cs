// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the operation to create a connection monitor. </summary>
    public partial class ConnectionMonitorCreateOrUpdateContent
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

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorCreateOrUpdateContent"/>. </summary>
        public ConnectionMonitorCreateOrUpdateContent()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Endpoints = new ChangeTrackingList<ConnectionMonitorEndpoint>();
            TestConfigurations = new ChangeTrackingList<ConnectionMonitorTestConfiguration>();
            TestGroups = new ChangeTrackingList<ConnectionMonitorTestGroup>();
            Outputs = new ChangeTrackingList<ConnectionMonitorOutput>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectionMonitorCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> Connection monitor location. </param>
        /// <param name="tags"> Connection monitor tags. </param>
        /// <param name="source"> Describes the source of connection monitor. </param>
        /// <param name="destination"> Describes the destination of connection monitor. </param>
        /// <param name="autoStart"> Determines if the connection monitor will start automatically once created. </param>
        /// <param name="monitoringIntervalInSeconds"> Monitoring interval in seconds. </param>
        /// <param name="endpoints"> List of connection monitor endpoints. </param>
        /// <param name="testConfigurations"> List of connection monitor test configurations. </param>
        /// <param name="testGroups"> List of connection monitor test groups. </param>
        /// <param name="outputs"> List of connection monitor outputs. </param>
        /// <param name="notes"> Optional notes to be associated with the connection monitor. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectionMonitorCreateOrUpdateContent(AzureLocation? location, IDictionary<string, string> tags, ConnectionMonitorSource source, ConnectionMonitorDestination destination, bool? autoStart, int? monitoringIntervalInSeconds, IList<ConnectionMonitorEndpoint> endpoints, IList<ConnectionMonitorTestConfiguration> testConfigurations, IList<ConnectionMonitorTestGroup> testGroups, IList<ConnectionMonitorOutput> outputs, string notes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            Tags = tags;
            Source = source;
            Destination = destination;
            AutoStart = autoStart;
            MonitoringIntervalInSeconds = monitoringIntervalInSeconds;
            Endpoints = endpoints;
            TestConfigurations = testConfigurations;
            TestGroups = testGroups;
            Outputs = outputs;
            Notes = notes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Connection monitor location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Connection monitor tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Describes the source of connection monitor. </summary>
        public ConnectionMonitorSource Source { get; set; }
        /// <summary> Describes the destination of connection monitor. </summary>
        public ConnectionMonitorDestination Destination { get; set; }
        /// <summary> Determines if the connection monitor will start automatically once created. </summary>
        public bool? AutoStart { get; set; }
        /// <summary> Monitoring interval in seconds. </summary>
        public int? MonitoringIntervalInSeconds { get; set; }
        /// <summary> List of connection monitor endpoints. </summary>
        public IList<ConnectionMonitorEndpoint> Endpoints { get; }
        /// <summary> List of connection monitor test configurations. </summary>
        public IList<ConnectionMonitorTestConfiguration> TestConfigurations { get; }
        /// <summary> List of connection monitor test groups. </summary>
        public IList<ConnectionMonitorTestGroup> TestGroups { get; }
        /// <summary> List of connection monitor outputs. </summary>
        public IList<ConnectionMonitorOutput> Outputs { get; }
        /// <summary> Optional notes to be associated with the connection monitor. </summary>
        public string Notes { get; set; }
    }
}
