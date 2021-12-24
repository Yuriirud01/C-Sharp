namespace Interfaces // Note: actual namespace depends on the project name.
{
    public class WorkFlow
    {
        private readonly IActivity _activity;
        private string _work;
        public WorkFlow(IActivity activity, string work)
        {
            _activity = activity;
            _work = work;
        }

        public void Execute_WorkFlow()
        {
            _activity.Execute(_work);
        }
    }
}