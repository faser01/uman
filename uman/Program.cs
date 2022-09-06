using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesList
{
    class Program
    {
        struct Human
        {
            public string Name;
            public int Age;
        }
        Program(Human[] human)
        {
            human[0].Name = "Сергей";
            human[0].Age = 32;
            human[1].Name = "Иван";
            human[1].Age = 17;
            human[2].Name = "Александр";
            human[2].Age = 81;
            human[3].Name = "Семен";
            human[3].Age = 43;
            human[4].Name = "Николай";
            human[4].Age = 87;
            human[5].Name = "Алевтина";
            human[5].Age = 18;
            human[6].Name = "Светлана";
            human[6].Age = 19;
            human[7].Name = "Наталья";
            human[7].Age = 22;
            human[8].Name = "Георгий";
            human[8].Age = 37;
            human[9].Name = "Павел";
            human[9].Age = 76;
            human[10].Name = "Руслан";
            human[10].Age = 38;
            human[11].Name = "Вася";
            human[11].Age = 22;
            human[12].Name = "Наталья";
            human[12].Age = 27;
        }
        static void Replace(Human[] human, int _number, string _item, int _item2)
        {
            human[_number].Name = _item;
            human[_number].Age = _item2;
        }
        static void Print(Human[] human)
        {
            for (int i = 0; i < human.Length; i++)
            {
                Console.WriteLine(" {0}:Имя -> {1}, возраст -> {2}лет", i + 1, human[i].Name, human[i].Age);
            }
            Console.WriteLine();
        }
        static void Search(Human[] human)
        {
            Print(human);
            Console.WriteLine("Для поиска введите имя человека:");
            string match = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < human.Length; i++)
            {
                if (human[i].Name == match)
                {
                    count++;
                    Console.WriteLine("Имя {0} входит в список посетителей, его возраст {1}, " +
                        "номер в списке {2}", match, human[i].Age, i + 1);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Имя {0} осутствует в списке посетителей!", match);
            }
        }
        static void Replace(Human[] human)
        {
            Console.WriteLine("Хотите ли вы изменить имя в списке посетителей?\n 1 - Yes, 2 - No .");
            string check = "";
            do
            {
                check = Console.ReadLine();
                if (check == "1")
                {
                    do
                    {
                        Console.WriteLine("Имя под каким номером хотите заменить?");
                        int numExchange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите имя нового посетителя:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Введите возраст:");
                        int newAge = Convert.ToInt32(Console.ReadLine());
                        Replace(human, numExchange - 1, newName, newAge);
                        Print(human);
                        Console.WriteLine("Хотите продолжить? \n1 - yes, 2 - No ");
                        check = Console.ReadLine();
                    } while (check == "1");
                }
                else
                {
                    if (check == "2")
                    {
                        Console.WriteLine("Завершение работы программы.");
                    }
                    else
                    {
                        Console.WriteLine("Такого варианта нет.\nПопробуйте ещё раз:");
                    }
                }
            } while (check != "2");
        }
        static void Main(string[] args)
        {
            Human[] human = new Human[13];
            Program program = new Program(human);
            Search(human);
            Replace(human);
        }
    }
}
