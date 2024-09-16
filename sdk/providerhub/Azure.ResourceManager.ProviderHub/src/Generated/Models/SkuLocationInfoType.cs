// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The SkuLocationInfoType. </summary>
    public readonly partial struct SkuLocationInfoType : IEquatable<SkuLocationInfoType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SkuLocationInfoType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SkuLocationInfoType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotSpecifiedValue = "NotSpecified";
        private const string EdgeZoneValue = "EdgeZone";
        private const string ArcZoneValue = "ArcZone";

        /// <summary> NotSpecified. </summary>
        public static SkuLocationInfoType NotSpecified { get; } = new SkuLocationInfoType(NotSpecifiedValue);
        /// <summary> EdgeZone. </summary>
        public static SkuLocationInfoType EdgeZone { get; } = new SkuLocationInfoType(EdgeZoneValue);
        /// <summary> ArcZone. </summary>
        public static SkuLocationInfoType ArcZone { get; } = new SkuLocationInfoType(ArcZoneValue);
        /// <summary> Determines if two <see cref="SkuLocationInfoType"/> values are the same. </summary>
        public static bool operator ==(SkuLocationInfoType left, SkuLocationInfoType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SkuLocationInfoType"/> values are not the same. </summary>
        public static bool operator !=(SkuLocationInfoType left, SkuLocationInfoType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SkuLocationInfoType"/>. </summary>
        public static implicit operator SkuLocationInfoType(string value) => new SkuLocationInfoType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SkuLocationInfoType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SkuLocationInfoType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
