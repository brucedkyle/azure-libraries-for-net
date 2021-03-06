// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Edifact agreement protocol settings.
    /// </summary>
    public partial class EdifactProcessingSettings
    {
        /// <summary>
        /// Initializes a new instance of the EdifactProcessingSettings class.
        /// </summary>
        public EdifactProcessingSettings()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EdifactProcessingSettings class.
        /// </summary>
        /// <param name="maskSecurityInfo">The value indicating whether to mask
        /// security information.</param>
        /// <param name="preserveInterchange">The value indicating whether to
        /// preserve interchange.</param>
        /// <param name="suspendInterchangeOnError">The value indicating
        /// whether to suspend interchange on error.</param>
        /// <param name="createEmptyXmlTagsForTrailingSeparators">The value
        /// indicating whether to create empty xml tags for trailing
        /// separators.</param>
        /// <param name="useDotAsDecimalSeparator">The value indicating whether
        /// to use dot as decimal separator.</param>
        public EdifactProcessingSettings(bool maskSecurityInfo, bool preserveInterchange, bool suspendInterchangeOnError, bool createEmptyXmlTagsForTrailingSeparators, bool useDotAsDecimalSeparator)
        {
            MaskSecurityInfo = maskSecurityInfo;
            PreserveInterchange = preserveInterchange;
            SuspendInterchangeOnError = suspendInterchangeOnError;
            CreateEmptyXmlTagsForTrailingSeparators = createEmptyXmlTagsForTrailingSeparators;
            UseDotAsDecimalSeparator = useDotAsDecimalSeparator;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the value indicating whether to mask security
        /// information.
        /// </summary>
        [JsonProperty(PropertyName = "maskSecurityInfo")]
        public bool MaskSecurityInfo { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to preserve interchange.
        /// </summary>
        [JsonProperty(PropertyName = "preserveInterchange")]
        public bool PreserveInterchange { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to suspend interchange on
        /// error.
        /// </summary>
        [JsonProperty(PropertyName = "suspendInterchangeOnError")]
        public bool SuspendInterchangeOnError { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to create empty xml tags
        /// for trailing separators.
        /// </summary>
        [JsonProperty(PropertyName = "createEmptyXmlTagsForTrailingSeparators")]
        public bool CreateEmptyXmlTagsForTrailingSeparators { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to use dot as decimal
        /// separator.
        /// </summary>
        [JsonProperty(PropertyName = "useDotAsDecimalSeparator")]
        public bool UseDotAsDecimalSeparator { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
