using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  internal class Program
  {

    delegate List<Node> CreateListOfNodes(BinaryTree tree);
    static void Main()
    {
      List <int> listOfNumbers = new List<int>() {21, 17, 62, 2, 73, 15, 37};

      BinaryTree tree = new BinaryTree(listOfNumbers);

      CreateListOfNodes listOfNodesDelegate = treeForCreatingListOfNodes =>
      {
        List<Node> listOfNodes = new List<Node>();

        foreach (int number in tree)
        {
          listOfNodes.Add(tree.FindNodeByData(tree.Root, number));
        }

        Console.WriteLine("Вам выдать список узлов в порядке возрастания или убывания?\n1 - Возрастание\n2 - Убывание");
        int choiсe = Int32.Parse(Console.ReadLine());

        switch (choiсe)
        {
          case (1):
            listOfNodes.Sort(new TreeComparer(1,-1));
            break;
          case (2):
            listOfNodes.Sort(new TreeComparer(-1,-1));
            break;
        }

        return listOfNodes;
      };

      Console.WriteLine("Список элементов списка их которых создано дерево:");
      foreach (int number in listOfNumbers)
      {
        Console.Write(number + " ");
      }
      Console.WriteLine();

      Console.WriteLine("Какое действие вы хотите сделать с деревом?\n" +
          "1 - Переход к следующему определённому элементу (Next)\n" +
          "2 - Переход к предыдущему определённому элементу (Previous)\n" +
          "3 - Переход к следующему элементу (++)\n" +
          "4 - Переход к предыдущему элементу (--)\n" +
          "0 - Выход из программы");

      bool isGoing = true;
      while (isGoing)
      {
        tree.PrintCurrent();

        switch(Int32.Parse(Console.ReadLine())) 
        {
          case (1):
            tree.PrintCurrent();

            Console.WriteLine("Выберите значение следующего элемента из списка в какой элемент перейти");
            tree.Current = tree.Next(tree.Current.Data, Int32.Parse(Console.ReadLine()));

            tree.PrintCurrent();

            break;

          case (2):
            tree.PrintCurrent();

            Console.WriteLine("Выберите значение предыдущего элемента из списка в какой элемент перейти");
            tree.Current = tree.Previous(tree.Current.Data, Int32.Parse(Console.ReadLine()));

            tree.PrintCurrent();

            break;

          case (3):
            tree.PrintCurrent();

            Console.WriteLine("Переход к следующему элементу");
            ++tree;

            tree.PrintCurrent();

            break;

          case (4):
            tree.PrintCurrent();

            Console.WriteLine("Переход к предыдущему элементу");
            --tree;

            tree.PrintCurrent();

            break;

          case (0):
            isGoing = false;
            break;

          default:
            Console.WriteLine("Неизвестная команда");
            break;

        }
      }
    }
  }
}
