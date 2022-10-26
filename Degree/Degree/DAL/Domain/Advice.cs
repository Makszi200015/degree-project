using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class Advice : SimpleDomainModel<int>
    {
        public string AdviceText { get; set; }
        public int AdviceType { get; set; }
    }
}
