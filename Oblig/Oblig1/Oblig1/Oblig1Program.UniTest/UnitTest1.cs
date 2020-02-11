using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using C_Sharp_Oblig_1;

namespace Oblig1Program.UniTest
{
    public class Tests
    {
        [Test]
        public void HelpText()
        {


            //var result = test.TimesTwo(-6);

            var expected = 4;
            SkriftsLinje = 1;

            //Assert.AreEqual(expected, result);
        }

        public int SkriftsLinje { get; set; }
    }
}