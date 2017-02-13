// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of job schedule parameters.
    /// </summary>
    public partial class JobScheduleProperties
    {
        private Guid _id;
        
        /// <summary>
        /// Optional. Gets or sets the id of job schedule.
        /// </summary>
        public Guid Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private IDictionary<string, string> _parameters;
        
        /// <summary>
        /// Optional. Gets or sets the parameters of the job schedule.
        /// </summary>
        public IDictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }
        
        private RunbookAssociationProperty _runbook;
        
        /// <summary>
        /// Optional. Gets or sets the runbook.
        /// </summary>
        public RunbookAssociationProperty Runbook
        {
            get { return this._runbook; }
            set { this._runbook = value; }
        }
        
        private ScheduleAssociationProperty _schedule;
        
        /// <summary>
        /// Optional. Gets or sets the schedule.
        /// </summary>
        public ScheduleAssociationProperty Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobScheduleProperties class.
        /// </summary>
        public JobScheduleProperties()
        {
            this.Parameters = new LazyDictionary<string, string>();
        }
    }
}
