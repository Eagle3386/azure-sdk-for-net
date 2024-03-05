// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Marketplace;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Request approvals details. </summary>
    public partial class RequestApprovalsDetails
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

        /// <summary> Initializes a new instance of <see cref="RequestApprovalsDetails"/>. </summary>
        internal RequestApprovalsDetails()
        {
            Plans = new ChangeTrackingList<PlanNotificationDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="RequestApprovalsDetails"/>. </summary>
        /// <param name="offerId"> Gets offer id. </param>
        /// <param name="displayName"> Gets offer display name. </param>
        /// <param name="publisherId"> Gets or sets publisher id. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="iconUri"> Gets or sets the icon url. </param>
        /// <param name="plans"> Gets or sets removed plans notifications. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RequestApprovalsDetails(string offerId, string displayName, string publisherId, long? messageCode, Uri iconUri, IReadOnlyList<PlanNotificationDetails> plans, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferId = offerId;
            DisplayName = displayName;
            PublisherId = publisherId;
            MessageCode = messageCode;
            IconUri = iconUri;
            Plans = plans;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets offer id. </summary>
        public string OfferId { get; }
        /// <summary> Gets offer display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets publisher id. </summary>
        public string PublisherId { get; }
        /// <summary> Gets or sets the notification message id. </summary>
        public long? MessageCode { get; }
        /// <summary> Gets or sets the icon url. </summary>
        public Uri IconUri { get; }
        /// <summary> Gets or sets removed plans notifications. </summary>
        public IReadOnlyList<PlanNotificationDetails> Plans { get; }
    }
}
