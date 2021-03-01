using EsimedGestionProjet.Entities.DataAccess;
using EsimedGestionProjet.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace EsimedGestionProjet.Entities
{
    public class DataInitializer
    {

        public static async System.Threading.Tasks.Task SeedUserData(DatabaseContext context)
        {
            if (!context.User.Any())
            {
                var file = System.IO.File.ReadAllText("user.seeder.json");
                var users = JsonSerializer.Deserialize<List<User>>(file);

                await context.User.AddRangeAsync(users);
                await context.SaveChangesAsync();
            }
        }
    }
}
