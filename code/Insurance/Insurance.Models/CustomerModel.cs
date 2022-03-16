namespace Insurance.Models
{
    public class CustomerModel
    {
        /// <summary>
        /// Customer's full name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age of the customer
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Date of birth of the customer
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Occupation of the customer
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// Total insurance coverage of the user
        /// </summary>
        public double SumInsured { get; set; }
    }
}
