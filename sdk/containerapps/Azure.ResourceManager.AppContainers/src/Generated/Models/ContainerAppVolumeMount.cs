// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Volume mount for the Container App. </summary>
    public partial class ContainerAppVolumeMount
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolumeMount"/>. </summary>
        public ContainerAppVolumeMount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppVolumeMount"/>. </summary>
        /// <param name="volumeName"> This must match the Name of a Volume. </param>
        /// <param name="mountPath"> Path within the container at which the volume should be mounted.Must not contain ':'. </param>
        /// <param name="subPath"> Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppVolumeMount(string volumeName, string mountPath, string subPath, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VolumeName = volumeName;
            MountPath = mountPath;
            SubPath = subPath;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> This must match the Name of a Volume. </summary>
        [WirePath("volumeName")]
        public string VolumeName { get; set; }
        /// <summary> Path within the container at which the volume should be mounted.Must not contain ':'. </summary>
        [WirePath("mountPath")]
        public string MountPath { get; set; }
        /// <summary> Path within the volume from which the container's volume should be mounted. Defaults to "" (volume's root). </summary>
        [WirePath("subPath")]
        public string SubPath { get; set; }
    }
}
