using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.VirtualWANs;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NetworkInterfaceAuxiliaryModeConstant
{
    [Description("Floating")]
    Floating,

    [Description("MaxConnections")]
    MaxConnections,

    [Description("None")]
    None,
}
