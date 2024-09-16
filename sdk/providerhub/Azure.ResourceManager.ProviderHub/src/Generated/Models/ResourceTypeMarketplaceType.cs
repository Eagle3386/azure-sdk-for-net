// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeMarketplaceType. </summary>
    public readonly partial struct ResourceTypeMarketplaceType : IEquatable<ResourceTypeMarketplaceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeMarketplaceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceTypeMarketplaceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string AddOnValue = "AddOn";
        private const string BypassValue = "Bypass";
        private const string StoreValue = "Store";

        /// <summary> NotSpecified. </summary>
        public static ResourceTypeMarketplaceType NotSpecified { get; } = new ResourceTypeMarketplaceType(NotSpecifiedValue);
        /// <summary> AddOn. </summary>
        public static ResourceTypeMarketplaceType AddOn { get; } = new ResourceTypeMarketplaceType(AddOnValue);
        /// <summary> Bypass. </summary>
        public static ResourceTypeMarketplaceType Bypass { get; } = new ResourceTypeMarketplaceType(BypassValue);
        /// <summary> Store. </summary>
        public static ResourceTypeMarketplaceType Store { get; } = new ResourceTypeMarketplaceType(StoreValue);
        /// <summary> Determines if two <see cref="ResourceTypeMarketplaceType"/> values are the same. </summary>
        public static bool operator ==(ResourceTypeMarketplaceType left, ResourceTypeMarketplaceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceTypeMarketplaceType"/> values are not the same. </summary>
        public static bool operator !=(ResourceTypeMarketplaceType left, ResourceTypeMarketplaceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceTypeMarketplaceType"/>. </summary>
        public static implicit operator ResourceTypeMarketplaceType(string value) => new ResourceTypeMarketplaceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceTypeMarketplaceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceTypeMarketplaceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
