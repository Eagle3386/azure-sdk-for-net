// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Dns.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary>
    /// A class representing the DnsZone data model.
    /// Describes a DNS zone.
    /// </summary>
    public partial class DnsZoneData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DnsZoneData"/>. </summary>
        /// <param name="location"> The location. </param>
        public DnsZoneData(AzureLocation location) : base(location)
        {
            NameServers = new ChangeTrackingList<string>();
            RegistrationVirtualNetworks = new ChangeTrackingList<WritableSubResource>();
            ResolutionVirtualNetworks = new ChangeTrackingList<WritableSubResource>();
            SigningKeys = new ChangeTrackingList<DnsSigningKey>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsZoneData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> The etag of the zone. </param>
        /// <param name="maxNumberOfRecords"> The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="maxNumberOfRecordsPerRecord"> The maximum number of records per record set that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="numberOfRecords"> The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="nameServers"> The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="zoneType"> The type of this DNS zone (Public or Private). </param>
        /// <param name="registrationVirtualNetworks"> A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private. </param>
        /// <param name="resolutionVirtualNetworks"> A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private. </param>
        /// <param name="signingKeys"> The list of signing keys. </param>
        internal DnsZoneData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, long? maxNumberOfRecords, long? maxNumberOfRecordsPerRecord, long? numberOfRecords, IReadOnlyList<string> nameServers, DnsZoneType? zoneType, IList<WritableSubResource> registrationVirtualNetworks, IList<WritableSubResource> resolutionVirtualNetworks, IReadOnlyList<DnsSigningKey> signingKeys) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            MaxNumberOfRecords = maxNumberOfRecords;
            MaxNumberOfRecordsPerRecord = maxNumberOfRecordsPerRecord;
            NumberOfRecords = numberOfRecords;
            NameServers = nameServers;
            ZoneType = zoneType;
            RegistrationVirtualNetworks = registrationVirtualNetworks;
            ResolutionVirtualNetworks = resolutionVirtualNetworks;
            SigningKeys = signingKeys;
        }

        /// <summary> The etag of the zone. </summary>
        public ETag? ETag { get; set; }
        /// <summary> The maximum number of record sets that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfRecords { get; }
        /// <summary> The maximum number of records per record set that can be created in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? MaxNumberOfRecordsPerRecord { get; }
        /// <summary> The current number of record sets in this DNS zone.  This is a read-only property and any attempt to set this value will be ignored. </summary>
        public long? NumberOfRecords { get; }
        /// <summary> The name servers for this DNS zone. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public IReadOnlyList<string> NameServers { get; }
        /// <summary> The type of this DNS zone (Public or Private). </summary>
        public DnsZoneType? ZoneType { get; set; }
        /// <summary> A list of references to virtual networks that register hostnames in this DNS zone. This is a only when ZoneType is Private. </summary>
        public IList<WritableSubResource> RegistrationVirtualNetworks { get; }
        /// <summary> A list of references to virtual networks that resolve records in this DNS zone. This is a only when ZoneType is Private. </summary>
        public IList<WritableSubResource> ResolutionVirtualNetworks { get; }
        /// <summary> The list of signing keys. </summary>
        public IReadOnlyList<DnsSigningKey> SigningKeys { get; }
    }
}
