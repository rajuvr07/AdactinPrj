using Insurance.Models;

namespace Insurance.Services
{
    public interface IPremiumService
    {
        /// <summary>
        /// Calculates the monthly premium based on inputs attributes
        /// </summary>
        /// <param name="age"></param>
        /// <param name="occupation"></param>
        /// <param name="sumInsured"></param>
        /// <returns></returns>
        public MonthlyPremiumModel Calculate(int age, string occupation, double sumInsured);
    }
}
