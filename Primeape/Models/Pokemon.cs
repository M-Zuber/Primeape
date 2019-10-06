using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Pokemon
    {
        public abstract string Name { get; }
        public string Nickname { get; set; }
        public abstract Type PrimaryType { get; }
        public abstract Type? SecondaryType { get; }
    }
}
