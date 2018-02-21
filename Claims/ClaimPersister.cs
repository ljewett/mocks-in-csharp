using System;
using ThirdPartyPersistenceEngine;

namespace Claims
{
    public class ClaimPersister : IPersister<Claim>
    {
        public string Save(Claim record)
        {
            throw new Exception("Database Not Available");
        }

        public Claim Get(string id)
        {
            throw new Exception("Database Not Available");
        }
    }
}