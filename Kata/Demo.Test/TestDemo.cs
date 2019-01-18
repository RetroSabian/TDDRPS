using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;
using Kata;
using NUnit.Framework;

namespace Demo.Test
{
   public class TestDemo
    {
        private RPS app;
        public TestDemo()
        {
            app = new RPS();
        }

        [TestCase('R','R',0)]
        [TestCase('R', 'P', 2)]
        [TestCase('R', 'S', 1)]
        [TestCase('R', 'X', 2)]
        [TestCase('P', 'P', 0)]
        [TestCase('P', 'R', 1)]
        [TestCase('P', 'S', 2)]
        [TestCase('P', 'X', 1)]
        [TestCase('S', 'S', 0)]
        [TestCase('S', 'P', 1)]
        [TestCase('S', 'R', 2)]
        [TestCase('S', 'X', 2)]
        [TestCase('X', 'R', 1)]
        [TestCase('X', 'S', 1)]
        [TestCase('X', 'P', 2)]
        public void Fight(char c1, char c2, int res)
        {
            //arrange
            var x = app.play(c1, c2);
            //act
            //assert
            Assert.AreEqual(res, x);
        }



    }
}
