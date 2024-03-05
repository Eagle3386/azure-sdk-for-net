// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> Defines the KPI Threshold limits. </summary>
    public partial class KpiDefinition
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="KpiDefinition"/>. </summary>
        /// <param name="entityType"> The mapping entity type. </param>
        /// <param name="entityTypeName"> The mapping entity name. </param>
        /// <param name="calculationWindow"> The calculation window. </param>
        /// <param name="function"> The computation function for the KPI. </param>
        /// <param name="expression"> The computation expression for the KPI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="entityTypeName"/> or <paramref name="expression"/> is null. </exception>
        internal KpiDefinition(EntityType entityType, string entityTypeName, CalculationWindowType calculationWindow, KpiFunction function, string expression)
        {
            if (entityTypeName == null)
            {
                throw new ArgumentNullException(nameof(entityTypeName));
            }
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }

            EntityType = entityType;
            EntityTypeName = entityTypeName;
            DisplayName = new ChangeTrackingDictionary<string, string>();
            Description = new ChangeTrackingDictionary<string, string>();
            CalculationWindow = calculationWindow;
            Function = function;
            Expression = expression;
            GroupBy = new ChangeTrackingList<string>();
            GroupByMetadata = new ChangeTrackingList<KpiGroupByMetadata>();
            ParticipantProfilesMetadata = new ChangeTrackingList<KpiParticipantProfilesMetadata>();
            Aliases = new ChangeTrackingList<KpiAlias>();
            Extracts = new ChangeTrackingList<KpiExtract>();
        }

        /// <summary> Initializes a new instance of <see cref="KpiDefinition"/>. </summary>
        /// <param name="entityType"> The mapping entity type. </param>
        /// <param name="entityTypeName"> The mapping entity name. </param>
        /// <param name="tenantId"> The hub name. </param>
        /// <param name="kpiName"> The KPI name. </param>
        /// <param name="displayName"> Localized display name for the KPI. </param>
        /// <param name="description"> Localized description for the KPI. </param>
        /// <param name="calculationWindow"> The calculation window. </param>
        /// <param name="calculationWindowFieldName"> Name of calculation window field. </param>
        /// <param name="function"> The computation function for the KPI. </param>
        /// <param name="expression"> The computation expression for the KPI. </param>
        /// <param name="unit"> The unit of measurement for the KPI. </param>
        /// <param name="filter"> The filter expression for the KPI. </param>
        /// <param name="groupBy"> the group by properties for the KPI. </param>
        /// <param name="groupByMetadata"> The KPI GroupByMetadata. </param>
        /// <param name="participantProfilesMetadata"> The participant profiles. </param>
        /// <param name="provisioningState"> Provisioning state. </param>
        /// <param name="thresHolds"> The KPI thresholds. </param>
        /// <param name="aliases"> The aliases. </param>
        /// <param name="extracts"> The KPI extracts. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiDefinition(EntityType entityType, string entityTypeName, Guid? tenantId, string kpiName, IReadOnlyDictionary<string, string> displayName, IReadOnlyDictionary<string, string> description, CalculationWindowType calculationWindow, string calculationWindowFieldName, KpiFunction function, string expression, string unit, string filter, IReadOnlyList<string> groupBy, IReadOnlyList<KpiGroupByMetadata> groupByMetadata, IReadOnlyList<KpiParticipantProfilesMetadata> participantProfilesMetadata, ProvisioningState? provisioningState, KpiThresholds thresHolds, IReadOnlyList<KpiAlias> aliases, IReadOnlyList<KpiExtract> extracts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EntityType = entityType;
            EntityTypeName = entityTypeName;
            TenantId = tenantId;
            KpiName = kpiName;
            DisplayName = displayName;
            Description = description;
            CalculationWindow = calculationWindow;
            CalculationWindowFieldName = calculationWindowFieldName;
            Function = function;
            Expression = expression;
            Unit = unit;
            Filter = filter;
            GroupBy = groupBy;
            GroupByMetadata = groupByMetadata;
            ParticipantProfilesMetadata = participantProfilesMetadata;
            ProvisioningState = provisioningState;
            ThresHolds = thresHolds;
            Aliases = aliases;
            Extracts = extracts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KpiDefinition"/> for deserialization. </summary>
        internal KpiDefinition()
        {
        }

        /// <summary> The mapping entity type. </summary>
        public EntityType EntityType { get; }
        /// <summary> The mapping entity name. </summary>
        public string EntityTypeName { get; }
        /// <summary> The hub name. </summary>
        public Guid? TenantId { get; }
        /// <summary> The KPI name. </summary>
        public string KpiName { get; }
        /// <summary> Localized display name for the KPI. </summary>
        public IReadOnlyDictionary<string, string> DisplayName { get; }
        /// <summary> Localized description for the KPI. </summary>
        public IReadOnlyDictionary<string, string> Description { get; }
        /// <summary> The calculation window. </summary>
        public CalculationWindowType CalculationWindow { get; }
        /// <summary> Name of calculation window field. </summary>
        public string CalculationWindowFieldName { get; }
        /// <summary> The computation function for the KPI. </summary>
        public KpiFunction Function { get; }
        /// <summary> The computation expression for the KPI. </summary>
        public string Expression { get; }
        /// <summary> The unit of measurement for the KPI. </summary>
        public string Unit { get; }
        /// <summary> The filter expression for the KPI. </summary>
        public string Filter { get; }
        /// <summary> the group by properties for the KPI. </summary>
        public IReadOnlyList<string> GroupBy { get; }
        /// <summary> The KPI GroupByMetadata. </summary>
        public IReadOnlyList<KpiGroupByMetadata> GroupByMetadata { get; }
        /// <summary> The participant profiles. </summary>
        public IReadOnlyList<KpiParticipantProfilesMetadata> ParticipantProfilesMetadata { get; }
        /// <summary> Provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The KPI thresholds. </summary>
        public KpiThresholds ThresHolds { get; }
        /// <summary> The aliases. </summary>
        public IReadOnlyList<KpiAlias> Aliases { get; }
        /// <summary> The KPI extracts. </summary>
        public IReadOnlyList<KpiExtract> Extracts { get; }
    }
}
