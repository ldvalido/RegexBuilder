using System.Text;

namespace RegexBuilder.Interfaces
{
    public interface ISection
    {
        //T Value{ get; set;}
        eQuantification QuantifyOperator{get;set;}
        void Render(StringBuilder sb);
    }
}
