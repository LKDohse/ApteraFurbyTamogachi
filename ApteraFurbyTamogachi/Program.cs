using System;
using System.Threading.Tasks;

namespace ApteraFurbyTamogachi
{
    class Program
    {
        private static string command;
        private static Tamogachi myFurby;

        static void Main(string[] args)
        {
            command = "";
            myFurby = new Tamogachi();
            myFurby.Health = 10;
            Clock();
            while (command != "stop")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "feed":
                        Console.WriteLine(myFurby.Feed());
                        break;
                    case "health":
                        Console.WriteLine(myFurby.GetHealth());
                        break;
                    case "status":
                        Console.WriteLine(myFurby.GetStatus());
                        break; 
                    case "kill":
                        myFurby.Kill();
                        break;
                    default:
                        myFurby.Ignore();
                        break;
                }

                Console.WriteLine($"Furby's Health: {myFurby.Health}");
                if (myFurby.Health == 0)
                {
                    Console.Beep(); 
                    Console.WriteLine("You killed Furby, you monster");
                }

            }
        }

        async static void Clock() {
            while (myFurby.Health > 0) {
                myFurby.Ignore();
                await Task.Delay(3000);
            }
        }
    }
}
