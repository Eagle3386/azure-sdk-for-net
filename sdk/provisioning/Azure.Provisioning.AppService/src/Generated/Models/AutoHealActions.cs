// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Actions which to take by the auto-heal module when a rule is triggered.
/// </summary>
public partial class AutoHealActions : ProvisioningConstruct
{
    /// <summary>
    /// Predefined action to be taken.
    /// </summary>
    public BicepValue<AutoHealActionType> ActionType { get => _actionType; set => _actionType.Assign(value); }
    private readonly BicepValue<AutoHealActionType> _actionType;

    /// <summary>
    /// Custom action to be taken.
    /// </summary>
    public BicepValue<AutoHealCustomAction> CustomAction { get => _customAction; set => _customAction.Assign(value); }
    private readonly BicepValue<AutoHealCustomAction> _customAction;

    /// <summary>
    /// Minimum time the process must execute             before taking the
    /// action
    /// </summary>
    public BicepValue<string> MinProcessExecutionTime { get => _minProcessExecutionTime; set => _minProcessExecutionTime.Assign(value); }
    private readonly BicepValue<string> _minProcessExecutionTime;

    /// <summary>
    /// Creates a new AutoHealActions.
    /// </summary>
    public AutoHealActions()
    {
        _actionType = BicepValue<AutoHealActionType>.DefineProperty(this, "ActionType", ["actionType"]);
        _customAction = BicepValue<AutoHealCustomAction>.DefineProperty(this, "CustomAction", ["customAction"]);
        _minProcessExecutionTime = BicepValue<string>.DefineProperty(this, "MinProcessExecutionTime", ["minProcessExecutionTime"]);
    }
}
