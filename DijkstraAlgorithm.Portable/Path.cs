using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DijkstraAlgorithm.Portable {
   public class Path<T> {
      public T Source { get; set; }

      public T Destination { get; set; }

      /// <summary>
      /// Cost of using this path from Source to Destination
      /// </summary>
      /// <remarks>
      /// Lower costs are preferable to higher costs
      /// </remarks>
      public int Cost { get; set; }
   }
}