using Degree.BLL.StatisticsFactory.FactoryModels.Abstarct;

namespace Degree.BLL.StatisticsFactory.FactoryModels.StatisticCreatorModels
{
    public abstract class StatisticsCreator
    {
        public abstract IStatistic FactoryMethod();
    }
}
