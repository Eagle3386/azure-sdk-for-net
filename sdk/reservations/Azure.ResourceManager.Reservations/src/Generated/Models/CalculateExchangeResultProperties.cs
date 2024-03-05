// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> CalculateExchange response properties. </summary>
    public partial class CalculateExchangeResultProperties
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

        /// <summary> Initializes a new instance of <see cref="CalculateExchangeResultProperties"/>. </summary>
        internal CalculateExchangeResultProperties()
        {
            ReservationsToPurchase = new ChangeTrackingList<ReservationToPurchaseCalculateExchange>();
            SavingsPlansToPurchase = new ChangeTrackingList<SavingsPlanToPurchaseCalculateExchange>();
            ReservationsToExchange = new ChangeTrackingList<ReservationToExchange>();
        }

        /// <summary> Initializes a new instance of <see cref="CalculateExchangeResultProperties"/>. </summary>
        /// <param name="sessionId"> Exchange session identifier. </param>
        /// <param name="netPayable"> Pricing information containing the amount and the currency code. </param>
        /// <param name="refundsTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="purchasesTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="reservationsToPurchase"> Details of the reservations being purchased. </param>
        /// <param name="savingsPlansToPurchase"> Details of the savings plans being purchased. </param>
        /// <param name="reservationsToExchange"> Details of the reservations being returned. </param>
        /// <param name="policyResult"> Exchange policy errors. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CalculateExchangeResultProperties(Guid? sessionId, PurchasePrice netPayable, PurchasePrice refundsTotal, PurchasePrice purchasesTotal, IReadOnlyList<ReservationToPurchaseCalculateExchange> reservationsToPurchase, IReadOnlyList<SavingsPlanToPurchaseCalculateExchange> savingsPlansToPurchase, IReadOnlyList<ReservationToExchange> reservationsToExchange, ExchangePolicyErrors policyResult, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SessionId = sessionId;
            NetPayable = netPayable;
            RefundsTotal = refundsTotal;
            PurchasesTotal = purchasesTotal;
            ReservationsToPurchase = reservationsToPurchase;
            SavingsPlansToPurchase = savingsPlansToPurchase;
            ReservationsToExchange = reservationsToExchange;
            PolicyResult = policyResult;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Exchange session identifier. </summary>
        public Guid? SessionId { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice NetPayable { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice RefundsTotal { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice PurchasesTotal { get; }
        /// <summary> Details of the reservations being purchased. </summary>
        public IReadOnlyList<ReservationToPurchaseCalculateExchange> ReservationsToPurchase { get; }
        /// <summary> Details of the savings plans being purchased. </summary>
        public IReadOnlyList<SavingsPlanToPurchaseCalculateExchange> SavingsPlansToPurchase { get; }
        /// <summary> Details of the reservations being returned. </summary>
        public IReadOnlyList<ReservationToExchange> ReservationsToExchange { get; }
        /// <summary> Exchange policy errors. </summary>
        internal ExchangePolicyErrors PolicyResult { get; }
        /// <summary> Exchange Policy errors. </summary>
        public IReadOnlyList<ExchangePolicyError> PolicyErrors
        {
            get => PolicyResult?.PolicyErrors;
        }
    }
}
