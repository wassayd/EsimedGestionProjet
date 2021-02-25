namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IUser
    {
        int Id { get; set; }

        string trigram { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

    }
}