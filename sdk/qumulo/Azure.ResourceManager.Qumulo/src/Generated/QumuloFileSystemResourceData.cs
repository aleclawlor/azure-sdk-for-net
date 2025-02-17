// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Qumulo.Models;

namespace Azure.ResourceManager.Qumulo
{
    /// <summary>
    /// A class representing the QumuloFileSystemResource data model.
    /// A FileSystem Resource by Qumulo
    /// </summary>
    public partial class QumuloFileSystemResourceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of QumuloFileSystemResourceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="marketplaceDetails"> Marketplace details. </param>
        /// <param name="storageSku"> Storage Sku. </param>
        /// <param name="userDetails"> User Details. </param>
        /// <param name="delegatedSubnetId"> Delegated subnet id for Vnet injection. </param>
        /// <param name="adminPassword"> Initial administrator password of the resource. </param>
        /// <param name="initialCapacity"> Storage capacity in TB. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="marketplaceDetails"/>, <paramref name="userDetails"/>, <paramref name="delegatedSubnetId"/> or <paramref name="adminPassword"/> is null. </exception>
        public QumuloFileSystemResourceData(AzureLocation location, MarketplaceDetails marketplaceDetails, StorageSku storageSku, QumuloUserDetails userDetails, string delegatedSubnetId, string adminPassword, int initialCapacity) : base(location)
        {
            Argument.AssertNotNull(marketplaceDetails, nameof(marketplaceDetails));
            Argument.AssertNotNull(userDetails, nameof(userDetails));
            Argument.AssertNotNull(delegatedSubnetId, nameof(delegatedSubnetId));
            Argument.AssertNotNull(adminPassword, nameof(adminPassword));

            MarketplaceDetails = marketplaceDetails;
            StorageSku = storageSku;
            UserDetails = userDetails;
            DelegatedSubnetId = delegatedSubnetId;
            PrivateIPs = new ChangeTrackingList<string>();
            AdminPassword = adminPassword;
            InitialCapacity = initialCapacity;
        }

        /// <summary> Initializes a new instance of QumuloFileSystemResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="marketplaceDetails"> Marketplace details. </param>
        /// <param name="provisioningState"> Provisioning State of the resource. </param>
        /// <param name="storageSku"> Storage Sku. </param>
        /// <param name="userDetails"> User Details. </param>
        /// <param name="delegatedSubnetId"> Delegated subnet id for Vnet injection. </param>
        /// <param name="clusterLoginUri"> File system Id of the resource. </param>
        /// <param name="privateIPs"> Private IPs of the resource. </param>
        /// <param name="adminPassword"> Initial administrator password of the resource. </param>
        /// <param name="initialCapacity"> Storage capacity in TB. </param>
        /// <param name="availabilityZone"> Availability zone. </param>
        internal QumuloFileSystemResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, MarketplaceDetails marketplaceDetails, QumuloProvisioningState? provisioningState, StorageSku storageSku, QumuloUserDetails userDetails, string delegatedSubnetId, Uri clusterLoginUri, IList<string> privateIPs, string adminPassword, int initialCapacity, string availabilityZone) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            MarketplaceDetails = marketplaceDetails;
            ProvisioningState = provisioningState;
            StorageSku = storageSku;
            UserDetails = userDetails;
            DelegatedSubnetId = delegatedSubnetId;
            ClusterLoginUri = clusterLoginUri;
            PrivateIPs = privateIPs;
            AdminPassword = adminPassword;
            InitialCapacity = initialCapacity;
            AvailabilityZone = availabilityZone;
        }

        /// <summary> The managed service identities assigned to this resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Marketplace details. </summary>
        public MarketplaceDetails MarketplaceDetails { get; set; }
        /// <summary> Provisioning State of the resource. </summary>
        public QumuloProvisioningState? ProvisioningState { get; }
        /// <summary> Storage Sku. </summary>
        public StorageSku StorageSku { get; set; }
        /// <summary> User Details. </summary>
        internal QumuloUserDetails UserDetails { get; set; }
        /// <summary> User Email. </summary>
        public string UserDetailsEmail
        {
            get => UserDetails is null ? default : UserDetails.Email;
            set => UserDetails = new QumuloUserDetails(value);
        }

        /// <summary> Delegated subnet id for Vnet injection. </summary>
        public string DelegatedSubnetId { get; set; }
        /// <summary> File system Id of the resource. </summary>
        public Uri ClusterLoginUri { get; set; }
        /// <summary> Private IPs of the resource. </summary>
        public IList<string> PrivateIPs { get; }
        /// <summary> Initial administrator password of the resource. </summary>
        public string AdminPassword { get; set; }
        /// <summary> Storage capacity in TB. </summary>
        public int InitialCapacity { get; set; }
        /// <summary> Availability zone. </summary>
        public string AvailabilityZone { get; set; }
    }
}
