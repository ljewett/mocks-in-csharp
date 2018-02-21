namespace Claims
{
    public class ClaimService
    {
        private readonly ClaimStorage _claimStorage;

        public ClaimService(ClaimStorage claimStorage)
        {
            _claimStorage = claimStorage;
        }
    }
}