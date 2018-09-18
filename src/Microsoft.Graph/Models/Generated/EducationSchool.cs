// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Education School.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationSchool : EducationOrganization
    {
    
        /// <summary>
        /// Gets or sets principal email.
        /// Email address of the principal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalEmail", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalEmail { get; set; }
    
        /// <summary>
        /// Gets or sets principal name.
        /// Name of the principal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "principalName", Required = Newtonsoft.Json.Required.Default)]
        public string PrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets external principal id.
        /// ID of principal in syncing system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalPrincipalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalPrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets lowest grade.
        /// Lowest grade taught.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lowestGrade", Required = Newtonsoft.Json.Required.Default)]
        public string LowestGrade { get; set; }
    
        /// <summary>
        /// Gets or sets highest grade.
        /// Highest grade taught.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "highestGrade", Required = Newtonsoft.Json.Required.Default)]
        public string HighestGrade { get; set; }
    
        /// <summary>
        /// Gets or sets school number.
        /// School Number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schoolNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SchoolNumber { get; set; }
    
        /// <summary>
        /// Gets or sets external id.
        /// ID of school in syncing system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalId", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalId { get; set; }
    
        /// <summary>
        /// Gets or sets phone.
        /// Phone number of school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "phone", Required = Newtonsoft.Json.Required.Default)]
        public string Phone { get; set; }
    
        /// <summary>
        /// Gets or sets fax.
        /// Fax number of school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fax", Required = Newtonsoft.Json.Required.Default)]
        public string Fax { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// Entity who created the school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdBy", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets address.
        /// Address of the school.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "address", Required = Newtonsoft.Json.Required.Default)]
        public PhysicalAddress Address { get; set; }
    
        /// <summary>
        /// Gets or sets classes.
        /// Classes taught at the school. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "classes", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSchoolClassesCollectionWithReferencesPage Classes { get; set; }
    
        /// <summary>
        /// Gets or sets users.
        /// Users in the school. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "users", Required = Newtonsoft.Json.Required.Default)]
        public IEducationSchoolUsersCollectionWithReferencesPage Users { get; set; }
    
    }
}

