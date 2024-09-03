using System.Net.Http.Json;

namespace CodeRefactor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string apiUrl = "https://fake-json-api.mock.beeceptor.com/users";
            var userdbus = new UserBusiness();
            await UserDisplay(userdbus, apiUrl);
        }

        public static async Task UserDisplay(UserBusiness userdbus, string apiUrl)
        {
            var users = await userdbus.FetchUsersAsync(apiUrl);

            if (users != null) // Would it be better if we check if the list is not empty instead not null? 
            {
                Console.WriteLine(
                        $"{"ID",-5} {"Name",-20} {"Company",-15} {"Username",-20} {"Email",-30} {"Address",-30} {"Zip",-10} {"State",-15} {"Country",-15} {"Phone",-40} {"Photo",-80}");

                Console.WriteLine(new string('-', 250));

                foreach (var user in users)
                {
                    Console.WriteLine($"{user.Id,-5} {user.Name,-20} {user.Company,-15} {user.Username,-20} {user.Email,-30} {user.Address,-30} {user.Zip,-10} {user.State,-15} {user.Country,-15} {user.Phone,-40} {user.Photo,-80}");
                }
            }
            else
            {
                Console.WriteLine("No users found.");
            }

        }

    }
}