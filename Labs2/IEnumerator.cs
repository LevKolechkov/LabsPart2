using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs2
{
  public interface IEnumerator
  {
    bool MoveNext();
    Node Current();
    void Reset(); 
  }
}
