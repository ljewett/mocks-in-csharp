using System.Collections.Generic;

namespace Claims
{
    public class ClaimsController
    {
        // POST /claims
        public string SaveClaim(Claim claim)
        {
            // Given I have a claim 
            // When I POST the claim to /claims
            // Then I should receive the claim ID back.

            return null;
        }
        
        // GET /claims/{claimId}/adjustments
        public List<Adjustment> GetClaimAdjustments(string claimId)
        {
            // Given I have just saved a claim
            // And I have the claim's ID
            // When I do a GET on /claims/{claimId}/adjustments
            // Then I should receive a list of adjustments for the claim.
            
            return null;
        }
    }
}