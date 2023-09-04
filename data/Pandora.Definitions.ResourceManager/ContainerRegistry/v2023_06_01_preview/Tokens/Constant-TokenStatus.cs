using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ContainerRegistry.v2023_06_01_preview.Tokens;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum TokenStatusConstant
{
    [Description("disabled")]
    Disabled,

    [Description("enabled")]
    Enabled,
}
