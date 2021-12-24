namespace Polymorphism // Note: actual namespace depends on the project name.
{

    public partial class Program
    {
        public class connector
        {
            public static void connect(List<DBConnection> connections)
            {
                foreach (DBConnection connection in connections)
                {
                    connection.OpenConnection();
                }
            }
        }
    }
}