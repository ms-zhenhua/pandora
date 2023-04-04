using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_02_02_preview.ManagedClusterSnapshots;

internal class CreateOrUpdateOperation : Operations.PutOperation
{
    public override Type? RequestObject() => typeof(ManagedClusterSnapshotModel);

    public override ResourceID? ResourceId() => new ManagedClusterSnapshotId();

    public override Type? ResponseObject() => typeof(ManagedClusterSnapshotModel);


}