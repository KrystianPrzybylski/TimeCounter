namespace TimeCounter
{
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var task = new Task();
        task.ShowStart();
        
        while(true)
        {
            var result=Console.ReadLine();
            task.ShowDuration();
            if(result=="q")
            {
                break;
            }
        }
        task.ShowTotalDuration();
        
    }
}
}