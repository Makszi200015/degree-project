namespace Degree.DAL.Domain.Abstract
{
    public abstract class SimpleDomainModel<T>
    {
        /// <summary>
        /// Id for Entity
        /// </summary>
        public T Id { get; set; }
    }
}
