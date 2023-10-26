namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the final placement of this team in this torunament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the placement in the tournament as a name,
        /// for example: "Winner" or "Runner Up".
        /// </summary>
        public string  PlaceName { get; set; }
        /// <summary>
        /// Prize money for this placement in the tournament.
        /// </summary>
        public decimal PrizeaAmount { get; set; }
        /// <summary>
        /// Perecentage of total prize pot for this placement in the tournament.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}