using Firebase.Database;
using System.Threading.Tasks;

namespace TestFirebase.auth
{
    public class Auth
    {

        private static Auth instance;

        public FirebaseClient FirebaseClient { get; set; }

        private Auth() { }

        public static Auth getInstance()
        {
            if (instance == null)
            {
                instance = new Auth();
            }

            return instance;
        }

        public void InitAuth()
        {

            var auth = System.Configuration.ConfigurationManager.AppSettings["appSecretDataBase"];
            var URLDataBase = System.Configuration.ConfigurationManager.AppSettings["URLDataBase"];

            FirebaseClient = new Firebase.Database.FirebaseClient(
                URLDataBase,
                new Firebase.Database.FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(auth)
                }
                );

        }

    }
}
