using Session10.ColaStoreProject.ValueObjects;

namespace Session10.ColaStoreProject.Constants
{
    public static class MessageLookup
    {
        public const string WELCOME = "Welcome to Cola Store!";
        public static string WELCOME_USER(string user)=> $"Welcome {user}!";

        public const string EXIT = "Press any key to exit";
        public static string DEFAULT_USER(string user) => $"Default User: {user}";
        public static string DEFAULT_PASS(string pass) => $"Default Password: {pass}";
        public static string DEFAULT_CREDIT(Money money) => $"Default Credit: {money.ToString()} ushlugh";

        public const string ENTER_USERNAME = "Please Enter your username to connect Bank gateway";
        public const string ENTER_PASSWORD = "Please Enter your password";
        public const string ENTER_COLA_TYPE = "Please enter your cola type: Limon, Orange, Blak or L, O, B";
        public const string ENTER_QUANTITY = "Please enter quantity. It must be greater than zero";
    }
}
