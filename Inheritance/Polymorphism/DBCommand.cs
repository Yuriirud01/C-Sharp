namespace Polymorphism // Note: actual namespace depends on the project name.
{
    public class DBCommand
    {
        public DBConnection _connection { get; set; }
        private string _command;

        public DBCommand(DBConnection connection)
        {
            this._connection = connection;
        }

        public void Execute()
        {
            if (_connection._isConnected == true) {
                while (_connection._isConnected == true)
                {
                    Console.WriteLine("Please, enter a command to execute. Enter 'close' to close connection");
                    this._command = Console.ReadLine();
                    if (String.IsNullOrEmpty(this._command))
                    {
                        Console.WriteLine("Incorrect command, please, try again.");
                    }
                    else if (this._command == "close")
                    {
                        _connection.CloseConnection();
                    }
                    else
                    {
                        Console.WriteLine("Command was executed successfully!");
                    }
                }
            }
            else
            {
                throw new Exception("Connection is closed; Connect first.");
            }
                
        }
    }
}