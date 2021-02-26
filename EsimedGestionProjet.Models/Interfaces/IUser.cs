namespace EsimedGestionProjet.Models.Interfaces
{
    public interface IUser
    {
        int Id { get; init; }

        string trigram { get; init; }

        string FirstName { get; init; }

        string LastName { get; init; }

    }
}