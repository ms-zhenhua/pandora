using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.LoadBalancers;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ProbeProtocolConstant
{
    [Description("Http")]
    HTTP,

    [Description("Https")]
    HTTPS,

    [Description("Tcp")]
    Tcp,
}
