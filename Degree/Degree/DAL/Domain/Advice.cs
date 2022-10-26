using Degree.DAL.Domain.Abstract;

namespace Degree.DAL.Domain
{
    public class Advice : SimpleDomainModel<int>
    {
        /// <summary>
        /// AdviceText
        /// </summary>
        public string AdviceText { get; set; }
        /// <summary>
        /// AdviceType enum value
        /// </summary>
        public int AdviceType { get; set; }
    }
}
