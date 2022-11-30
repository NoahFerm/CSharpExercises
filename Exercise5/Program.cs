namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ui = new UI();
            var app = new Manager(ui);
            app.Start();
            
        }
    }
}