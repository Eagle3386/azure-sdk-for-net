// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The PlayCompleted. </summary>
    public partial class PlayCompleted
    {
        /// <summary> Initializes a new instance of PlayCompleted. </summary>
        internal PlayCompleted()
        {
        }

        /// <summary> Initializes a new instance of PlayCompleted. </summary>
        /// <param name="operationContext"> Operation context. </param>
        /// <param name="resultInfo"></param>
        /// <param name="eventType"></param>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal PlayCompleted(string operationContext, ResultInformation resultInfo, AcsEventType eventType, string callConnectionId, string serverCallId, string correlationId)
        {
            OperationContext = operationContext;
            ResultInfo = resultInfo;
            EventType = eventType;
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
        }

        /// <summary> Operation context. </summary>
        public string OperationContext { get; }
        /// <summary> Gets the result info. </summary>
        public ResultInformation ResultInfo { get; }
    }
}
