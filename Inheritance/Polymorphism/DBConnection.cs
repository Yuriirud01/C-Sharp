namespace Polymorphism // Note: actual namespace depends on the project name.
{
    public abstract class DBConnection
    {
        private readonly string _connectStr;
        public bool _isConnected { get; set; }
        public DBConnection(string conStr)
        {
            if (String.IsNullOrWhiteSpace(conStr))
            {
                throw new ArgumentNullException("Str is null or whitespace.");
            }
            else
            {
                this._connectStr = conStr;
            }
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}