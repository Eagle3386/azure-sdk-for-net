// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The instance view of a virtual machine run command. </summary>
    public partial class VirtualMachineRunCommandInstanceView
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandInstanceView"/>. </summary>
        internal VirtualMachineRunCommandInstanceView()
        {
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineRunCommandInstanceView"/>. </summary>
        /// <param name="executionState"> Script execution status. </param>
        /// <param name="executionMessage"> Communicate script configuration errors or execution messages. </param>
        /// <param name="exitCode"> Exit code returned from script execution. </param>
        /// <param name="output"> Script output stream. </param>
        /// <param name="error"> Script error stream. </param>
        /// <param name="startOn"> Script start time. </param>
        /// <param name="endOn"> Script end time. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineRunCommandInstanceView(ExecutionState? executionState, string executionMessage, int? exitCode, string output, string error, DateTimeOffset? startOn, DateTimeOffset? endOn, IReadOnlyList<InstanceViewStatus> statuses, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ExecutionState = executionState;
            ExecutionMessage = executionMessage;
            ExitCode = exitCode;
            Output = output;
            Error = error;
            StartOn = startOn;
            EndOn = endOn;
            Statuses = statuses;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Script execution status. </summary>
        public ExecutionState? ExecutionState { get; }
        /// <summary> Communicate script configuration errors or execution messages. </summary>
        public string ExecutionMessage { get; }
        /// <summary> Exit code returned from script execution. </summary>
        public int? ExitCode { get; }
        /// <summary> Script output stream. </summary>
        public string Output { get; }
        /// <summary> Script error stream. </summary>
        public string Error { get; }
        /// <summary> Script start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Script end time. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
