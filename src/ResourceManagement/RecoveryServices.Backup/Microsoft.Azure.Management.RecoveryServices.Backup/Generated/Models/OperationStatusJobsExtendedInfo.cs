// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Operation status extended info for list of jobs.
    /// </summary>
    public partial class OperationStatusJobsExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the OperationStatusJobsExtendedInfo
        /// class.
        /// </summary>
        public OperationStatusJobsExtendedInfo() { }

        /// <summary>
        /// Initializes a new instance of the OperationStatusJobsExtendedInfo
        /// class.
        /// </summary>
        /// <param name="jobIds">IDs of the jobs created for the protected
        /// item.</param>
        /// <param name="failedJobsError">Stores all the failed jobs along
        /// with the corresponding error codes.</param>
        public OperationStatusJobsExtendedInfo(System.Collections.Generic.IList<string> jobIds = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IDictionary<string, string> failedJobsError = default(System.Collections.Generic.IDictionary<string, string>))
        {
            JobIds = jobIds;
            FailedJobsError = failedJobsError;
        }

        /// <summary>
        /// Gets or sets iDs of the jobs created for the protected item.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobIds")]
        public System.Collections.Generic.IList<string> JobIds { get; set; }

        /// <summary>
        /// Gets or sets stores all the failed jobs along with the
        /// corresponding error codes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "failedJobsError")]
        public System.Collections.Generic.IDictionary<string, string> FailedJobsError { get; set; }

    }
}
