namespace GestionProjet.Models.Interfaces
{
    public class RequirementNoneFunctional
    {
        public string Value { get; set; }

        private RequirementNoneFunctional(string value)
        {
            this.Value = value;
        }

        public static RequirementNoneFunctional Data { get { return new RequirementNoneFunctional("donées"); }  }
        public static RequirementNoneFunctional Performance { get { return new RequirementNoneFunctional("interfaces utilisateur"); } }
        public static RequirementNoneFunctional Interfaces { get { return new RequirementNoneFunctional("qualité"); } }
        public static RequirementNoneFunctional Services { get { return new RequirementNoneFunctional("services"); } }
    }
}