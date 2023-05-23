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

    public BinaryTree(List<int> listOfNumbers)
    {
      _listOfNumbers = listOfNumbers;

      foreach (int number in _listOfNumbers)
      {
        this.Insert(number);
      }
    }

    public void Insert (int data)
    {
      Root = InsertRecursive(Root, data);
    }

    public Node InsertRecursive(Node root, int data)
    {
      if (root == null)
      {
        root = new Node(data);
        return root;
      }

      if (data < root.Data)
      {
        root.Left = InsertRecursive(root.Left, data);
      }

      else if (data > root.Data) 
      {
        root.Right = InsertRecursive(root.Right, data);
      }

      return root;
    }

    public void Next(int fromRootData, int toRootData)
    {
      Node fromRoot = FindNodeByData(Root, fromRootData);
      Node toRoot = FindNodeByData(Root, toRootData);
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
