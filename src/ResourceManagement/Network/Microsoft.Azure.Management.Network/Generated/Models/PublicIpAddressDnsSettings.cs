// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Azure;
    using Management;
    using Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains FQDN of the DNS record associated with the public IP address
    /// </summary>
    public partial class PublicIPAddressDnsSettings
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddressDnsSettings class.
        /// </summary>
        public PublicIPAddressDnsSettings() { }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddressDnsSettings class.
        /// </summary>
        /// <param name="domainNameLabel">Gets or sets the Domain name
        /// label.The concatenation of the domain name label and the
        /// regionalized DNS zone make up the fully qualified domain name
        /// associated with the public IP address. If a domain name label is
        /// specified, an A DNS record is created for the public IP in the
        /// Microsoft Azure DNS system.</param>
        /// <param name="fqdn">Gets the FQDN, Fully qualified domain name of
        /// the A DNS record associated with the public IP. This is the
        /// concatenation of the domainNameLabel and the regionalized DNS
        /// zone.</param>
        /// <param name="reverseFqdn">Gets or Sets the Reverse FQDN. A
        /// user-visible, fully qualified domain name that resolves to this
        /// public IP address. If the reverseFqdn is specified, then a PTR DNS
        /// record is created pointing from the IP address in the in-addr.arpa
        /// domain to the reverse FQDN. </param>
        public PublicIPAddressDnsSettings(string domainNameLabel = default(string), string fqdn = default(string), string reverseFqdn = default(string))
        {
            DomainNameLabel = domainNameLabel;
            Fqdn = fqdn;
            ReverseFqdn = reverseFqdn;
        }

        /// <summary>
        /// Gets or sets the Domain name label.The concatenation of the domain
        /// name label and the regionalized DNS zone make up the fully
        /// qualified domain name associated with the public IP address. If a
        /// domain name label is specified, an A DNS record is created for the
        /// public IP in the Microsoft Azure DNS system.
        /// </summary>
        [JsonProperty(PropertyName = "domainNameLabel")]
        public string DomainNameLabel { get; set; }

        /// <summary>
        /// Gets the FQDN, Fully qualified domain name of the A DNS record
        /// associated with the public IP. This is the concatenation of the
        /// domainNameLabel and the regionalized DNS zone.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or Sets the Reverse FQDN. A user-visible, fully qualified
        /// domain name that resolves to this public IP address. If the
        /// reverseFqdn is specified, then a PTR DNS record is created pointing
        /// from the IP address in the in-addr.arpa domain to the reverse FQDN.
        /// </summary>
        [JsonProperty(PropertyName = "reverseFqdn")]
        public string ReverseFqdn { get; set; }

    }
}

