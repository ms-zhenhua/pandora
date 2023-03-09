using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_01_02_preview.ManagedClusters;


internal class ManagedClusterWindowsProfileModel
{
    [JsonPropertyName("adminPassword")]
    public string? AdminPassword { get; set; }

    [JsonPropertyName("adminUsername")]
    [Required]
    public string AdminUsername { get; set; }

    [JsonPropertyName("enableCSIProxy")]
    public bool? EnableCSIProxy { get; set; }

    [JsonPropertyName("gmsaProfile")]
    public WindowsGmsaProfileModel? GmsaProfile { get; set; }

    [JsonPropertyName("licenseType")]
    public LicenseTypeConstant? LicenseType { get; set; }
}