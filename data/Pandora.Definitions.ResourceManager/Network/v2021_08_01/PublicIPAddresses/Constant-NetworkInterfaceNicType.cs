using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.PublicIPAddresses;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkInterfaceNicTypeConstant
{
    [Description("Elastic")]
    Elastic,

    [Description("Standard")]
    Standard,
}
