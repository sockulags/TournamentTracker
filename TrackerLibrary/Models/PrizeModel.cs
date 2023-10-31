namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents the final placement of this team in this torunament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the placement in the tournament as a name,
        /// for example: "Winner" or "Runner Up".
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize money for this placement in the tournament.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Perecentage of total prize pot for this placement in the tournament.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;

        }
    }
}