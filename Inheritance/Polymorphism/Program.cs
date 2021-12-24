using System;
using System.Collections.Generic;
using System.Linq;

namespace Polymorphism // Note: actual namespace depends on the project name.
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            //var connections = new List<DBConnection>() {new SqlConnection("sql"), new OracleConnection("Oracle") };
            //connector.connect(connections);
            var my_command = new DBCommand(new SqlConnection("josh"));
            my_command._connection.OpenConnection();
            my_command.Execute();
        }
    }
}