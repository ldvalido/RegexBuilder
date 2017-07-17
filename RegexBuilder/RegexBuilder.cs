using System.Collections.Generic;
using RegexBuilder.Implementation.Renders;
using RegexBuilder.Implementation.Sections;
using RegexBuilder.Interfaces;

namespace RegexBuilder
{
    public enum eQuantification
    {
        Optional = 1,
        Positive = 2,
        Infinite = 4
    }
    public class RegexBuilder
    {
        #region Private Properties
        IRender _render = new CSharpRender();
        private List<ISection> sections = new List<ISection>();        
        #endregion

        #region Public Properties

        #endregion

        #region Public Methods
        public ISection AddNumber(int number)
        {
            ISection section = RegexSectionFactory.CreateNumberSection(number);
            sections.Add(section);
            return section;
        }
        public ISection AddNumber(int number, eQuantification wildcard)
        {
            return null;
        }
        public ISection AddNumber(decimal number)
        {
            return null;
        }
        public ISection AddNumber(decimal number, eQuantification wildcard)
        {
            return null;
            
        }
        public ISection AddNumber(long number)
        {
            return null;
            
        }
        public ISection AddNumber(long number, eQuantification wildcard)
        {
            return null;
            
        }
        public ISection AddNumber(byte number)
        {
            return null;
            
        }
        public ISection AddNumber(byte number, eQuantification wildcard)
        {
            return null;
            
        }
        public ISection AddAnyNumber()
        {
            return null;
        }
        public ISection AddLiteral(string literal)
        {
            return null;
        }
        #endregion

        #region C...tor
        public RegexBuilder()
        {
        }

        public RegexBuilder(IRender render)
        {
            _render = render;
        }
        #endregion

        #region Override Methods
        public override string ToString()
        {
            return "/^$/";
        }
        #endregion

    }
}
