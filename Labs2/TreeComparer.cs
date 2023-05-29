using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  class TreeComparer : IComparer<Node>
  {
    private int _isNeed;
    private int _notNeed;

    public TreeComparer(int isNeed, int notNeed)
    {
      _isNeed= isNeed;
      _notNeed= notNeed;
    }

    public int Compare(Node firstNode, Node secondNode)
    {
      if (firstNode.Data > secondNode.Data)
      {
        return _isNeed;
      }
      else if (firstNode.Data < secondNode.Data)
      {
        return _notNeed;
      }
      return 0;
    }
  }
}
