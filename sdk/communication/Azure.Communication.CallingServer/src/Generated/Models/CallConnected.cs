// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The CallConnectedEvent. </summary>
    public partial class CallConnected
    {
        /// <summary> Initializes a new instance of CallConnected. </summary>
        internal CallConnected()
        {
        }

        /// <summary> Initializes a new instance of CallConnected. </summary>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal CallConnected(AcsEventType eventType, string callConnectionId, string serverCallId, string correlationId)
        {
            EventType = eventType;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }
    }
}
