namespace Polymorphism // Note: actual namespace depends on the project name.
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string conStr) : base(conStr)
        {

        }

        public override void OpenConnection()
        {
            if (this._isConnected == false)
            {
                _isConnected = true;
                Console.WriteLine("Oracle connection was opened.");
            }
            else
            {
                Console.WriteLine("Oracle connection is already opened.");
            };
        }

        public override void CloseConnection()
        {
            if (this._isConnected == true)
            {
                _isConnected = false;
                Console.WriteLine("Oracle connection was closed.");
            }
            else
            {
                Console.WriteLine("Oracle connection is already closed.");
            };
        }
    }

}