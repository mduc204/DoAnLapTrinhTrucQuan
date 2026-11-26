namespace DoAnLapTrinhTrucQuan.Helpers
{
    /// <summary>
    /// Quản lý thông tin phiên làm việc của người dùng hiện tại (Session)
    /// </summary>
    public static class Session
    {
        public static string Username { get; set; } = "admin";
        public static string FullName { get; set; } = "Nguyễn Văn Hưng";
        public static string Role { get; set; } = "Quản lý cửa hàng";
        public static bool IsAdmin { get; set; } = true;

        public static void Login(string username, string fullName, string role, bool isAdmin)
        {
            Username = username;
            FullName = fullName;
            Role = role;
            IsAdmin = isAdmin;
        }

        public static void Logout()
        {
            Username = string.Empty;
            FullName = string.Empty;
            Role = string.Empty;
            IsAdmin = false;
        }
    }
}
