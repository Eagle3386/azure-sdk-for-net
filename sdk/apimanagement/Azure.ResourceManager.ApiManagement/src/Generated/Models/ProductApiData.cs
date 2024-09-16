// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> The ProductApiData. </summary>
    public partial class ProductApiData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ProductApiData"/>. </summary>
        public ProductApiData()
        {
            Protocols = new ChangeTrackingList<ApiOperationInvokableProtocol>();
        }

        /// <summary> Initializes a new instance of <see cref="ProductApiData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the API. May include HTML formatting tags. </param>
        /// <param name="authenticationSettings"> Collection of authentication settings included into this API. </param>
        /// <param name="subscriptionKeyParameterNames"> Protocols over which API is made available. </param>
        /// <param name="apiType"> Type of API. </param>
        /// <param name="apiRevision"> Describes the revision of the API. If no value is provided, default revision 1 is created. </param>
        /// <param name="apiVersion"> Indicates the version identifier of the API if the API is versioned. </param>
        /// <param name="isCurrent"> Indicates if API revision is current api revision. </param>
        /// <param name="isOnline"> Indicates if API revision is accessible via the gateway. </param>
        /// <param name="apiRevisionDescription"> Description of the API Revision. </param>
        /// <param name="apiVersionDescription"> Description of the API Version. </param>
        /// <param name="apiVersionSetId"> A resource identifier for the related ApiVersionSet. </param>
        /// <param name="isSubscriptionRequired"> Specifies whether an API or Product subscription is required for accessing the API. </param>
        /// <param name="termsOfServiceLink"> A URL to the Terms of Service for the API. MUST be in the format of a URL. </param>
        /// <param name="contact"> Contact information for the API. </param>
        /// <param name="license"> License information for the API. </param>
        /// <param name="sourceApiId"> API identifier of the source API. </param>
        /// <param name="displayName"> API name. Must be 1 to 300 characters long. </param>
        /// <param name="serviceLink"> Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long. </param>
        /// <param name="path"> Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API. </param>
        /// <param name="protocols"> Describes on which protocols the operations in this API can be invoked. </param>
        /// <param name="apiVersionSet"> Version set details. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProductApiData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, AuthenticationSettingsContract authenticationSettings, SubscriptionKeyParameterNamesContract subscriptionKeyParameterNames, ApiType? apiType, string apiRevision, string apiVersion, bool? isCurrent, bool? isOnline, string apiRevisionDescription, string apiVersionDescription, ResourceIdentifier apiVersionSetId, bool? isSubscriptionRequired, string termsOfServiceLink, ApiContactInformation contact, ApiLicenseInformation license, ResourceIdentifier sourceApiId, string displayName, string serviceLink, string path, IList<ApiOperationInvokableProtocol> protocols, ApiVersionSetContractDetails apiVersionSet, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            AuthenticationSettings = authenticationSettings;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            ApiType = apiType;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            ApiRevisionDescription = apiRevisionDescription;
            ApiVersionDescription = apiVersionDescription;
            ApiVersionSetId = apiVersionSetId;
            IsSubscriptionRequired = isSubscriptionRequired;
            TermsOfServiceLink = termsOfServiceLink;
            Contact = contact;
            License = license;
            SourceApiId = sourceApiId;
            DisplayName = displayName;
            ServiceLink = serviceLink;
            Path = path;
            Protocols = protocols;
            ApiVersionSet = apiVersionSet;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Description of the API. May include HTML formatting tags. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Collection of authentication settings included into this API. </summary>
        [WirePath("properties.authenticationSettings")]
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }
        /// <summary> Protocols over which API is made available. </summary>
        [WirePath("properties.subscriptionKeyParameterNames")]
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }
        /// <summary> Type of API. </summary>
        [WirePath("properties.type")]
        public ApiType? ApiType { get; set; }
        /// <summary> Describes the revision of the API. If no value is provided, default revision 1 is created. </summary>
        [WirePath("properties.apiRevision")]
        public string ApiRevision { get; set; }
        /// <summary> Indicates the version identifier of the API if the API is versioned. </summary>
        [WirePath("properties.apiVersion")]
        public string ApiVersion { get; set; }
        /// <summary> Indicates if API revision is current api revision. </summary>
        [WirePath("properties.isCurrent")]
        public bool? IsCurrent { get; set; }
        /// <summary> Indicates if API revision is accessible via the gateway. </summary>
        [WirePath("properties.isOnline")]
        public bool? IsOnline { get; }
        /// <summary> Description of the API Revision. </summary>
        [WirePath("properties.apiRevisionDescription")]
        public string ApiRevisionDescription { get; set; }
        /// <summary> Description of the API Version. </summary>
        [WirePath("properties.apiVersionDescription")]
        public string ApiVersionDescription { get; set; }
        /// <summary> A resource identifier for the related ApiVersionSet. </summary>
        [WirePath("properties.apiVersionSetId")]
        public ResourceIdentifier ApiVersionSetId { get; set; }
        /// <summary> Specifies whether an API or Product subscription is required for accessing the API. </summary>
        [WirePath("properties.subscriptionRequired")]
        public bool? IsSubscriptionRequired { get; set; }
        /// <summary> A URL to the Terms of Service for the API. MUST be in the format of a URL. </summary>
        [WirePath("properties.termsOfServiceUrl")]
        public string TermsOfServiceLink { get; set; }
        /// <summary> Contact information for the API. </summary>
        [WirePath("properties.contact")]
        public ApiContactInformation Contact { get; set; }
        /// <summary> License information for the API. </summary>
        [WirePath("properties.license")]
        public ApiLicenseInformation License { get; set; }
        /// <summary> API identifier of the source API. </summary>
        [WirePath("properties.sourceApiId")]
        public ResourceIdentifier SourceApiId { get; set; }
        /// <summary> API name. Must be 1 to 300 characters long. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long. </summary>
        [WirePath("properties.serviceUrl")]
        public string ServiceLink { get; set; }
        /// <summary> Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API. </summary>
        [WirePath("properties.path")]
        public string Path { get; set; }
        /// <summary> Describes on which protocols the operations in this API can be invoked. </summary>
        [WirePath("properties.protocols")]
        public IList<ApiOperationInvokableProtocol> Protocols { get; }
        /// <summary> Version set details. </summary>
        [WirePath("properties.apiVersionSet")]
        public ApiVersionSetContractDetails ApiVersionSet { get; set; }
        /// <summary> The provisioning state. </summary>
        [WirePath("properties.provisioningState")]
        public string ProvisioningState { get; }
    }
}
