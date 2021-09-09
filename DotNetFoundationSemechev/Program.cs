using System;
using System.Collections.Generic;

namespace DotNetFoundationSemechev
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1: Create new list");
                Console.WriteLine("2: Enter new number");
                Console.WriteLine("3: Output the list");
                Console.WriteLine("0: Exit");

                int command = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (command)
                {
                    case 1:
                        singleLinkedList = new SingleLinkedList();
                        Console.WriteLine("Enter number of elements");
                        int number = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < number; i++)
                        {
                            Console.WriteLine("Enter the element number " + (i + 1));
                            singleLinkedList.Add(Convert.ToInt32(Console.ReadLine()));
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter value of element");
                        int value = Convert.ToInt32(Console.ReadLine());
                        int position = 0;
                        while (true)
                        {
                            Console.WriteLine("Enter position of element in list (position cannot be 0, 1 or tail)");
                            position = Convert.ToInt32(Console.ReadLine());
                            if (position != 0 && position != 1 && position < singleLinkedList.Count)
                                break;
                        }
                        singleLinkedList.InsertByIndex(value, position);
                        Console.WriteLine();
                        break;

                    case 3:
                        foreach (var item in singleLinkedList)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
