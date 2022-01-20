using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Purview.v2021_07_01.DefaultAccount
{
    internal class Definition : ResourceDefinition
    {
        public string Name => "DefaultAccount";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new GetOperation(),
            new RemoveOperation(),
            new SetOperation(),
        };
    }
}
