// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Azure;
    using Management;
    using Cdn;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Customer provided domain for branding purposes, e.g. www.consoto.com.
    /// </summary>
    [JsonTransformation]
    public partial class CustomDomain : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        public CustomDomain() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomain class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="hostName">The host name of the custom domain. Must be
        /// a domain name.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="resourceState">Resource status of the custom domain.
        /// Possible values include: 'Creating', 'Active', 'Deleting'</param>
        /// <param name="customHttpsProvisioningState">Provisioning state of
        /// Custom Https of the custom domain. Possible values include:
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Failed'</param>
        /// <param name="validationData">Special validation or data may be
        /// required when delivering CDN to some regions due to local
        /// compliance reasons. E.g. ICP license number of a custom domain is
        /// required to deliver content in China.</param>
        /// <param name="provisioningState">Provisioning status of the custom
        /// domain.</param>
        public CustomDomain(string location, string hostName, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string resourceState = default(string), string customHttpsProvisioningState = default(string), string validationData = default(string), string provisioningState = default(string))
            : base(location, id, name, type, tags)
        {
            HostName = hostName;
            ResourceState = resourceState;
            CustomHttpsProvisioningState = customHttpsProvisioningState;
            ValidationData = validationData;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets or sets the host name of the custom domain. Must be a domain
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets resource status of the custom domain. Possible values include:
        /// 'Creating', 'Active', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; protected set; }

        /// <summary>
        /// Gets provisioning state of Custom Https of the custom domain.
        /// Possible values include: 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.customHttpsProvisioningState")]
        public string CustomHttpsProvisioningState { get; protected set; }

        /// <summary>
        /// Gets or sets special validation or data may be required when
        /// delivering CDN to some regions due to local compliance reasons.
        /// E.g. ICP license number of a custom domain is required to deliver
        /// content in China.
        /// </summary>
        [JsonProperty(PropertyName = "properties.validationData")]
        public string ValidationData { get; set; }

        /// <summary>
        /// Gets provisioning status of the custom domain.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}

