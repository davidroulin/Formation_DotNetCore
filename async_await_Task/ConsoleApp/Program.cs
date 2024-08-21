using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ConsoleApp
{

    [AttributeUsage(AttributeTargets.Method)]
    public class InMenu : System.Attribute;

    internal class Menu
    {

        private static string Line = new string('-', 64);

        private static bool MethodInMenu(MethodInfo method) => System.Attribute.GetCustomAttributes(method).Any(a => a is InMenu);
        private static IEnumerable<MethodInfo> GetMenuMethods() => typeof(Program).GetMethods().Where(method => MethodInMenu(method));
        private static List<MethodInfo> callableMethods = GetMenuMethods().ToList();

        private static Program _instance;

        private static void ClearConsole()
        {
            Console.Clear();
        }

        private static void RewriteMenu()
        {
            Console.WriteLine($"\n{Line}\nPick method:\n");
            callableMethods.Select((method, index) => (method, index)).ToList().ForEach(tuple => Console.WriteLine($" {tuple.index + 1} : {tuple.method.Name}"));
            Console.WriteLine($"\n 0 : Quit\n{Line}\n");
        }

        private static (bool exec, int index, bool exit) GetInput()
        {
            int choice;
            char ch = Console.ReadKey().KeyChar; // Blocking
            int.TryParse(ch.ToString(), out choice);
            int index = choice - 1; // attention
            return (callableMethods.ElementAtOrDefault(index) != null, index, choice == 0);
        }

        private static void CallMethod(int index)
        {
            _instance.RestartTimer();
            Console.WriteLine($"Executing {callableMethods[index].Name}:\n{Line}\n");
            callableMethods[index].Invoke(_instance, null); // args not supported
        }

        private static void Loop()
        {
            ClearConsole();
            RewriteMenu();
            bool exit = false;
            while (!exit)
            {
                (bool exec, int index, exit) = GetInput();
                if (exec)
                {
                    ClearConsole();
                    CallMethod(index);
                    RewriteMenu();
                }
            }
            Console.WriteLine("\n\nBye!");
        }

        public static void StartMenu(Program instance)
        {
            _instance = instance;
            Loop();
        }

    }

    partial class Program
    {



        private static Program _singleton;

        public static Program Instance {
            get {
                _singleton ??= new Program();
                return _singleton;
            }
        }


        private Stopwatch _timer = new Stopwatch();

        public void RestartTimer()
        {
            _timer?.Restart();
        }

        public void StopTimer()
        {
            _timer?.Stop();
        }

        public void InstanceTimeLog(string line)
        {
            TimeSpan ts = Instance._timer.Elapsed;
            string elapsedTime = String.Format(
                "{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10
            );
            Console.WriteLine($"{ elapsedTime} : {line}");
        }

        public static void TimeLog(string line)
        {
            Instance.InstanceTimeLog(line);
        }


        static void Main(string[] args)
        {
            Menu.StartMenu(Instance);

            //Instance.TacheLongueBloquante();

            //Console.Read()
        
            Console.WriteLine("End Main");
        }
    }
}
