using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace finallytask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерация номера - " + InspectorLib.FunctionInsp.GenerateNumber(1232, 'Ю', 92) + "\n");
            Console.WriteLine("Генерация номера - " + InspectorLib.FunctionInsp.GenerateNumber(1222, 'В', 92) + "\n");
            Console.WriteLine("Название инспекции - " + FunctionInsp.GetCarInspection() + "\n");
            Console.WriteLine("Инспектор - " + FunctionInsp.GetInspector() + "\n");

            foreach (string member in FunctionInsp.GetWorker())
                Console.Write(member + "\t");

            Console.WriteLine("\n\n" + FunctionInsp.SetInspector("Лихачев В.И.") + "\n");
            Console.WriteLine(FunctionInsp.SetInspector("Иванов И.И.") + "\n");

            FunctionInsp.AddWorker("Лихачев В.В.");

            foreach (string member in FunctionInsp.GetWorker())
                Console.Write(member + "\t");
        }
    }
}
