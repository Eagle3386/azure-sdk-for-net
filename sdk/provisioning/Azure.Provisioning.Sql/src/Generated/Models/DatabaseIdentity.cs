// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Azure Active Directory identity configuration for a resource.
/// </summary>
public partial class DatabaseIdentity : ProvisioningConstruct
{
    /// <summary>
    /// The identity type.
    /// </summary>
    public BicepValue<DatabaseIdentityType> IdentityType { get => _identityType; set => _identityType.Assign(value); }
    private readonly BicepValue<DatabaseIdentityType> _identityType;

    /// <summary>
    /// The Azure Active Directory tenant id.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// The resource ids of the user assigned identities to use.
    /// </summary>
    public BicepDictionary<UserAssignedIdentityDetails> UserAssignedIdentities { get => _userAssignedIdentities; set => _userAssignedIdentities.Assign(value); }
    private readonly BicepDictionary<UserAssignedIdentityDetails> _userAssignedIdentities;

    /// <summary>
    /// Creates a new DatabaseIdentity.
    /// </summary>
    public DatabaseIdentity()
    {
        _identityType = BicepValue<DatabaseIdentityType>.DefineProperty(this, "IdentityType", ["type"]);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"], isOutput: true);
        _userAssignedIdentities = BicepDictionary<UserAssignedIdentityDetails>.DefineProperty(this, "UserAssignedIdentities", ["userAssignedIdentities"]);
    }
}
