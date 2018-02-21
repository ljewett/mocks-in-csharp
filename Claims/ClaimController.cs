using System.Collections.Generic;

namespace Claims
{
    public class ClaimController
    {
        private readonly ClaimService _claimService;

        public ClaimController(ClaimService claimService)
        {
            _claimService = claimService;
        }
        
        // POST /claims
        public string SaveClaim(Claim claim)
        {
            // Given I have a claim 
            // When I POST the claim to /claims
            // Then I should receive the claim ID back.

            return null;
        }
    }
}