// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing the TargetType data model.
    /// Model that represents a Target Type resource.
    /// </summary>
    public partial class TargetTypeData : ResourceData
    {
        /// <summary> Initializes a new instance of TargetTypeData. </summary>
        public TargetTypeData()
        {
            ResourceTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TargetTypeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Location of the Target Type resource. </param>
        /// <param name="displayName"> Localized string of the display name. </param>
        /// <param name="description"> Localized string of the description. </param>
        /// <param name="propertiesSchema"> URL to retrieve JSON schema of the Target Type properties. </param>
        /// <param name="resourceTypes"> List of resource types this Target Type can extend. </param>
        internal TargetTypeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string displayName, string description, string propertiesSchema, IReadOnlyList<string> resourceTypes) : base(id, name, resourceType, systemData)
        {
            Location = location;
            DisplayName = displayName;
            Description = description;
            PropertiesSchema = propertiesSchema;
            ResourceTypes = resourceTypes;
        }

        /// <summary> Location of the Target Type resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Localized string of the display name. </summary>
        public string DisplayName { get; }
        /// <summary> Localized string of the description. </summary>
        public string Description { get; }
        /// <summary> URL to retrieve JSON schema of the Target Type properties. </summary>
        public string PropertiesSchema { get; }
        /// <summary> List of resource types this Target Type can extend. </summary>
        public IReadOnlyList<string> ResourceTypes { get; }
    }
}
