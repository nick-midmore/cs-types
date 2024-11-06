using System.Text.Json;

namespace CSTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task00.Run();
            //Task01.Run();
            //Task02.Run();
            //Task04.MultiplyInt((int)2.2, (int)4.9m);
            //Task05.ConvertToDouble();

            Console.WriteLine("Please provide new student as JSON:");
            NorthcodersStudent studentFromJSON = JsonSerializer.Deserialize<NorthcodersStudent>(Console.ReadLine());

            Console.WriteLine(studentFromJSON.Name);
        }
    }
}
