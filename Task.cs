namespace TimeCounter
{
    public class Task
    {
        DateTime start;
        DateTime stop;
        TimeSpan duration;

        public Task()
        {
            this.start=DateTime.Now;
            this.stop=DateTime.Now;
            this.duration=TimeSpan.MinValue;    
        }

        public void StartTheTask()
        {
            this.start=DateTime.Now;
        }
        public void ShowStart()
        {
            Console.WriteLine("Zadanie rozpoczęto o godz: "+start);
        }
        public void ShowDuration()
        {
            duration=DateTime.Now-start;
            Console.WriteLine("Aktualny czas "+duration.ToString());
        }

        public void ShowTotalDuration()
        {
            Console.WriteLine("Całkowity czas zadania: "+(DateTime.Now-start).ToString());
        }
        
    }
}