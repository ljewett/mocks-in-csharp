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
        
        public Claim GetClaim(string claimID)
        {
            return _claimService.GetClaim(claimID);
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