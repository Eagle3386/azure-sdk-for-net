// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> The refund details of a transaction. </summary>
    public partial class RefundTransactionDetails
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

        /// <summary> Initializes a new instance of <see cref="RefundTransactionDetails"/>. </summary>
        public RefundTransactionDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RefundTransactionDetails"/>. </summary>
        /// <param name="amountRequested"> The amount of refund requested. </param>
        /// <param name="amountRefunded"> The amount refunded. </param>
        /// <param name="refundOperationId"> The ID of refund operation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RefundTransactionDetails(BillingAmount amountRequested, BillingAmount amountRefunded, string refundOperationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AmountRequested = amountRequested;
            AmountRefunded = amountRefunded;
            RefundOperationId = refundOperationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The amount of refund requested. </summary>
        [WirePath("amountRequested")]
        public BillingAmount AmountRequested { get; }
        /// <summary> The amount refunded. </summary>
        [WirePath("amountRefunded")]
        public BillingAmount AmountRefunded { get; }
        /// <summary> The ID of refund operation. </summary>
        [WirePath("refundOperationId")]
        public string RefundOperationId { get; set; }
    }
}
