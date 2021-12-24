namespace OOPFundamentals // Note: actual namespace depends on the project name.
{
    public class StopWatch
    {
        public DateTime startTime;
        public DateTime endTime;
        public bool isRunning = false;

        public void Start()
        {
            if (!isRunning)
            {
                startTime = DateTime.Now;
                isRunning = true;
            }
            else
            {
                throw new InvalidOperationException("You should end Timer before you start it again");
            }
        }

        public void End()
        {
            endTime = DateTime.Now;
            Console.WriteLine("Timer ended. Time of working: " + endTime);
            isRunning = false;
        }

        public void Duration()
        {
            Console.WriteLine(endTime - startTime);
        }
    }
}
