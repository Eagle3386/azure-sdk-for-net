// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The container settings for a Task.
    /// </summary>
    public partial class TaskContainerSettings
    {
        /// <summary>
        /// Initializes a new instance of the TaskContainerSettings class.
        /// </summary>
        public TaskContainerSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskContainerSettings class.
        /// </summary>
        /// <param name="imageName">The Image to use to create the container in
        /// which the Task will run.</param>
        /// <param name="containerRunOptions">Additional options to the
        /// container create command.</param>
        /// <param name="registry">The private registry which contains the
        /// container Image.</param>
        /// <param name="workingDirectory">The location of the container Task
        /// working directory.</param>
        /// <param name="containerHostBatchBindMounts">The paths you want to
        /// mounted to container task.</param>
        public TaskContainerSettings(string imageName, string containerRunOptions = default(string), ContainerRegistry registry = default(ContainerRegistry), ContainerWorkingDirectory? workingDirectory = default(ContainerWorkingDirectory?), IList<ContainerHostBatchBindMountEntry> containerHostBatchBindMounts = default(IList<ContainerHostBatchBindMountEntry>))
        {
            ContainerRunOptions = containerRunOptions;
            ImageName = imageName;
            Registry = registry;
            WorkingDirectory = workingDirectory;
            ContainerHostBatchBindMounts = containerHostBatchBindMounts;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets additional options to the container create command.
        /// </summary>
        /// <remarks>
        /// These additional options are supplied as arguments to the "docker
        /// create" command, in addition to those controlled by the Batch
        /// Service.
        /// </remarks>
        [JsonProperty(PropertyName = "containerRunOptions")]
        public string ContainerRunOptions { get; set; }

        /// <summary>
        /// Gets or sets the Image to use to create the container in which the
        /// Task will run.
        /// </summary>
        /// <remarks>
        /// This is the full Image reference, as would be specified to "docker
        /// pull". If no tag is provided as part of the Image name, the tag
        /// ":latest" is used as a default.
        /// </remarks>
        [JsonProperty(PropertyName = "imageName")]
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the private registry which contains the container
        /// Image.
        /// </summary>
        /// <remarks>
        /// This setting can be omitted if was already provided at Pool
        /// creation.
        /// </remarks>
        [JsonProperty(PropertyName = "registry")]
        public ContainerRegistry Registry { get; set; }

        /// <summary>
        /// Gets or sets the location of the container Task working directory.
        /// </summary>
        /// <remarks>
        /// The default is 'taskWorkingDirectory'. Possible values include:
        /// 'taskWorkingDirectory', 'containerImageDefault'
        /// </remarks>
        [JsonProperty(PropertyName = "workingDirectory")]
        public ContainerWorkingDirectory? WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets the paths you want to mounted to container task.
        /// </summary>
        /// <remarks>
        /// If this array is null or be not present, container task will mount
        /// entire temporary disk drive in windows (or AZ_BATCH_NODE_ROOT_DIR
        /// in Linux). It won't' mount any data paths into container if this
        /// array is set as empty.
        /// </remarks>
        [JsonProperty(PropertyName = "containerHostBatchBindMounts")]
        public IList<ContainerHostBatchBindMountEntry> ContainerHostBatchBindMounts { get; set; }

    }
}
