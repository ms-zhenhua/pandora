using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Network.v2021_08_01.AzureFirewalls;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum AzureFirewallApplicationRuleProtocolTypeConstant
{
    [Description("Http")]
    HTTP,

    [Description("Https")]
    HTTPS,

    [Description("Mssql")]
    Mssql,
}
