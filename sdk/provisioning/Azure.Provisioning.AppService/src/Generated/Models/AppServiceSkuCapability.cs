// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Describes the capabilities/features allowed for a specific SKU.
/// </summary>
public partial class AppServiceSkuCapability : ProvisioningConstruct
{
    /// <summary>
    /// Name of the SKU capability.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Value of the SKU capability.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// Reason of the SKU capability.
    /// </summary>
    public BicepValue<string> Reason { get => _reason; set => _reason.Assign(value); }
    private readonly BicepValue<string> _reason;

    /// <summary>
    /// Creates a new AppServiceSkuCapability.
    /// </summary>
    public AppServiceSkuCapability()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["value"]);
        _reason = BicepValue<string>.DefineProperty(this, "Reason", ["reason"]);
    }
}
