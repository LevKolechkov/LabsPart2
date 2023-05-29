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

    public void PrintCurrent()
    {
      Console.WriteLine($"Сейчас вы на узле {this.Current.nameOfNode}");
    }

    public void Insert(int data)
    {
      Root = InsertRecursive(Root, data, null);
      Current = Root;
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

    public Node Next(int fromRootData, int toRootData) // toRootData > fromRootData
    {
      Node fromRoot = FindNodeByData(Root, fromRootData);
      Node toRoot = FindNodeByData(Root, toRootData);

      if (fromRoot == null || toRoot == null)
      {
        Console.WriteLine("Узел не найден по значению");
        return null;
      }

      Node toReturnRoot = NextChildrenRecursive(fromRoot, toRoot);

      if (toReturnRoot == null)
      {
        toReturnRoot = NextParent(fromRoot.Parent, toRoot);

        switch (toReturnRoot == null)
        {
          case (true):
            return NextChildrenRecursive(Root, toRoot);

          case (false):
            return toReturnRoot;
        }
      }
      else
      {
        return toReturnRoot;
      }

      return null;
    }

    private Node NextChildrenRecursive(Node moveRoot, Node toRoot)
    {
      if (moveRoot == toRoot || moveRoot == null)
      {
        return moveRoot;
      }

      if (moveRoot.Data < toRoot.Data)
      {
        return NextChildrenRecursive(moveRoot.Right, toRoot);
      }

      if (moveRoot.Data > toRoot.Data)
      {
        return NextChildrenRecursive(moveRoot.Left, toRoot);
      }

      return null;
    }

    private Node NextParent(Node moveRoot, Node toRoot) 
    {
      if (moveRoot == null)
      {
        return null;
      }

      if (moveRoot.Parent == toRoot)
      {
        return moveRoot.Parent;
      }

      if (moveRoot.Parent.Data != toRoot.Data)
      {
        Node toReturnRoot = NextChildrenRecursive(moveRoot.Parent.Right, toRoot);

        if (toReturnRoot == null)
        {
          NextParent(moveRoot.Parent, toRoot);
        }
        else
        {
          return toReturnRoot;
        }

      }

      return null;
    }

    public Node Previous(int fromRootData, int toRootData) // toRootData < fromRootData
    {
      return Next(toRootData, fromRootData);
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

    public static BinaryTree operator ++(BinaryTree tree)
    {
      Node workRoot = tree.Current;


    }
  }
}
