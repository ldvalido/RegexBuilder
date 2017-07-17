using NUnit.Framework;
using RegexBuilder;

namespace RegexBuilderTest
{
    [TestFixture]
    public class RegexBuilderTest
    {
        [Test]
        public void TestBasic()
        {
            RegexBuilder.RegexBuilder reg=new RegexBuilder.RegexBuilder();
            reg.AddNumber(4, eQuantification.Positive);
            string r = reg.ToString();
        }
    }
}
