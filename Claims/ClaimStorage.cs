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

        public string Put(Claim claim)
        {
            return null;
        }
    }
}