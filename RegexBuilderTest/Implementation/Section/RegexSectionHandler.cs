using NUnit.Framework;
using RegexBuilder.Implementation.Sections;
using RegexBuilder.Interfaces;

namespace RegexBuilderTest.Implementation.Section
{
    [TestFixture]
    public class RegexSectionHandler
    {
        [Test]
        public void TestCreateNumberSection()
        {
            ISection section = RegexSectionFactory.CreateNumberSection(1);
            Assert.IsNotNull(section);
        }

        [Test]
        public void TestCreateNumberSectionRender()
        {
            ISection section = RegexSectionFactory.CreateNumberSection(1);
            Assert.IsNotNull(section);
            string r = section.ToString();
            Assert.AreEqual(r,"1");
        }
    }
}
