// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Cognitive Services account ModelDeprecationInfo.
/// </summary>
public partial class ServiceAccountModelDeprecationInfo : ProvisioningConstruct
{
    /// <summary>
    /// The datetime of deprecation of the fineTune Model.
    /// </summary>
    public BicepValue<DateTimeOffset> FineTuneOn { get => _fineTuneOn; set => _fineTuneOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _fineTuneOn;

    /// <summary>
    /// The datetime of deprecation of the inference Model.
    /// </summary>
    public BicepValue<DateTimeOffset> InferenceOn { get => _inferenceOn; set => _inferenceOn.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _inferenceOn;

    /// <summary>
    /// Creates a new ServiceAccountModelDeprecationInfo.
    /// </summary>
    public ServiceAccountModelDeprecationInfo()
    {
        _fineTuneOn = BicepValue<DateTimeOffset>.DefineProperty(this, "FineTuneOn", ["fineTune"]);
        _inferenceOn = BicepValue<DateTimeOffset>.DefineProperty(this, "InferenceOn", ["inference"]);
    }
}
