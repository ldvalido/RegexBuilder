using RegexBuilder.Interfaces;

namespace RegexBuilder.Implementation.Sections
{
    internal class RegexSectionFactory
    {
        internal static ISection CreateNumberSection(int number)
        {
            RegexSection<int> returnValue = new RegexSection<int>();
            returnValue.Value = number;
            return returnValue;
        }
    }
}
