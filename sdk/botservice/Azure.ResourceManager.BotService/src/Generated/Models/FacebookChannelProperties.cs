// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the Facebook channel. </summary>
    public partial class FacebookChannelProperties
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

        /// <summary> Initializes a new instance of <see cref="FacebookChannelProperties"/>. </summary>
        /// <param name="appId"> Facebook application id. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appId"/> is null. </exception>
        public FacebookChannelProperties(string appId, bool isEnabled)
        {
            if (appId == null)
            {
                throw new ArgumentNullException(nameof(appId));
            }

            Pages = new ChangeTrackingList<FacebookPage>();
            AppId = appId;
            IsEnabled = isEnabled;
        }

        /// <summary> Initializes a new instance of <see cref="FacebookChannelProperties"/>. </summary>
        /// <param name="verifyToken"> Verify token. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="pages"> The list of Facebook pages. </param>
        /// <param name="appId"> Facebook application id. </param>
        /// <param name="appSecret"> Facebook application secret. Value only returned through POST to the action Channel List API, otherwise empty. </param>
        /// <param name="callbackUri"> Callback Url. </param>
        /// <param name="isEnabled"> Whether this channel is enabled for the bot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FacebookChannelProperties(string verifyToken, IList<FacebookPage> pages, string appId, string appSecret, Uri callbackUri, bool isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VerifyToken = verifyToken;
            Pages = pages;
            AppId = appId;
            AppSecret = appSecret;
            CallbackUri = callbackUri;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FacebookChannelProperties"/> for deserialization. </summary>
        internal FacebookChannelProperties()
        {
        }

        /// <summary> Verify token. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string VerifyToken { get; }
        /// <summary> The list of Facebook pages. </summary>
        public IList<FacebookPage> Pages { get; }
        /// <summary> Facebook application id. </summary>
        public string AppId { get; set; }
        /// <summary> Facebook application secret. Value only returned through POST to the action Channel List API, otherwise empty. </summary>
        public string AppSecret { get; set; }
        /// <summary> Callback Url. </summary>
        public Uri CallbackUri { get; }
        /// <summary> Whether this channel is enabled for the bot. </summary>
        public bool IsEnabled { get; set; }
    }
}
