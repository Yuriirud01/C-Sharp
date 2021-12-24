namespace Polymorphism // Note: actual namespace depends on the project name.
{
    public class SqlConnection : DBConnection
    {
        public SqlConnection(string conStr) : base(conStr)
        {

        }

        public override void OpenConnection()
        {
            if (this._isConnected == false)
            {
                _isConnected = true;
                Console.WriteLine("Sql connection was opened.");
            }
            else
            {
                Console.WriteLine("Sql connection is already opened.");
            };
        }

        public override void CloseConnection()
        {
            if (this._isConnected == true)
            {
                _isConnected = false;
                Console.WriteLine("Sql connection was closed.");
            }
            else
            {
                Console.WriteLine("Sql connection is already closed.");
            };
        }
    }

}