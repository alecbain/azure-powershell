// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies the security posture to be used in the scale set. Minimum
    /// api-version: 2023-03-01
    /// </summary>
    public partial class SecurityPostureReference
    {
        /// <summary>
        /// Initializes a new instance of the SecurityPostureReference class.
        /// </summary>
        public SecurityPostureReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityPostureReference class.
        /// </summary>
        /// <param name="id">The security posture reference id in the form of
        /// /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|latest</param>
        /// <param name="excludeExtensions">The list of virtual machine
        /// extension names to exclude when applying the security
        /// posture.</param>
        /// <param name="isOverridable">Whether the security posture can be
        /// overridden by the user.</param>
        public SecurityPostureReference(string id, IList<string> excludeExtensions = default(IList<string>), bool? isOverridable = default(bool?))
        {
            Id = id;
            ExcludeExtensions = excludeExtensions;
            IsOverridable = isOverridable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the security posture reference id in the form of
        /// /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|latest
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual machine extension names to exclude
        /// when applying the security posture.
        /// </summary>
        [JsonProperty(PropertyName = "excludeExtensions")]
        public IList<string> ExcludeExtensions { get; set; }

        /// <summary>
        /// Gets or sets whether the security posture can be overridden by the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "isOverridable")]
        public bool? IsOverridable { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
