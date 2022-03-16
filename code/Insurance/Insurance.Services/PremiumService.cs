using Insurance.Models;

namespace Insurance.Services
{
    public class PremiumService : IPremiumService
    {
        private readonly IRatingService _ratingService;

        public PremiumService(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public MonthlyPremiumModel Calculate(int age, string occupation, double sumInsured)
        {
            var rating = _ratingService.GetRating(occupation);

            if (rating == 0.0) throw new ArgumentOutOfRangeException(nameof(rating));

            if (age == 0 || rating == 0 || sumInsured == 0) throw new ArgumentException("Invalid input attributes");

            return new MonthlyPremiumModel
            {
                TotalMonthlyPremium = (age * rating * sumInsured) / 1000
            };
        }
    }
}
