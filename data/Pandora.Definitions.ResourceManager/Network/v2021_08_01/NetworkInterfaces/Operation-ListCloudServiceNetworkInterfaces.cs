using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.NetworkInterfaces;

internal class ListCloudServiceNetworkInterfacesOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new CloudServiceId();

    public override Type NestedItemType() => typeof(NetworkInterfaceModel);

    public override string? UriSuffix() => "/networkInterfaces";


}
