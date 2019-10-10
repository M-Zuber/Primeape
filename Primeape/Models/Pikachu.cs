using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {

        }

        public Pikachu(string nickname)
        {
            Nickname = nickname;
        }

        public override string Name => nameof(Pikachu);

        public override Type PrimaryType => Type.Electric;

        public override Type SecondaryType => Type.None;
    }
}
