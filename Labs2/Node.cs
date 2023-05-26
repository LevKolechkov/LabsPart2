using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  public class Node
  {
    public int Data { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    public Node Parent { get; set; }

    public Node(int data) 
    {
      Data = data;
      Left = null; 
      Right = null;
      Parent = null;
    }
  }
}
