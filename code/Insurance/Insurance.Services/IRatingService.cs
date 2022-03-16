namespace Insurance.Services
{
    public interface IRatingService
    {
        /// <summary>
        /// Get's the rating based on the customer's occupation
        /// </summary>
        /// <param name="occupation">Customer's Occupation</param>
        /// <returns></returns>
        public double GetRating(string occupation);
    }
}
