using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerService.v2023_04_02_preview.ManagedClusters;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum OSSKUConstant
{
    [Description("AzureLinux")]
    AzureLinux,

    [Description("CBLMariner")]
    CBLMariner,

    [Description("Mariner")]
    Mariner,

    [Description("Ubuntu")]
    Ubuntu,

    [Description("Windows2019")]
    WindowsTwoZeroOneNine,

    [Description("Windows2022")]
    WindowsTwoZeroTwoTwo,
}
