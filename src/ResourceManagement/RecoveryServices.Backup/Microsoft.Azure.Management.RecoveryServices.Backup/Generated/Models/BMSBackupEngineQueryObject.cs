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
    /// Query parameters to fetch list of backup engines.
    /// </summary>
    public partial class BMSBackupEngineQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the BMSBackupEngineQueryObject class.
        /// </summary>
        public BMSBackupEngineQueryObject() { }

        /// <summary>
        /// Initializes a new instance of the BMSBackupEngineQueryObject class.
        /// </summary>
        /// <param name="backupManagementType">Backup management type for the
        /// backup engine. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        public BMSBackupEngineQueryObject(BackupManagementType? backupManagementType = default(BackupManagementType?))
        {
            BackupManagementType = backupManagementType;
        }

        /// <summary>
        /// Gets or sets backup management type for the backup engine.
        /// Possible values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

    }
}
