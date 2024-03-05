// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> SSIS properties for managed integration runtime. </summary>
    public partial class IntegrationRuntimeSsisProperties
    {
        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeSsisProperties"/>. </summary>
        public IntegrationRuntimeSsisProperties()
        {
            ExpressCustomSetupProperties = new ChangeTrackingList<CustomSetupBase>();
            PackageStores = new ChangeTrackingList<DataFactoryPackageStore>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeSsisProperties"/>. </summary>
        /// <param name="catalogInfo"> Catalog information for managed dedicated integration runtime. </param>
        /// <param name="licenseType"> License type for bringing your own license scenario. </param>
        /// <param name="customSetupScriptProperties"> Custom setup script properties for a managed dedicated integration runtime. </param>
        /// <param name="dataProxyProperties"> Data proxy properties for a managed dedicated integration runtime. </param>
        /// <param name="edition"> The edition for the SSIS Integration Runtime. </param>
        /// <param name="expressCustomSetupProperties">
        /// Custom setup without script properties for a SSIS integration runtime.
        /// Please note <see cref="CustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzPowerShellSetup"/>, <see cref="CmdkeySetup"/>, <see cref="ComponentSetup"/> and <see cref="EnvironmentVariableSetup"/>.
        /// </param>
        /// <param name="packageStores"> Package stores for the SSIS Integration Runtime. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeSsisProperties(IntegrationRuntimeSsisCatalogInfo catalogInfo, IntegrationRuntimeLicenseType? licenseType, IntegrationRuntimeCustomSetupScriptProperties customSetupScriptProperties, IntegrationRuntimeDataProxyProperties dataProxyProperties, IntegrationRuntimeEdition? edition, IList<CustomSetupBase> expressCustomSetupProperties, IList<DataFactoryPackageStore> packageStores, DataFactoryCredentialReference credential, IDictionary<string, BinaryData> additionalProperties)
        {
            CatalogInfo = catalogInfo;
            LicenseType = licenseType;
            CustomSetupScriptProperties = customSetupScriptProperties;
            DataProxyProperties = dataProxyProperties;
            Edition = edition;
            ExpressCustomSetupProperties = expressCustomSetupProperties;
            PackageStores = packageStores;
            Credential = credential;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Catalog information for managed dedicated integration runtime. </summary>
        public IntegrationRuntimeSsisCatalogInfo CatalogInfo { get; set; }
        /// <summary> License type for bringing your own license scenario. </summary>
        public IntegrationRuntimeLicenseType? LicenseType { get; set; }
        /// <summary> Custom setup script properties for a managed dedicated integration runtime. </summary>
        public IntegrationRuntimeCustomSetupScriptProperties CustomSetupScriptProperties { get; set; }
        /// <summary> Data proxy properties for a managed dedicated integration runtime. </summary>
        public IntegrationRuntimeDataProxyProperties DataProxyProperties { get; set; }
        /// <summary> The edition for the SSIS Integration Runtime. </summary>
        public IntegrationRuntimeEdition? Edition { get; set; }
        /// <summary>
        /// Custom setup without script properties for a SSIS integration runtime.
        /// Please note <see cref="CustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzPowerShellSetup"/>, <see cref="CmdkeySetup"/>, <see cref="ComponentSetup"/> and <see cref="EnvironmentVariableSetup"/>.
        /// </summary>
        public IList<CustomSetupBase> ExpressCustomSetupProperties { get; }
        /// <summary> Package stores for the SSIS Integration Runtime. </summary>
        public IList<DataFactoryPackageStore> PackageStores { get; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
