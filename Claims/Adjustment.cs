namespace Claims
{
    public class Adjustment
    {
        public string Id {
            get; private set;
        }

        public string ClaimId { get; private set; }

        public Adjustment(string id, string claimId)
        {
            Id = id;
            ClaimId = claimId;
        }
    }
}