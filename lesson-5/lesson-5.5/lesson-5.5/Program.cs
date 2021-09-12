using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace lesson_5._5
{
    class ToDoApp
    {
        public ToDoApp()
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        
        #region Свойства и поля
        public string Title { get; set; }
        public bool IsDone { get; set; }

        static string path = @"D:\GeekBrains_Lessons\HomeWork\lesson-5\lesson-5.5\tasks.json";

        string myJsonString;
        #endregion

        

        static public void Deserializer(ref List<ToDoApp> tasks)
        {
            string myJsonString = File.ReadAllText(path);
            if (myJsonString != null && myJsonString != "" && myJsonString != " ")
            {
                tasks = JsonSerializer.Deserialize<List<ToDoApp>>(myJsonString);
            }
        }

        static public void Serializer(List<ToDoApp> tasks)
        {
            var convertedJson = JsonSerializer.Serialize(tasks);
            File.WriteAllText(path, convertedJson);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string title;
            List<ToDoApp> tasks = new List<ToDoApp>();
            ToDoApp.Deserializer(ref tasks);

            do
            {
                Console.WriteLine("Введите \"watch\", чтобы просмотреть весь список задач ");
                Console.WriteLine("Введите \"exit\", чтобы завершить выполнение программы");
                Console.WriteLine("Укажите задачу (или опцию):");
                title = Console.ReadLine();

                

                if (title == "exit")
                {
                    ToDoApp.Serializer(tasks);
                    break;
                }
                else if (title == "watch")
                {
                    ToDoApp.Serializer(tasks);
                    Console.Clear();

                    Console.WriteLine("Введите порядковый номер задачи, чтобы подтвердить выполнение");

                    for (int i = 0; i < tasks.Count; i++)
                    {
                        if (tasks[i].IsDone)
                        {
                            Console.Write($"{i + 1}. [X]    ");
                        }
                        else
                        {
                            Console.Write($"{i + 1}. [O]    ");
                        }
                        Console.Write(tasks[i].Title);
                        Console.WriteLine();
                    }
                    string input = Console.ReadLine();
                    bool parseSuccess = int.TryParse(input, out number);
                    if (parseSuccess && tasks.Count + 1 > number)
                    {
                        tasks[number - 1].IsDone = true;
                    }
                    
                }
                else
                {
                    tasks.Add(new ToDoApp() { Title = title, IsDone = false });
                }

            } while (true);

            
        }
    }
}
