using Degree.DataTypes.Enums;

namespace Degree.BLL.Dtos
{
    public class AdviceDto
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// AdviceText
        /// </summary>
        public string AdviceText { get; set; }
        /// <summary>
        /// AdviceType enum value
        /// </summary>
        public EAdviceType AdviceType { get; set; }
    }
}
