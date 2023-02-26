// See https://aka.ms/new-console-template for more information

namespace Delegates
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Delegate helloWorldDelegate = HelloWorld;
            helloWorldDelegate.DynamicInvoke();

            var action = WriteMessage;

            action("Hello!");

            ConfigurarFramework(options =>
            {
                options.UsarTalCoisa = true;
                options.ConfigurarOutraCoisa();
            });

            // Lambda expression
            var method = () => Console.WriteLine("Hellow World!");

            // Lambda statement
            var function = () =>
            {
                Console.WriteLine("Hellow World 1!");
                Console.WriteLine("Hellow World 2!");
            };

            method();
            function();
        }

        private static void HelloWorld()
        {

            Console.WriteLine("Hello, World!");
        }

        public static void ConfigurarFramework(Action<FrameworkOptions> options)
        {
            // ...
        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class FrameworkOptions
    {
        public bool UsarTalCoisa { get; set; }

        public void ConfigurarOutraCoisa()
        {
            Console.WriteLine($"Chamou {nameof(ConfigurarOutraCoisa)}!");
        }
    }
}
