namespace Insurance.Services
{
    public class RatingService : IRatingService
    {
        private Dictionary<string, double> _occupations = new Dictionary<string, double>();

        public RatingService()
        {
            _occupations = new Dictionary<string, double>
            {
                {"professional", 1.0 },
                {"white collar", 1.25 },
                {"light manual", 1.50 },
                {"heavy manual", 1.75 }
            };
        }

        public double GetRating(string occupation)
        {
            var occupationLower = occupation.ToLowerInvariant();

            if (_occupations.ContainsKey(occupationLower)) return _occupations[occupationLower];

            return 0.0;
        }
    }
}
