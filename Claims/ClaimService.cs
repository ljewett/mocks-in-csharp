namespace Claims
{
    public class ClaimService
    {
        private readonly ClaimStorage _claimStorage;

        public ClaimService(ClaimStorage claimStorage)
        {
            _claimStorage = claimStorage;
        }

        public Claim GetClaim(string claimId)
        {
            return _claimStorage.Get(claimId);
        }
    }
}