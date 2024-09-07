// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The TransactionType. </summary>
    public readonly partial struct TransactionType : IEquatable<TransactionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TransactionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TransactionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string BilledValue = "Billed";
        private const string UnbilledValue = "Unbilled";

        /// <summary> Other. </summary>
        public static TransactionType Other { get; } = new TransactionType(OtherValue);
        /// <summary> Billed. </summary>
        public static TransactionType Billed { get; } = new TransactionType(BilledValue);
        /// <summary> Unbilled. </summary>
        public static TransactionType Unbilled { get; } = new TransactionType(UnbilledValue);
        /// <summary> Determines if two <see cref="TransactionType"/> values are the same. </summary>
        public static bool operator ==(TransactionType left, TransactionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransactionType"/> values are not the same. </summary>
        public static bool operator !=(TransactionType left, TransactionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransactionType"/>. </summary>
        public static implicit operator TransactionType(string value) => new TransactionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TransactionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TransactionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
