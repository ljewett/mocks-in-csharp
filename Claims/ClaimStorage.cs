using ThirdPartyPersistenceEngine;

namespace Claims
{
    public class ClaimStorage
    {
        private readonly IPersister<Claim> _persister;

        public ClaimStorage(IPersister<Claim> persister)
        {
            _persister = persister;
        }

        public Claim Get(string claimId)
        {
            return _persister.Get(claimId);
        }
        
        public string Put(Claim claim)
        {
            return null;
        }
    }
}