namespace Claims {
    public class ClaimService
    {
        public string HandleClaimSubmission(Claim claim)
        {
            // Given I have a claim
            // And the claim type is HAIL
            // When I save the claim
            // Then a single adjustment should also be created.

            // Given I have a claim
            // And the claim type is NOT HAIL
            // When I save the claim
            // Then no adjustment should be created.
            return null;
        }
    }
}