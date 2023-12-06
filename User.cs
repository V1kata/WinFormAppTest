namespace WinFormAppTest
{
    public class User
    {
        private string username = "N/A";
        private string password = "N/A";
        private DateTime timeOfRegister = DateTime.Now;

        private static int nextId = 0;
        private int id = nextId++;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; }

        public override string ToString()
        {
            return String.Format($"Username: {this.username}, " +
                                $"Password: {this.password}, " +
                                $"Id: {this.id}, " +
                                $"Time of register: {this.timeOfRegister}");
        }
    }
}
