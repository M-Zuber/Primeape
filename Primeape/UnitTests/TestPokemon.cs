using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class DualType : Pokemon
    {
        public override string Name => nameof(DualType);

        public override Models.Type PrimaryType => Models.Type.Fighting;

        public override Models.Type? SecondaryType => Models.Type.Flying;
    }

    public class SingleType : Pokemon
    {
        public override string Name => nameof(DualType);

        public override Models.Type PrimaryType => Models.Type.Fighting;

        public override Models.Type? SecondaryType => null;
    }
}
