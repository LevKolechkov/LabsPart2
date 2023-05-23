using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  internal class Program
  {
    static void Main()
    {
      List <int> listOfNumbers = new List<int>() {21, 17, 62, 2, 73, 15, 37};

      BinaryTree tree = new BinaryTree(listOfNumbers);
      
    }
  }
}
