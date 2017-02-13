// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the dsc node type.
    /// </summary>
    public partial class DscNode : ResourceBase
    {
        private Guid _accountId;
        
        /// <summary>
        /// Optional. Gets or sets the account id of the node.
        /// </summary>
        public Guid AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        
        private string _ip;
        
        /// <summary>
        /// Optional. Gets or sets the ip of the node.
        /// </summary>
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }
        
        private DateTimeOffset _lastSeen;
        
        /// <summary>
        /// Optional. Gets or sets the last seen time of the node.
        /// </summary>
        public DateTimeOffset LastSeen
        {
            get { return this._lastSeen; }
            set { this._lastSeen = value; }
        }
        
        private DscNodeConfigurationAssociationProperty _nodeConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets the configuration of the node.
        /// </summary>
        public DscNodeConfigurationAssociationProperty NodeConfiguration
        {
            get { return this._nodeConfiguration; }
            set { this._nodeConfiguration = value; }
        }
        
        private DateTimeOffset _registrationTime;
        
        /// <summary>
        /// Optional. Gets or sets the registration time of the node.
        /// </summary>
        public DateTimeOffset RegistrationTime
        {
            get { return this._registrationTime; }
            set { this._registrationTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Gets or sets the status of the node.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscNode class.
        /// </summary>
        public DscNode()
        {
        }
    }
}
