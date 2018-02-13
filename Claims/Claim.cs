namespace Claims {
    public class Claim {
        public string Id {
            get; private set;
        }

        public ClaimType Type {
            get; private set;
        }

        public Claim(string id, ClaimType type)
        {
            Id = id;
            Type = type;
        }
    }

    public enum ClaimType {
        Fire, Hail, Flood, Wind
    }
}