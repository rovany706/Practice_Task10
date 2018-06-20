using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputHelper;

namespace Task10
{
    class Program
    {
        static void PrintTask()
        {
            Console.WriteLine("Задача 10\n=================");
            Console.WriteLine("Выполнить задание, реализовав динамические структуры данных «вручную»,\n" +
                              "без использования коллекций языка C#.\n" +
                              "Создать структуру дерева и написать метод для его уничтожения.\n" +
                              "=================");
        }

        static void Main(string[] args)
        {
            PrintTask();
            int size = Input.ReadInt("Введите количество элементов в дереве: ", 1);
            TreeNode root = TreeNode.GenerateTree(size);
            Menu(root);
        }

        static void Menu(TreeNode root)
        {
            Console.Clear();
            PrintTask();
            if(root == null)
                Console.WriteLine("Дерево не создано.");
            else
            {
                Console.WriteLine("Дерево:");
                TreeNode.ShowTree(root, 5);
            }
            Console.WriteLine("1. Создать новое дерево\n2. Добавить элемент в дерево\n" +
                              "3. Уничтожить дерево\n4. Выйти из программы");
            int input = Input.ReadInt("Выберите действие: ", 1, 4);

            switch (input)
            {
                case 1:
                    Console.Clear();
                    int size = Input.ReadInt("Введите количество элементов в дереве: ", 1);
                    root = TreeNode.GenerateTree(size);
                    Menu(root);
                    break;
                case 2:
                    Console.Clear();
                    int number = Input.ReadInt("Введите число, которое хотите жобавить в дерево:");
                    root = TreeNode.Add(root, number);
                    Console.WriteLine($"Число {number} добавлено в дерево!");
                    Console.ReadLine();
                    Menu(root);
                    break;
                case 3:
                    Console.Clear();
                    root = TreeNode.DeleteTree(root);
                    Console.WriteLine("Дерево удалено!");
                    Console.ReadLine();
                    Menu(root);
                    break;
                case 4:
                    return;
            }
        }
    }
}
