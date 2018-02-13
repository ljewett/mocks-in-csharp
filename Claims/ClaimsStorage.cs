using ThirdPartyPersistenceEngine;

namespace Claims
{
    public class ClaimsStorage
    {
        private readonly Persister<Claim> Persister;
        
        public ClaimsStorage(Persister<Claim> claimPersister)
        {
            Persister = claimPersister;
        }

        public string Put(Claim claim)
        {
            return null;
        }
    }
}