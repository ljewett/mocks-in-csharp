using ThirdPartyPersistenceEngine;

namespace Claims
{
    public class ClaimsStorage
    {
        private readonly IPersister<Claim> _persister;
        
        public ClaimsStorage(IPersister<Claim> persister)
        {
            _persister = persister;
        }

        public string Put(Claim claim)
        {
            return null;
        }
    }
}