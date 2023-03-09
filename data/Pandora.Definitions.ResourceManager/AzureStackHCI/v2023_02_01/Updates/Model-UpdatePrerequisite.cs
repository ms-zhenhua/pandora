using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.AzureStackHCI.v2023_02_01.Updates;


internal class UpdatePrerequisiteModel
{
    [JsonPropertyName("packageName")]
    public string? PackageName { get; set; }

    [JsonPropertyName("updateType")]
    public string? UpdateType { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}