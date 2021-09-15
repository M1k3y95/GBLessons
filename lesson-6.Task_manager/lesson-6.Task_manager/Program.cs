using System;
using System.Diagnostics;

namespace lesson_6.Task_manager
{
    class TaskManager
    {
        Process[] allProcesses = Process.GetProcesses();
        private int proccessIndex;
        public void PrintProccessList()
        {
            Console.Clear();
            Console.WriteLine($"{"Имя процесса",-40} {"ID Процесса",15} {"Объем выделенной памяти",25}");
            for (int i = 0; i < allProcesses.Length; i++)
            {
                Console.WriteLine($"{ allProcesses[i].ProcessName,-40} {allProcesses[i].Id,15} {allProcesses[i].VirtualMemorySize64,25}");
            }
        }

        public void EndTheProccessByName(string name)
        {

            for (int i = 0; i < allProcesses.Length; i++)
            {
                if (allProcesses[i].ProcessName == name)
                {
                    proccessIndex = i;
                    break;
                }
                else
                {
                    proccessIndex = -1;
                }
            }
            if (proccessIndex != -1)
            {
                allProcesses[proccessIndex].Kill();
            }
            else
            {
                Console.WriteLine("Что-то пошло не так. Возможно, вы неверно ввели имя процесса. Попробуйте снова");
            }

        }

        public void EndTheProccessByID(string id)
        {
            int proccessID;
            bool succesParsing = int.TryParse(id, out proccessID);

            for (int i = 0; i < allProcesses.Length; i++)
            {
                if (allProcesses[i].Id == proccessID)
                {
                    proccessIndex = i;
                    break;
                }
                else
                {
                    proccessIndex = -1;
                }
            }
            if (succesParsing)
            {
                if (proccessIndex != -1)
                {
                    allProcesses[proccessIndex].Kill();
                }
                else
                {
                    Console.WriteLine("Что-то пошло не так. Возможно, вы неверно ввели ID процесса. Попробуйте снова");
                }
            }
            else
            {
                Console.WriteLine("Введены неверные данные, указанного процесса не существует");
                return;
            }
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                TaskManager taskmanager = new TaskManager();

                while (true)
                {
                    Console.WriteLine("Список процессов: /list");
                    Console.WriteLine("Завершение процесса по ID: /agent47");
                    Console.WriteLine("Завершение процесса по имени: /name");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "/list":
                            taskmanager.PrintProccessList();
                            break;

                        case "/agent47":
                            Console.WriteLine("Введите ID процесса:");
                            string id = Console.ReadLine();
                            taskmanager.EndTheProccessByID(id);
                            break;

                        case "/name":
                            Console.WriteLine("Введите имя процесса:");
                            string name = Console.ReadLine();
                            taskmanager.EndTheProccessByName(name);
                            break;

                        default:
                            Console.WriteLine("Что-то пошло не так. Попробуйте снова");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
}

