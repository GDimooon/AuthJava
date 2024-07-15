using System;
using System.Collections.Generic;
using System.IO;

namespace TerminalDirectory
{
    class TerminalDirectory
    {
        static void Main(string[] args)
        {

            // Создание списка терминалов
            List<Terminal> terminalList = new List<Terminal>();

            if (File.Exists("terminals.txt"))
            {
                using (StreamReader reader = new StreamReader("terminals.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] info = reader.ReadLine().Split(',');
                        terminalList.Add(new Terminal(int.Parse(info[0]), info[1], int.Parse(info[2]), int.Parse(info[3])));
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("Введите команду:\n  1 - Добавить терминал,\n  2 - Удалить терминал,\n  3 - Показать список терминалов,\n  4 - Сохранить данные терминалов,\n  5 - Выйти из приложения\n ");
                string command = Console.ReadLine();

                if (command == "1")
                {
                    Console.Write("Номер терминала: ");
                    int terminalNumber;
                    if (int.TryParse(Console.ReadLine(), out terminalNumber) && terminalNumber > 0)
                    {
                        Console.Write("Адрес установки: ");
                        string address = Console.ReadLine();

                        Console.Write("Емкость купюроприемника: ");
                        int cashCapacity;
                        if (int.TryParse(Console.ReadLine(), out cashCapacity) && cashCapacity > 0)
                        {
                            Console.Write("Наполненность купюроприемника: ");
                            int cashFillLevel;
                            if (int.TryParse(Console.ReadLine(), out cashFillLevel) && cashFillLevel >= 0)
                            {
                                terminalList.Add(new Terminal(terminalNumber, address, cashCapacity, cashFillLevel));
                            }
                            else
                            {
                                Console.WriteLine("Ошибка при вводе наполненности купюроприемника");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ошибка при вводе емкости купюроприемника терминала");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе номера терминала");
                    }
                }
                else if (command == "2")
                {
                    Console.Write("Введите номер терминала для удаления: ");
                    int index;
                    if (int.TryParse(Console.ReadLine(), out index) && index > 0)
                    {
                        index -= 1;
                        if (index >= 0 && index < terminalList.Count)
                        {
                            terminalList.RemoveAt(index);
                            Console.WriteLine("Терминал удален");
                        }
                        else
                        {
                            Console.WriteLine("Неверный номер терминала");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка при вводе номера терминала");
                    }
                }
                else if (command == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Список терминалов:");
                    Console.ResetColor();

                    Console.WriteLine("Номер Терминала    Адрес                   Емкость купюроприемника      Наполненность купюроприемника");
                    Console.WriteLine("------------------------------------------------------------------------------------");

                    foreach (var terminal in terminalList)
                    {
                        Console.Write($"{terminal.TerminalNumber}              {terminal.Address,-24}          {terminal.CashAcceptorCapacity}               {terminal.CashFillLevel}");

                        if ((double)terminal.CashFillLevel / terminal.CashAcceptorCapacity * 100 > 90)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("   (Купюроприемник почти заполнен)");
                            Console.ResetColor();
                        }

                        Console.Write(Environment.NewLine);
                        Console.WriteLine("------------------------------------------------------------------------------------");
                    }
                }
                else if (command == "4")
                {
                    using (StreamWriter writer = new StreamWriter("terminals.txt"))
                    {
                        foreach (Terminal terminal in terminalList)
                        {
                            writer.WriteLine($"{terminal.TerminalNumber},{terminal.Address},{terminal.CashAcceptorCapacity},{terminal.CashFillLevel}");
                        }
                    }

                    Console.WriteLine("Данные сохранены");
                }
                else if (command == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка при вводе команды");
                }
            }
        }
    }

    class Terminal
    {
        public int TerminalNumber { get; set; }
        public string Address { get; set; }
        public int CashAcceptorCapacity { get; set; }
        public int CashFillLevel { get; set; }

        public Terminal(int terminalNumber, string address, int cashAcceptorCapacity, int cashFillLevel)
        {
            TerminalNumber = terminalNumber;
            Address = address;
            CashAcceptorCapacity = cashAcceptorCapacity;
            CashFillLevel = cashFillLevel;
        }
    }
}