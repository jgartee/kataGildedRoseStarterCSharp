using Xunit;
using System;
using System.IO;
using System.Text;
using GildedRose;

namespace GildedRose.Tests
{
    public class GildedRoseShould
    {
        [Fact]
        public void FindTheGildedRoseClass()
        {
            var gr = new GildedRose(new Item[] { new Item("name", 0, 0) });
            Assert.IsType<GildedRose>(gr);
        }
    }
}

