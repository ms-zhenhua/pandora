using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.Attestation.v2020_10_01.AttestationProviders
{
    internal class Definition : ApiDefinition
    {
        // Generated from Swagger revision "0cfcacb4d5b58433bfa7cf811f20b1d233cd4dac" 

        public string ApiVersion => "2020-10-01";
        public string Name => "AttestationProviders";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new CreateOperation(),
            new DeleteOperation(),
            new GetOperation(),
            new GetDefaultByLocationOperation(),
            new ListOperation(),
            new ListByResourceGroupOperation(),
            new ListDefaultOperation(),
            new UpdateOperation(),
        };
    }
}
