namespace C__Group_Assignment
{
    internal static class UserSession
    {
        public static string UserID { get; private set; }

        public static string UserName { get; private set; }

        public static string Role { get; private set; }

        public static bool IsAuthenticated => !string.IsNullOrWhiteSpace(UserID);

        public static void Start(string userID, string userName, string role)
        {
            UserID = userID;
            UserName = userName;
            Role = role;
        }

        public static void UpdateUserName(string userName)
        {
            UserName = userName;
        }

        public static void Clear()
        {
            UserID = null;
            UserName = null;
            Role = null;
        }
    }
}
