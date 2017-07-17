using System;
using System.Text;
using RegexBuilder.Interfaces;

namespace RegexBuilder.Implementation.Sections
{
    public class RegexSection<T> : ISection
    {
        #region Private Properties
        private T _value;
        private eQuantification _quantifyOperator;
        #endregion

        #region ISection<T> Members
        public T Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public eQuantification QuantifyOperator
        {
            get{return _quantifyOperator;}
            set{_quantifyOperator = value;}
        }

        #endregion

        #region ISection Members
        public void Render(StringBuilder sb)
        {
            sb.Append(String.Empty);
        }
        #endregion
    }
}
