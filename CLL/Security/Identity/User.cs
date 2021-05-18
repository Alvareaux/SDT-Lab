namespace CLL.Security.Identity
{
    public abstract class User
    {
        public User(int user_id, string name, int department_id, string user_type)
        {
            User_id = user_id;
            Name = name;
            Department_id = department_id;
            User_type = user_type;
        }
        public int User_id { get; }
        public string Name { get; }
        public int Department_id { get; }
        protected string User_type { get; }
    }
}
