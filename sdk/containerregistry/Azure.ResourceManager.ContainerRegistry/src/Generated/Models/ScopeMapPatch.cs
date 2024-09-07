// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties for updating the scope map. </summary>
    public partial class ScopeMapPatch
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

        /// <summary> Initializes a new instance of <see cref="ScopeMapPatch"/>. </summary>
        public ScopeMapPatch()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ScopeMapPatch"/>. </summary>
        /// <param name="description"> The user friendly description of the scope map. </param>
        /// <param name="actions">
        /// The list of scope permissions for registry artifacts.
        /// E.g. repositories/repository-name/pull,
        /// repositories/repository-name/delete
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScopeMapPatch(string description, IList<string> actions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Description = description;
            Actions = actions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user friendly description of the scope map. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary>
        /// The list of scope permissions for registry artifacts.
        /// E.g. repositories/repository-name/pull,
        /// repositories/repository-name/delete
        /// </summary>
        [WirePath("properties.actions")]
        public IList<string> Actions { get; }
    }
}
