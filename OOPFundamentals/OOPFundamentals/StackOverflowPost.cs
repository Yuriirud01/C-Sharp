namespace OOPFundamentals // Note: actual namespace depends on the project name.
{
    public class StackOverflowPost
    {
        private string _title;
        private string _description;
        private readonly DateTime _creationDate;
        private readonly Dictionary<string, int> _votes;

        public StackOverflowPost()
        {
            _creationDate = DateTime.Now;
            _votes = new Dictionary<string, int>()
            {
                {"up", 0},
                {"down", 0}
            };
        }

        public StackOverflowPost(string title, string desc) : this()
        {
            this._title = title;
            this._description = desc;
        }

        public void GetPost()
        {
            Console.WriteLine(_title);
            Console.WriteLine(_description);
        }

        public void MakeVote(string vote)
        {
            {
                this._votes[vote.ToLower()] += 1;
            }
        }

        public void GetVotes()
        {
            foreach (var vote in this._votes)
            {
                Console.WriteLine(vote.Key + ": " + vote.Value);
            }           
        }
    }
}
