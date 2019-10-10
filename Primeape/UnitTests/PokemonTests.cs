using System;
using Xunit;

namespace UnitTests
{
    public class PokemonTests
    {
        [Fact]
        public void TypeHandlesDualTypedPokemon()
        {
            var instance = new DualType();
            Assert.Equal("Fighting/Flying", instance.PrintFriendlyType);
        }

        [Fact]
        public void TypeHandlesSingleTypedPokemon()
        {
            var instance = new SingleType();
            Assert.Equal("Fighting", instance.PrintFriendlyType);
        }
    }
}
