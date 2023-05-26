using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  public class BinaryTree
  {
    public Node Root { get; set; }
    public Node Current { get; set; }

    private readonly List<int> _listOfNumbers;

    private int _dataOfMainRoot;

    public BinaryTree(List<int> listOfNumbers)
    {
      _listOfNumbers = listOfNumbers;

      _dataOfMainRoot = listOfNumbers[0];

      foreach (int number in _listOfNumbers)
      {
        this.Insert(number);
      }
    }

    public void Insert (int data)
    {
      Root = InsertRecursive(Root, data, null);
    }

    public Node InsertRecursive(Node root, int data, Node parentRoot)
    {
      if (root == null)
      {
        root = new Node(data);
        root.Parent = parentRoot;
        return root;
      }

      if (data < root.Data)
      {
        root.Left = InsertRecursive(root.Left, data, root);
      }

      else if (data > root.Data) 
      {
        root.Right = InsertRecursive(root.Right, data, root);
      }

      return root;
    }

    public void Next(int fromRootData, int toRootData)
    {
      Node fromRoot = FindNodeByData(Root, fromRootData);
      Node toRoot = FindNodeByData(Root, toRootData);

      if (fromRoot == null || toRoot == null) 
      {
        Console.WriteLine("Узел не найден по значению");
        return;
      }


    }

    private Node FindNodeByData(Node root, int data)
    {
      if (root.Data == data || root == null)
      {
        return root;
      }

      if (data < root.Data)
      {
        return FindNodeByData(root.Left, data);
      }

      if (data > root.Data)
      {
        return FindNodeByData(root.Right, data);
      }

      return null;
    }
  }
}
