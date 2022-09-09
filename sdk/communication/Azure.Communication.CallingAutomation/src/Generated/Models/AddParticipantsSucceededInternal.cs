// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The AddParticipantsSucceededEvent. </summary>
    internal partial class AddParticipantsSucceededInternal
    {
        /// <summary> Initializes a new instance of AddParticipantsSucceededInternal. </summary>
        internal AddParticipantsSucceededInternal()
        {
            Participants = new ChangeTrackingList<CommunicationIdentifierModel>();
        }

        /// <summary> Initializes a new instance of AddParticipantsSucceededInternal. </summary>
        /// <param name="operationContext"> Operation context. </param>
        /// <param name="resultInfo"></param>
        /// <param name="participants"> Participants added. </param>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal AddParticipantsSucceededInternal(string operationContext, ResultInformation resultInfo, IReadOnlyList<CommunicationIdentifierModel> participants, AcsEventType eventType, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInfo = resultInfo;
            Participants = participants;
            EventType = eventType;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> Operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result info. </summary>
        public ResultInformation ResultInfo { get; }
        /// <summary> Participants added. </summary>
        public IReadOnlyList<CommunicationIdentifierModel> Participants { get; }
        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
